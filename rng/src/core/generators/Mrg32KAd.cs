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
    using Vec6f64 = Vector<N6,double>;
    using Mat3f64 = Matrix<N3,double>;

    /// <summary>
    /// Implements L’Ecuyer's combined multiple recursive generator (CMRG) with 64-bit floating-point arithmetic.
    /// This generator has a period length of  approx 2^{191}.
    /// The values of V, W, and Z are 2^{51}, 2^{76}, and 2^{127}, respectively.
    /// (See  @ref RandomStream for their definition.) The seed of the RNG, and
    /// the state of a stream at any given step, are six-dimensional vectors of
    /// 32-bit integers, stored in `double`. The default initial seed of the RNG
    /// is (12345, 12345, 12345, 12345, 12345, 12345).
    /// </summary>
    /// <remarks>
    /// Derived from SSJ project sources; see LICENSE file in this project root
    /// </remarks>
    public class Mrg32K3Ad : IPointSource<double>
    {
        const double m1 = Mod1;

        const double m2 = Mod2;

        const double a12 = A12;

        const double a13n = A13n;

        const double a21 = A21;

        const double a23n = A23n;


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
        static Vec6f64 nextSeed = new double[]{12345, 12345, 12345, 12345, 12345, 12345};

        double Cg0, Cg1, Cg2, Cg3, Cg4, Cg5;

        double[] Bg = new double[6];

        double[] Ig = new double[6];

        /// <summary>
        /// Computes the vector v = As (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="s">The vector to be transformed</param>
        /// <param name="v">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static void matVecModM (double[,] A, double[] s, double[] v, double m) 
        {
            var x = new double[v.Length];
            for (var i = 0; i < v.Length;  ++i) 
            {
                for(var j = 0; j < s.Length; j++)
                    x[i] = Mod.fma(A[i,j], s[j], x[i], m);
            }

            for (var i = 0; i < v.Length;  ++i)
                v[i] = x[i];
        }

        // The arrays Cg, Bg and Ig contain the current state,
        // the starting point of the current substream,
        // and the starting point of the stream, respectively.

        //multiply the first half of v by A with a modulo of m1
        //and the second half by B with a modulo of m2
        static void multMatVect(Vec6f64 v, double[,] A, double m1, double[,] B, double m2) 
        {
            var vv = new double[3];
            for(int i = 0; i < 3; i++)
                vv[i] = v[i];

            matVecModM(A, vv, vv, m1);
            for(int i = 0; i < 3; i++)
                v[i] = vv[i];

            for(int i = 0; i < 3; i++)
                vv[i] = v[i + 3];

            matVecModM(B, vv, vv, m2);
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
        public static void setPackageSeed (Vec6u32 seed) 
        {
            // Must use long because there is no unsigned int type.
            CheckSeed (seed);
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
        public Mrg32K3Ad() 
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

        public void SetSeed (Vec6u32 seed) 
        {
            CheckSeed (seed);
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
        public Vec6u32 State() 
        {
            return new uint[] 
            {   (uint)Cg0, (uint)Cg1, (uint)Cg2,
                (uint)Cg3, (uint)Cg4, (uint)Cg5
            };
        }

        public RngKind RngKind 
            => RngKind.MRG32K3Ad;


        /// <summary>
        /// Calls `nextDouble` once to create one integer between `i` and `j`.
        /// This method always uses the highest order bits of the random number.
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public int Next(int min, int max) 
        {
            // This works even for an interval [0, 2^31 - 1]. 
            // return i + (int)(nextDouble() * (j - i + 1));
            return min + (int)(Next() * (max - min));
        }


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


}