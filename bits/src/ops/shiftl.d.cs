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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static Span256;
    using static Span128;
    
    partial class Bits
    {
        [MethodImpl(Inline)]
        public static sbyte shiftl(sbyte lhs, int rhs)
            => (sbyte)(lhs << rhs);

        [MethodImpl(Inline)]
        public static byte shiftl(byte lhs, int rhs)
            => (byte)(lhs << rhs);

        [MethodImpl(Inline)]
        public static short shiftl(short lhs, int rhs)
            => (short)(lhs << rhs);

        [MethodImpl(Inline)]
        public static ushort shiftl(ushort lhs, int rhs)
            => (ushort)(lhs << rhs);

        [MethodImpl(Inline)]
        public static int shiftl(int lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static uint shiftl(uint lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static long shiftl(long lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static ulong shiftl(ulong lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public static ref sbyte shiftl(ref sbyte lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte shiftl(ref byte lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short shiftl(ref short lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort shiftl(ref ushort lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int shiftl(ref int lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint shiftl(ref uint lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long shiftl(ref long lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong shiftl(ref ulong lhs, int rhs)
        {
            lhs <<= rhs;
            return ref lhs;
        }
 
        [MethodImpl(Inline)]
        public static Vec128<short> shiftl(in Vec128<short> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> shiftl(in Vec128<ushort> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> shiftl(in Vec128<int> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftl(in Vec128<uint> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftl(in Vec128<long> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftl(in Vec128<ulong> src, byte count)
            => ShiftLeftLogical(src, count);
        
        [MethodImpl(Inline)]
        public static Vec256<short> shiftl(in Vec256<short> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> shiftl(in Vec256<ushort> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> shiftl(in Vec256<int> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> shiftl(in Vec256<uint> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> shiftl(in Vec256<long> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftl(in Vec256<ulong> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<short> lhs, byte count, ref short dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<ushort> lhs, byte count, ref ushort dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<int> lhs, byte count, ref int dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<uint> lhs, byte count, ref uint dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<long> lhs, byte count, ref long dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<ulong> lhs, byte count, ref ulong dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<short> lhs, byte count, ref short dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void  shiftl(in Vec256<ushort> lhs, byte count, ref ushort dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<int> lhs, byte count, ref int dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<uint> lhs, byte count, ref uint dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<long> lhs, byte count, ref long dst)
            => vstore(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<ulong> lhs, byte count, ref ulong dst)
            => vstore(shiftl(lhs,count), ref dst);

       [MethodImpl(Inline)]
        public static Vec128<int> shiftl(in Vec128<int> src, in Vec128<uint> count)
            => ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftl(in Vec128<uint> src, in Vec128<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftl(in Vec128<long> src, in Vec128<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftl(in Vec128<ulong> src, in Vec128<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);       
 
        [MethodImpl(Inline)]
        public static Vec256<int> shiftl(in Vec256<int> src, in Vec256<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<uint> shiftl(in Vec256<uint> src, in Vec256<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<long> shiftl(in Vec256<long> src, in Vec256<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftl(in Vec256<ulong> src, in Vec256<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);  

    }


}