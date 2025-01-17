#region

using Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

#endregion

namespace Libraries.UralMathLib;

public static partial class UralMathLib
{
    public const double sqrt_ot_2 = 1.41421356237309504880168872421;
    public const double sqrt_ot_2_na_2 = 0.707106781186547524400844362105;
    public const double sqrt_ot_3 = 1.73205080756887729352744634151;
    public const double sqrt_ot_3_na_2 = 0.866025403784438646763723170753;
    public const double sqrt_ot_pi = 1.77245385090551602729816748334;
    public const double sqrt_ot_5 = 2.2360679774997896964091736687312762;
    public const double phi = 1.6180339887498948482045868343656; //Золотое сечение
    public const double dhi = 2.41421356237309504880; //Серебрянная сечение

    public const double sinh_ot_1 = 1.1752011936438014568823818506;
    public const double cosh_ot_1 = 1.54308063481524377847790562076;
    public const double tanh_ot_1 = 0.761594155955764888119458282605;

    public const double e = 2.71828182845904523536028747135;
    public const double e_otric_stepen = 0.367879441171442321595523770161; //e^-1
    public const double e_mascheroni = 0.577215664901532860606512090082;
    public const double e_stepen_pi = 23.1406926327792690057290863679; //e^pi

    public const double pi = 3.14159265358979323846264338328;
    public const double pi_gamma = 7.18808272897603270208219434512; //Г(pi)
    public const double pi2 = 6.28318530717958647692528676656;
    public const double pi_na_2 = 1.57079632679489661923132169164;
    public const double pi_na_3 = 1.04719755119659774615421446109;
    public const double pi_na_4 = 0.78539816339744830961566084582;
    public const double sfera_obem = 4.18879020478639098461685784437;
    public const double rad_to_ang = 0.0174532925199432957692369076849; //1 deg in rads 
    public const double ang_to_rad = 57.2957795130823208767981548141; //1 rad in degs

    public const double omega_f_ot_1 = 0.56714329040978387299; //W(1)
    public const double bessel_f_ot_2 = 0.69777465796400798201; //L2(2)/L1(2)
    public const double viswanat = 1.1319882487943; //Рандомное золотое сечение
    public const double sierpińskiy = 2.58498175957925321706; //Sierpiński triangle

    public const double erf_ot_1 = 0.842700792949714869341220635083;
    public const double zeta_ot_pi = 1.17624173838258275887215045194;
    public const double zeta_ot_e = 1.2690096043357171157655698666;

    public const double normal_ot_1 = 0.841344746068542948585232545632; //left to +1 sd
    public const double normal_ot_2 = 0.977249868051820792799717362834; //left to +2 sd
    public const double normal_ot_3 = 0.998650101968369905473348185232; //left to +3 sd
    public const double normal_ot_4 = 0.999968328758166880078746229243; //left to +4 sd
    public const double normal_ot_5 = 0.999999713348428120806088326248; //left to +5 sd
    public const double normal_otcdf_1 = 0.682689492137085897170465091264; //middle, -1 sd to 1 sd
    public const double normal_otcdf_2 = 0.954499736103641585599434725667; //middle, -2 sd to 2 sd
    public const double normal_otcdf_3 = 0.997300203936739810946696370465; //middle, -3 sd to 3 sd
    public const double normal_otcdf_4 = 0.999936657516333760157492458487; //middle, -4 sd to 4 sd
    public const double normal_otcdf_5 = 0.999999426696856241612176652495; //middle, -5 sd to 5 sd

    public const double music_poltona = 1.059463094359295264561825;

