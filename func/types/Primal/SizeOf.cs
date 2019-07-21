//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static PrimalKind;

    /// <summary>
    /// Computes the size of a primal numeric type
    /// </summary>
    public readonly struct SizeOf<T>
    {
        /// <summary>
        /// The type's kind
        /// </summary>
        public static readonly PrimalKind Primitive = PrimalKinds.kind<T>();
        
        /// <summary>
        /// The size of the type in bytes
        /// </summary>
        public static readonly ByteSize Size = GetSize();

        /// <summary>
        /// The size of the type in bits
        /// </summary>
        public static readonly ulong BitSize = Size*8;
        
        static int GetSize()
            => Primitive switch{
                int8 => 1,
                uint8 => 1,
                int16 => 2,
                uint16 => 2,
                int32 => 4,
                uint32 => 4,
                float32 => 4,
                int64 => 8,
                uint64 => 8,
                float64 => 8,
                _ => -1
            };
    }
}