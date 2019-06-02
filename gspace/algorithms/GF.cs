//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
// Thie this is a deriviative work based on
// GF-Complete: A Comprehensive Open Source Library for Galois Field Arithmetic
// James S. Plank, Ethan L. Miller, Kevin M. Greenan,
// Benjamin A. Arnold, John A. Burnum, Adam W. Disney, Allen C. McBride.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static zfunc;


    public static partial class GF
    {

        public static Span<uint> invert_binary_matrix(Span<uint> src, Span<uint> dst, int rows)
        {
            var cols = rows;
            var tmp = 0u;
            var i = 0;
            var j = 0;

            for (i = 0; i < rows; i++) 
                dst[i] = (1u << i);

            /* First -- convert into upper triangular */
            for (i = 0; i < cols; i++) 
            {

                /* Swap rows if we ave a zero i,i element.  If we can't swap, then the
                matrix was not invertible */

                if ((src[i] & (1 << i)) == 0) 
                {
                    for (j = i+1; j < rows && (src[j] & (1 << i)) == 0; j++) ;
                    if (j == rows) 
                        throw new Exception("galois_invert_matrix: Matrix not invertible!!\n");
                        
                    tmp = src[i]; 
                    src[i] = src[j]; 
                    src[j] = tmp;
                    
                    tmp = dst[i]; 
                    dst[i] = dst[j]; 
                    dst[j] = tmp;
                }

                /* Now for each j>i, add A_ji*Ai to Aj */
                for (j = i+1; j != rows; j++) 
                {
                    if ((src[j] & (1 << i)) != 0) 
                    {
                        src[j] ^= src[i];
                        dst[j] ^= dst[i];
                    }
                }

                /* Now the matrix is upper triangular.  Start at the top and multiply down */

                for (i = rows-1; i >= 0; i--) 
                for (j = 0; j < i; j++) 
                    if ( (src[j] & (1u << i)) != 0) 
                        dst[j] ^= dst[i];
            }            

            return dst;
        }
        
        public static uint gf_bitmatrix_inverse(uint y, int w, uint pp) 
        {
            //uint32_t mat[32], inv[32], mask;
            int i;
            var mat = span<uint>(32);
            var inv = span<uint>(32);
            var mask = 0u;

            mask = (w == 32) ? 0xffffffff : (1u << w) - 1;

            for (i = 0; i < w; i++) 
            {
                mat[i] = y;

                if ((y & (1 << (w-1))) !=0) 
                {
                    y = y << 1;
                    y = ((y ^ pp) & mask);
                } 
                else 
                    y = y << 1;
            }

            invert_binary_matrix(mat, inv, w);
            return inv[0];
        }

        
    }

 

}