    public static drobch64 Sqrt(dynamic x)
    {
        double g = (double)x;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(natch16 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(natch32 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(natch64 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(celch16 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(celch32 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(celch64 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(drobch16 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(drobch32 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Sqrt(drobch64 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 2) - (double)x) / (2 * g)); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(dynamic x)
    {
        double g = (double)x;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(natch16 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(natch32 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(natch64 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(celch16 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(celch32 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(celch64 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(drobch16 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(drobch32 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Cbrt(drobch64 x)
    {
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, 3) - (double)x) / (3 * Math.Pow(g, 2))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(dynamic x, dynamic n)
    {
        double nx = (double)n;
        double g = (double)x;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch16 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch32 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch64 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch16 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch32 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch64 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(drobch16 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(drobch32 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(drobch64 x, natch16 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch16 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch32 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch64 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch16 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch32 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch64 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(drobch16 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }


    public static drobch64 Nrt(drobch32 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(drobch64 x, natch32 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch16 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch32 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(natch64 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch16 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch32 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(celch64 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(drobch16 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(drobch32 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static drobch64 Nrt(drobch64 x, natch64 n)
    {
        double nx = (double)n.value;
        double g = (double)x.value;
        double diff = 999999999;
        double ng = 0;
        while (diff > 0.0000001)
        {
            ng = g - ((Math.Pow(g, nx) - (double)x) / (nx * Math.Pow(g, nx - 1))); //Newton-Raphson method
            diff = Math.Abs(ng - g);

            g = ng;
        }

        return new drobch64(g);
    }

    public static unsafe drobch64 ObrSqrt(dynamic x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(natch16 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(natch32 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(natch64 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(celch16 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(celch32 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(celch64 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(drobch16 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(drobch32 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static unsafe drobch64 ObrSqrt(drobch64 x)
    {
        float x1 = (float)x;
        float xhalf = 0.5f * x1;
        int i = BitConverter.ToInt32(BitConverter.GetBytes(x1), 0);
        i = 0x5f375a86 - (i >> 1);
        x1 = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        x1 = x1 * (1.5f - (xhalf * x1 * x1)); //Newton-Raphson method
        return new drobch64((double)x1);
    }

    public static drobch64 Exp(dynamic x)
    {
        double func_sum = 0;

        for (int i = 0; i <= 13; i++) func_sum += Math.Pow((double)x, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(natch16 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(natch32 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(natch64 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(celch16 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(celch32 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(celch64 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(drobch16 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(drobch32 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Exp(drobch64 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        for (int i = 0; i <= 13; i++) func_sum += Math.Pow(x1, i) / (double)Factorial(i);

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(dynamic x)
    {
        double func_sum = 0;
        if (((double)x > 0) & ((double)x <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x - 1, i) / i;
        }
        else if (((double)x > 2) & ((double)x <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow(((double)x - 1) / (double)x, i) / i;
        }
        else if (((double)x > 10) & ((double)x <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow(((double)x - 1) / ((double)x + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow(((double)x - 1) / ((double)x + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(natch16 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(natch32 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(natch64 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(celch16 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(celch32 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(celch64 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(drobch16 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(drobch32 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Ln(drobch64 x)
    {
        double func_sum = 0;
        double x1 = (double)x.value;
        if ((x1 > 0) & (x1 <= 2))
        {
            for (int i = 1; i <= 10000000; i++) func_sum += Math.Pow(-1, i - 1) * Math.Pow(x1 - 1, i) / i;
        }
        else if ((x1 > 2) & (x1 <= 10))
        {
            for (int i = 1; i <= 286; i++) func_sum += Math.Pow((x1 - 1) / x1, i) / i;
        }
        else if ((x1 > 10) & (x1 <= 100))
        {
            for (int i = 1; i <= 3000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }
        else
        {
            for (int i = 1; i <= 1000000; i++) func_sum += Math.Pow((x1 - 1) / (x1 + 1), (2 * i) - 1) / ((2 * i) - 1);

            func_sum *= 2;
        }

        return new drobch64(func_sum);
    }

    public static drobch64 Lb(dynamic x) => new drobch64((double)Ln((double)x) / (double)Ln(2));

    public static drobch64 Lb(natch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lb(natch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lb(natch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lb(celch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lb(celch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lb(celch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lb(drobch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lb(drobch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lb(drobch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(2));
    }

    public static drobch64 Lt(dynamic x) => new drobch64((double)Ln((double)x) / (double)Ln(3));

    public static drobch64 Lt(natch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lt(natch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lt(natch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lt(celch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lt(celch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lt(celch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lt(drobch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lt(drobch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lt(drobch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(3));
    }

    public static drobch64 Lg(dynamic x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(natch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(natch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(natch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(celch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(celch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(celch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(drobch16 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(drobch32 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static drobch64 Lg(drobch64 x)
    {
        double x1 = (double)x.value;
        return new drobch64((double)Ln(x1) / (double)Ln(10));
    }

    public static dynamic Log(dynamic a, dynamic x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch16 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch32 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(natch64 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch16 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch32 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(celch64 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch16 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch32 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, natch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, natch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, natch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, celch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, celch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, celch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, drobch16 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, drobch32 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static dynamic Log(drobch64 a, drobch64 x)
    {
        double x1 = (double)x.value;
        double a1 = (double)a.value;
        if ((a1 <= 0) | (a1 == 1))
        {
            if (x1 <= 0)
            {
                FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
                err.Execute();
                return null;
            }

            return new drobch64((double)Ln(x1) / (double)Ln(a1));
        }

        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }
    }

    public static drobch64 Sin(natch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Sin(natch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Sin(natch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Sin(celch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Sin(celch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Sin(celch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Sin(drobch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Sin(drobch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Sin(drobch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 6; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((int)x.value, (2 * i) + 1) /
                        (double)Factorial((2 * i) + 1).value;

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(natch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(natch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(natch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(celch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(celch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(celch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(drobch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(drobch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 ArcSin(drobch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 17; i++)
            func_sum += (ulong)Factorial(2 * i) /
                        (Math.Pow(2, 2 * i) * Math.Pow((double)Factorial(i), 2)) *
                        (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));

        return new drobch64(func_sum);
    }

    public static drobch64 Sinc(natch16 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc(natch32 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc(natch64 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc(celch16 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc(celch32 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc(celch64 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc(drobch16 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc(drobch32 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc(drobch64 x)
    {
        double func_prod = 1;
        if ((double)x.value == 0)
        {
            func_prod = 1;
        }
        else if (((double)x.value >= -0.1) & ((double)x.value <= 0.1))
        {
            for (int i = 1; i < 5000; i++)
                func_prod = func_prod * Cos(new drobch64((double)x.value) / Math.Pow(2, i));
        }
        else
        {
            func_prod = (double)Sin(x) / (double)x.value;
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(natch16 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(natch32 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(natch64 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(celch16 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(celch32 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(celch64 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(drobch16 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(drobch32 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Sinc_pi(drobch64 x)
    {
        double func_prod = 1;
        if ((double)x == 0)
        {
            func_prod = 1;
        }
        else
        {
            for (int i = 1; i < 10000; i++)
                func_prod *= 1 - Math.Pow((double)x.value / i, 2);
        }

        return new drobch64(func_prod);
    }

    public static drobch64 Csc(natch16 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Csc(natch32 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Csc(natch64 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Csc(celch16 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Csc(celch32 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Csc(celch64 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Csc(drobch16 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Csc(drobch32 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Csc(drobch64 x) => new drobch64(1 / (double)Sin(x).value);

    public static drobch64 Cos(natch16 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new natch16(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new natch16(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Cos(natch32 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new natch32(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new natch32(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Cos(natch64 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new natch64(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new natch64(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Cos(celch16 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new celch16(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new celch16(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Cos(celch32 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new celch32(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new celch32(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Cos(celch64 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new celch64(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new celch64(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Cos(drobch16 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new drobch16(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new drobch16(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Cos(drobch32 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new drobch32(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new drobch32(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 Cos(drobch64 x)
    {
        double func_sum = 0;
        if (x.value >= 0)
        {
            while (x.value >= pi2)
                x = new drobch64(x.value - pi2);
        }

        if (x.value <= 0)
        {
            while (x.value <= -pi2)
                x = new drobch64(x.value + pi2);
        }

        for (int i = 0; i < 8; i++)
            func_sum += Math.Pow(-1, i) * Math.Pow((double)x.value, 2 * i) /
                        (double)Factorial(2 * i).value;

        return new drobch64(func_sum);
    }

    public static drobch64 ArcCos(natch16 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 ArcCos(natch32 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 ArcCos(natch64 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 ArcCos(celch16 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 ArcCos(celch32 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 ArcCos(celch64 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 ArcCos(drobch16 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 ArcCos(drobch32 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 ArcCos(drobch64 x)
    {
        double arcsin = (double)ArcSin(x);
        double arccos = pi_na_2 - arcsin;
        return new drobch64(arccos);
    }

    public static drobch64 Sec(natch16 x) => new drobch64(1 / (double)Cos(x).value);

    public static drobch64 Sec(natch32 x) => new drobch64(1 / (double)Cos(x).value);

    public static drobch64 Sec(natch64 x) => new drobch64(1 / (double)Cos(x).value);

    public static drobch64 Sec(celch16 x) => new drobch64(1 / (double)Cos(x).value);

    public static drobch64 Sec(celch32 x) => new drobch64(1 / (double)Cos(x).value);

    public static drobch64 Sec(celch64 x) => new drobch64(1 / (double)Cos(x).value);

    public static drobch64 Sec(drobch16 x) => new drobch64(1 / (double)Cos(x).value);

    public static drobch64 Sec(drobch32 x) => new drobch64(1 / (double)Cos(x).value);

    public static drobch64 Sec(drobch64 x) => new drobch64(1 / (double)Cos(x).value);

    public static dynamic Tan(natch16 x)
    {
        double xd = (double)x.value;
        while ((xd < -pi_na_2) | (xd > pi_na_2)) xd -= pi;

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static dynamic Tan(natch32 x)
    {
        double xd = (double)x.value;
        if (xd >= 0)
        {
            while (xd >= pi_na_2)
                xd -= pi_na_2;
        }

        if (xd <= 0)
        {
            while (xd <= -pi_na_2)
                xd += pi_na_2;
        }

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static dynamic Tan(natch64 x)
    {
        double xd = (double)x.value;
        if (xd >= 0)
        {
            while (xd >= pi_na_2)
                xd -= pi_na_2;
        }

        if (xd <= 0)
        {
            while (xd <= -pi_na_2)
                xd += pi_na_2;
        }

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static dynamic Tan(celch16 x)
    {
        double xd = (double)x.value;
        if (xd >= 0)
        {
            while (xd >= pi_na_2)
                xd -= pi_na_2;
        }

        if (xd <= 0)
        {
            while (xd <= -pi_na_2)
                xd += pi_na_2;
        }

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static dynamic Tan(celch32 x)
    {
        double xd = (double)x.value;
        if (xd >= 0)
        {
            while (xd >= pi_na_2)
                xd -= pi_na_2;
        }

        if (xd <= 0)
        {
            while (xd <= -pi_na_2)
                xd += pi_na_2;
        }

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static dynamic Tan(celch64 x)
    {
        double xd = (double)x.value;
        if (xd >= 0)
        {
            while (xd >= pi_na_2)
                xd -= pi_na_2;
        }

        if (xd <= 0)
        {
            while (xd <= -pi_na_2)
                xd += pi_na_2;
        }

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static dynamic Tan(drobch16 x)
    {
        double xd = (double)x.value;
        if (xd >= 0)
        {
            while (xd >= pi_na_2)
                xd -= pi_na_2;
        }

        if (xd <= 0)
        {
            while (xd <= -pi_na_2)
                xd += pi_na_2;
        }

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static dynamic Tan(drobch32 x)
    {
        double xd = (double)x.value;
        if (xd >= 0)
        {
            while (xd >= pi_na_2)
                xd -= pi_na_2;
        }

        if (xd <= 0)
        {
            while (xd <= -pi_na_2)
                xd += pi_na_2;
        }

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static drobch64 Tan(drobch64 x)
    {
        double xd = (double)x.value;
        if (xd >= 0)
        {
            while (xd >= pi_na_2)
                xd -= pi_na_2;
        }

        if (xd <= 0)
        {
            while (xd <= -pi_na_2)
                xd += pi_na_2;
        }

        double sin = (double)Sin(new drobch64(xd));
        double cos = (double)Cos(new drobch64(xd));
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(sin / cos);
    }

    public static drobch64 ArcTan(natch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static drobch64 ArcTan(natch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static drobch64 ArcTan(natch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static drobch64 ArcTan(celch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static drobch64 ArcTan(celch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static drobch64 ArcTan(celch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static drobch64 ArcTan(drobch16 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static drobch64 ArcTan(drobch32 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static drobch64 ArcTan(drobch64 x)
    {
        double func_sum = 0;
        for (int i = 0; i < 8; i++) func_sum += Math.Pow(-1, i + 1) * Math.Pow((double)x.value, (2 * i) - 1) / ((2 * i) - 1);

        return new drobch64(func_sum);
    }

    public static dynamic Cot(natch16 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static dynamic Cot(natch32 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static dynamic Cot(natch64 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static dynamic Cot(celch16 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static dynamic Cot(celch32 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static dynamic Cot(celch64 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static dynamic Cot(drobch16 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static dynamic Cot(drobch32 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static drobch64 Cot(drobch64 x)
    {
        double sin = (double)Sin(x);
        double cos = (double)Cos(x);
        if (cos == 0)
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(cos / sin);
    }

    public static drobch64 Sinh(natch16 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }

    public static drobch64 Sinh(natch32 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }

    public static drobch64 Sinh(natch64 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }

    public static drobch64 Sinh(celch16 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }

    public static drobch64 Sinh(celch32 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }

    public static drobch64 Sinh(celch64 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }

    public static drobch64 Sinh(drobch16 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }

    public static drobch64 Sinh(drobch32 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }

    public static drobch64 Sinh(drobch64 x)
    {
        double value = ((double)Exp((double)x.value) - (double)Exp(-1 * (double)x.value)) /
                       2;
        return new drobch64(value);
    }


    public static drobch64 ArcSinh(natch16 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 ArcSinh(natch32 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 ArcSinh(natch64 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 ArcSinh(celch16 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 ArcSinh(celch32 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 ArcSinh(celch64 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 ArcSinh(drobch16 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 ArcSinh(drobch32 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 ArcSinh(drobch64 x)
    {
        double arcsinh = 0;
        if (((double)x.value > -1) & ((double)x.value < 1))
        {
            for (int i = 0; i <= 32; i++)
                arcsinh += Math.Pow(-1, i) * (double)DvoynoyFactorial((2 * i) - 1) /
                           (double)DvoynoyFactorial(2 * i) *
                           (Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1));
        }
        else if (((double)x.value > -10) & ((double)x.value < 10))
        {
            for (int i = 1; i <= 32; i++)
                arcsinh += Math.Pow(-1, i + 1) *
                           ((double)DvoynoyFactorial((2 * i) - 1) /
                            (2 * i * (double)DvoynoyFactorial(2 * i))) *
                           (1 / Math.Pow((double)x.value, 2 * i));

            arcsinh += (double)Ln(2 * (double)x.value);
        }
        else { arcsinh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) + 1).value).value; }

        return new drobch64(arcsinh);
    }

    public static drobch64 Cosh(natch16 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 Cosh(natch32 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 Cosh(natch64 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 Cosh(celch16 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 Cosh(celch32 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 Cosh(celch64 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 Cosh(drobch16 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 Cosh(drobch32 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 Cosh(drobch64 x)
    {
        double value = ((double)Exp((double)x.value).value +
                        (double)Exp(-1 * (double)x.value).value) / 2;
        return new drobch64(value);
    }

    public static drobch64 ArcCosh(natch16 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 ArcCosh(natch32 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 ArcCosh(natch64 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 ArcCosh(celch16 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 ArcCosh(celch32 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 ArcCosh(celch64 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 ArcCosh(drobch16 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 ArcCosh(drobch32 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 ArcCosh(drobch64 x)
    {
        double arccosh = 0;
        if ((double)x.value == 1) { arccosh = 0; }
        else if (((double)x.value > 1) & ((double)x.value <= 3))
        {
            arccosh = (double)Ln(2 * (double)x.value).value;
            for (int i = 1; i <= 65; i++)
                arccosh -= (double)Factorial(2 * i) / (Math.Pow(2, 2 * i) *
                                                       Math.Pow(
                                                           (double)Factorial(i).value,
                                                           2) * (2 * i) * Math.Pow((double)x.value,
                                                           2 * i));
        }
        else { arccosh = (double)Ln((double)x.value + (double)Sqrt(Math.Pow((double)x.value, 2) - 1).value).value; }

        return new drobch64(arccosh);
    }

    public static drobch64 Tanh(natch16 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64 Tanh(natch32 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64 Tanh(natch64 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64 Tanh(celch16 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64 Tanh(celch32 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64 Tanh(celch64 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64 Tanh(drobch16 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64 Tanh(drobch32 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64 Tanh(drobch64 x)
    {
        double tanh = ((double)Exp(2 * (double)x.value).value - 1) /
                      ((double)Exp(-2 * (double)x.value).value + 1);
        return new drobch64(tanh);
    }

    public static drobch64? ArcTanh(natch16 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64? ArcTanh(natch32 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64? ArcTanh(natch64 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64 ArcTanh(celch16 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64? ArcTanh(celch32 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64? ArcTanh(celch64 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64? ArcTanh(drobch16 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64 ArcTanh(drobch32 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64 ArcTanh(drobch64 x)
    {
        double arctanh = 0;
        if (((double)x.value >= -0.5) & ((double)x.value <= 0.5))
        {
            for (int i = 0; i < 200; i++) arctanh += Math.Pow((double)x.value, (2 * i) + 1) / ((2 * i) + 1);
        }
        else if (((double)x.value > -1) & ((double)x.value < 1)) { arctanh = 0.5 * (double)Ln((1 + (double)x.value) / (1 - (double)x.value)).value; }
        else
        {
            FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
            err.Execute();
            return null;
        }

        return new drobch64(arctanh);
    }

    public static drobch64 Coth(natch16 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Coth(natch32 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Coth(natch64 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Coth(celch16 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Coth(celch32 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Coth(celch64 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Coth(drobch16 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Coth(drobch32 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Coth(drobch64 x)
    {
        double coth = ((double)Exp(2 * (double)x.value).value + 1) /
                      ((double)Exp(-2 * (double)x.value).value - 1);
        return new drobch64(coth);
    }

    public static drobch64 Sech(natch16 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Sech(natch32 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Sech(natch64 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Sech(celch16 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Sech(celch32 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Sech(celch64 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Sech(drobch16 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Sech(drobch32 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Sech(drobch64 x)
    {
        double sech = 2 / ((double)Exp((double)x.value).value +
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(sech);
    }

    public static drobch64 Csch(natch16 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static drobch64 Csch(natch32 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static drobch64 Csch(natch64 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static drobch64 Csch(celch16 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static drobch64 Csch(celch32 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static drobch64 Csch(celch64 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static drobch64 Csch(drobch16 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static drobch64 Csch(drobch32 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static drobch64 Csch(drobch64 x)
    {
        double csch = 2 / ((double)Exp((double)x.value).value -
                           (double)Exp(-1 * (double)x.value).value);
        return new drobch64(csch);
    }

    public static ArrayList ProstyeChisla(ushort up_limit)
    {
        ArrayList prostye = new Eratosthenes(up_limit);
        return prostye;
    }

    public static ArrayList ProstyeChisla(uint up_limit)
    {
        ArrayList prostye = new Eratosthenes(up_limit);
        return prostye;
    }

    public static ArrayList ProstyeChisla(ulong up_limit)
    {
        ArrayList prostye = new Eratosthenes(up_limit);
        return prostye;
    }

    public static ArrayList ProstyeChisla(natch16 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static ArrayList ProstyeChisla(natch32 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static ArrayList ProstyeChisla(natch64 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static ArrayList ProstyeChisla(celch16 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static ArrayList ProstyeChisla(celch32 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static ArrayList ProstyeChisla(celch64 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static ArrayList ProstyeChisla(drobch16 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static ArrayList ProstyeChisla(drobch32 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static ArrayList ProstyeChisla(drobch64 up_limit)
    {
        ArrayList prostye = new Eratosthenes((ulong)up_limit.value);
        return prostye;
    }

    public static RCI ChekProstoe(ushort prostoe)
    {
        ArrayList prostye = ProstyeChisla(prostoe + 1U);
        if (prostye.Contains((ulong)prostoe))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(uint prostoe)
    {
        ArrayList prostye = ProstyeChisla(prostoe + 1U);
        if (prostye.Contains((ulong)prostoe))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(ulong prostoe)
    {
        ArrayList prostye = ProstyeChisla(prostoe + 1UL);
        if (prostye.Contains(prostoe))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(natch16 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(natch32 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(natch64 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(celch16 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(celch32 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(celch64 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(drobch16 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(drobch32 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static RCI ChekProstoe(drobch64 prostoe)
    {
        ArrayList prostye = ProstyeChisla((ulong)prostoe.value + 1UL);
        if (prostye.Contains((ulong)prostoe.value))
        {
            return new RCI(true);
        }

        return new RCI(false);
    }

    public static dynamic Factorial(short n)
    {
        if ((double)n >= 0)
        {
            if (n == 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

            return new natch64(fact);
        }

        return new drobch64(Gamma(n + 1));
    }

    public static dynamic Factorial(int n)
    {
        if ((double)n >= 0)
        {
            if (n == 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

            return new natch64(fact);
        }

        return new drobch64(Gamma(n + 1));
    }

    public static dynamic Factorial(long n)
    {
        if ((double)n >= 0)
        {
            if ((int)n == 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

            return new natch64(fact);
        }

        return new drobch64(Gamma(n + 1));
    }

    public static natch64 Factorial(ushort n)
    {
        if (n == 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = 1; i <= n; i++) fact *= i;

        return new natch64(fact);
    }

    public static natch64 Factorial(uint n)
    {
        if ((int)n == 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = 1; i <= n; i++) fact *= i;

        return new natch64(fact);
    }

    public static natch64 Factorial(ulong n)
    {
        if ((int)n == 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = 1; i <= n; i++) fact *= i;

        return new natch64(fact);
    }

    public static drobch64 Factorial(float n) => new drobch64(Gamma(n + 1));

    public static dynamic Factorial(double n) => new drobch64(Gamma(n + 1));

    public static natch64 Factorial(natch16 n)
    {
        if ((int)n == 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

        return new natch64(fact);
    }

    public static natch64 Factorial(natch32 n)
    {
        if ((int)n == 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

        return new natch64(fact);
    }

    public static natch64 Factorial(natch64 n)
    {
        if ((int)n == 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

        return new natch64(fact);
    }

    public static dynamic Factorial(celch16 n)
    {
        if ((double)n.value >= 0)
        {
            if ((int)n == 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

            return new natch64(fact);
        }

        return new drobch64(Gamma(n + 1));
    }

    public static dynamic Factorial(celch32 n)
    {
        if ((double)n.value >= 0)
        {
            if ((int)n == 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

            return new natch64(fact);
        }

        return new drobch64(Gamma(n + 1));
    }

    public static dynamic Factorial(celch64 n)
    {
        if ((double)n.value >= 0)
        {
            if ((int)n == 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = 1; i <= (ulong)n; i++) fact *= i;

            return new natch64(fact);
        }

        return new drobch64(Gamma(n + 1));
    }

    public static dynamic Factorial(drobch16 n) => new drobch64(Gamma(n + 1));

    public static dynamic Factorial(drobch32 n) => new drobch64(Gamma(n + 1));

    public static dynamic Factorial(drobch64 n) => new drobch64(Gamma(n + 1));

    public static natch64 DvoynoyFactorial(ushort n)
    {
        if (n <= 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = n; i >= 2; i -= 2) fact *= i;

        return new natch64(fact);
    }

    public static natch64 DvoynoyFactorial(uint n)
    {
        if ((int)n <= 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = n; i >= 2; i -= 2) fact *= i;

        return new natch64(fact);
    }

    public static natch64 DvoynoyFactorial(ulong n)
    {
        if ((int)n <= 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = n; i >= 2; i -= 2) fact *= i;

        return new natch64(fact);
    }

    public static dynamic DvoynoyFactorial(short n)
    {
        if (n >= 0)
        {
            if (n <= 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

            return new natch64(fact);
        }

        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static dynamic DvoynoyFactorial(int n)
    {
        if (n >= 0)
        {
            if (n <= 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

            return new natch64(fact);
        }

        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static dynamic DvoynoyFactorial(long n)
    {
        if (n >= 0)
        {
            if ((int)n <= 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

            return new natch64(fact);
        }

        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static natch64 DvoynoyFactorial(natch16 n)
    {
        if ((int)n <= 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

        return new natch64(fact);
    }

    public static natch64 DvoynoyFactorial(natch32 n)
    {
        if ((int)n <= 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

        return new natch64(fact);
    }

    public static natch64 DvoynoyFactorial(natch64 n)
    {
        if ((int)n <= 0)
        {
            return new natch64(1);
        }

        ulong fact = 1;
        for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

        return new natch64(fact);
    }

    public static dynamic DvoynoyFactorial(celch16 n)
    {
        if ((double)n.value >= 0)
        {
            if ((int)n <= 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

            return new natch64(fact);
        }

        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static dynamic DvoynoyFactorial(celch32 n)
    {
        if ((double)n.value >= 0)
        {
            if ((int)n <= 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

            return new natch64(fact);
        }

        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static dynamic DvoynoyFactorial(celch64 n)
    {
        if ((double)n.value >= 0)
        {
            if ((int)n <= 0)
            {
                return new natch64(1);
            }

            ulong fact = 1;
            for (ulong i = (ulong)n; i >= 2; i -= 2) fact *= i;

            return new natch64(fact);
        }

        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static FuncOutOfRangeError DvoynoyFactorial(drobch16 n)
    {
        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static FuncOutOfRangeError DvoynoyFactorial(drobch32 n)
    {
        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static FuncOutOfRangeError DvoynoyFactorial(drobch64 n)
    {
        FuncOutOfRangeError err = new FuncOutOfRangeError(0, 0);
        err.Execute();
        return null;
    }

    public static double Gamma(ushort z, ushort z2 = default)
    {
        if ((double)z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return pi / (Math.Sin(pi * z) * Gamma(1 - (double)z));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / ((double)z + i);
            double t = z + g + 0.5;
            return Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x;
        }

        return (double)Factorial((ulong)z - 1);
    }

    public static drobch64 Gamma(ushort z)
    {
        if ((double)z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return new drobch64(pi / (Math.Sin(pi * z) * Gamma(1 - (double)z)));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / ((double)z + i);
            double t = z + g + 0.5;
            return new drobch64(Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x);
        }

        return new drobch64(Factorial((ulong)z - 1));
    }

    public static drobch64 Gamma(uint z)
    {
        if ((double)z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return pi / (Math.Sin(pi * z) * Gamma(1 - z));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / ((double)z + i);
            double t = z + g + 0.5;
            return new drobch64(Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x);
        }

        return new drobch64(Factorial((ulong)z - 1));
    }

    public static drobch64 Gamma(ulong z)
    {
        if ((double)z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return pi / (Math.Sin(pi * z) * Gamma(1 - z));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / ((double)z + i);
            double t = z + (ulong)g + 0.5;
            return new drobch64(Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x);
        }

        return new drobch64(Factorial(z - 1));
    }

    public static drobch64 Gamma(short z)
    {
        if ((double)z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return new drobch64(pi / (Math.Sin(pi * z) * Gamma(1 - (double)z)));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / ((double)z + i);
            double t = z + g + 0.5;
            return new drobch64(Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x);
        }

        return new drobch64(Factorial((ulong)z - 1));
    }

    public static drobch64 Gamma(int z)
    {
        if ((double)z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return pi / (Math.Sin(pi * z) * Gamma(1 - z));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / ((double)z + i);
            double t = z + g + 0.5;
            return new drobch64(Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x);
        }

        return new drobch64(Factorial((ulong)z - 1));
    }

    public static drobch64 Gamma(long z)
    {
        if ((double)z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return pi / (Math.Sin(pi * z) * Gamma(1 - z));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / ((double)z + i);
            double t = z + g + 0.5;
            return new drobch64(Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x);
        }

        return new drobch64(Factorial((ulong)z - 1));
    }

    public static drobch64 Gamma(float z)
    {
        if ((double)z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return pi / (Math.Sin(pi * z) * Gamma(1 - z));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / ((double)z + i);
            double t = z + (ulong)g + 0.5;
            return new drobch64(Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x);
        }

        return new drobch64(Factorial((ulong)z - 1));
    }

    public static double Gamma(double z)
    {
        if (z < 21)
        {
            int g = 7;
            double [] p =
            {
                0.99999999999980993, 676.5203681218851, -1259.1392167224028, 771.32342877765313,
                -176.61502916214059, 12.507343278686905, -0.13857109526572012, 9.9843695780195716e-6,
                1.5056327351493116e-7
            };

            if (z < 0.5)
            {
                return pi / (Math.Sin(pi * z) * Gamma(1 - z));
            }

            z -= 1;
            double x = p[0];
            for (int i = 1; i < g + 2; i++)
                x += p[i] / (z + i);
            double t = z + (ulong)g + 0.5;
            return Math.Sqrt(2 * pi) * Math.Pow(t, z + 0.5) * Math.Exp(-t) * x;
        }

        return (double)Factorial((ulong)z - 1);
    }

    public static drobch64 Gamma(natch16 z) => new drobch64(Gamma((ulong)z.value));

    public static drobch64 Gamma(natch32 z) => new drobch64(Gamma((ulong)z.value));

    public static drobch64 Gamma(natch64 z) => new drobch64(Gamma((ulong)z.value));

    public static drobch64 Gamma(celch16 z) => new drobch64(Gamma((long)z.value));

    public static drobch64 Gamma(celch32 z) => new drobch64(Gamma((long)z.value));

    public static drobch64 Gamma(celch64 z) => new drobch64(Gamma((long)z.value));

    public static drobch64 Gamma(drobch16 z) => new drobch64(Gamma((double)z.value));

    public static drobch64 Gamma(drobch32 z) => new drobch64(Gamma((double)z.value));

    public static drobch64 Gamma(drobch64 z) => new drobch64(Gamma((double)z.value));

    public static List<celch64> FibonacciList(int n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(natch16 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(natch32 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(natch64 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(celch16 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(celch32 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(celch64 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(drobch16 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(drobch32 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }

    public static List<celch64> FibonacciList(drobch64 n)
    {
        Func<double, int> fibonacci = x =>
            Convert.ToInt32((Math.Pow(phi, x) - Math.Pow(-1 / phi, x)) /
                            sqrt_ot_5);
        List<celch64> f = Enumerable.Range(0, (int)n).Select(selector: i => new celch64(fibonacci(i + 1))).ToList();
        return f;
    }


    /*

    public static drobch64 ZeroBeskonechnostSimpsonIntegral(dynamic a, Func<dynamic, dynamic> f)
    {

        return new drobch64(UralMath.SimpsonIntegral(0, 1, t1));


        static dynamic t1(dynamic t, Func<dynamic, dynamic> f)
        {
            return (f((double)t /(1 - (double)t))/((1- (double)t)*(1- (double)t)));
        }
    }
    */
}