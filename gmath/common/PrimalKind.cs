//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    

    public readonly struct PrimalKind<T>
    {
        public static readonly Type Type = typeof(T);

        public static readonly PrimalKind Kind = PrimalKinds.kind(Type);
    }

    public enum PrimalKind : byte
    {
        none = 0,
        
        int8 = 1,

        uint8 = 2,

        int16 = 3,

        uint16 = 4,        

        int32 = 5,
        
        uint32 = 6,

        int64 = 7,

        uint64 = 8,
                            
        float32 = 9,

        float64 = 10,  

        float128 = 11,

        decimal128 = 12,

        bigint = 13,
        
        last = bigint      
    }

    public static class PrimalX
    {
        public static bool IsUnsignedIntegral(this PrimalKind kind)
            => kind == PrimalKind.uint8 ||
               kind == PrimalKind.uint16 ||
               kind == PrimalKind.uint32 ||
               kind == PrimalKind.uint64;

        public static bool IsSignedIntegral(this PrimalKind kind)
            => kind == PrimalKind.int8 ||
               kind == PrimalKind.int16 ||
               kind == PrimalKind.int32 ||
               kind == PrimalKind.int64 ||
               kind == PrimalKind.bigint;

        public static bool IsIntegral(this PrimalKind kind)
            => kind.IsSignedIntegral() || kind.IsUnsignedIntegral();

    }
}