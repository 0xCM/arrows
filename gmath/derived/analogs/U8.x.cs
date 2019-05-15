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

    public static class U8x
    {
        [MethodImpl(Inline)]
        public static ref U8 Add(this ref U8 lhs, in U8 rhs)
        {
            lhs.src += rhs.src;
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref U8 Sub(this ref U8 lhs, in U8 rhs)
        {
            lhs.src -= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 Mul(this ref U8 lhs, in U8 rhs)
        {
            lhs.src *= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 Div(this ref U8 lhs, in U8 rhs)
        {
            lhs.src /= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 Mod(this ref U8 lhs, in U8 rhs)
        {
            lhs.src %= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 And(this ref U8 lhs, in U8 rhs)
        {
            lhs.src &= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 Or(this ref U8 lhs, in U8 rhs)
        {
            lhs.src |= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 XOr(this ref U8 lhs, in U8 rhs)
        {
            lhs.src |= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 LShift(this ref U8 lhs, int rhs)
        {
            lhs.src <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 RShift(this ref U8 lhs, int rhs)
        {
            lhs.src >>= rhs;
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref U8 Flip(this ref U8 lhs)
        {
            lhs.src = (byte)~lhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 Inc(this ref U8 lhs)
        {
            ++lhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U8 Dec(this ref U8 lhs)
        {
            --lhs.src;
            return ref lhs;
        }


    }    
}