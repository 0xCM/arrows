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


    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct I64 
    {
        public const int MinIndex = 0;
        
        public const int MaxIndex = 7;

        public static Span<I64> Many(params long[] src)
        {
            var dst = span<I64>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }
        
        public static implicit operator I64(long src)
            => new I64(src);

        [MethodImpl(Inline)]
        public static I64 operator +(I64 lhs, I64 rhs)
            => lhs.Add(rhs.src);

        [MethodImpl(Inline)]
        public static I64 operator -(I64 lhs, I64 rhs)
            => lhs.Sub(rhs.src);

        [MethodImpl(Inline)]
        public static I64 operator *(I64 lhs, I64 rhs)
            => lhs.Mul(rhs.src);

        [MethodImpl(Inline)]
        public static I64 operator /(I64 lhs, I64 rhs)
            => lhs.Div(rhs.src);

        [MethodImpl(Inline)]
        public static I64 operator %(I64 lhs, I64 rhs)
            => lhs.Mod(rhs.src);
        
        [MethodImpl(Inline)]
        public static I64 operator &(I64 lhs, I64 rhs)
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static I64 operator |(I64 lhs, I64 rhs)
            => lhs.Or(rhs.src);

        [MethodImpl(Inline)]
        public static I64 operator ^(I64 lhs, I64 rhs)
            => lhs.XOr(rhs.src);

        [MethodImpl(Inline)]
        public static I64 operator <<(I64 lhs, int rhs)
            => lhs.LShift(rhs);

        [MethodImpl(Inline)]
        public static I64 operator >>(I64 lhs, int rhs)
            => lhs.RShift(rhs);

        [MethodImpl(Inline)]
        public static I64 operator ~(I64 src)
            => src.Flip();

        [MethodImpl(Inline)]
        public static I64 operator ++(I64 src)
            => src.Inc();

        [MethodImpl(Inline)]
        public static I64 operator --(I64 src)
            => src.Dec();

        [MethodImpl(Inline)]
        public static bool operator ==(I64 lhs, I64 rhs)
            => lhs.src == rhs.src;

        [MethodImpl(Inline)]
        public static bool operator !=(I64 lhs, I64 rhs)
            => lhs.src != rhs.src;

        [MethodImpl(Inline)]
        public static bool operator >(I64 lhs, I64 rhs)
            => lhs.src > rhs.src;

        [MethodImpl(Inline)]
        public static bool operator <(I64 lhs, I64 rhs)
            => lhs.src < rhs.src;

        [MethodImpl(Inline)]
        public static bool operator >=(I64 lhs, I64 rhs)
            => lhs.src >= rhs.src;

        [MethodImpl(Inline)]
        public static bool operator <=(I64 lhs, I64 rhs)
            => lhs.src <= rhs.src;

        [MethodImpl(Inline)]    
        public I64(long src)
        {
            this.x000 = 0;
            this.x001 = 0;
            this.x010 = 0;
            this.x011 = 0;
            this.x100 = 0;
            this.x101 = 0;
            this.x110 = 0;
            this.x111 = 0;
            this.x00 = 0;
            this.x01 = 0;
            this.x10 = 0;
            this.x11 = 0;
            this.x0 = 0;
            this.x1 = 0;
            this.src = src;
        }

        [FieldOffset(0)]
        public long src;
        
        [FieldOffset(0)]
        public U32 x0;

        [FieldOffset(4)]
        public U32 x1;

        [FieldOffset(0)]
        public U16 x00;

        [FieldOffset(2)]
        public U16 x01;

        [FieldOffset(4)]
        public U16 x10;

        [FieldOffset(6)]
        public U16 x11;

        [FieldOffset(0)]        
        public byte x000;
        
        [FieldOffset(1)]
        public byte x001;
        
        [FieldOffset(2)]
        public byte x010;
        
        [FieldOffset(3)]
        public byte x011;

        [FieldOffset(4)]
        public byte x100;
        
        [FieldOffset(5)]
        public byte x101;
        
        [FieldOffset(6)]
        public byte x110;
        
        [FieldOffset(7)]
        public byte x111;
 
 
        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object lhs)
            => throw new NotSupportedException();
 
    }



}