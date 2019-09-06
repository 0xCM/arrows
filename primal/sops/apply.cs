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

    partial class StructOps
    {
        [MethodImpl(Inline)]
        public static T apply<T>(in AddOp<T> op, T x, T y)
            where T : unmanaged        
                => op.apply(x,y);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in AddOp<T> op, ref T x, in T y)
            where T : unmanaged        
                => ref op.apply(ref x,in y);

        [MethodImpl(Inline)]
        public static T apply<T>(in SubOp<T> op, T x, T y)
            where T : unmanaged        
                => op.apply(x,y);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in SubOp<T> op, ref T x, in T y)
            where T : unmanaged        
                => ref op.apply(ref x,in y);

        [MethodImpl(Inline)]
        public static T apply<T>(in MulOp<T> op, T x, T y)
            where T : unmanaged        
                => op.apply(x,y);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in MulOp<T> op, ref T x, in T y)
            where T : unmanaged        
                => ref op.apply(ref x,in y);

        [MethodImpl(Inline)]
        public static T apply<T>(in DivOp<T> op, T x, T y)
            where T : unmanaged        
                => op.apply(x,y);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in DivOp<T> op, ref T x, in T y)
            where T : unmanaged        
                => ref op.apply(ref x,in y);

        [MethodImpl(Inline)]
        public static T apply<T>(in ModOp<T> op, T x, T y)
            where T : unmanaged        
                => op.apply(x,y);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in ModOp<T> op, ref T x, in T y)
            where T : unmanaged        
                => ref op.apply(ref x,in y);

        [MethodImpl(Inline)]
        public static T apply<T>(in AbsOp<T> op, T x)
            where T : unmanaged        
                => op.apply(x);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in AbsOp<T> op, ref T x)
            where T : unmanaged        
                => ref op.apply(ref x);

        [MethodImpl(Inline)]
        public static T apply<T>(in IncOp<T> op, T x)
            where T : unmanaged        
                => op.apply(x);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in IncOp<T> op, ref T x)
            where T : unmanaged        
                => ref op.apply(ref x);

        [MethodImpl(Inline)]
        public static T apply<T>(in DecOp<T> op, T x)
            where T : unmanaged        
                => op.apply(x);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in DecOp<T> op, ref T x)
            where T : unmanaged        
                => ref op.apply(ref x);

        [MethodImpl(Inline)]
        public static T apply<T>(in NegateOp<T> op, T x)
            where T : unmanaged        
                => op.apply(x);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in NegateOp<T> op, ref T x)
            where T : unmanaged        
                => ref op.apply(ref x);

        [MethodImpl(Inline)]
        public static T apply<T>(in FlipOp<T> op, T x)
            where T : unmanaged        
                => op.apply(x);

        [MethodImpl(Inline)]
        public static ref T apply<T>(in FlipOp<T> op, ref T x)
            where T : unmanaged        
                => ref op.apply(ref x);


    }

}