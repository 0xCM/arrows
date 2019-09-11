//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class ginx
    {                        
        /// <summary>
        /// Creates a 256-bit vector from two 128-bit vectors    
        /// This mimics the _mm256_set_m128i intrinsic which is not available (!?!)
        /// </summary>
        /// <param name="lo">The lo part</param>
        /// <param name="hi">The hi part</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> set<T>(in Vec128<T> lo, in Vec128<T> hi)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Vec256.FromParts(in int8(in lo), in int8(in hi)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Vec256.FromParts(in uint8(in lo), in uint8(in hi)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Vec256.FromParts(in int16(in lo), in int16(in hi)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Vec256.FromParts(in uint16(in lo), in uint16(in hi)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Vec256.FromParts(in int32(in lo), in int32(in hi)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Vec256.FromParts(in uint32(in lo), in uint32(in hi)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Vec256.FromParts(in int64(in lo), in int64(in hi)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Vec256.FromParts(in uint64(in lo), in uint64(in hi)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Vec256.FromParts(in float32(in lo), in float32(in hi)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Vec256.FromParts(in float64(in lo), in float64(in hi)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec512<T> set<T>(in Vec256<T> lo, in Vec256<T> hi)
            where T : struct
                => Vec512.FromParts(lo,hi);
        
    }

}