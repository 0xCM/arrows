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
                default:
                    throw unsupported(Type);
            }
        }

        public static readonly PrimalKind Kind = GetKind();
    }

    /// <summary>
    /// Defines the recognized primal kinds
    /// </summary>
    /// <remarks>
    /// There are other types that could be consindered 'primitive',
    /// such as bool, decimal and so on, but this list is restricted
    /// to "machine" primitive numeric types
    /// </remarks>
    [Flags]
    public enum PrimalKind : uint
    {        
        /// <summary>
        /// When present, identifies an signed type
        /// </summary>
        SignedFacet = Pow2.T01,

        /// <summary>
        /// When present, identifies an integral type
        /// </summary>
        IntegralFacet = Pow2.T02,

        /// <summary>
        /// When present, identifies a floating point type
        /// </summary>
        FloatingFacet = Pow2.T03,
        
        /// <summary>
        /// Identifies a signed 8-bit integer type
        /// </summary>
        int8 = Pow2.T08 | SignedFacet | IntegralFacet,

        /// <summary>
        /// Identifies an unsigned 8-bit integer type
        /// </summary>
        uint8 = Pow2.T09 | IntegralFacet,

        /// <summary>
        /// Identifies a signed 16-bit integer type
        /// </summary>
        int16 = Pow2.T10 | SignedFacet | IntegralFacet,

        /// <summary>
        /// Identifies an unsigned 16-bit integer type
        /// </summary>
        uint16 = Pow2.T11 | IntegralFacet,

        /// <summary>
        /// Identifies a signed 32-bit integer type
        /// </summary>
        int32 = Pow2.T12 | SignedFacet | IntegralFacet,
        
        /// <summary>
        /// Identifies an unsigned 32-bit integer type
        /// </summary>
        uint32 = Pow2.T13 | IntegralFacet,

        /// <summary>
        /// Identifies a signed 64-bit integer type
        /// </summary>
        int64 = Pow2.T14 | SignedFacet | IntegralFacet,

        /// <summary>
        /// Identifies an unsigned 64-bit integer type
        /// </summary>
        uint64 = Pow2.T15 | IntegralFacet,
                            
        /// <summary>
        /// Identifies a a 32-bit floating point type
        /// </summary>
        float32 = Pow2.T16 | SignedFacet | FloatingFacet,

        /// <summary>
        /// Identifies a a 64-bit floating point type
        /// </summary>
        float64 = Pow2.T17 | SignedFacet | FloatingFacet,    
        
        /// <summary>
        /// Identifies the signed integral types
        /// </summary>
        SignedInt = int8 | int16 | int32 | int64,

        /// <summary>
        /// Identifies the usigned integral types
        /// </summary>
        UnsignedInt = uint8 | uint16 | uint32 | uint64,

        /// <summary>
        /// Identifies the integral types
        /// </summary>
        Int = SignedFacet | UnsignedInt,

        /// <summary>
        /// Identifies the floating point types
        /// </summary>
        Floats = float64 | float32,

    }
}