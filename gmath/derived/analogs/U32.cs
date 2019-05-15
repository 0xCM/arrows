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


    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct U32 
    {
        public const int MinIndex = 0;
        
        public const int MaxIndex = 3;

        public static Span<U32> Many(params uint[] src)
        {
            var dst = span<U32>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }
        
        public static implicit operator U32(uint src)
            => new U32(src);

        [MethodImpl(Inline)]
        public static U32 operator +(U32 lhs, U32 rhs)
            => lhs.Add(rhs.src);

        [MethodImpl(Inline)]
        public static U32 operator -(U32 lhs, U32 rhs)
            => lhs.Sub(rhs.src);

        [MethodImpl(Inline)]
        public static U32 operator *(U32 lhs, U32 rhs)
            => lhs.Mul(rhs.src);

        [MethodImpl(Inline)]
        public static U32 operator /(U32 lhs, U32 rhs)
            => lhs.Div(rhs.src);

        [MethodImpl(Inline)]
        public static U32 operator %(U32 lhs, U32 rhs)
            => lhs.Mod(rhs.src);
        
        [MethodImpl(Inline)]
        public static U32 operator &(U32 lhs, U32 rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static U32 operator |(U32 lhs, U32 rhs)
            => lhs.Or(rhs.src);

        [MethodImpl(Inline)]
        public static U32 operator ^(U32 lhs, U32 rhs)
            => lhs.XOr(rhs.src);

        [MethodImpl(Inline)]
        public static U32 operator <<(U32 lhs, int rhs)
            => lhs.LShift(rhs);

        [MethodImpl(Inline)]
        public static U32 operator >>(U32 lhs, int rhs)
            => lhs.RShift(rhs);

        [MethodImpl(Inline)]
        public static U32 operator ~(U32 src)
            => src.Flip();

        [MethodImpl(Inline)]
        public static U32 operator ++(U32 src)
            => src.Inc();

        [MethodImpl(Inline)]
        public static U32 operator --(U32 src)
            => src.Dec();

        [MethodImpl(Inline)]
        public static bool operator ==(U32 lhs, U32 rhs)
            => lhs.src == rhs.src;

        [MethodImpl(Inline)]
        public static bool operator !=(U32 lhs, U32 rhs)
            => lhs.src != rhs.src;

        [MethodImpl(Inline)]
        public static bool operator >(U32 lhs, U32 rhs)
            => lhs.src > rhs.src;

        [MethodImpl(Inline)]
        public static bool operator <(U32 lhs, U32 rhs)
            => lhs.src < rhs.src;

        [MethodImpl(Inline)]
        public static bool operator >=(U32 lhs, U32 rhs)
            => lhs.src >= rhs.src;

        [MethodImpl(Inline)]
        public static bool operator <=(U32 lhs, U32 rhs)
            => lhs.src <= rhs.src;
                
        [MethodImpl(Inline)]
        public U32(uint x0)
        {
            this.x000 = 0;
            this.x001 = 0;
            this.x010 = 0;
            this.x011 = 0;
            this.x00 = 0;
            this.x01 = 0;
            this.src = x0;
        }

        [FieldOffset(0)]
        public uint src;

        [FieldOffset(0)]
        public U16 x00;

        [FieldOffset(2)]
        public U16 x01;
        
        [FieldOffset(0)]
        public byte x000;
        
        [FieldOffset(1)]
        public byte x001;
        
        [FieldOffset(2)]
        public byte x010;
        
        [FieldOffset(3)]
        public byte x011;

        public byte this[int offset]
        {
            [MethodImpl(Inline)]
            get =>
                offset == 0 ? x000 :
                offset == 1 ? x001 :
                offset == 2 ? x010 :
                offset == 3 ? x011 :
                    throw outOfRange(offset, MinIndex, MaxIndex);

            [MethodImpl(Inline)]
            set 
            {
                if(offset == 0)
                    x000 = value;
                else if(offset == 1)
                    x001 = value;
                else if(offset == 2)
                    x010 = value;
                else if (offset == 3)
                    x011 = value;
                else
                    throw outOfRange(offset, MinIndex, MaxIndex);
            } 
        }

        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object lhs)
            => throw new NotSupportedException();
    }
}