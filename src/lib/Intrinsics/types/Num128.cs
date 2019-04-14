//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static zcore;
    using static x86;

   public readonly struct Num128<T> : IEquatable<Num128<T>>
        where T : struct, IEquatable<T>
    {        
        readonly Vector128<T> data;            

        [MethodImpl(Inline)]
        public static implicit operator Num128<T>(Vector128<T> src)
            => new Num128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Num128<T>(T src)
            => new Num128<T>(Num128.define(src));

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(Num128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public Num128(Vector128<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        static T getValue(Vector128<T> src)
        {
            ref T e0 = ref Unsafe.As<Vector128<T>, T>(ref src);                    
            return Unsafe.Add(ref e0, 0);           
        }

        public T value
        {
            [MethodImpl(Inline)]
            get => getValue(this.data);
        }

        [MethodImpl(Inline)]
        public bool Equals(Num128<T> rhs)
            => data.Equals(rhs.data);

        public override string ToString()
            => value.ToString();

    }     
}