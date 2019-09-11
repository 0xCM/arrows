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

    /// <summary>
    /// SSJ algorithms
    /// </summary>
    /// <remarks>
    /// Algorithms taken from SSJ in accordance with the project license; 
    /// see LICENSE file in this project root
    /// </remarks>
    public static partial class SSJ
    {
        const double two17    =  131072.0;
        
        const double two53    =  9007199254740992.0;

        /// <summary>
        /// Computes the number of different combinations of s objects out
        /// of a total number of objects n
        /// </summary>
        /// <param name="n">The total number of objects</param>
        /// <param name="s">The selection size</param>
        public static double comb(int n, int s) 
        {
            const int NLIM = 100;            
            int i;

            if (s == 0 || s == n)
                return 1;
            if (s < 0) 
            {
                error ("combination: s < 0");
                return 0;
            }
            if (s > n) 
            {
                error("combination: s > n");
                return 0;
            }
            if (s > (n/2))
                s = n - s;

            if (n <= NLIM) 
            {
                var Res = 1.0;
                int Diff = n - s;
                for (i = 1; i <= s; i++) {
                Res *= (double)(Diff + i)/(double)i;
                }
                return Res;
            }
            else 
                return fmath.exp(lnfac (n) - lnfac(s) - lnfac(n - s));
        }


        /// <summary>
        /// Computes the natural log of n!
        /// </summary>
        /// <param name="n">A number n such that x = n! for some x</param>
        public static double lnfac (long n) 
        {
            const int NLIM = 14;

            if (n < 0)
                throw new ArgumentException ("lnFactorial: n < 0");

            if (n == 0 || n == 1)
                return 0.0;

            if (n <= NLIM) 
            {
                long z = 1;
                long x = 1;
                for (int i = 2; i <= n; i++) 
                {
                    ++x;
                    z *= x;
                }
                
                return fmath.ln (z);
            }
            else 
            {
                var x = (double)(n + 1);
                var y = 1.0/(x*x);
                var z = ((-(5.95238095238E-4*y) + 7.936500793651E-4)*y - 2.7777777777778E-3)*y + 8.3333333333333E-2;
                z = ((x - 0.5)*fmath.ln (x) - x) + 9.1893853320467E-1 + z/x;
                return z;
            }
        }


        /// <summary>
        /// Computes (a*s + c) % m, an integer in the range [0, m-1]
        /// </summary>
        /// <param name="a"></param>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <param name="m"></param>
        [MethodImpl(Inline)]
        public static int multModM (int a, int s, int c, int m) 
        {
            int r = (int) (((long)a * s + c) % m);
            return r < 0 ? r + m : r;
        }

        /// <summary>
        /// Computes the vector v = As (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="s">The vector to be transformed</param>
        /// <param name="v">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static void matVecModM (int[,] A, int[] s, int[] v, int m) 
        {
            int i;
            var x = new int[v.Length];
            for (i = 0; i < v.Length;  ++i) 
            {
                x[i] = 0;
                for(int j = 0; j < s.Length; j++)
                    x[i] = multModM(A[i,j], s[j], x[i], m);
            }
            
            for (i = 0; i < v.Length;  ++i)
                v[i] = x[i];

        }

        /// <summary>
        /// Computes the matrix product C = AB (mod m)
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The result matrix</param>
        /// <param name="m">The modulus</param>
        public static void matMatModM (int[,] A, int[,] B, int[,] C, int m) 
        {
            int i, j;
            int r = C.Length; //# of rows of C
            int c = B.Length; //# of columns of C and rows of B
            var V = new int[r];
            var W = new int[r,c];
            for (i = 0; i < c;  ++i) 
            {
                for (j = 0; j < r;  ++j)
                    V[j] = B[j,i];
                
                matVecModM (A, V, V, m);

                for (j = 0; j < r;  ++j)
                    W[j,i] = V[j];
            }
            
            for (i = 0; i < r;  ++i) 
            {
                for (j = 0; j < c;  ++j)
                    C[i,j] = W[i,j];
            }
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="e">The log2 of the exponent</param>
        public static void matTwoPowModM (int[,] A, int[,] B, int m, int e) 
        {
            int i, j;
            
            /* initialize: B = A */
            if (A != B) 
            {
                for (i = 0; i < A.Length; i++) 
                {
                    for (j = 0; j < A.Length;  ++j)  //A is square
                        B[i,j] = A[i,j];
                }
            }
            
            /* Compute B = A^{2^e} */
            for (i = 0; i < e; i++)
                matMatModM (B, B, B, m);
        }

        /// <summary>
        /// Computes B = A^c (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="c">The exponent</param>
        public static void matPowModM (int[,] A, int[,] B, int m, int c) 
        {
            int i, j;
            int n = c;
            int s = A.Length;   //we suppose that A is square (it must be)
            var W = new int[s,s];

            /* initialize: W = A; B = I */
            for (i = 0; i < s; i++) 
            {
                for (j = 0; j < s;  ++j)  
                {
                    W[i,j] = A[i,j];
                    B[i,j] = 0;
                }
            }
            
            for (j = 0; j < s;  ++j)
                B[j,j] = 1;

            /* Compute B = A^c mod m using the binary decomp. of c */
            while (n > 0) 
            {
                if ((n % 2)==1)
                    matMatModM (W, B, B, m);
                
                matMatModM (W, W, W, m);
                n /= 2;
            }
        }

        public static uint multModM (uint a, uint s, uint c, uint m) 
        {
            const uint H = 2147483648u; // = 2^d used in MultMod              
            uint a0, a1, q, qh, rh, k, p;
            if (a < H) 
            {
                a0 = a;
                p = 0;
            } 
            else 
            {
                a1 = a / H;
                a0 = a - H * a1;
                qh = m / H;
                rh = m - H * qh;
                if (a1 >= H) 
                {
                    a1 = a1 - H;
                    k = s / qh;
                    p = H * (s - k * qh) - k * rh;
                    if (p < 0)
                        p = (p + 1) % m + m - 1;
                } 
                else // p = (A2 * s * h) % m.   
                    p = 0;

                if (a1 != 0) 
                {
                    q = m / a1;
                    k = s / q;
                    p -= k * (m - a1 * q);
                    if (p > 0)
                        p -= m;
                    p += a1 * (s - k * q);
                    if (p < 0)
                        p = (p + 1) % m + m - 1;
                }   
                                        // p = ((A2 * h + a1) * s) % m.
                k = p / qh;
                p = H * (p - k * qh) - k * rh;
                if (p < 0)
                p = (p + 1) % m + m - 1;
            } // p = ((A2 * h + a1) * h * s) % m
            
            if (a0 != 0) 
            {
                q = m / a0;
                k = s / q;
                p -= k * (m - a0 * q);
                if (p > 0)
                p -= m;
                p += a0 * (s - k * q);
                if (p < 0)
                p = (p + 1) % m + m - 1;
            }

            p = (p - m) + c;
            if (p < 0)
                p += m;
            return p;
        }

        /// <summary>
        /// Computes the vector v = As (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="s">The vector to be transformed</param>
        /// <param name="v">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static void matVecModM (uint[,] A, uint[] s, uint[] v, uint m) 
        {
            var x = new uint[v.Length];
            for (var i = 0; i < v.Length;  ++i) 
            {
                x[i] = 0;
                for(int j = 0; j < s.Length; j++)
                    x[i] = multModM(A[i,j], s[j], x[i], m);
            }

            for (var i = 0; i < v.Length;  ++i)
                v[i] = x[i];
        }

        public static void matMatModM (uint[,] A, uint[,] B, uint[,] C, uint m) 
        {
            var r = C.Length;    //# of rows of C
            var c = B.Length; //# of columns of C and rows of B
            var V = new uint[r];
            var W = new uint[r,c];

            for (var i = 0; i < c;  ++i) 
            {
                for (var j = 0; j < r;  ++j)
                V[j] = B[j,i];
                
                matVecModM (A, V, V, m);
                
                for (var j = 0; j < r;  ++j)
                W[j,i] = V[j];
            }

            for (var i = 0; i < r;  ++i) 
            for (var j = 0; j < c;  ++j)
                C[i,j] = W[i,j];
        }

        /// <summary>
        /// Computes B = A^c (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="c">The exponent</param>
        public static void matPowModM (uint[,] A, uint[,] B, uint m, uint c) 
        {
            int i, j;
            uint n = c;
            var s = A.Length;   //we suppose that A is square (it must be)
            var W = new uint[s,s];

            /* initialize: W = A; B = I */
            for (i = 0; i < s; i++) {
                for (j = 0; j < s;  ++j)  
                {
                    W[i,j] = A[i,j];
                    B[i,j] = 0;
                }
            }

            for (j = 0; j < s;  ++j)
                B[j,j] = 1;

            /* Compute B = A^c mod m using the binary decomp. of c */
            while (n > 0) 
            {
                if ((n % 2)==1)
                    matMatModM (W, B, B, m);
            
                matMatModM (W, W, W, m);
                n /= 2;
            }
        }

        /// <summary>
        /// Computes B = A^c (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="c">The exponent</param>
        public static void matPowModM (uint[,] A, uint[,] B, uint m, int c) 
        {
            int i, j;
            int n = c;
            int s = A.Length;   //we suppose that A is square (it must be)
            var W = new uint[s,s];

            /* initialize: W = A; B = I */
            for (i = 0; i < s; i++) {
                for (j = 0; j < s;  ++j)  
                {
                    W[i,j] = A[i,j];
                    B[i,j] = 0;
                }
            }

            for (j = 0; j < s;  ++j)
                B[j,j] = 1;

            /* Compute B = A^c mod m using the binary decomp. of c */
            while (n > 0) 
            {
                if ((n % 2)==1)
                    matMatModM (W, B, B, m);
            
                matMatModM (W, W, W, m);
                n /= 2;
            }
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="e">The log2 of the exponent</param>
        public static void matTwoPowModM (uint[,] A, uint[,] B, uint m, uint e) 
        {
            int i, j;
            
            /* initialize: B = A */
            if (A != B) 
            {
                for (i = 0; i < A.Length; i++) 
                {
                for (j = 0; j < A.Length;  ++j)  //A is square
                    B[i,j] = A[i,j];
                }
            }
            
            /* Compute B = A^{2^e} */
            for (i = 0; i < e; i++)
                matMatModM (B, B, B, m);
        }

        /// <summary>
        /// Computes (a*s + c) % m, an integer in the range [0, m-1]
        /// </summary>
        /// <param name="a"></param>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <param name="m">The modulus</param>
        public static long multModM (long a, long s, long c, long m) 
        {
            const long H = 2147483648L; // = 2^d used in MultMod              
            long a0, a1, q, qh, rh, k, p;
            if (a < H) 
            {
                a0 = a;
                p = 0;
            } 
            else 
            {
                a1 = a / H;
                a0 = a - H * a1;
                qh = m / H;
                rh = m - H * qh;
                if (a1 >= H) 
                {
                    a1 = a1 - H;
                    k = s / qh;
                    p = H * (s - k * qh) - k * rh;
                    if (p < 0)
                        p = (p + 1) % m + m - 1;
                } 
                else // p = (A2 * s * h) % m.   
                    p = 0;

                if (a1 != 0) 
                {
                    q = m / a1;
                    k = s / q;
                    p -= k * (m - a1 * q);
                    if (p > 0)
                        p -= m;
                    p += a1 * (s - k * q);
                    if (p < 0)
                        p = (p + 1) % m + m - 1;
                }   
                                        // p = ((A2 * h + a1) * s) % m.
                k = p / qh;
                p = H * (p - k * qh) - k * rh;
                if (p < 0)
                p = (p + 1) % m + m - 1;
            } // p = ((A2 * h + a1) * h * s) % m
            
            if (a0 != 0) 
            {
                q = m / a0;
                k = s / q;
                p -= k * (m - a0 * q);
                if (p > 0)
                p -= m;
                p += a0 * (s - k * q);
                if (p < 0)
                p = (p + 1) % m + m - 1;
            }

            p = (p - m) + c;
            if (p < 0)
                p += m;
            return p;
        }


        /// <summary>
        /// Computes the vector v = As (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="s">The vector to be transformed</param>
        /// <param name="v">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static void matVecModM (long[,] A, long[] s, long[] v, long m) 
        {
            var x = new long[v.Length];
            for (var i = 0; i < v.Length;  ++i) 
            {
                x[i] = 0;
                for(int j = 0; j < s.Length; j++)
                    x[i] = multModM(A[i,j], s[j], x[i], m);
            }

            for (var i = 0; i < v.Length;  ++i)
                v[i] = x[i];
        }

        public static void matMatModM (long[,] A, long[,] B, long[,] C, long m) 
        {
            var r = C.Length;    //# of rows of C
            var c = B.Length; //# of columns of C and rows of B
            var V = new long[r];
            var W = new long[r,c];

            for (var i = 0; i < c;  ++i) 
            {
                for (var j = 0; j < r;  ++j)
                V[j] = B[j,i];
                
                matVecModM (A, V, V, m);
                
                for (var j = 0; j < r;  ++j)
                W[j,i] = V[j];
            }

            for (var i = 0; i < r;  ++i) 
            for (var j = 0; j < c;  ++j)
                C[i,j] = W[i,j];
        }

        /// <summary>
        /// Computes B = A^c (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="c">The exponent</param>
        public static void matPowModM (long[,] A, long[,] B, long m, int c) 
        {
            int i, j;
            int n = c;
            int s = A.Length;   //we suppose that A is square (it must be)
            var W = new long[s,s];

            /* initialize: W = A; B = I */
            for (i = 0; i < s; i++) {
                for (j = 0; j < s;  ++j)  
                {
                    W[i,j] = A[i,j];
                    B[i,j] = 0;
                }
            }

            for (j = 0; j < s;  ++j)
                B[j,j] = 1;

            /* Compute B = A^c mod m using the binary decomp. of c */
            while (n > 0) 
            {
                if ((n % 2)==1)
                    matMatModM (W, B, B, m);
            
                matMatModM (W, W, W, m);
                n /= 2;
            }
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="e">The log2 of the exponent</param>
        public static void matTwoPowModM (long[,] A, long[,] B, long m, int e) 
        {
            int i, j;
            
            /* initialize: B = A */
            if (A != B) 
            {
                for (i = 0; i < A.Length; i++) 
                {
                for (j = 0; j < A.Length;  ++j)  //A is square
                    B[i,j] = A[i,j];
                }
            }
            
            /* Compute B = A^{2^e} */
            for (i = 0; i < e; i++)
                matMatModM (B, B, B, m);
        }

        /// <summary>
        /// Computes (a*s + c) % m, an integer in the range [0, m-1]
        /// </summary>
        /// <param name="a"></param>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <param name="m"></param>
        public static double multModM (double a, double s, double c, double m) 
        {
            int a1;
            double v = a * s + c;
            if (v >= two53 || v <= -two53 ) 
            {
                a1 = (int)(a / two17);
                a -= a1 * two17;
                v  = a1 * s;
                a1 = (int)(v / m);
                v -= a1 * m;
                v  = v * two17 + a * s + c;
            }
            a1 = (int)(v / m);
            
            if ((v -= a1 * m) < 0.0)
                return v += m;
            else
                return v;
        }

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
                x[i] = 0.0;
                for(var j = 0; j < s.Length; j++)
                    x[i] = multModM (A[i,j], s[j], x[i], m);
            }

            for (var i = 0; i < v.Length;  ++i)
                v[i] = x[i];
        }

   

        /// <summary>
        /// Computes the matrix product C = AB (mod m)
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The result matrix</param>
        /// <param name="m">The modulus</param>
        public static void matMatModM (double[,] A, double[,] B, double[,] C, double m) 
        {
            int r = C.Length;    //# of rows of C
            int c = B.Length; //# of columns of C
            var V = new double[r];
            var W = new double[r,c];
            for (var i = 0; i < c;  ++i) 
            {
                for (var j = 0; j < r;  ++j)
                    V[j] = B[j,i];

                matVecModM (A, V, V, m);
            
                for (var j = 0; j < r;  ++j)
                    W[j,i] = V[j];
            }

            for (var i = 0; i < r;  ++i) 
            for (var j = 0; j < c;  ++j)
                C[i,j] = W[i,j];            
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="e">The log2 of the exponent</param>
        public static void matTwoPowModM (double[,] A, double[,] B, double m, int e) 
        {
            int i, j;
            /* initialize: B = A */
            if (A != B) 
            {
                for (i = 0; i < A.Length; i++) {
                    for (j = 0; j < A.Length;  ++j)  //A is square
                    B[i,j] = A[i,j];
                }
            }
            /* Compute B = A^{2^e} */
            for (i = 0; i < e; i++)
                matMatModM (B, B, B, m);
        }

        /// <summary>
        /// Computes B = A^c (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The result matrix</param>
        /// <param name="m">The modulus</param>
        /// <param name="c">The exponent</param>
        public static void matPowModM (double[,] A, double[,] B, double m, int c) 
        {
            int i, j;
            int n = c;
            int s = A.Length;   //we suppose that A is square
            var W = new double[s,s];

            /* initialize: W = A; B = I */
            for (i = 0; i < s; i++) 
            {
                for (j = 0; j < s;  ++j)  
                {
                    W[i,j] = A[i,j];
                    B[i,j] = 0.0;
                }
            }

            for (j = 0; j < s;  ++j)
                B[j,j] = 1.0;

            /* Compute B = A^c mod m using the binary decomp. of c */
            while (n > 0) 
            {
                if ((n % 2)==1)
                    matMatModM (W, B, B, m);
            
                matMatModM (W, W, W, m);
                n /= 2;
            }
        }

    }


}