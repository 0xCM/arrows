//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IReciprocativeOps<T> : IUnitalOps<T>, IMultiplicativeOps<T>
    {
        /// <summary>
        /// Calculates the multiplicative inverse of a given element
        /// </summary>
        /// <param name="x">The individual for which an inverse will be calculated</param>
        T recip(T x);
        
    }
    
    /// <summary>
    /// Characterizes a multiplicative and unitial structure S such that
    /// s:S => s * recip(s) = 1
    /// </summary>
    /// <typeparam name="S"></typeparam>
    public interface IReciprocative<S> :  IUnital<S>, IMultiplicative<S>
        where S : IReciprocative<S>, new()
    {
        /// <summary>
        /// Calculates the structure's multiplicative inverse
        /// </summary>
        S recip();            
    }

}