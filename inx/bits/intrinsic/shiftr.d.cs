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

    partial class dinx
    {
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
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<long> lhs, in Vec128<ulong> rhs, ref long dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<int> lhs, in Vec256<uint> rhs, ref int dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<long> lhs, in Vec256<ulong> rhs, ref long dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

 
        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<short> lhs, byte count, ref short dst)
           => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<ushort> lhs, byte count, ref ushort dst)
           => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<int> lhs, byte count, ref int dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<uint> lhs, byte count, ref uint dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<long> lhs, byte count, ref long dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<ulong> lhs, byte count, ref ulong dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<short> lhs, byte count, ref short dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<ushort> lhs, byte count, ref ushort dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<int> lhs, byte count, ref int dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<uint> lhs, byte count, ref uint dst)
           => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<long> lhs, byte count, ref long dst)
           => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<ulong> lhs, byte count, ref ulong dst)
           => store(shiftr(lhs,count), ref dst);

   }
}