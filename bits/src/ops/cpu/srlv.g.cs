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
        ///  __m128i _mm_srlv_epiN (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control vector</param>
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
        ///  __m128i _mm_srlv_epiN (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
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


    }

}