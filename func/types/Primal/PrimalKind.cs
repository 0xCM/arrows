//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public readonly struct PrimalKind<T>
    {
        public static readonly Type Type = typeof(T);

        static PrimalKind GetKind()
        {
            var code = Type.GetTypeCode(Type);
            switch(code)
            {
                case TypeCode.SByte:
                    return PrimalKind.int8;
                case TypeCode.Byte:
                    return PrimalKind.uint8;
                case TypeCode.Int16:
                    return PrimalKind.int16;
                case TypeCode.UInt16:
                    return PrimalKind.uint16;
                case TypeCode.Int32:
                    return PrimalKind.int32;
                case TypeCode.UInt32:
                    return PrimalKind.uint32;
                case TypeCode.Int64:
                    return PrimalKind.int64;
                case TypeCode.UInt64:
                    return PrimalKind.uint64;
                case TypeCode.Single:
                    return PrimalKind.float32;
                case TypeCode.Double:
                    return PrimalKind.float64;
                case TypeCode.Decimal:
                    return PrimalKind.float128;                    

                default:
                    if (Type == type<System.Numerics.BigInteger>())
                        return PrimalKind.bigint;
                    else
                        throw unsupported(Type);
            }
        }

        public static readonly PrimalKind Kind = GetKind();
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

        [MethodImpl(Inline)]
        public static bool IsIntegral(this PrimalKind kind)
            => (byte)kind < (byte)PrimalKind.float32;

        [MethodImpl(Inline)]
        public static bool IsFloat(this PrimalKind kind)
            => (byte)(kind) > (byte)PrimalKind.uint64;


    }
}