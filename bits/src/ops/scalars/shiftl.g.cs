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

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T shiftl<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) << offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) << offset));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) << offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) << offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) << offset);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) << offset);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) << offset);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) << offset);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T shiftl<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) << (int)int8(offset)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) << (int)uint8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) << (int)int16(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) << (int)uint16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) << (int)int32(offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) << (int)uint32(offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) << (int)int64(offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) << (int)uint64(offset));
            else            
                throw unsupported<T>();
        }           


        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref T shiftl<T>(ref T lhs, int rhs)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                shiftl(ref int8(ref lhs), rhs);
            else if (typeof(T) == typeof(byte))
                shiftl(ref uint8(ref lhs), rhs);
            else if (typeof(T) == typeof(short))
                shiftl(ref int16(ref lhs), rhs);
            else if (typeof(T) == typeof(ushort))
                shiftl(ref uint16(ref lhs), rhs);
            else if (typeof(T) == typeof(int))
                shiftl(ref int32(ref lhs), rhs);
            else if (typeof(T) == typeof(uint))
                shiftl(ref uint32(ref lhs), rhs);
            else if (typeof(T) == typeof(long))
                shiftl(ref int64(ref lhs), rhs);
            else if (typeof(T) == typeof(ulong))
                shiftl(ref uint64(ref lhs), rhs);
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static T shiftl<T>(in T lhs, in uint rhs)
            where T : struct
                => shiftl(lhs, (int)rhs);

        [MethodImpl(Inline)]
        public static T shiftl<T>(in T lhs, in ulong rhs)
            where T : struct
                => shiftl(lhs, (int)rhs);

        [MethodImpl(Inline)]
        static ref sbyte shiftl(ref sbyte lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref byte shiftl(ref byte lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref short shiftl(ref short lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref ushort shiftl(ref ushort lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref int shiftl(ref int lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref uint shiftl(ref uint lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref long shiftl(ref long lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref ulong shiftl(ref ulong lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

    }

}