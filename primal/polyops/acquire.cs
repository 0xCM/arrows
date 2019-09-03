//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
        
    using static zfunc;

    using static As;

    partial class PolyOps
    {

        [MethodImpl(Inline)]
        public static ref readonly AddOp<T> add<T>()
            where T : unmanaged        
                => ref AddOp<T>.TheOnly;

        [MethodImpl(Inline)]
        public static ref readonly SubOp<T> sub<T>()
            where T : unmanaged        
                => ref SubOp<T>.TheOnly;

        [MethodImpl(Inline)]
        public static ref readonly MulOp<T> mul<T>()
            where T : unmanaged        
                => ref MulOp<T>.TheOnly;

        [MethodImpl(Inline)]
        public static ref readonly DivOp<T> div<T>()
            where T : unmanaged        
                => ref DivOp<T>.TheOnly;

        [MethodImpl(Inline)]
        public static ref readonly ModOp<T> mod<T>()
            where T : unmanaged        
                => ref ModOp<T>.TheOnly;

        [MethodImpl(Inline)]
        public static ref readonly AbsOp<T> abs<T>()
            where T : unmanaged        
                => ref AbsOp<T>.TheOnly;

        [MethodImpl(Inline)]
        public static ref readonly IncOp<T> inc<T>()
            where T : unmanaged        
                => ref IncOp<T>.TheOnly;

        [MethodImpl(Inline)]
        public static ref readonly DecOp<T> dec<T>()
            where T : unmanaged        
                => ref DecOp<T>.TheOnly;

       [MethodImpl(Inline)]
        public static ref readonly FlipOp<T> flip<T>()
            where T : unmanaged        
                => ref FlipOp<T>.TheOnly;

       [MethodImpl(Inline)]
        public static ref readonly NegateOp<T> negate<T>()
            where T : unmanaged        
                => ref NegateOp<T>.TheOnly;

    }

}