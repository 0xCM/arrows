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
    
    partial class dinx
    {
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
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<ushort> lhs, byte count, ref ushort dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<int> lhs, byte count, ref int dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<uint> lhs, byte count, ref uint dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<long> lhs, byte count, ref long dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<ulong> lhs, byte count, ref ulong dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<short> lhs, byte count, ref short dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void  shiftl(in Vec256<ushort> lhs, byte count, ref ushort dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<int> lhs, byte count, ref int dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<uint> lhs, byte count, ref uint dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<long> lhs, byte count, ref long dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<ulong> lhs, byte count, ref ulong dst)
            => store(shiftl(lhs,count), ref dst);

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