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

    using static zcore;

    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    /// <remarks> Adapted from http://xoshiro.di.unimi.it/xoshiro256starstar.c</remarks>
    public class RandUInt16
    {

        const int Bitsize = 16;
        
        [MethodImpl(Inline)]
        static ushort rotl(ushort x, int k) 
            => (ushort)((x << k) | (x >> (Bitsize - k)));

        static IEnumerable<ushort> guiseed()
        {
            var g1 = Guid.NewGuid().ToByteArray();
            var g2 = Guid.NewGuid().ToByteArray();
            yield return BitConverter.ToUInt16(g1,0);
            yield return BitConverter.ToUInt16(g1,4);
            yield return BitConverter.ToUInt16(g2,0);
            yield return BitConverter.ToUInt16(g2,4);
        }

        readonly ushort[] seed;

        public RandUInt16()
            => seed = guiseed().ToArray();

        public RandUInt16(ushort[] seed)
            => this.seed = seed;
 
        [MethodImpl(Inline)]
        void increment()
        {
            var t = seed[1] << 17;
            seed[2] ^= seed[0];
            seed[3] ^= seed[1];
            seed[1] ^= seed[2];
            seed[0] ^= seed[3];
            seed[2] ^= (ushort)t;
            seed[3] = rotl(seed[3], 45);
        }
        
        public ushort next() 
        {
            var next = (ushort)(rotl( (ushort)(seed[1] * 5), 7) * 9);
            increment(); 
            return next;
        }
    }
}