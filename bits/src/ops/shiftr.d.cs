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
    using static Span256;
    using static Span128;
    using static As;

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static sbyte shiftr(sbyte lhs, int rhs)
            => (sbyte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static byte shiftr(byte lhs, int rhs)
            => (byte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static short shiftr(short lhs, int rhs)
            => (short)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static ushort shiftr(ushort lhs, int rhs)
            => (ushort)(lhs >> rhs);

        [MethodImpl(Inline)]
        public static int shiftr(int lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static uint shiftr(uint lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static long shiftr(long lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static ulong shiftr(ulong lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public static ref sbyte shiftr(ref sbyte lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte shiftr(ref byte lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short shiftr(ref short lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort shiftr(ref ushort lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int shiftr(ref int lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint shiftr(ref uint lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long shiftr(ref long lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong shiftr(ref ulong lhs, int rhs)
        {
            lhs >>= rhs;
            return ref lhs;
        }
         
        [MethodImpl(Inline)]
        public static Vec128<short> shiftr(in Vec128<short> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> shiftr(in Vec128<ushort> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> shiftr(in Vec128<int> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftr(in Vec128<uint> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftr(in Vec128<long> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftr(in Vec128<ulong> src, byte count)
            => ShiftRightLogical(src, count);
        
        [MethodImpl(Inline)]
        public static Vec256<short> shiftr(in Vec256<short> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> shiftr(in Vec256<ushort> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> shiftr(in Vec256<int> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> shiftr(in Vec256<uint> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> shiftr(in Vec256<long> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftr(in Vec256<ulong> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> shiftr(in Vec128<int> src, in Vec128<uint> count)
            => ShiftRightLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftr(in Vec128<uint> src, in Vec128<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftr(in Vec128<long> src, in Vec128<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftr(in Vec128<ulong> src, in Vec128<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);       
 
        [MethodImpl(Inline)]
        public static Vec256<int> shiftr(in Vec256<int> src, in Vec256<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<uint> shiftr(in Vec256<uint> src, in Vec256<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<long> shiftr(in Vec256<long> src, in Vec256<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftr(in Vec256<ulong> src, in Vec256<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts); 
  
        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<int> lhs, in Vec128<uint> rhs, ref int dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<long> lhs, in Vec128<ulong> rhs, ref long dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<int> lhs, in Vec256<uint> rhs, ref int dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<long> lhs, in Vec256<ulong> rhs, ref long dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

 
        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<short> lhs, byte count, ref short dst)
           => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<ushort> lhs, byte count, ref ushort dst)
           => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<int> lhs, byte count, ref int dst)
            => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<uint> lhs, byte count, ref uint dst)
            => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<long> lhs, byte count, ref long dst)
            => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<ulong> lhs, byte count, ref ulong dst)
            => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<short> lhs, byte count, ref short dst)
            => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<ushort> lhs, byte count, ref ushort dst)
            => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<int> lhs, byte count, ref int dst)
            => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<uint> lhs, byte count, ref uint dst)
           => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<long> lhs, byte count, ref long dst)
           => vstore(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<ulong> lhs, byte count, ref ulong dst)
           => vstore(shiftr(lhs,count), ref dst);
    }

}