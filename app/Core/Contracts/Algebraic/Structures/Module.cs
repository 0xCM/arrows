//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes a left module over a commtative unital ring
    /// </summary>
    /// <typeparam name="G">The group individual type</typeparam>
    /// <typeparam name="R">The ring individual type</typeparam>
    public interface LeftModule<R,G> 
        where G : AbelianGroup<G>
        where R : Ring<R>
    {
        /// <summary>
        /// Effects left scalar multiplication
        /// </summary>
        /// <param name="r">The ring individual type, i.e., the scalar type</param>
        /// <param name="m">The group individual type</param>
        /// <returns></returns>
        G scale(R r, G m);
    }

    /// <summary>
    /// Characterizes a right module over a commtative unital ring
    /// </summary>
    /// <typeparam name="G">The group individual type</typeparam>
    /// <typeparam name="R">The ring individual type</typeparam>
    public interface RightModule<G,R> 
        where G : AbelianGroup<G>
        where R : Ring<R>
    {
        /// <summary>
        /// Effects right scalar multiplication
        /// </summary>
        /// <param name="m">The group individual type</param>
        /// <param name="r">The ring individual type, i.e., the scalar type</param>
        /// <returns></returns>
        G scale(G m, R r);
    }

}