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
    
    
    using static mfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> lshiftw(in Vec128<short> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> lshiftw(in Vec128<ushort> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> lshiftw(in Vec128<int> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> lshiftw(in Vec128<uint> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> lshiftw(in Vec128<long> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> lshiftw(in Vec128<ulong> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        
        [MethodImpl(Inline)]
        public static Vec256<short> lshiftw(in Vec256<short> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> lshiftw(in Vec256<ushort> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> lshiftw(in Vec256<int> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> lshiftw(in Vec256<uint> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> lshiftw(in Vec256<long> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> lshiftw(in Vec256<ulong> src, byte count)
            => Avx2.ShiftLeftLogical128BitLane(src, count); 
    }
}