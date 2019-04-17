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
    using static inX;

    partial class InX
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
    }

}