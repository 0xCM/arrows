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

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Ssse3;

    using static zfunc;    

    partial class dinx
    {
        
        [MethodImpl(Inline)]
        public static Vec128<byte> abs(Vec128<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> abs(Vec128<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> abs(Vec128<int> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<byte> abs(Vec256<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<ushort> abs(Vec256<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<uint> abs(Vec256<int> src)
            => Abs(src);
 
        [MethodImpl(Inline)]
        public static void abs(Vec128<sbyte> src, ref sbyte dst)
            => Abs(src);

        [MethodImpl(Inline)]
        public static void abs(Vec128<short> src, ref short dst)
            => Abs(src);

        [MethodImpl(Inline)]
        public static void abs(Vec128<int> src, ref uint dst)
            => store(Abs(src), ref dst);

        [MethodImpl(Inline)]
        public static void abs(Vec256<sbyte> src, ref byte dst)
            => store(Abs(src), ref dst);

        [MethodImpl(Inline)]
        public static void abs(Vec256<short> src, ref ushort dst)
            => store(Abs(src), ref dst);

        [MethodImpl(Inline)]
        public static void abs(Vec256<int> src, ref uint dst)
            => store(Abs(src), ref dst);
 
    }

}