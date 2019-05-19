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

    
    using static mfunc;


    partial class ginxx
    {

        [MethodImpl(Inline)]
        public static ref Num128<T> Add<T>(this ref Num128<T> lhs, in Num128<T> rhs)
            where T : struct
                => ref ginx.add(ref lhs,rhs);


        [MethodImpl(Inline)]
        public static Vec128<T> Add<T>(this in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<T> Add<T>(this in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T>  LoScalar<T>(this Vec128<T> src)
            where T : struct
                => src[0];

        [MethodImpl(Inline)]
        public static Num128<T>  HiScalar<T>(this Vec128<T> src)
            where T : struct
                => src[Vec128<T>.Length -1];
        
        [MethodImpl(Inline)]
        public static Num128<T> Scalar<T>(this Vec128<T> src, int index)
            where T : struct            
                => Num128.define(src[index]);


    }

}