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

    public struct AddOp<T>
        where T : unmanaged        
    {
        public static readonly AddOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x, T y)
            => gmath.add(x,y);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x, in T y)
            => ref gmath.add(ref x, y);

    }

    public struct SubOp<T>
        where T : unmanaged        
    {
        public static readonly SubOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x, T y)
            => gmath.sub(x,y);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x, in T y)
            => ref gmath.sub(ref x, in y);
    }


    public struct MulOp<T>
        where T : unmanaged        
    {
        public static readonly MulOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x, T y)
            => gmath.mul(x,y);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x, in T y)
            => ref gmath.mul(ref x, y);
    }

    public struct DivOp<T>
        where T : unmanaged        
    {
        public static readonly DivOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x, T y)
            => gmath.div(x,y);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x, in T y)
            => ref gmath.div(ref x,y);
    }

    public struct ModOp<T>
        where T : unmanaged        
    {
        public static readonly ModOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x, T y)
            => gmath.mod(x,y);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x,in T y)
            => ref gmath.mod(ref x,y);

    }

   public struct AbsOp<T>
        where T : unmanaged        
    {
        public static readonly AbsOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x)
            => gmath.abs(x);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x)
            => ref gmath.abs(ref x);
    }

    public struct IncOp<T>
        where T : unmanaged        
    {
        public static readonly IncOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x)
            => gmath.inc(x);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x)
            => ref gmath.inc(ref x);

    }

    public struct DecOp<T>
        where T : unmanaged        
    {
        public static readonly DecOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x)
            => gmath.dec(x);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x)
            => ref gmath.dec(ref x);

    }

    public struct NegateOp<T>
        where T : unmanaged        
    {
        public static readonly NegateOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x)
            => gmath.negate(x);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x)
            => ref gmath.negate(ref x);
    }

    public struct FlipOp<T>
        where T : unmanaged        
    {
        public static readonly FlipOp<T> TheOnly = default;

        [MethodImpl(Inline)]
        public readonly T apply(T x)
            => gmath.flip(x);

        [MethodImpl(Inline)]
        public readonly ref T apply(ref T x)
            => ref gmath.flip(ref x);
    }
}