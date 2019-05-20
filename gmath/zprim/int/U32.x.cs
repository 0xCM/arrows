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

    public static class U32x
    {
        [MethodImpl(Inline)]
        public static ref U32 Add(this ref U32 lhs, in U32 rhs)
        {
            lhs.src += rhs.src;
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref U32 Sub(this ref U32 lhs, in U32 rhs)
        {
            lhs.src -= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 Mul(this ref U32 lhs, in U32 rhs)
        {
            lhs.src *= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 Div(this ref U32 lhs, in U32 rhs)
        {
            lhs.src /= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 Mod(this ref U32 lhs, in U32 rhs)
        {
            lhs.src %= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 And(this ref U32 lhs, in U32 rhs)
        {
            lhs.src &= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 Or(this ref U32 lhs, in U32 rhs)
        {
            lhs.src |= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 XOr(this ref U32 lhs, in U32 rhs)
        {
            lhs.src |= rhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 LShift(this ref U32 lhs, int rhs)
        {
            lhs.src <<= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 RShift(this ref U32 lhs, int rhs)
        {
            lhs.src >>= rhs;
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref U32 Flip(this ref U32 lhs)
        {
            lhs.src = (byte)~lhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 Inc(this ref U32 lhs)
        {
            ++lhs.src;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref U32 Dec(this ref U32 lhs)
        {
            --lhs.src;
            return ref lhs;
        }


    }    
}