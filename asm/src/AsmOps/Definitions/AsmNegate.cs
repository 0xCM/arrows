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
    using static AsmCodeBank;
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
                return AsmCode.FromBytes<T>(negate8iBytes);
            else if(typeof(T) == typeof(byte))
                return AsmCode.FromBytes<T>(negate8uBytes);
            else if(typeof(T) == typeof(short))
                return AsmCode.FromBytes<T>(negate16iBytes);
            else if(typeof(T) == typeof(ushort))
                return AsmCode.FromBytes<T>(negate16uBytes);
            else if(typeof(T) == typeof(int))
                return AsmCode.FromBytes<T>(negate32iBytes);
            else if(typeof(T) == typeof(uint))
                return AsmCode.FromBytes<T>(negate32uBytes);
            else if(typeof(T) == typeof(long))
                return AsmCode.FromBytes<T>(negate64iBytes);
            else if(typeof(T) == typeof(ulong))
                return AsmCode.FromBytes<T>(negate64uBytes);
            else if(typeof(T) == typeof(float))
                return AsmCode.FromBytes<T>(negate32fBytes);
            else if(typeof(T) == typeof(double))
                return AsmCode.FromBytes<T>(negate64fBytes);
            else 
                throw unsupported<T>();
        }




    }
}