//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    public static partial class BitMatrixOps
    {   
        public static ref BitMatrix<N,T> Or<N,T>(this ref BitMatrix<N,T> lhs, in BitMatrix<N,T> rhs)        
            where N : ITypeNat, new()
            where T : struct
        {
            gbits.or(lhs.Bits, rhs.Bits, lhs.Bits);
            return ref lhs;
        }

        internal static string FormatMatrixBits(this Span<byte> src, int rowlen)            
        {
            var dst = gbits.bitchars(src);
            var sb = sbuild();
            for(var i=0; i<dst.Length; i+= rowlen)
            {
                var remaining = dst.Length - i;
                var segment = math.min(remaining, rowlen);
                var rowbits = dst.Slice(i, segment);
                var row = new string(rowbits.Intersperse(AsciSym.Space));                                
                sb.AppendLine(row);
            }
            return sb.ToString();
        }       

        /// <summary>
        /// Constructs a graph from an adjacency bitmatrix of natural dimension
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dim">The dimension of the matrix</param>
        /// <param name="v">An arbitrary value to help type inference</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="T">The source matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static Graph<V> ToGraph<V,N,T>(this BitMatrix<N,N,T> src, N dim = default, V v = default)
            where N : ITypeNat, new()
            where V : struct
            where T : struct
                => BitMatrix.ToGraph<V,N,T>(src);

        public static BitMatrix<M,N,T> Mul<M,N,K,T>(this BitMatrix<M,K,T> lhs, in BitMatrix<K,N,T> rhs)
            where M : ITypeNat, new()        
            where N : ITypeNat, new()
            where T : struct
            where K : ITypeNat, new()
        {
            var x = lhs;
            var y = rhs.Transpose();
            var dst = BitMatrix.Alloc<M,N,T>();

            for(var i=0; i< lhs.RowCount; i++)
            {
                var r = x.RowVector(i);
                for(var j = 0; j< y.ColCount; j++)
                {
                    var c = y.RowVector(j);
                    dst[i,j] = r % c;
                }
            }
            return dst;
        }

            
        public static ref BitMatrix<N8,N16,uint> Transpose(this ref BitMatrix<N8,N16,uint> A)
        {
            var vec = Vec128.Load(ref head(A.Bytes));
            vstore(dinx.shuffle(in vec, Tr8x16Mask), ref head(A.Bytes));
            return ref A;
        }


        static Vec128<byte> Tr8x16Mask
        {
            [MethodImpl(Inline)]
            get => Vec128.Load(ref As.asRef(in Tr8x16MaskBytes[0]));
        }

        /// <summary>
        ///  When used as a mask for _mm_shuffle_epi8, transposes a 8x16 bitmatrix
        /// </summary>
        static ReadOnlySpan<byte> Tr8x16MaskBytes => new byte[]
        {
            0, 4, 8, 12,
            1, 5, 9, 13,
            2, 6, 10, 14,
            3, 7, 11, 15

        };


        /// <summary>
        /// Part of a pattern to do cross-lane 256-bit shuffles
        /// </summary>
        /// <remarks> See https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector</remarks>
        static ReadOnlySpan<byte> Tr16x16A => new byte[]
        {
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 
            0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0        
        };

        static ReadOnlySpan<byte> Tr16x16B => new byte[]
        {
            0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 
            0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70        
        };

    }
}