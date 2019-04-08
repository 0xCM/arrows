//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    using static zcore;

    /// <summary>
    /// Defines primary bitvector api
    /// </summary>
    public static class BitVector
    {
        /// <summary>
        /// Constructs a BitVector from an integer
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        public static BitVector<N,T> define<N,T>(N nat, intg<T> src)
            where N : TypeNat, new()
                => new BitVector<N,T>(src);

        /// <summary>
        /// Constructs a BitVector from a base-2 string
        /// </summary>
        /// <param name="src">The source string</param>
        /// <typeparam name="T">The bitvector integral type</typeparam>
        public static BitVector<N,T> parse<N,T>(string src)
            where N : TypeNat, new()
        {
            var result = intg<T>.Zero;    
            var chars = reorient(remove(src.Trim(), "0b"));
            var start = min(chars.Length,(int)intg<T>.BitSize) - 1;
            for(var i = start; i >=0; i--)
            {                
                var c = chars[i];
                var b = bit.Parse(c).ToIntG<T>();
                result += Pow2.mul(i,b);
            }
            return result;
        }

        /// <summary>
        /// Consucts a byte-BitVector from a base-2 string
        /// </summary>
        /// <param name="n">The type natural representation for the number 8</param>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> parse(N8 n, string src)
            => parse<N8, byte>(src);

        /// <summary>
        /// Consucts a ushort-BitVector from a base-2 string
        /// </summary>
        /// <param name="n">The type natural representation for the number 16</param>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> parse(N16 n, string src)
            => parse<N16, ushort>(src);

        /// <summary>
        /// Consucts a uint-BitVector from a base-2 string
        /// </summary>
        /// <param name="n">The type natural representation for the number 32</param>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> parse(N32 n, string src)
            => parse<N32, uint>(src);

        /// <summary>
        /// Consucts a ulong-BitVector from a base-2 string
        /// </summary>
        /// <param name="n">The type natural representation for the number 64</param>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> parse(N64 n, string src)
            => parse<N64, ulong>(src);
    
    }  
}