//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;


    public static partial class PrimalOps
    {        
        
        [MethodImpl(Inline)]
        public static PrimalBinPred<T> eq<T>()
            where T : struct, IEquatable<T>
                => Eq<T>.Op;

        [MethodImpl(Inline)]
        public static PrimalBinPred<T> gt<T>()
            where T : struct, IEquatable<T>
                => Gt<T>.Op;


        [MethodImpl(Inline)]
        public static PrimalBinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add<T>.Op;


        [MethodImpl(Inline)]
        public static PrimalBinOp<T> sub<T>()
            where T : struct, IEquatable<T>
                => Sub<T>.Op;


        [MethodImpl(Inline)]
        public static PrimalBinOp<T> mul<T>()
            where T : struct, IEquatable<T>
                => Mul<T>.Op;


        [MethodImpl(Inline)]
        public static PrimalBinOp<T> div<T>()
            where T : struct, IEquatable<T>
                => Div<T>.Op;


        [MethodImpl(Inline)]
        public static PrimalBinOp<T> mod<T>()
            where T : struct, IEquatable<T>
                => Mod<T>.Op;


        [MethodImpl(Inline)]
        public static PrimalBinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => And<T>.Op;

 
        [MethodImpl(Inline)]
        public static PrimalBinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Or<T>.Op;

 
        [MethodImpl(Inline)]
        public static PrimalBinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => XOr<T>.Op;

 
        [MethodImpl(Inline)]
        public static PrimalUnaryOp<T> inc<T>()
            where T : struct, IEquatable<T>
                => Inc<T>.Op;

        [MethodImpl(Inline)]
        public static T inc<T>(T src)
            where T : struct, IEquatable<T>
                => Inc<T>.Op(src);

    }

}