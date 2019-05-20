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


    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct U8
    {
        public static Span<U8> Many(params byte[] src)
        {
            var dst = span<U8>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator U8(byte src)
            => new U8(src);

        [MethodImpl(Inline)]
        public static implicit operator U8(uint src)
            => new U8(src);

        [MethodImpl(Inline)]
        public static U8 operator +(U8 lhs, U8 rhs)
            => lhs.Add(rhs.src);

        [MethodImpl(Inline)]
        public static U8 operator -(U8 lhs, U8 rhs)
            => lhs.Sub(rhs.src);

        [MethodImpl(Inline)]
        public static U8 operator *(U8 lhs, U8 rhs)
            => lhs.Mul(rhs.src);

        [MethodImpl(Inline)]
        public static U8 operator /(U8 lhs, U8 rhs)
            => lhs.Div(rhs.src);

        [MethodImpl(Inline)]
        public static U8 operator %(U8 lhs, U8 rhs)
            => lhs.Mod(rhs.src);
        
        [MethodImpl(Inline)]
        public static U8 operator &(U8 lhs, U8 rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static U8 operator |(U8 lhs, U8 rhs)
            => lhs.Or(rhs.src);

        [MethodImpl(Inline)]
        public static U8 operator ^(U8 lhs, U8 rhs)
            => lhs.XOr(rhs.src);

        [MethodImpl(Inline)]
        public static U8 operator <<(U8 lhs, int rhs)
            => lhs.LShift(rhs);

        [MethodImpl(Inline)]
        public static U8 operator >>(U8 lhs, int rhs)
            => lhs.RShift(rhs);

        [MethodImpl(Inline)]
        public static U8 operator ~(U8 src)
            => src.Flip();

        [MethodImpl(Inline)]
        public static U8 operator ++(U8 src)
            => src.Inc();

        [MethodImpl(Inline)]
        public static U8 operator --(U8 src)
            => src.Dec();

        [MethodImpl(Inline)]
        public static bool operator ==(U8 lhs, U8 rhs)
            => lhs.src == rhs.src;

        [MethodImpl(Inline)]
        public static bool operator !=(U8 lhs, U8 rhs)
            => lhs.src != rhs.src;

        [MethodImpl(Inline)]
        public static bool operator >(U8 lhs, U8 rhs)
            => lhs.src > rhs.src;

        [MethodImpl(Inline)]
        public static bool operator <(U8 lhs, U8 rhs)
            => lhs.src < rhs.src;

        [MethodImpl(Inline)]
        public static bool operator >=(U8 lhs, U8 rhs)
            => lhs.src >= rhs.src;

        [MethodImpl(Inline)]
        public static bool operator <=(U8 lhs, U8 rhs)
            => lhs.src <= rhs.src;

        [MethodImpl(Inline)]
        public static U8 operator +(U8 lhs, byte rhs)
            => lhs.Add(rhs);

        [MethodImpl(Inline)]
        public static U8 operator -(U8 lhs, byte rhs)
            => lhs.Sub(rhs);

        [MethodImpl(Inline)]
        public static U8 operator *(U8 lhs, byte rhs)
            => lhs.Mul(rhs);

        [MethodImpl(Inline)]
        public static U8 operator /(U8 lhs, byte rhs)
            => lhs.Div(rhs);

        [MethodImpl(Inline)]
        public static U8 operator %(U8 lhs, byte rhs)
            => lhs.Mod(rhs);

        [MethodImpl(Inline)]
        public static U8 operator &(U8 lhs, byte rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static U8 operator |(U8 lhs, byte rhs)
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static U8 operator ^(U8 lhs, byte rhs)
            => lhs.XOr(rhs);


        [MethodImpl(Inline)]
        public static bool operator ==(U8 lhs, byte rhs)
            => lhs.src == rhs;

        [MethodImpl(Inline)]
        public static bool operator !=(U8 lhs, byte rhs)
            => lhs.src == rhs;
        
        [MethodImpl(Inline)]
        public static bool operator >(U8 lhs, byte rhs)
            => lhs.src > rhs;

        [MethodImpl(Inline)]
        public static bool operator <(U8 lhs, byte rhs)
            => lhs.src < rhs;

        [MethodImpl(Inline)]
        public static bool operator >=(U8 lhs, byte rhs)
            => lhs.src >= rhs;

        [MethodImpl(Inline)]
        public static bool operator <=(U8 lhs, byte rhs)
            => lhs.src <= rhs;

        [FieldOffset(0)]
        public byte src;
                    

        [FieldOffset(0)]
        public byte x000;

        [MethodImpl(Inline)]
        U8(uint src)
        {
            this.src = 0;
            this.x000 = 0;
        }

        [MethodImpl(Inline)]
        public U8(byte src)
        {
            this.src = 0;
            this.x000 = 0;
        }
                
        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object lhs)
            => throw new NotSupportedException();
    }


}