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
    using static System.Runtime.Intrinsics.X86.Ssse3;

    using static zfunc;    

    partial class dinx
    {    
        [MethodImpl(Inline)]
        public static Vec128<byte> abs(in Vec128<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> abs(in Vec128<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> abs(in Vec128<int> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<long> abs(Vec128<long> src)
        {
            var mask = negate(srli(src, 31));                        
            return sub(xor(mask, src), mask);
        }

        [MethodImpl(Inline)]
        public static Vec256<byte> abs(in Vec256<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<ushort> abs(in Vec256<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<uint> abs(in Vec256<int> src)
            => Abs(src);        
 
        [MethodImpl(Inline)]
        public static Vec256<long> abs(Vec256<long> src)
        {
            var mask = negate(srli(src, 63));                        
            return sub(xor(mask, src), mask);
        }
    }

}