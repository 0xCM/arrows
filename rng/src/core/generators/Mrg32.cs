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
    using static MRG32k;

    using Mrg32kSeed = BlockVector<N6,uint>;

    static class MRG32k
    {
        public static readonly double Norm   = 2.328306549295727688e-10;

        public static void validateSeed (uint[] seed) 
        {
            if (seed.Length < 6)
                throw new ArgumentException("Seed must contain 6 values");
        
            if (seed[0] == 0 && seed[1] == 0 && seed[2] == 0)
                throw new ArgumentException("The first 3 values must not be 0");
        
            if (seed[3] == 0 && seed[4] == 0 && seed[5] == 0)
                throw new ArgumentException("The last 3 values must not be 0");
        
            const long m1 = 4294967087L;
        
            if (seed[0] >= m1 || seed[1] >= m1 || seed[2] >= m1)
                throw new ArgumentException("The first 3 values must be less than " + m1);
        
            const long m2 = 4294944443L;
            if (seed[3] >= m2 || seed[4] >= m2 || seed[5] >= m2)
                throw new ArgumentException("The last 3 values must be less than " + m2);
        }

    }

    /// <summary>
    /// Implements the combined multiple recursive generator (CMRG)
    /// MRG32k3a proposed by L’Ecuyer, with 64-bit floating-point arithmetic.
    /// This generator has a period length of  approx 2^{191}.
    /// The values of V, W, and Z are 2^{51}, 2^{76}, and 2^{127}, respectively.
    /// (See  @ref RandomStream for their definition.) The seed of the RNG, and
    /// the state of a stream at any given step, are six-dimensional vectors of
    /// 32-bit integers, stored in `double`. The default initial seed of the RNG
    /// is (12345, 12345, 12345, 12345, 12345, 12345).
    /// </summary>
    /// <remarks>
    /// Derived from SSJ project sources in accordance with license; see LICENSE file in this project root
    /// </remarks>
    public class MRG32k3aD : IPointSource<double>
    {
        static readonly double m1     = 4294967087.0;

        static readonly double m2     = 4294944443.0;

        static readonly double a12    =  1403580.0;

        static readonly double a13n   =   810728.0;

        static readonly double a21    =   527612.0;

        static readonly double a23n   =  1370589.0;


        static readonly double[,] A1p76 = 
        {
            { 82758667.0, 1871391091.0, 4127413238.0 },
            { 3672831523.0,   69195019.0, 1871391091.0 },
            { 3672091415.0, 3528743235.0,   69195019.0 }
        };

        static readonly double[,] A2p76 = 
        {
            { 1511326704.0, 3759209742.0, 1610795712.0 },
            { 4292754251.0, 1511326704.0, 3889917532.0 },
            { 3859662829.0, 4292754251.0, 3708466080.0 }
        };

        static readonly double[,] A1p127 = 
        {
            {    2427906178.0, 3580155704.0,  949770784.0 },
            {     226153695.0, 1230515664.0, 3580155704.0 },
            {    1988835001.0,  986791581.0, 1230515664.0 }
        };
        static readonly double[,] A2p127 = 
        {
            {    1464411153.0,  277697599.0, 1610723613.0 },
            {      32183930.0, 1464411153.0, 1022607788.0 },
            {    2824425944.0,   32183930.0, 2093834863.0 }
        };

        // Default seed of the package for the first stream
        static double[] nextSeed = {12345, 12345, 12345, 12345, 12345, 12345};

        double Cg0, Cg1, Cg2, Cg3, Cg4, Cg5;

        double[] Bg = new double[6];

        double[] Ig = new double[6];

        // The arrays Cg, Bg and Ig contain the current state,
        // the starting point of the current substream,
        // and the starting point of the stream, respectively.

        //multiply the first half of v by A with a modulo of m1
        //and the second half by B with a modulo of m2
        static void multMatVect(double[] v, double[,] A, double m1, double[,] B, double m2) 
        {
            var vv = new double[3];
            for(int i = 0; i < 3; i++)
                vv[i] = v[i];

            SSJ.matVecModM(A, vv, vv, m1);
            for(int i = 0; i < 3; i++)
                v[i] = vv[i];

            for(int i = 0; i < 3; i++)
                vv[i] = v[i + 3];

            SSJ.matVecModM(B, vv, vv, m2);
            for(int i = 0; i < 3; i++)
                v[i + 3] = vv[i];
        }

        /// <summary>
        /// Sets the initial seed to the six integers in the vector `seed[0..5]`. 
        /// This will be the seed (initial state) of the first stream. If this method is not called, 
        /// the default initial seed is (12345, 12345, 12345, 12345, 12345, 12345)
        /// If it is called, the first 3 values of the seed must all be less than 
        /// m_1 = 4294967087, and not all 0; and the last 3 values must all be less than 
        /// m_2 = 4294944443 and not all 0. 
        /// </summary>
        /// <param name="seed"></param>
        public static void setPackageSeed (uint[] seed) 
        {
            // Must use long because there is no unsigned int type.
            validateSeed (seed);
            for (int i = 0; i < 6;  ++i)
                nextSeed[i] = seed[i];
        }


        public string Name {get;}

        public bool Anti {get;}

        public bool Prec53 {get;}

        /**
            * Constructs a new stream, initializes its seed I_g, sets
            * B_g and C_g equal to I_g, and sets its antithetic
            * switch to `false`. The seed I_g is equal to the initial seed
            * of the package given by  #setPackageSeed(long[]) if this is the
            * first stream created, otherwise it is Z steps ahead of that of
            * the stream most recently created in this class.
            */
        public MRG32k3aD() 
        {
            Name = null;
            Anti = false;
            Prec53 = false;
            for(int i = 0; i < 6; i++)
                Ig[i] = nextSeed[i];
        
                ResetStartStream();
        
            multMatVect(nextSeed, A1p127, m1, A2p127, m2);
        }

        /**
            * Sets the initial seed I_g of this stream to the vector
            * `seed[0..5]`. This vector must satisfy the same conditions as in
            * `setPackageSeed`. The stream is then reset to this initial seed. The
            * states and seeds of the other streams are not modified. As a result,
            * after calling this method, the initial seeds of the streams are no
            * longer spaced Z values apart. For this reason, *this method
            * should be used only in very exceptional situations* (I have never
            * used it myself!); proper use of `reset...` and of the stream
            * constructor is preferable.
            *  @param seed         array of 6 integers representing the new seed
            */

        public void SetSeed (uint[] seed) 
        {
            // Must use long because there is no unsigned int type.
            validateSeed (seed);
            for (int i = 0; i < 6;  ++i)
                Ig[i] = seed[i];
            ResetStartStream();
        }

        public void ResetStartStream()  
        {
            for (int i = 0; i < 6;  ++i)
                Bg[i] = Ig[i];
            ResetStartSubstream();
        }

        public void ResetStartSubstream()  
        {
            Cg0 = Bg[0];
            Cg1 = Bg[1];
            Cg2 = Bg[2];
            Cg3 = Bg[3];
            Cg4 = Bg[4];
            Cg5 = Bg[5];
        }

        /**
        * Returns the current state C_g of this stream. This is a vector of 6
        * integers. This method is convenient if we want to save the state for
        * subsequent use.
        *  @return the current state of the generator
        */
        public uint[] State() 
        {
            return new uint[] 
            {   (uint)Cg0, (uint)Cg1, (uint)Cg2,
                (uint)Cg3, (uint)Cg4, (uint)Cg5
            };
        }

        public RngKind RngKind 
            => RngKind.MRG32k3aD;

        public double Next() 
        {
            int k;
            double p1, p2;

            /* Component 1 */
            p1 = a12 * Cg1 - a13n * Cg0;
            k = (int)(p1 / m1);
            p1 -= k * m1;
            if (p1 < 0.0)
                p1 += m1;
            Cg0 = Cg1;
            Cg1 = Cg2;
            Cg2 = p1;

            /* Component 2 */
            p2 = a21 * Cg5 - a23n * Cg3;
            k  = (int)(p2 / m2);
            p2 -= k * m2;
            if (p2 < 0.0)
                p2 += m2;
            Cg3 = Cg4;
            Cg4 = Cg5;
            Cg5 = p2;

            /* Combination */
            return ((p1 > p2) ? (p1 - p2) * Norm : (p1 - p2 + m1) * Norm);
        }

    }


    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Derived from SSJ project sources in accordance with license; see LICENSE file in this project root
    /// </remarks>
    public class MRG32k3a : IPointSource<uint>, IPointSource<double>
    {
        static readonly uint   m1     = 4294967087;

        static readonly uint   m2     = 4294944443;

        static readonly uint   a12    =  1403580;

        static readonly uint   a13n   =   810728;

        static readonly uint   a21    =   527612;

        static readonly uint   a23n   =  1370589;

            
        static readonly uint[,] A1p76 = 
        {
            { 82758667, 1871391091, 4127413238},
            { 3672831523, 69195019, 1871391091},
            { 3672091415, 3528743235, 69195019 }
        };
        
        private static readonly uint[,] A2p76 = 
        {
            { 1511326704, 3759209742, 1610795712 },
            { 4292754251, 1511326704, 3889917532 },
            { 3859662829, 4292754251, 3708466080 }
        };

        private static readonly uint[,] A1p127 = 
        {
            {2427906178, 3580155704,  949770784 },
            {226153695, 1230515664, 3580155704 },
            {1988835001,  986791581, 1230515664 }
        };

        private static readonly uint[,] A2p127 = 
        {
            {1464411153,  277697599, 1610723613 },
            {32183930, 1464411153, 1022607788 },
            {2824425944,   32183930, 2093834863 }
        };

        // Default seed of the package for the first stream
        static uint[] NextSeed = new uint[]{0xFA243, 0xAD941, 0xBC883, 0xDB193, 0xAA137, 0xB1B39};
        
        long Cg0, Cg1, Cg2, Cg3, Cg4, Cg5;
        
        uint[] Bg = new uint[6];
        
        uint[] Ig = new uint[6];

        // The arrays Cg, Bg and Ig contain the current state,
        // the starting point of the current substream,
        // and the starting point of the stream, respectively.

        //multiply the first half of v by A with a modulo of m1
        //and the second half by B with a modulo of m2
        static void mvmul(uint[] v, uint[,] A, uint m1, uint[,] B, uint m2) 
        {
            uint[] vv = new uint[3];
            for(int i = 0; i < 3; i++)
                vv[i] = v[i];
            SSJ.matVecModM(A, vv, vv, m1);
            for(int i = 0; i < 3; i++)
                v[i] = vv[i];

            for(int i = 0; i < 3; i++)
                vv[i] = v[i + 3];

            SSJ.matVecModM(B, vv, vv, m2);
            for(int i = 0; i < 3; i++)
                v[i + 3] = vv[i];
        }

        public string Name {get;}

        public bool anti {get;}

        public bool prec53 {get;}

        public RngKind RngKind 
            => RngKind.MRG32k3a;

        public MRG32k3a() 
        {
            Name = null;
            anti = false;
            prec53 = false;
            for(int i = 0; i < 6; i++)
                Ig[i] = NextSeed[i];
            ResetStartStream();
            mvmul(NextSeed, A1p127, m1, A2p127, m2);
        }

        public MRG32k3a (String name) 
            : this()
        {
            this.Name = name;
        }

        public static void SetPackageSeed (uint[] seed) 
        {
            // Must use uint because there is no unsigned int type.
            validateSeed (seed);
            for (int i = 0; i < 6;  ++i)
                NextSeed[i] = seed[i];
        }

        public void SetSeed (uint[] seed) 
        {
            // Must use uint because there is no unsigned int type.
            validateSeed (seed);
            for (int i = 0; i < 6;  ++i)
                Ig[i] = seed[i];
            ResetStartStream();
        }

        public void ResetStartStream()  
        {
            for (int i = 0; i < 6;  ++i)
                Bg[i] = Ig[i];
            ResetStartSubstream();
        }

        public void ResetStartSubstream()  
        {
            Cg0 = Bg[0];
            Cg1 = Bg[1];
            Cg2 = Bg[2];
            Cg3 = Bg[3];
            Cg4 = Bg[4];
            Cg5 = Bg[5];
        }

        public void ResetNextSubstream()  
        {
            mvmul(Bg, A1p76, m1, A2p76, m2);
            ResetStartSubstream();
        }
        
        public uint[] State() 
        {
            return new uint[]{(uint)Cg0, (uint)Cg1, (uint)Cg2, (uint)Cg3, (uint)Cg4, (uint)Cg5};
        }

        public uint Next()
        {

            /* Component 1 */
            var p1 = (a12 * Cg1 - a13n * Cg0) % m1;
            if (p1 < 0)
                p1 += m1;
            Cg0 = Cg1;
            Cg1 = Cg2;
            Cg2 = p1;

            /* Component 2 */
            var p2 = (a21 * Cg5 - a23n * Cg3) % m2;
            if (p2 < 0)
                p2 += m2;
            Cg3 = Cg4;
            Cg4 = Cg5;
            Cg5 = p2;

            var next = (p1 > p2) ? (p1 - p2) : (p1 - p2 + m1);
            return (uint)next;
        }

        double IPointSource<double>.Next()
            => Next()*Norm;
 
    }

}