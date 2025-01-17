namespace Datatypes.Collections.MathCollections;

public class LambdaFunc
{
    public static Type I<Type>(Type x) => x;

    // И = x => x
    public static Func<Type2, Type1> K<Type1, Type2>(Type1 x)
    {
        return _ => x;
        // К = x => _ => x
    }

    public static Func<Type1, TypeR> A<Type1, TypeR>(Func<Type1, TypeR> f) => f;

    // А = f => f
    public static Func<Func<Type1, Type2>, Func<Type1, TypeR>> S<Type1, Type2, TypeR>(Func<Type1, Func<Type2, TypeR>> x)
    {
        return y => z => x(z)(y(z));
        // C = x => y => z = x(z)(y(z))
    }

    public static Func<Func<Type1, Type2>, Func<Type1, TypeR>> B<Type1, Type2, TypeR>(Func<Type2, TypeR> x)
    {
        return y => z => x(y(z));
        //Б = x => => z => x(y(z))
    }

    public static Func<Type2, Func<Type1, TypeR>> C<Type1, Type2, TypeR>(Func<Type1, Func<Type2, TypeR>> x)
    {
        return y => z => x(z)(y);
        // Ц = f => x => y => f(y)(z)
    }

    public static Func<Type1, TypeR> W<Type1, TypeR>(Func<Type1, Func<Type1, TypeR>> x)
    {
        return y => x(y)(y);
        // В
    }

    public static Func<Func<Type1, Type2>, Func<Func<Type1, Type3>, Func<Type1, T4>>>
        M<Type1, Type2, Type3, T4>(Func<Type2, Func<Type3, T4>> f)
    {
        return g => h => x => f(g(x))(h(x));
        // М
    }
}

public static class Y<Type_T, Type_R>
{
    private delegate Func<Type_T, Type_R> YI(Lambda x);

    private delegate Func<Type_T, Type_R> RI(RI ri);

    public delegate Func<Type_T, Type_R> Lambda(Func<Type_T, Type_R> rec);

    public static Func<Type_T, Type_R> Fix(params Lambda [] fs)
    {
        Lambda? f = fs.Aggregate(func: (fx, decorator) => x => decorator(fx(x)));
        return new YI(f => new RI(x => v => f(x(x))(v))(x => v => f(x(x))(v)))(f);
    }
}