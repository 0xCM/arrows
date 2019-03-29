//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zcore;

    /// <summary>
    /// Characterizes structural reification of type S over a data type T
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying data type</typeparam>
    public interface Structural<S,T> : IEquatable<S>
        where S : Structural<S,T>, new()
    {
        /// <summary>
        /// Specifies the data encapsulated by the structure
        /// </summary>
        /// <value></value>
        T data {get;}        
    }    

    /// <summary>
    /// Characterizes an operational reification of unspecified type over an operand of type T
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface Operational<T>
    {

    }

    /// <summary>
    /// Characterizes an operational reification of type R over an operand of type T
    /// </summary>
    /// <typeparam name="R">The reification type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    public interface Operational<R,T> : Operational<T>
        where R : Operational<R,T>, new()
    {

    }

    /// <summary>
    /// Identifies a typeclass instance
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class TypeClassAttribute : Attribute
    {
    
        public static IEnumerable<(Type reifier, Type operand)> Find<T>()
            => from  attrib in typeof(T).Assembly.GetTypeAttributions<TypeClassAttribute>()
                select (attrib.Value.ReifyingType, attrib.Value.OperandType);

        public TypeClassAttribute(Type reify, Type operand)
        {
            this.ReifyingType = reify;
            this.OperandType = operand;
        }
        
        /// <summary>
        /// The type that implements operations over the operand
        /// </summary>
        public Type ReifyingType{get;}

        /// <summary>
        /// The type over which operations are reified
        /// </summary>
        public Type OperandType{get;}
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