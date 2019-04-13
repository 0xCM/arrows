//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using X86 = System.Runtime.Intrinsics.X86;
    using static zcore;

    using NumVec = System.Numerics.Vector;


    public partial class Vec128
    {
        
    }

   public readonly struct Vec128<T>
        where T : struct, IEquatable<T>
    {
        public const int BitCount = 128;

        const int ByteCount = 16;

        public static readonly int Length = Vector128<T>.Count;
        
        public static readonly int ComponentBitCount = BitCount / (Length * 8);
        
        readonly Vector128<T> data;        
    

        [MethodImpl(Inline)]
        public static implicit operator Vec128<T>(Vector128<T> src)
            => new Vec128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(Vec128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public Vec128(Vector128<T> src)
            => this.data = src;

        public T this[int idx]
        {
            [MethodImpl(Inline)]
            get => Vec128.element(data,idx);
        }

        public override string ToString()
            => data.ToString();
    }
     
}