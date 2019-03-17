//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    /// <summary>
    /// Characterizes an algebraic group
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="O">The operator type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    public interface Group<T> : Monoid<T>
    {
        /// <summary>
        /// Calculates the inverse of a given element
        /// </summary>
        /// <param name="x">The individual for which an inverse will be calculated</param>
        /// <returns></returns>
        T invert(T x);
        
    }

    public interface FreeGroup<T> : Group<T>, FreeMonoid<T>
    {

    }

    /// <summary>
    /// Characterizes a group consisting of individuals that can be enumerated
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface DiscreteGroup<T> : Group<T>, DiscreteSet<T>
    {

    }


    /// <summary>
    /// Characterizes a group that consists of finitely many individuals
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface FiniteGroup<T> : DiscreteGroup<T>, FiniteSet<T>
    {


    }


    /// <summary>
    /// Characterizes a normal subgroup
    /// </summary>
    /// <typeparam name="X">The individual type</typeparam>
    public interface NormalSubgroup<S> : Group<S>
    {
        
    }

    /// <summary>
    /// Characterizes a set obtained by composing a subgroup with a particular element 
    /// of the supergroup
    /// </summary>
    /// <typeparam name="S">The group/subgroup structure type</typeparam>
    /// <typeparam name="I">The individual type</typeparam>
    public interface Coset<T> 
        where T : Group<T>
    {
        /// <summary>
        /// The distinguished group element with which to compose each subgroup element
        /// </summary>
        /// <returns></returns>
        T actor {get;}

        /// <summary>
        /// The subgroup to be acted upon
        /// </summary>
        /// <returns></returns>
        Group<T> subgroup {get;}

    }

    /// <summary>
    /// Characterizes a coset formed by a left-action
    /// </summary>
    public interface LeftCoset<T> : Coset<T>
        where T : Group<T>
    {
        
    }

    /// <summary>
    /// Characterizes a coset formed by a right-action
    /// </summary>
    public interface RightCoset<T> : Coset<T>
        where T : Group<T>
    {
        
    }


    /// <summary>
    /// Characterizes a group action on a set
    /// </summary>
    /// <typeparam name="G">The type of the acting group</typeparam>
    /// <typeparam name="T">The type of the target set</typeparam>
    /// <remarks>
    /// For an instance to be law-abiding, the act function must satisfy g(act(h,t)) = act(hg,t) and
    /// act(1,t) = t for all g,h in G and t in T
    /// </remarks>
    public interface GroupAction<G,T>
        where G : Group<G>
    {
        /// <summary>
        /// Applies a G-element to a T-element
        /// </summary>
        /// <param name="g">The group element</param>
        /// <param name="t">The target element</param>
        /// <returns></returns>
        T act(G g, T t);

    }

}