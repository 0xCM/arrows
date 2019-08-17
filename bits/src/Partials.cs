//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public static partial class Bits
    {
        
    }

    public static partial class gbits
    {

    }
    public static partial class BitsX
    {

    }

    /// <summary>
    /// Defines bitwise reference operations
    /// </summary>
    public static partial class BitRef
    {



    }

    public static class AdHocExtensions
    {

        [MethodImpl(Inline)]
        public static BitString ToBitString(this in UInt128 src)
            => BitString.FromScalar(src.hi) + BitString.FromScalar(src.lo);


        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> Or<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Unsized.ReadOnly().Or(rhs.Unsized, lhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> And<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Unsized.ReadOnly().And(rhs.Unsized, lhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> XOr<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Unsized.ReadOnly().XOr(rhs.Unsized, lhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> And<T>(ref Vector<T> lhs, Vector<T> rhs)
            where T : struct
        {
            var x = lhs.Unblocked;
            var y = rhs.Unblocked;
            gbits.and(in x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Or<T>(ref Vector<T> lhs, Vector<T> rhs)
            where T : struct
        {
            var x = lhs.Unblocked;
            var y = rhs.Unblocked;
            gbits.or(in x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> XOr<T>(ref Vector<T> lhs, Vector<T> rhs)
            where T : struct
        {
            var x = lhs.Unblocked;
            var y = rhs.Unblocked;
            gbits.xor(in x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Flip<T>(ref Vector<T> src)
            where T : struct
        {
            gbits.flip(src.Unblocked, src.Unblocked);
            return ref src;
        }

        /// <summary>
        /// Converts a generic number to a bitstring
        /// </summary>
        /// <param name="src">The source number</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this num<T> src)
            where T : struct
                => BitString.FromScalar<T>(src.Scalar());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<BinaryDigit> ToBinaryDigits<T>(this num<T> src)
            where T : struct    
                =>  BitString.FromScalar(src.Scalar()).ToDigits();

        /// <summary>
        /// Converts an 128-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vec128<T> src)
            where T : struct        
                => BitString.FromScalars(src.ToSpan());
        
        /// <summary>
        /// Converts an 256-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vec256<T> src)
            where T : struct        
            => BitString.FromScalars(src.ToSpan());        

        // /// <summary>
        // /// Converts an 256-bit intrinsic integer representation to a bistring
        // /// </summary>
        // /// <param name="src">The source vector</param>
        // /// <typeparam name="T">The underlying primal type</typeparam>
        // [MethodImpl(Inline)]   
        // public static BitString ToBitString<T>(this __m256i src)
        //     where T : struct
        //         => src.ToVec256<T>().ToBitString();

    }

    public static class InxOps
    {
        /// <summary>
        /// Multiplies two two 256-bit/u64 vectors to yield a 256-bit/u64 vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<ulong> x, in Vec256<ulong> y)    
        {
            var loMask = Vec256.Fill(Bits.LoMask64);    
            var xl = Bits.and(x, loMask).As<uint>();
            var xh = Bits.shiftr(x, 32).As<uint>();
            var yl = Bits.and(y, loMask).As<uint>();
            var yh = Bits.shiftr(y, 32).As<uint>();

            var xh_yl = dinx.mul(xh, yl);
            var hl = Bits.shiftl(xh_yl, 32);

            var xh_mh = dinx.mul(xh, yh);
            var lh = Bits.shiftl(xh_mh, 32);

            var xl_yl = dinx.mul(xl, yl);

            var hl_lh = dinx.add(hl, lh);
            var z = dinx.add(xl_yl, hl_lh);
            return z;
        }

    }
}