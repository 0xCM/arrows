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
    
    using static zfunc;    
    using static As;
    using static Span256;
    using static Span128;

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static sbyte or(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs | rhs);

        [MethodImpl(Inline)]
        public static sbyte or(sbyte x1, sbyte x2, params sbyte[] more)
        {
            var result = (sbyte)(x1 | x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }
            
        [MethodImpl(Inline)]
        public static byte or(byte lhs, byte rhs)
            => (byte)(lhs | rhs);

        [MethodImpl(Inline)]
        public static byte or(byte x1, byte x2, params byte[] more)
        {
            var result = (byte)(x1 | x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static short or(short lhs, short rhs)
            => (short)(lhs | rhs);


        [MethodImpl(Inline)]
        public static short or(short x1, short x2, params short[] more)
        {
            short result = (short)(x1 | x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static ushort or(ushort lhs, ushort rhs)
            => (ushort)(lhs | rhs);

        public static ushort or(ushort x1, ushort x2, params ushort[] more)
        {
            var result = (ushort)(x1 | x2);
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static int or(int lhs, int rhs)
            => lhs | rhs;

        public static int or(int x1, int x2, params int[] more)
        {
            var result = x1 | x2;
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static uint or(uint lhs, uint rhs)
            => lhs | rhs;

        public static uint or(uint x1, uint x2, params uint[] more)
        {
            var result = x1 | x2;
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static long or(long lhs, long rhs)
            => lhs | rhs;

        public static long or(long x1, long x2, params long[] more)
        {
            var result = x1| x2;
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }

        [MethodImpl(Inline)]
        public static ulong or(ulong lhs, ulong rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public static float or(float lhs, float rhs)
            => BitConverter.Int32BitsToSingle(lhs.ToBits() | rhs.ToBits());

        [MethodImpl(Inline)]
        public static double or(double lhs, double rhs)
            => BitConverter.Int64BitsToDouble(lhs.ToBits() | rhs.ToBits());

        public static ulong or(ulong x1, ulong x2, params ulong[] more)
        {
            var result = x1 | x2;
            for(var i = 0; i< more.Length; i++)
                result |= more[i];
            return result;
        }
         
 
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
        public static ref float or(ref float lhs, float rhs)
        {
            lhs = or(lhs,rhs);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref double or(ref double lhs, double rhs)
        {
            lhs = or(lhs,rhs);
            return ref lhs;
        }

       [MethodImpl(Inline)]
        public static UInt128 or(in UInt128 lhs, in UInt128 rhs)
            => or(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();

        [MethodImpl(Inline)]
        public static ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
        {
            dst = or(lhs.ToVec128(), rhs.ToVec128()).ToUInt128();
            return ref dst;            
        }
                
        [MethodImpl(Inline)]
        public static Vec128<byte> or(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> or(in Vec128<short> lhs, in Vec128<short> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> or(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> or(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> or(in Vec128<int> lhs, in Vec128<int> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> or(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> or(in Vec128<long> lhs, in Vec128<long> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> or(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> or(in Vec128<float> lhs, in Vec128<float> rhs)
            => Or(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> or(in Vec128<double> lhs, in Vec128<double> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> or(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> or(in Vec256<short> lhs, in Vec256<short> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> or(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> or(in Vec256<int> lhs, in Vec256<int> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> or(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> or(in Vec256<long> lhs, in Vec256<long> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> or(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> or(in Vec256<float> lhs, in Vec256<float> rhs)
            => Or(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<double> or(in Vec256<double> lhs, in Vec256<double> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => vstore(or(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void or(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => vstore(or(lhs, rhs), ref dst);
 
    }

}