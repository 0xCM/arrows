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

    public static class Seed
    {
        /// <summary>
        /// Produces a specified number of entropic bytes
        /// </summary>
        /// <param name="bz">The number of bytes</param>
        [MethodImpl(Inline)]
        public static Span<byte> Entropy(ByteSize bz)
        {
            using var csp = new RNGCryptoServiceProvider();
            var dst = new byte[bz];
            csp.GetBytes(dst);
            return dst;
        }
        
        /// <summary>
        /// Produces a specified number of entropic bytes as a span of primal type
        /// </summary>
        /// <param name="bz">The number of bytes</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Entropy<T>(ByteSize bz)
            where T : struct
        {
            var src = Entropy(bz);
            return MemoryMarshal.Cast<byte,T>(src);
        }

        /// <summary>
        /// Produces a specified number of entropic primal values
        /// </summary>
        /// <param name="count">The number of bytes</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Entropy<T>(int count)
            where T : struct
        {
            var typeBz = Unsafe.SizeOf<T>();
            var bz = count * typeBz;            
            var src = Entropy(bz);
            return MemoryMarshal.Cast<byte,T>(src);
        }

        /// <summary>
        /// Produces a single entropic value of primal type
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T Entropy<T>()
            where T : struct
        {
            var typeBz = Unsafe.SizeOf<T>();
            var src = Entropy(typeBz);
            return MemoryMarshal.Cast<byte,T>(src)[0];
        }        
    }

}
