//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a type for which exactly one value may exist and that value
    /// must be obtainable via a parameterless new construction
    /// </summary>
    /// <typeparam name="S">The type of both the type and value so characterized</typeparam>
    public interface Singleton<S>
        where S : Singleton<S>, new()
    {
        S inhabitant {get;}        
    }


    /// <summary>
    /// Characterizes a typeclass *instance* together with the trait and implementation
    /// </summary>
    /// <typeparam name="I">The concrete instance type</typeparam>
    /// <typeparam name="R">The resolution type, i.e., the type that will be used to resolve the instance</typeparam>
    public interface TypeClass<I,R,T> : Singleton<I>
        where I : TypeClass<I,R,T>, new()
    {
        
    }

    /// <summary>
    /// Binds a realization R with a trait T
    /// </summary>
    /// <typeparam name="R">The concrete instance type</typeparam>
    /// <typeparam name="T">The resolution type, i.e., the type that will be used to resolve the instance</typeparam>
    public interface TypeClass<R,T>
        where R : T,  new()
    {
        R instance();        
    }

}