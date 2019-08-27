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
    

    public static partial class gbits
    {

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T shiftr<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) >> offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) >> offset));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) >> offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) >> offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) >> offset);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) >> offset);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) >> offset);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) >> offset);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T shiftr<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) >> (int)int8(offset)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) >> (int)uint8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) >> (int)int16(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) >> (int)uint16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) >> (int)int32(offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) >> (int)uint32(offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) >> (int)int64(offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) >> (int)uint64(offset));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T shiftr<T>(ref T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                shiftr(ref int8(ref src), offset);
            else if(typeof(T) == typeof(byte))
                shiftr(ref uint8(ref src), offset);
            else if(typeof(T) == typeof(short))
                shiftr(ref int16(ref src), offset);
            else if(typeof(T) == typeof(ushort))
                shiftr(ref uint16(ref src), offset);
            else if(typeof(T) == typeof(int))
                shiftr(ref int32(ref src), offset);
            else if(typeof(T) == typeof(uint))
                shiftr(ref uint32(ref src), offset);
            else if(typeof(T) == typeof(long))
                shiftr(ref int64(ref src), offset);
            else if(typeof(T) == typeof(ulong))
                shiftr(ref uint64(ref src), offset);
            else
                throw unsupported<T>();
            return ref src;
        }           

        [MethodImpl(Inline)]
        public static Vec128<S> srlv<S,T>(in Vec128<S> lhs, in Vec128<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(Bits.srlv(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(Bits.srlv(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(Bits.srlv(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(Bits.srlv(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec256<S> srlv<S,T>(in Vec256<S> lhs, in Vec256<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(Bits.srlv(in int32(in lhs),  shifts.As<uint>()));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(Bits.srlv(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(Bits.srlv(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(Bits.srlv(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }


        [MethodImpl(Inline)]
        static ref sbyte shiftr(ref sbyte lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref byte shiftr(ref byte lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref short shiftr(ref short lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref ushort shiftr(ref ushort lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref int shiftr(ref int lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref uint shiftr(ref uint lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref long shiftr(ref long lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref ulong shiftr(ref ulong lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

    }

}