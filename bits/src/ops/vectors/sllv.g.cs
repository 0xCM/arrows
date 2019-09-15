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
        /// <summary>
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec128<S> sllv<S,T>(in Vec128<S> lhs, in Vec128<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(Bits.sllv(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(Bits.sllv(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(Bits.sllv(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(Bits.sllv(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
        [MethodImpl(Inline)]
        public static Vec256<S> sllv<S,T>(in Vec256<S> lhs, in Vec256<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(Bits.sllv(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(Bits.sllv(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(Bits.sllv(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(Bits.sllv(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
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

        [MethodImpl(Inline)]
        public static Vec256<T> srl<T>(in Vec256<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.srl(in uint8(in lhs), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.srl(in int16(in lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.srl(in uint16(in lhs), offset));
            if(typeof(T) == typeof(int))
                return generic<T>(Bits.srl(in int32(in lhs), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(Bits.srl(in uint32(in lhs), offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.srl(in int64(lhs), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.srl(in uint64(lhs), offset));
            else
                throw unsupported<T>();
        }

        public static Span256<T> sll<T>(ReadOnlySpan256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                vstore(sll(lhs.LoadVec256(i), offset), ref dst.Block(i));                             
            return dst;        
        } 

        public static Span256<T> srl<T>(ReadOnlySpan256<T> lhs, byte offset, Span256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< lhs.BlockCount; i++)
                vstore(srl(lhs.LoadVec256(i), offset), ref dst.Block(i));                             
            return dst;        
        } 



    }

}