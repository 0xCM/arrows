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
        public static Num128<T> Add<T>(this in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
                => ginx.add(lhs,rhs);


        [MethodImpl(Inline)]
        public static Vec128<T> Add<T>(this in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => ginx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<T> Add<T>(this in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct, IEquatable<T>
                => ginx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T>  LoScalar<T>(this Vec128<T> src)
            where T : struct, IEquatable<T>
                => src[0];

        [MethodImpl(Inline)]
        public static Num128<T>  HiScalar<T>(this Vec128<T> src)
            where T : struct, IEquatable<T>
                => src[Vec128<T>.Length -1];
        
        [MethodImpl(Inline)]
        public static Num128<T> Scalar<T>(this Vec128<T> src, int index)
            where T : struct, IEquatable<T>            
                => Num128.define(src[index]);


    }

}