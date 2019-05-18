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
        public static Vec128<int> lshiftv(in Vec128<int> src, Vec128<uint> count)
            => Avx2.ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> lshiftv(in Vec128<uint> src, Vec128<uint> count)
            => Avx2.ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> lshiftv(in Vec128<long> src, Vec128<ulong> count)
            => Avx2.ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> lshiftv(in Vec128<ulong> src, Vec128<ulong> count)
            => Avx2.ShiftLeftLogicalVariable(src, count);       
 
        [MethodImpl(Inline)]
        public static Vec256<int> lshiftv(in Vec256<int> src, Vec256<uint> count)
            => Avx2.ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> lshiftv(in Vec256<uint> src, Vec256<uint> count)
            => Avx2.ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> lshiftv(in Vec256<long> src, Vec256<ulong> count)
            => Avx2.ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> lshiftv(in Vec256<ulong> src, Vec256<ulong> count)
            => Avx2.ShiftLeftLogicalVariable(src, count); 
    }

}