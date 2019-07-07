namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;    
        
    //~ opgroup     :: Flip: this | Span[T] -> Span[T]
    //~ T           :: Integers (sbyte | byte | short | ushort | int | uint | long | ulong)
    //~ opname      :: Flip
    //~ facets      :: public | static | nongeneric


    public class OpGroup
    {
        public OpGroup(string Name, bool IsGeneric, int Arity, TypeParamSet[] TypeParameters)
        {
            this.Name = Name;
            this.IsGeneric = IsGeneric;
            this.Arity = Arity;
            this.TypeParameters = TypeParameters;
        }

        /// <summary>
        /// The name of the method that represents the group
        /// </summary>
        public string Name {get;}
        
        /// <summary>
        /// Indicates whether the operator itself is generic.
        /// If non-generic, the opgroup represents a set of overloaded
        /// methods
        /// </summary>
        public bool IsGeneric {get;}

        /// <summary>
        /// Specifies the common number of operands accepted by each operator
        /// </summary>
        public int Arity {get;}

        /// <summary>
        /// If generic, discribes the type parameters. If IsGeneric = true,
        /// there should be at least one type parameter description
        /// </summary>
        /// <value></value>
        public TypeParamSet[] TypeParameters {get;}
        
    }
}