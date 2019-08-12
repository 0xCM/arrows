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
    
    using static zfunc;

    public struct Num128<T>
        where T : struct
    {        
        Vector128<T> data;            

        [MethodImpl(Inline)]
        public static implicit operator Num128<T>(in Vector128<T> src)
            => new Num128<T>(src);

        // [MethodImpl(Inline)]
        // public static implicit operator Num128<T>(T src)
        //     => new Num128<T>(Vector128.Create(src));

        [MethodImpl(Inline)]
        public static implicit operator T(Num128<T> src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(in Num128<T> src)
            => src.As<T>();

        [MethodImpl(Inline)]
        public Num128(in Vector128<T> src)
            => this.data = src;

        public T value
        {
            [MethodImpl(Inline)]
            get => data.GetElement(0);
        }

        [MethodImpl(Inline)]
        public bool Equals(Num128<T> rhs)
            => data.Equals(rhs.data);

        public override string ToString()
            => value.ToString();

        [MethodImpl(Inline)]
        public Vector128<U> As<U>() 
            where U : struct        
                => Unsafe.As<Vector128<T>, Vector128<U>>(ref Unsafe.AsRef(in data));        
    }     
}