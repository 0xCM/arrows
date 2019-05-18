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
        public static Vec128<short> rshiftw(in Vec128<short> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> rshiftw(in Vec128<ushort> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> rshiftw(in Vec128<int> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> rshiftw(in Vec128<uint> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> rshiftw(in Vec128<long> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> rshiftw(in Vec128<ulong> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);
        
        [MethodImpl(Inline)]
        public static Vec256<short> rshiftw(in Vec256<short> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> rshiftw(in Vec256<ushort> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> rshiftw(in Vec256<int> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> rshiftw(in Vec256<uint> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> rshiftw(in Vec256<long> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> rshiftw(in Vec256<ulong> src, byte count)
            => Avx2.ShiftRightLogical128BitLane(src, count); 
    }
}