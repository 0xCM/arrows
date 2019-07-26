//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;

    using static zfunc;
    using static Span256;
    using static Span128;

    partial class dinxx
    {
        /// <summary>
        /// Calculates the 64-bit product of two 32-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong UMul64(this uint lhs, uint rhs)
            => dinx.umul64(lhs,rhs);

        /// <summary>
        /// Calculates the 128-bit product of two 64-bit integers
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static UInt128 UMul128(this ulong lhs, ulong rhs)
            => dinx.umul128(lhs,rhs, out UInt128 _);

        [MethodImpl(Inline)]
        public static ref UInt128 UMul128(this ulong lhs, ulong rhs, out UInt128 dst)
        {
            dinx.umul128(lhs,rhs, out dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ulong UMulLo(this ulong lhs, ulong rhs)
            => dinx.umulLo(lhs,rhs);

        [MethodImpl(Inline)]
        public static ulong UMulHi(this ulong lhs, ulong rhs)
            => dinx.umulHi(lhs,rhs);

        [MethodImpl(Inline)]
        public static UInt128 ShiftRW(this in UInt128 src, byte offset)
            => dinx.shiftrw(src.ToVec128(), offset).ToUInt128();

        [MethodImpl(Inline)]
        public static UInt128 ShiftLW(this in UInt128 src, byte offset)
            => dinx.shiftlw(src.ToVec128(), offset).ToUInt128();

        public static Span128<long> Mul(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Multiply(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span128<ulong> Mul(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Multiply(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span128<float> Mul(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Multiply(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span128<double> Mul(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Multiply(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span256<long> Mul(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Multiply(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span256<ulong> Mul(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Multiply(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span256<float> Mul(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Multiply(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span256<double> Mul(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Multiply(lhs.LoadVec256(block), lhs.LoadVec256(block)), ref dst.Block(block));
            return dst;            
        }
    }
}