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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static As;
    using static zfunc;
    using static Span256;
    using static Span128;

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static UInt128 and(in UInt128 lhs, in UInt128 rhs)
            => and(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = and(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();
            return ref dst;            
        }

        [MethodImpl(Inline)]
        public static Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
            => And(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> and(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> and(in Vec256<short> lhs, in Vec256<short> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> and(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> and(in Vec256<int> lhs, in Vec256<int> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> and(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> and(in Vec256<long> lhs, in Vec256<long> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> and(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> and(in Vec256<float> lhs, in Vec256<float> rhs)
            => And(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<double> and(in Vec256<double> lhs, in Vec256<double> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => vstore(and(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void and(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => vstore(and(lhs, rhs), ref dst);
 
         public static Span<sbyte> and(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<byte> and(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<short> and(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ushort> and(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<int> and(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<uint> and(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<long> and(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ulong> and(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.and(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<sbyte> and(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        public static Span<byte> and(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        public static Span<short> and(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        public static Span<ushort> and(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        public static Span<int> and(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        public static Span<uint> and(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        public static Span<long> and(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        public static Span<ulong> and(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] &= rhs[i];
            return lhs;
        }

        public static Span<sbyte> and(Span<sbyte> lhs, sbyte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        public static Span<byte> and(Span<byte> lhs, byte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        public static Span<short> and(Span<short> lhs, short rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        public static Span<ushort> and(Span<ushort> lhs, ushort rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        public static Span<int> and(Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        public static Span<uint> and(Span<uint> lhs, uint rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        public static Span<long> and(Span<long> lhs, long rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }

        public static Span<ulong> and(Span<ulong> lhs, ulong rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] &= rhs;
            return lhs;
        }
 
 
     }

}