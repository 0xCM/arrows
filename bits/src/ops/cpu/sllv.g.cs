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