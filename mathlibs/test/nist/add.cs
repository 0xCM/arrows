namespace Z0
{
    using System;


    public static partial class NIST
    {
        /// <summary>
        /// Computes A = A + B
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static byte add(Span<byte> A, Span<byte> B)
        {
            int		i, indexA, indexB;
            byte	accum;
            var LA = A.Length;
            var LB = B.Length;

            indexA = LA - 1; 	/* LSD of result */
            indexB = LB - 1; 	/* LSD of B */

            accum = 0;
            for ( i = 0; i < LB; i++ ) 
            {
                accum += A[indexA];
                accum += B[indexB--];
                A[indexA--] = (byte)(accum & 0xff);
                accum >>= 8;
            }

            if ( LA > LB )
                while ((accum != 0)  && (indexA >= 0)) 
                {
                    accum += A[indexA];
                    A[indexA--] = (byte)(accum & 0xff);
                    accum >>= 8;
                }

            return accum;        }

    }
}