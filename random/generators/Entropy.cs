//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;

    using static zfunc;

    public static class Entropy
    {
        /// <summary>
        /// Produces a specified number of entropic bytes
        /// </summary>
        /// <param name="count">The number of bytes</param>
        [MethodImpl(Inline)]
        public static Span<byte> Bytes(int count)
        {
            using var csp = new RNGCryptoServiceProvider();
            var dst = new byte[count];
            csp.GetBytes(dst);
            return dst;
        }
        
        /// <summary>
        /// Produces a specified number of entropic primal values
        /// </summary>
        /// <param name="count">The number of bytes</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Values<T>(int count)
            where T : struct
        {
            var typeBz = Unsafe.SizeOf<T>();
            var bz = count * typeBz;            
            var src = Bytes(bz);
            return MemoryMarshal.Cast<byte,T>(src);
        }

        /// <summary>
        /// Produces an entropic primal sequence of natural length
        /// </summary>
        /// <param name="count">The number of bytes</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,T> Values<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : struct        
                => Values<T>((int)n.value);    


        /// <summary>
        /// Produces a single entropic value of primal type
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Value<T>()
            where T : struct
        {
            var typeBz = Unsafe.SizeOf<T>();
            var src = Bytes(typeBz);
            return MemoryMarshal.Cast<byte,T>(src)[0];
        }        
    }

}
