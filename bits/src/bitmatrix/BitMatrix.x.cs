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
        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static BitMatrix8 ToBitMatrix(this Perm<N8> src)
        {
            var dst = BitMatrix8.Alloc();
            for(var row = 0; row<src.Length; row++)
                dst[row,src[row]] = Bit.On;
            return dst;
        }

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static BitMatrix16 ToBitMatrix(this Perm<N16> src)
        {
            var dst = BitMatrix16.Alloc();
            for(var row = 0; row<src.Length; row++)
                dst[row,src[row]] = Bit.On;
            return dst;
        }

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static BitMatrix32 ToBitMatrix(this Perm<N32> src)
        {
            var dst = BitMatrix32.Alloc();
            for(var row = 0; row<src.Length; row++)
                dst[row,src[row]] = Bit.On;
            return dst;
        }

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static BitMatrix64 ToBitMatrix(this Perm<N64> src)
        {
            var dst = BitMatrix64.Alloc();
            for(var row = 0; row<src.Length; row++)
                dst[row,src[row]] = Bit.On;
            return dst;
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

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this byte[] src, int rowlen)            
            => src.AsSpan().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this Span<ushort> src, int rowlen)            
            => src.AsBytes().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this Span<uint> src, int rowlen)            
            => src.AsBytes().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this uint[] src, int rowlen)            
            => src.AsSpan().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this Span<ulong> src, int rowlen)            
            => src.AsBytes().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this ulong[] src, int rowlen)            
            => src.AsSpan().FormatMatrixBits(rowlen);
                
        /// <summary>
        /// Multiplies the left bitmatrix by the right
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        /// <typeparam name="M">The left row dimension type</typeparam>
        /// <typeparam name="N">The right column dimension type</typeparam>
        /// <typeparam name="K">The common column/row dimension type betwen the left and right matrices</typeparam>
        /// <typeparam name="T">The primal segment type</typeparam>
        public static BitMatrix<M,N,T> Mul<M,N,K,T>(this BitMatrix<M,K,T> lhs, in BitMatrix<K,N,T> rhs)
            where M : ITypeNat, new()        
            where N : ITypeNat, new()
            where T : unmanaged
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

        public static BitVector64 Mul(in BitMatrix64 lhs, in BitVector64 rhs)
        {
            var dst = BitVector64.Alloc();
            for(var i=0; i< 64; i++)
                dst[i] = lhs.RowVector(i) % rhs;
            return dst;        
        }

        public static BitMatrix64 Mul(BitMatrix64 lhs, BitMatrix64 rhs)
        {
            var x = lhs;
            var y = rhs.Transpose();
            var n = 64;
            var dst = BitMatrix64.Alloc();

            for(var i=0; i< n; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< n; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = (ulong)z;
            }
            return dst;
        }

        public static ref BitMatrix64 Mul(BitMatrix64 lhs, BitMatrix64 rhs, ref BitMatrix64 dst)
        {
            var x = lhs;
            var y = rhs.Transpose();
            var n = 64;

            for(var i=0; i< n; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< n; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = (ulong)z;
            }
            return ref dst;
        }

        public static ref BitMatrix32 Mul(in BitMatrix32 lhs, in BitMatrix32 rhs, ref BitMatrix32 dst)
        {
            var x = lhs;
            var y = rhs.Transpose();
            var n = 32;

            for(var i=0; i< n; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector32.Alloc();
                for(var j = 0; j< n; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = (uint)z;
            }
            return ref dst;
        }


        /// <summary>
        /// Multiplies the left bitmatrix by the right
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        /// <typeparam name="M">The left row dimension type</typeparam>
        /// <typeparam name="N">The right column dimension type</typeparam>
        /// <typeparam name="K">The common column/row dimension type betwen the left and right matrices</typeparam>
        /// <typeparam name="T">The primal segment type</typeparam>
        public static ref BitMatrix<M,N,T> Mul<M,N,K,T>(BitMatrix<M,K,T> lhs, in BitMatrix<K,N,T> rhs, ref BitMatrix<M,N,T> dst)
            where M : ITypeNat, new()        
            where N : ITypeNat, new()
            where T : unmanaged
            where K : ITypeNat, new()
        {
            var x = lhs;
            var y = rhs.Transpose();

            for(var i=0; i< lhs.RowCount; i++)
            {
                var r = x.RowVector(i);
                for(var j = 0; j< y.ColCount; j++)
                {
                    var c = y.RowVector(j);
                    dst[i,j] = r % c;
                }
            }
            return ref dst;
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