//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class AsmNegate
    {
        readonly struct Host<T>
            where T : struct
        {
            public static readonly Host<T> TheOnly = default;

            static readonly AsmUnaryOp<T> Reified = Code<T>().CreateUnaryOp();

            public AsmUnaryOp<T> Operator
                => Reified;
        }

        public static AsmUnaryOp<T> Op<T>()
            where T : struct
            => Host<T>.TheOnly.Operator;

        [MethodImpl(Inline)]
        public static AsmCode<T> Code<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return NegateI8.As<T>();
            else if(typeof(T) == typeof(byte))
                return NegateU8.As<T>();
            else if(typeof(T) == typeof(short))
                return NegateI16.As<T>();
            else if(typeof(T) == typeof(ushort))
                return NegateU16.As<T>();
            else if(typeof(T) == typeof(int))
                return NegateI32.As<T>();
            else if(typeof(T) == typeof(uint))
                return NegateU32.As<T>();
            else if(typeof(T) == typeof(long))
                return NegateI64.As<T>();
            else if(typeof(T) == typeof(ulong))
                return NegateU64.As<T>();
            else if(typeof(T) == typeof(float))
                return NegateF32.As<T>();
            else if(typeof(T) == typeof(double))
                return NegateF64.As<T>();
            else 
                throw unsupported<T>();
        }

        public static AsmCode<sbyte> NegateI8
            => NegateI8Bytes;

        public static AsmCode<byte> NegateU8
            => NegateU8Bytes;

        public static AsmCode<short> NegateI16
            => NegateI16Bytes;

        public static AsmCode<ushort> NegateU16
            => NegateU16Bytes;

        public static AsmCode<int> NegateI32
            => NegateI32Bytes;

        public static AsmCode<uint> NegateU32
            => NegateU32Bytes;

        public static AsmCode<long> NegateI64
            => NegateI64Bytes;

        public static AsmCode<ulong> NegateU64
            => NegateU64Bytes;

        public static AsmCode<float> NegateF32
            => NegateF32Bytes;

        public static AsmCode<double> NegateF64
            => NegateF64Bytes;


       static ReadOnlySpan<byte> NegateU8Bytes
            => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};

        static ReadOnlySpan<byte> NegateI8Bytes
            => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};

        static ReadOnlySpan<byte> NegateI16Bytes
            => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};

        static ReadOnlySpan<byte> NegateU16Bytes
            => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};

        static ReadOnlySpan<byte> NegateI32Bytes
            => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};

        static ReadOnlySpan<byte> NegateU32Bytes
            => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};

        static ReadOnlySpan<byte> NegateI64Bytes
            => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};

        static ReadOnlySpan<byte> NegateU64Bytes
            => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};

        static ReadOnlySpan<byte> NegateF32Bytes
            => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF2,0x5C,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};

        static ReadOnlySpan<byte> NegateF64Bytes
            => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF3,0x5C,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
    }
}