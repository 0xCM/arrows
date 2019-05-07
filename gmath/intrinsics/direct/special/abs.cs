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
    
    using static zcore;
    using static global::mfunc;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> abs(Vec128<sbyte> src)
            => Avx2.Abs(src);


        [MethodImpl(Inline)]
        public static Vec128<ushort> abs(Vec128<short> src)
            => Avx2.Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> abs(Vec128<int> src)
            => Avx2.Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<byte> abs(Vec256<sbyte> src)
            => Avx2.Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<ushort> abs(Vec256<short> src)
            => Avx2.Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<uint> abs(Vec256<int> src)
            => Avx2.Abs(src);


    }

}