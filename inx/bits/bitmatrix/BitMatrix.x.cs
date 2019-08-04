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
        public static ref BitMatrix<M,N,T> And<M,N,T>(this ref BitMatrix<M,N,T> lhs, in BitMatrix<M,N,T> rhs)        
            where M : ITypeNat, new()        
            where N : ITypeNat, new()
            where T : struct
        {
            gbits.and(lhs.Bits, rhs.Bits, lhs.Bits);
            return ref lhs;
        }

        public static ref BitMatrix<M,N,T> Or<M,N,T>(this ref BitMatrix<M,N,T> lhs, in BitMatrix<M,N,T> rhs)        
            where M : ITypeNat, new()        
            where N : ITypeNat, new()
            where T : struct
        {
            gbits.or(lhs.Bits, rhs.Bits, lhs.Bits);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<ushort> LoadVector(this BitMatrix16 src, out Vec256<ushort> dst)
        {
            dst = Vec256.load(ref src.bits[0]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<uint> LoadVector(this BitMatrix32 src, out Vec256<uint> dst, int rowOffset)
        {
            dst = Vec256.load(ref src.bits[rowOffset]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<ulong> LoadVector(this BitMatrix64 src, out Vec256<ulong> dst, int rowOffset)
        {
            dst = Vec256.load(ref src.bits[rowOffset]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static string Format(this in BitMatrix8 src)
            => src.bits.FormatMatrixBits(8);

        [MethodImpl(Inline)]
        public static string Format(this in BitMatrix16 src)
            => MemoryMarshal.AsBytes(src.bits).FormatMatrixBits(16);

        [MethodImpl(Inline)]
        public static string Format(this in BitMatrix32 src)
            => MemoryMarshal.AsBytes(src.bits).FormatMatrixBits(32);

        internal static string FormatMatrixBits(this Span<byte> src, int rowlen)            
        {
            var dst = gbits.bitchars(src);
            var sb = sbuild();
            for(var i=0; i<dst.Length; i+= rowlen)
            {
                var rowbits = dst.Slice(i, rowlen);
                Claim.eq(rowbits.Length, rowlen);                
                var row = new string(rowbits.Intersperse(AsciSym.Space));                                
                sb.AppendLine(row);
            }
            return sb.ToString();
        }       

    }
}