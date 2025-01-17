#region

using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;
using MathNet.Numerics.Integration;

#endregion

namespace Libraries.UralMathLib;

public static partial class UralMathLib
{
    public static partial class MatematicheskiyAnaliz
    {
        public static class Integracia
        {
            public static drobch64 SigmaSumma(dynamic a, dynamic b, Func<dynamic, dynamic> f)
            {
                double func_sum = 0;
                for (double i = a; i <= b; i++) func_sum += f(i);

                return new drobch64(func_sum);
            }

            public static drobch64 PiProduct(dynamic a, dynamic b, Func<dynamic, dynamic> f)
            {
                double func_prod = 1;
                for (double i = a; i <= b; i++) func_prod *= f(i);

                return new drobch64(func_prod);
            }

            //ToDo
            public static drobch64 Integral(double a, double b, Func<double, double> f) => new drobch64(NewtonCotesTrapeziumRule.IntegrateComposite(f, a, b, 40));

            public static drobch64 TriangularIntegral(double a, double b, Func<double, double> f) => new drobch64((b * f(b)) - (a * f(a)) - Integral(a, b, f));

            public static drobch64 DvoynoyIntegral(double lx, double ux, double ly, double uy, Func<double, double, double> f)
            {
                int nx, ny;

                double [,] z = new double[(int)1.0e+4, (int)1.0e+4];
                double [] ax = new double[(int)1.0e+4];
                double answer;

                nx = (int)(((ux - lx) / 1.0e-3) + 1);
                ny = (int)(((uy - ly) / 1.0e-3) + 1);

                for (int i = 0; i < nx; i++)
                {
                    for (int j = 0; j < ny; j++) z[i, j] = f(lx + (i * 1.0e-3), ly + (j * 1.0e-3));
                }

                for (int i = 0; i < nx; i++)
                {
                    ax[i] = 0;
                    for (int j = 0; j < ny; j++)
                        if ((j == 0) || (j == ny - 1))
                        {
                            ax[i] += z[i, j];
                        }
                        else if (j % 2 == 0)
                        {
                            ax[i] += 2 * z[i, j];
                        }
                        else
                        {
                            ax[i] += 4 * z[i, j];
                        }

                    ax[i] *= 1.0e-3 / 3;
                }

                answer = 0;

                for (int i = 0; i < nx; i++)
                    if ((i == 0) || (i == nx - 1))
                    {
                        answer += ax[i];
                    }
                    else if (i % 2 == 0)
                    {
                        answer += 2 * ax[i];
                    }
                    else
                    {
                        answer += 4 * ax[i];
                    }

                answer *= 1.0e-3 / 3;

                return new drobch64(answer);
            }

            public static dynamic ExponentialIntegral(double x, int n)
            {
                if ((n < 0) | (x < 0.0))
                {
                    FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                    err.Execute();
                }

                const double epsilon = 0.00000000000000001;
                int maxIterations = 100;
                int i, ii;
                double ndbl = n;
                double result;
                double nearDoubleMin = 1e-100;
                double factorial = 1.0d;
                double del;
                double psi;
                double a, b, c, d, h;


                if (n == 0)
                {
                    return Exp(-1.0d * x) / x;
                }

                if (x == 0.0d)
                {
                    return 1.0d / (ndbl - 1.0d);
                }

                if (x > 1.0d)
                {
                    b = x + n;
                    c = 1.0d / nearDoubleMin;
                    d = 1.0d / b;
                    h = d;
                    for (i = 1; i <= maxIterations; i++)
                    {
                        a = -1.0d * i * (ndbl - 1.0d + i);
                        b += 2.0d;
                        d = 1.0d / ((a * d) + b);
                        c = b + (a / c);
                        del = c * d;
                        h = h * del;
                        if (Math.Abs(del - 1.0d) < epsilon)
                        {
                            return h * Exp(-x);
                        }
                    }

                    FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                    err.Execute();
                    return null;
                }

                else
                {
                    result = ndbl - 1.0d != 0
                        ? 1.0 / (ndbl - 1.0d)
                        : (-1.0d * Ln(x)) - e_mascheroni; //Set first term.
                    for (i = 1; i <= maxIterations; i++)
                    {
                        factorial *= -1.0d * x / i;
                        if (i != ndbl - 1.0d) { del = -factorial / (i - (ndbl - 1.0d)); }
                        else
                        {
                            psi = -1.0d * e_mascheroni;
                            for (ii = 1; ii <= ndbl - 1.0d; ii++) psi += 1.0d / ii;

                            del = factorial * ((-1.0d * Ln(x)) + psi);
                        }

                        result += del;
                        if (Math.Abs(del) < Math.Abs(result) * epsilon)
                        {
                            return result;
                        }
                    }

                    FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                    err.Execute();
                    return null;
                }
            }

