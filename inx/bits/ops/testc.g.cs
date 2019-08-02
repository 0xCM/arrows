//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    using static AsInX;

    partial class gbits
    {

        [MethodImpl(Inline)]
        public static bool testc<T>(in Vec128<T> lhs,in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return Bits.testc(in int8(in lhs), int8(in rhs));
            else if(typeof(T) == typeof(byte))
                return Bits.testc(in uint8(in lhs), uint8(in rhs));
            else if(typeof(T) == typeof(short))
                return Bits.testc(in int16(in lhs), int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                return Bits.testc(in uint16(in lhs), uint16(in rhs));
            else if(typeof(T) == typeof(int))
                return Bits.testc(in int32(in lhs), int32(in rhs));
            else if(typeof(T) == typeof(uint))
                return Bits.testc(in uint32(in lhs), uint32(in rhs));
            else if(typeof(T) == typeof(long))
                return Bits.testc(in int64(in lhs), int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                return Bits.testc(in uint64(in lhs), uint64(in rhs));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(in Vec256<T> lhs,in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return Bits.testc(in int8(in lhs), int8(in rhs));
            else if(typeof(T) == typeof(byte))
                return Bits.testc(in uint8(in lhs), uint8(in rhs));
            else if(typeof(T) == typeof(short))
                return Bits.testc(in int16(in lhs), int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                return Bits.testc(in uint16(in lhs), uint16(in rhs));
            else if(typeof(T) == typeof(int))
                return Bits.testc(in int32(in lhs), int32(in rhs));
            else if(typeof(T) == typeof(uint))
                return Bits.testc(in uint32(in lhs), uint32(in rhs));
            else if(typeof(T) == typeof(long))
                return Bits.testc(in int64(in lhs), int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                return Bits.testc(in uint64(in lhs), uint64(in rhs));
            else 
                throw unsupported<T>();
        }

    }

}