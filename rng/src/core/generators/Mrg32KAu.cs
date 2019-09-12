//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Mrg32K;

    using Vec6u32 = Vector<N6,uint>;
    using Vec6i64 = Vector<N6,long>;
    using Mat3u32 = Matrix<N3,uint>;

    /// <summary>
    /// Implements L’Ecuyer's combined multiple recursive generator (CMRG) with 32-bit 
    /// unsigned integers This generator has a period length of  approx 2^{191}.
    /// The values of V, W, and Z are 2^{51}, 2^{76}, and 2^{127}, respectively.
    /// (See  @ref RandomStream for their definition.) The seed of the RNG, and
    /// the state of a stream at any given step, are six-dimensional vectors of
    /// unsigned 32-bit integers
    /// </summary>
    /// <remarks>
    /// Derived from SSJ project sources; see LICENSE file in this project root
    /// </remarks>
    public class Mrg32K3A : IPointSource<uint>, IPointSource<double>
    {
        const uint m1 = Mod1;

        const uint m2 = Mod2;

        const uint a12 = A12;

        const uint a13n = A13n;

        const uint a21 = A21;

        const uint a23n = A23n;
            
        static readonly Mat3u32 A1p76 = new uint[]
        {
            82758667, 1871391091, 4127413238,
            3672831523, 69195019, 1871391091,
            3672091415, 3528743235, 69195019
        };

        static readonly Mat3u32 A2p76 = new uint[] 
        {
             1511326704, 3759209742, 1610795712 ,
             4292754251, 1511326704, 3889917532 ,
             3859662829, 4292754251, 3708466080 
        };

        static readonly Mat3u32  A1p127 = new uint[] 
        {
            2427906178, 3580155704,  949770784,
            226153695, 1230515664, 3580155704,
            1988835001,  986791581, 1230515664 
        };

        static readonly Mat3u32 A2p127 = new uint[] 
        {
            1464411153,  277697599, 1610723613 ,
            32183930, 1464411153, 1022607788 ,
            2824425944,   32183930, 2093834863 
        };

        // Default seed of the package for the first stream
        //static Vec6u32 DefaultSeed = new uint[]{0xFA243, 0xAD941, 0xBC883, 0xDB193, 0xAA137, 0xB1B39};

        static void MVMul(in Vec6u32 v, in Mat3u32 A, uint m1, in Mat3u32 B, uint m2) 
        {
            Vector<N3,uint> vv = new uint[3];
            for(int i = 0; i < 3; i++)
                vv[i] = v[i];

            MatMod.MVMul(in A, in vv, m1, ref vv);
            for(int i = 0; i < 3; i++)
                v[i] = vv[i];

            for(int i = 0; i < 3; i++)
                vv[i] = v[i + 3];

            MatMod.MVMul(in B, in vv, m2, ref vv);
            for(int i = 0; i < 3; i++)
                v[i + 3] = vv[i];
        }

        Vec6i64 Cg;
        
        Vec6u32 Bg;
        
        Vec6u32 Ig;

        public RngKind RngKind 
            => RngKind.Mrg32K3Au;

        public Mrg32K3A(Vec6u32 seed) 
        {
            Ig = seed;
            Bg = Ig.Replicate();
            Cg = Vector.Alloc<N6,long>();
            Cg[0] = Bg[0];
            Cg[1] = Bg[1];
            Cg[2] = Bg[2];
            Cg[3] = Bg[3];
            Cg[4] = Bg[4];
            Cg[5] = Bg[5];            
            MVMul(seed, A1p127, m1, A2p127, m2);
        }

        void ResetStartStream()  
        {
            Bg = Ig.Replicate();

            ResetStartSubstream();
        }

        void ResetStartSubstream()  
        {        
            Cg[0] = Bg[0];
            Cg[1] = Bg[1];
            Cg[2] = Bg[2];
            Cg[3] = Bg[3];
            Cg[4] = Bg[4];
            Cg[5] = Bg[5];
        }

        void ResetNextSubstream()  
        {
            MVMul(Bg, A1p76, m1, A2p76, m2);
            ResetStartSubstream();
        }
        
        Vec6u32 State() 
            => Cg.Convert<uint>();

        public uint Next()
        {
            /* Component 1 */
            var p1 = (a12 * Cg[1] - a13n * Cg[0]) % m1;
            if (p1 < 0)
                p1 += m1;
            Cg[0] = Cg[1];
            Cg[1] = Cg[2];
            Cg[2] = p1;

            /* Component 2 */
            var p2 = (a21 * Cg[5] - a23n * Cg[3]) % m2;
            if (p2 < 0)
                p2 += m2;
            Cg[3] = Cg[4];
            Cg[4] = Cg[5];
            Cg[5] = p2;

            var next = (p1 > p2) ? (p1 - p2) : (p1 - p2 + m1);
            return (uint)next;
        }


        [MethodImpl(Inline)]
        public double NextF64()
            => Next()*Norm;
        
        double IPointSource<double>.Next()
            => NextF64();
 
    }

}