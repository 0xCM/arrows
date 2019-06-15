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
    using System.Collections.Generic;
        
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse42;

    using static zfunc;
    
    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> insert(byte src, in Vec128<byte> dst, byte index)        
            => Insert(dst,src,index);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> insert(sbyte src, in Vec128<sbyte> dst, byte index)        
            => Insert(dst,src,index);

        [MethodImpl(Inline)]
        public static Vec128<short> insert(short src, in Vec128<short> dst, byte index)        
            => Insert(dst,src,index);

        [MethodImpl(Inline)]
        public static Vec128<ushort> insert(ushort src, in Vec128<ushort> dst, byte index)        
            => Insert(dst,src,index);

        [MethodImpl(Inline)]
        public static Vec128<int> insert(int src, in Vec128<int> dst, byte index)        
            => Insert(dst,src,index);

        [MethodImpl(Inline)]
        public static Vec128<uint> insert(uint src, in Vec128<uint> dst, byte index)        
            => Insert(dst,src,index);

        [MethodImpl(Inline)]
        public static Vec128<long> insert(long src, in Vec128<long> dst, byte index)        
            => Avx2.X64.Insert(dst,src,index);

        [MethodImpl(Inline)]
        public static Vec128<ulong> insert(ulong src, in Vec128<ulong> dst, byte index)        
            => Avx2.X64.Insert(dst,src,index);
    }
}