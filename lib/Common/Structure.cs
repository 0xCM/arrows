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
    /// Identifies a typeclass instance
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class StructureAttribute : Attribute
    {
    
        public static IEnumerable<(Type reifier, Type operand)> Find<T>()
            => from  attrib in typeof(T).Assembly.GetTypeAttributions<StructureAttribute>()
                select (attrib.Value.ReifyingType, attrib.Value.OperandType);

        public StructureAttribute(Type reify, Type operand)
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
}