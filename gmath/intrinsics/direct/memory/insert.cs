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
    
    using static zcore;
    using static inxfunc;


    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> insert<T>(byte src, Vec128<byte> dst, byte offset)        
            where T : struct, IEquatable<T>
                => Avx2.Insert(dst,src,offset);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> insert<T>(sbyte src, Vec128<sbyte> dst, byte offset)        
            where T : struct, IEquatable<T>
                => Avx2.Insert(dst,src,offset);

        [MethodImpl(Inline)]
        public static Vec128<short> insert<T>(short src, Vec128<short> dst, byte offset)        
            where T : struct, IEquatable<T>
                => Avx2.Insert(dst,src,offset);

        [MethodImpl(Inline)]
        public static Vec128<ushort> insert<T>(ushort src, Vec128<ushort> dst, byte offset)        
            where T : struct, IEquatable<T>
                => Avx2.Insert(dst,src,offset);

        [MethodImpl(Inline)]
        public static Vec128<int> insert<T>(int src, Vec128<int> dst, byte offset)        
            where T : struct, IEquatable<T>
                => Avx2.Insert(dst,src,offset);

        [MethodImpl(Inline)]
        public static Vec128<uint> insert<T>(uint src, Vec128<uint> dst, byte offset)        
            where T : struct, IEquatable<T>
                => Avx2.Insert(dst,src,offset);

        [MethodImpl(Inline)]
        public static Vec128<long> insert<T>(long src, Vec128<long> dst, byte offset)        
            where T : struct, IEquatable<T>
                => Avx2.X64.Insert(dst,src,offset);

        [MethodImpl(Inline)]
        public static Vec128<ulong> insert<T>(ulong src, Vec128<ulong> dst, byte offset)        
            where T : struct, IEquatable<T>
                => Avx2.X64.Insert(dst,src,offset);

    }

}