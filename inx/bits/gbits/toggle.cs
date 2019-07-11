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
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static ref T toggle<T>(ref T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                Bits.toggle(ref int8(ref src), pos);
            else if(typeof(T) == typeof(byte))
                Bits.toggle(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(short))
                Bits.toggle(ref int16(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                Bits.toggle(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(int))
                Bits.toggle(ref int32(ref src), pos);
            else if(typeof(T) == typeof(uint))
                Bits.toggle(ref uint32(ref src), pos);
            else if(typeof(T) == typeof(long))
                Bits.toggle(ref int64(ref src), pos);
            else if(typeof(T) == typeof(ulong))
                Bits.toggle(ref uint64(ref src), pos);
            else if(typeof(T) == typeof(float))
                Bits.toggle(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                Bits.toggle(ref float64(ref src), pos);
            else
                throw unsupported<T>();

            return ref src;                            
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static T toggle<T>(T src, int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.toggle(int8(src), pos));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.toggle(uint8(src), pos));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.toggle(int16(src), pos));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.toggle(uint16(src), pos));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.toggle(int32(src), pos));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.toggle(uint32(src), pos));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.toggle(int64(src), pos));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.toggle(uint64(src), pos));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.toggle(float32(src), pos));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.toggle(float64(src), pos));
            else
                throw unsupported<T>();
        }
    }
}