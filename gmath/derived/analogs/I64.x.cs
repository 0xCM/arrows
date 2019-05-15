//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static mfunc;

    public static class I64x
    {
        [MethodImpl(Inline)]
        public static ref I64 Add(this ref I64 lhs, in I64 rhs)
        {
            lhs.src += rhs.src;
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref I64 Sub(this ref I64 lhs, in I64 rhs)
        {
            lhs.src -= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 Mul(this ref I64 lhs, in I64 rhs)
        {
            lhs.src *= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 Div(this ref I64 lhs, in I64 rhs)
        {
            lhs.src /= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 Mod(this ref I64 lhs, in I64 rhs)
        {
            lhs.src %= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 And(this ref I64 lhs, in I64 rhs)
        {
            lhs.src &= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 Or(this ref I64 lhs, in I64 rhs)
        {
            lhs.src |= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 XOr(this ref I64 lhs, in I64 rhs)
        {
            lhs.src |= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 LShift(this ref I64 lhs, int rhs)
        {
            lhs.src <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 RShift(this ref I64 lhs, int rhs)
        {
            lhs.src >>= rhs;
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref I64 Flip(this ref I64 lhs)
        {
            lhs.src = (byte)~lhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 Inc(this ref I64 lhs)
        {
            ++lhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref I64 Dec(this ref I64 lhs)
        {
            --lhs.src;
            return ref lhs;
        }


    }    
}