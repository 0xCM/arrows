//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes operational inversion
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IInvertiveOps<T>
    {

    }

    /// <summary>
    /// Characterizes operational multiplicative inversion
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface InvertiveMOps<T> : IInvertiveOps<T>
    {
        T invertM(T x);
    }

    /// <summary>
    /// Characterizes operational additive inversion
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface InvertiveA<T> : IInvertiveOps<T>
    {
        T invertA(T x);
    }

    /// <summary>
    /// Characterizes structural inversion
    /// </summary>
    /// <typeparam name="T">The type over which the structrue is defined</typeparam>
    public interface IInvertive<S>
    {
        
    }

    /// <summary>
    /// Characterizes structural multiplicative inversion
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IInvertiveM<S> : IInvertive<S>, IMultiplicative<S>
        where S : IInvertiveM<S>, new()
    {
        /// <summary>
        /// Effects multiplicative inversion
        /// </summary>
        S invertM();
    }

    /// <summary>
    /// Characterizes structural additive inversion
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IInvertiveA<S> : IInvertive<S>, IAdditive<S>
        where S : IInvertiveA<S>, new()
    {
        /// <summary>
        /// Effects additive inversion
        /// </summary>
        S invertA();
    }

}
 