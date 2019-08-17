namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// Implements an XOrShift generator
    /// </summary>
    /// <remarks>
    /// Core algorithms taken from the paper: https://arxiv.org/pdf/1402.6246.pdf
    /// </remarks>
    public class XOrShift1024 : IRandomSource, IRandomSource<ulong>
    {
        /// <summary>
        /// The jump table of predetermined constants to facilitate an efficient way
        /// to simulate calls to "Next()"
        /// </summary>
        readonly static ulong[] JT = new ulong[]
        {   0x84242f96eca9c41d, 0xa3c65b8776f96855, 0x5b34a39f070b5837,0x4489affce4f31a1e, 
            0x2ffeeb0a48316f40, 0xdc2d9891fe68c022, 0x3659132bb12fea70, 0xaac17d8efa43cab8, 
            0xc4cb815590989b13, 0x5ee975283d71c93b, 0x691548c86c1bd540, 0x7910c41d10a1e6a5,
            0x0b5fc64563b3e2a8, 0x047f7684e9fc949d, 0xb99181f2d8f685ca, 0x284600e3f30e38c3
        };

        /// <summary>
        /// Predetermined constant by which every generated value is multiplied
        /// </summary>
        const ulong Multiplier = 1181783497276652981;

        readonly ulong[] state;
        
        int p;

        Polyrand MR;

        public XOrShift1024(ulong[] seed)
        {
            if(seed.Length < 16)
                throw new Exception($"Not enough seed! 1024 bits = 128 bytes = 16 longs are required");
            this.state = As.uint64(seed).ToArray();
            this.MR = RNG.Polyrand(this);
        }

        public XOrShift1024(Span<byte> seed)
        {
            if(seed.Length < 128)
                throw new Exception($"Not enough seed! 1024 bits = 128 bytes are required");
            this.state = As.uint64(seed).ToArray();
            this.MR = RNG.Polyrand(this);
        }

        public void Jump() 
        {
            ulong[] t = new ulong[16];

            for(int i = 0; i < JT.Length; i++)
            for(int b = 0; b < 64; b++) 
            {
                if ( (JT[i] & 1ul << b) != 0)
                    for(int j = 0; j < 16; j++)
                        t[j] ^= state[(j + p) & 15];
                NextUInt64();
            }

            for(int j = 0; j < 16; j++)
                state[(j + p) & 15] = t[j];
        }

        [MethodImpl(Inline)]
        public ulong NextUInt64() 
        {
            ulong s0 = state[p];
            ulong s1 = state[p = (p + 1) & 15];
            s1 ^= s1 << 31; // a
            state[p] = s1 ^ s0 ^ (s1 >> 11) ^ (s0 >> 30); // b,c
            return state[p] * Multiplier;
        }
        

        [MethodImpl(Inline)]
        public double NextDouble()
            => MR.Next<double>();

        ulong IPointSource<ulong>.Next()
            => NextUInt64();

        ulong IRandomSource.NextUInt64(ulong max)
            => (this as IRandomSource<ulong>).Next(max);

        int IRandomSource.NextInt32(int max)
            => (this as IRandomSource<ulong>).Next(max);

    }

}