            public static double [] ODE_FirstOrder(double y0, double start, double end, int N,
                Func<double, double, double> f)
            {
                double dt = (end - start) / (N - 1);
                double t = start;
                double [] y = new double[N];
                y[0] = y0;
                for (int i = 1; i < N; i++)
                {
                    y[i] = y0 + (dt * f(t, y0));
                    t += dt;
                    y0 = y[i];
                }

                return y;
            }

            public static double [] ODE_SecondOrder(double y0, double start, double end, int N,
                Func<double, double, double> f)
            {
                double dt = (end - start) / (N - 1);
                double t = start;
                double [] y = new double[N];

                double k1 = f(t, y0);
                double k2 = f(t + dt, y0 + (dt * k1));
                double y1 = y0 + (0.5 * dt * (k1 + k2));

                y[0] = y0;
                y[1] = y1;
                for (int i = 2; i < N; i++)
                {
                    y[i] = y1 + (dt * ((1.5 * f(t + dt, y1)) - (0.5 * f(t, y0))));
                    t += dt;
                    y0 = y[i - 1];
                    y1 = y[i];
                }

                return y;
            }

            public static double [] ODE_ThirdOrder(double y0, double start, double end, int N,
                Func<double, double, double> f)
            {
                double dt = (end - start) / (N - 1);
                double t = start;
                double [] y = new double[N];

                double k1;
                double k2;
                double k3;
                double k4;
                y[0] = y0;
                for (int i = 1; i < 3; i++)
                {
                    k1 = dt * f(t, y0);
                    k2 = dt * f(t + (dt / 2), y0 + (k1 / 2));
                    k3 = dt * f(t + (dt / 2), y0 + (k2 / 2));
                    k4 = dt * f(t + dt, y0 + k3);
                    y[i] = y0 + ((k1 + (2 * k2) + (2 * k3) + k4) / 6);
                    t += dt;
                    y0 = y[i];
                }

                for (int i = 3; i < N; i++)
                {
                    y[i] = y[i - 1] + (dt *
                        ((23 * f(t, y[i - 1])) - (16 * f(t - dt, y[i - 2])) + (5 * f(t - (2 * dt), y[i - 3]))) / 12.0);
                    t += dt;
                }

                return y;
            }

            public static double [] ODE_FourthOrder(double y0, double start, double end, int N,
                Func<double, double, double> f)
            {
                double dt = (end - start) / (N - 1);
                double t = start;
                double [] y = new double[N];

                double k1;
                double k2;
                double k3;
                double k4;
                y[0] = y0;
                for (int i = 1; i < 4; i++)
                {
                    k1 = dt * f(t, y0);
                    k2 = dt * f(t + (dt / 2), y0 + (k1 / 2));
                    k3 = dt * f(t + (dt / 2), y0 + (k2 / 2));
                    k4 = dt * f(t + dt, y0 + k3);
                    y[i] = y0 + ((k1 + (2 * k2) + (2 * k3) + k4) / 6);
                    t += dt;
                    y0 = y[i];
                }

                for (int i = 4; i < N; i++)
                {
                    y[i] = y[i - 1] + (dt * ((55 * f(t, y[i - 1])) - (59 * f(t - dt, y[i - 2])) +
                        (37 * f(t - (2 * dt), y[i - 3])) - (9 * f(t - (3 * dt), y[i - 4]))) / 24.0);
                    t += dt;
                }

                return y;
            }

            public static drobch64 TaylorFunction(natch16 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch16 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch16 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch16 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch16 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch16 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch16 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch16 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch16 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch32 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(natch64 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch16 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch32 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(celch64 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch16 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch32 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, natch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, natch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, natch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, celch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, celch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, celch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, drobch16 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, drobch32 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }

            public static drobch64 TaylorFunction(drobch64 x, drobch64 a, Func<double, double> f)
            {
                double func_sum = 0;
                for (uint i = 0; i <= 15; i++)
                    func_sum += (double)Differenciaciya.NProizvodnaya(i, (double)a, f) /
                                (double)Factorial(i).value *
                                (double)Factorial((ulong)x - (ulong)a).value;

                return new drobch64(func_sum);
            }
        }
    }
}