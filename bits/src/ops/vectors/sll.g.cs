//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {
        [MethodImpl(Inline)]
        public static Vec128<T> sll<T>(in Vec128<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.sll(in uint8(in lhs), offset));
            else if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.sll(in int8(in lhs), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.sll(in int16(in lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.sll(in uint16(in lhs), offset));
            if(typeof(T) == typeof(int))
                return generic<T>(Bits.sll(in int32(in lhs), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(Bits.sll(in uint32(in lhs), offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.sll(in int64(lhs), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.sll(in uint64(lhs), offset));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vec256<T> sll<T>(in Vec256<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.sll(in uint8(in lhs), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.sll(in int16(in lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.sll(in uint16(in lhs), offset));
            if(typeof(T) == typeof(int))
                return generic<T>(Bits.sll(in int32(in lhs), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(Bits.sll(in uint32(in lhs), offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.sll(in int64(lhs), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.sll(in uint64(lhs), offset));
            else
                throw unsupported<T>();
        }



    }
}