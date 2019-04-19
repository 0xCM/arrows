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
    using static inxfunc;

   public readonly struct Num256<T> : IEquatable<Num256<T>>
        where T : struct, IEquatable<T>
    {        
        readonly Vector256<T> data;            

        [MethodImpl(Inline)]
        public static implicit operator Num256<T>(Vector256<T> src)
            => new Num256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Num256<T>(T src)
            => new Num256<T>(Num256.define(src));

        [MethodImpl(Inline)]
        public static implicit operator Vector256<T>(Num256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public Num256(Vector256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        static T getValue(Vector256<T> src)
        {
            ref T e0 = ref Unsafe.As<Vector256<T>, T>(ref src);                    
            return Unsafe.Add(ref e0, 0);           
        }

        public T value
        {
            [MethodImpl(Inline)]
            get => getValue(this.data);
        }

        [MethodImpl(Inline)]
        public bool Equals(Num256<T> rhs)
            => data.Equals(rhs.data);

        public override string ToString()
            => value.ToString();

        [MethodImpl(Inline)]
        public Vector256<U> As<U>() 
            where U : struct        
                => Unsafe.As<Vector256<T>, Vector256<U>>(ref Unsafe.AsRef(in data));        

    }     
}