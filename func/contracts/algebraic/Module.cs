//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface ILeftModule<R,G>  : IGroupA<G>
        where R : IRing<R>, new()
        where G : IGroupA<G>, new()
    {
        /// <summary>
        /// Effects scalar multiplication from the left
        /// </summary>
        /// <param name="r">The ring individual type, i.e., the scalar type</param>
        /// <param name="m">The group individual type</param>
        G LeftScale(R r);
    }

    public interface IRightModule<G,R>  : IGroupA<G>
        where R : IRing<R>, new()
        where G : IGroupA<G>, new()
    {
        /// <summary>
        /// Effects scalar multiplication from the right
        /// </summary>
        /// <param name="r">The ring individual type, i.e., the scalar type</param>
        /// <param name="m">The group individual type</param>
        G RightScale(R r);
    }

    public interface ILeftModule<S,R,G> : ILeftModule<R,G>
        where S : ILeftModule<S,R,G>, new()
        where R : ICommutativeRing<R>, new()
        where G : IGroupA<G>, new()
    {

    }

    public interface IRightModule<S,G,R> : IRightModule<G,R>
        where S : IRightModule<S,G,R>, new()
        where R : ICommutativeRing<R>, new()
        where G : IGroupA<G>, new()
    {

    }

    /// <summary>
    /// Characterizes a group action on a set
    /// </summary>
    /// <typeparam name="G">The type of the acting group</typeparam>
    /// <typeparam name="R">The type of the target set</typeparam>
    /// <remarks>
    /// For an instance to be law-abiding, the act function must satisfy g(act(h,t)) = act(hg,t) and
    /// act(1,t) = t for all g,h in G and t in T
    /// Also, see https://en.wikipedia.org/wiki/Group_with_operators
    /// </remarks>
    public interface IGroupAction<G,R>
        where G : IGroupOps<G>, new()

    {
        /// <summary>
        /// Applies a G-element to a T-element
        /// </summary>
        /// <param name="g">The group element</param>
        /// <param name="t">The target element</param>
        R Act(G g, R t);
    }

    /// <summary>
    /// Characterizes a left module over a commtative unital ring
    /// </summary>
    /// <typeparam name="G">The group individual type</typeparam>
    /// <typeparam name="R">The ring individual type</typeparam>
    public interface ILeftModuleOps<R,G> : IGroupAOps<G>
        where R : ICommutativeRingOps<R>, new()
        
    {
        /// <summary>
        /// Effects left scalar multiplication
        /// </summary>
        /// <param name="r">The ring individual type, i.e., the scalar type</param>
        /// <param name="m">The group individual type</param>
        G LeftScale(R r, G m);
    }

    /// <summary>
    /// Characterizes a right module over a commtative unital ring
    /// </summary>
    /// <typeparam name="G">The group individual type</typeparam>
    /// <typeparam name="R">The ring individual type</typeparam>
    public interface IRightModuleOps<G,R> : IGroupAOps<G>
        where R : ICommutativeRingOps<R>, new()
    {
        /// <summary>
        /// Effects right scalar multiplication
        /// </summary>
        /// <param name="m">The group individual type</param>
        /// <param name="r">The ring individual type, i.e., the scalar type</param>
        G RightScale(G m, R r);
    }

}