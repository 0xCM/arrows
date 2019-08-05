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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    
    using static zfunc;    
    using static Span256;
    using static Span128;

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static ref sbyte or(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs | rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte or(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs | rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short or(ref short lhs, short rhs)
        {
            lhs = (short)(lhs | rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort or(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs | rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int or(ref int lhs, int rhs)
        {
            lhs = lhs | rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint or(ref uint lhs, uint rhs)
        {
            lhs = lhs | rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long or(ref long lhs, long rhs)
        {
            lhs = lhs | rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong or(ref ulong lhs, ulong rhs)
        {
            lhs = lhs | rhs;
            return ref lhs;
        }

 
        [MethodImpl(Inline)]
        public static UInt128 xor(in UInt128 lhs, in UInt128 rhs)
            => xor(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 xor(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = xor(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();
            return ref dst;            
        }
            
        [MethodImpl(Inline)]
        public static Vec128<byte> xor(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> xor(in Vec128<short> lhs, in Vec128<short> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> xor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> xor(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> xor(in Vec128<int> lhs, in Vec128<int> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> xor(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> xor(in Vec128<long> lhs, in Vec128<long> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> xor(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> xor(in Vec128<float> lhs, in Vec128<float> rhs)
            => Xor(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> xor(in Vec128<double> lhs, in Vec128<double> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> xor(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> xor(in Vec256<short> lhs, in Vec256<short> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> xor(in Vec256<int> lhs, in Vec256<int> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> xor(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> xor(in Vec256<long> lhs, in Vec256<long> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> xor(in Vec256<float> lhs, in Vec256<float> rhs)
            => Xor(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<double> xor(in Vec256<double> lhs, in Vec256<double> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => vstore(Xor(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => vstore(Xor(lhs,rhs), ref dst);

        public static Span<sbyte> xor(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] ^= rhs[i];
            return lhs;
        }

        public static Span<byte> xor(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] ^= rhs[i];
            return lhs;
        }

        public static Span<short> xor(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] ^= rhs[i];
            return lhs;
        }

        public static Span<ushort> xor(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] ^= rhs[i];
            return lhs;
        }

        public static Span<int> xor(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] ^= rhs[i];
            return lhs;
        }

        public static Span<uint> xor(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] ^= rhs[i];
            return lhs;
        }

        public static Span<long> xor(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] ^= rhs[i];
            return lhs;
        }

        public static Span<ulong> xor(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] ^= rhs[i];
            return lhs;
        }

        public static Span<sbyte> xor(Span<sbyte> lhs, sbyte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] ^= rhs;
            return lhs;
        }

        public static Span<byte> xor(Span<byte> lhs, byte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] ^= rhs;
            return lhs;
        }

        public static Span<short> xor(Span<short> lhs, short rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] ^= rhs;
            return lhs;
        }

        public static Span<ushort> xor(Span<ushort> lhs, ushort rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] ^= rhs;
            return lhs;
        }

        public static Span<int> xor(Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] ^= rhs;
            return lhs;
        }

        public static Span<uint> xor(Span<uint> lhs, uint rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] ^= rhs;
            return lhs;
        }

        public static Span<long> xor(Span<long> lhs, long rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] ^= rhs;
            return lhs;
        }

        public static Span<ulong> xor(Span<ulong> lhs, ulong rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] ^= rhs;
            return lhs;
        }

    }

    partial class dinx
    {

   }
}