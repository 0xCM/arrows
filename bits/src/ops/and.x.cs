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
    
    using static zfunc;
    using static As;
    

    partial class BitsX
    {
        /// <summary>
        /// Computes the bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> And<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => gbits.and(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> And<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => gbits.and(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static Span128<T> And<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
                => gbits.and(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span256<T> And<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct  
                => gbits.and(lhs,rhs,dst);

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
        public static ref Matrix<M,N,T> And<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Unsized.ReadOnly().And(rhs.Unsized, lhs.Unsized);
            return ref lhs;
        }

 
        [MethodImpl(Inline)]
        public static Vec256<sbyte> And(this Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Bits.and(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> And(this Vec256<byte> lhs, in Vec256<byte> rhs)
            => Bits.and(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> And(this Vec256<short> lhs, in Vec256<short> rhs)
            => Bits.and(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> And(this Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Bits.and(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> And(this Vec256<int> lhs, in Vec256<int> rhs)
            => Bits.and(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> And(this Vec256<uint> lhs, in Vec256<uint> rhs)
            => Bits.and(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> And(this Vec256<long> lhs, in Vec256<long> rhs)
            => Bits.and(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> And(this Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Bits.and(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static void And(this Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => Bits.and(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void And(this Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => Bits.and(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void And(this Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => Bits.and(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void And(this Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => Bits.and(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void And(this Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => Bits.and(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void And(this Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => Bits.and(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void And(this Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => Bits.and(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void And(this Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => Bits.and(in lhs, in rhs, ref dst);

        public static Span128<sbyte> And(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, in Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<byte> And(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, in Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<short> And(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, in Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<ushort> And(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, in Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<int> And(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, in Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<uint> And(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, in Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<long> And(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, in Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<ulong> And(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<float> And(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, in Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<double> And(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, in Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<sbyte> And(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, in Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<byte> And(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, in Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<short> And(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, in Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<ushort> And(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, in Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<int> And(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, in Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<uint> And(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<long> And(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, in Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<ulong> And(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<float> And(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, in Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<double> And(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, in Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                Bits.and(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        } 
    }
}