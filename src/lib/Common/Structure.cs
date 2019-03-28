//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a type that exists to encapsulate and define 
    /// a specific presentation of the encapsulated value
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying data type</typeparam>
    public interface Structure<S,T> : IEquatable<S>
        where S : Structure<S,T>, new()
    {
        /// <summary>
        /// Specifies the data encapsulated by the structure
        /// </summary>
        /// <value></value>
        T data {get;}        
    }    

    /// <summary>
    /// Identifies a typeclass instance
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class TypeClassAttribute : Attribute
    {
        public TypeClassAttribute(Type TraitType)
            => this.TraitType = TraitType;
        public Type TraitType {get;}
    }
    
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
    /// Characterizes a typeclass reification
    /// </summary>
    /// <typeparam name="R"></typeparam>
    public interface TypeClass<R> 
        where R : TypeClass<R>, new()
    {

    }

    /// <summary>
    /// Characterizes a typeclass reification for a specified contract
    /// </summary>
    /// <typeparam name="R">The reification type</typeparam>
    /// <typeparam name="T">The operand type </typeparam>
    public interface TypeClass<R,T> : TypeClass<R>
        where R : TypeClass<R,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a typeclass reification for a specified operations/operand type
    /// </summary>
    /// <typeparam name="R">The reification type</typeparam>
    /// <typeparam name="C">The contract/trait that characterizes the operations to be realized</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    public interface TypeClass<R,C,T> : TypeClass<R,T>, Singleton<R>
        where R : TypeClass<R,C,T>, new()
    {
        
    }



}