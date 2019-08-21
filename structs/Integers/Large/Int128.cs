//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct Int128
    {
        [FieldOffset(0)]
        public long lo;

        [FieldOffset(8)]
        public long hi;

       [FieldOffset(0)]
        public uint x00;

        [FieldOffset(4)]
        public uint x01;

        [FieldOffset(8)]
        public uint x10;

        [FieldOffset(12)]
        public uint x11;

        [FieldOffset(0)]
        public ushort x000;

        [FieldOffset(2)]
        public ushort x001;

        [FieldOffset(4)]
        public ushort x010;

        [FieldOffset(6)]
        public ushort x011;

        [FieldOffset(8)]
        public ushort x100;

        [FieldOffset(10)]
        public ushort x101;

        [FieldOffset(12)]
        public ushort x110;

        [FieldOffset(12)]
        public ushort x111;

        [FieldOffset(0)]        
        public byte x0000;
        
        [FieldOffset(1)]
        public byte x0001;
        
        [FieldOffset(2)]
        public byte x0010;
        
        [FieldOffset(3)]
        public byte x0011;

        [FieldOffset(4)]
        public byte x0100;
        
        [FieldOffset(5)]
        public byte x0101;
        
        [FieldOffset(6)]
        public byte x0110;
        
        [FieldOffset(7)]
        public byte x0111;

        [FieldOffset(8)]        
        public byte x1000;
        
        [FieldOffset(9)]
        public byte x1001;
        
        [FieldOffset(10)]
        public byte x1010;
        
        [FieldOffset(11)]
        public byte x1011;

        [FieldOffset(12)]
        public byte x1100;
        
        [FieldOffset(13)]
        public byte x1101;
        
        [FieldOffset(14)]
        public byte x1110;
        
        [FieldOffset(15)]
        public byte x1111;

        [MethodImpl(Inline)]
        public static Int128 Define(long x0, long x1)        
            => new Int128(x0, x1);
        
        [MethodImpl(Inline)]
        public static bool operator ==(Int128 lhs, Int128 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Int128 lhs, Int128 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static Int128 operator |(Int128 lhs, Int128 rhs)
            => Define(lhs.lo | rhs.lo, lhs.hi | rhs.hi);

        [MethodImpl(Inline)]
        public static Int128 operator &(Int128 lhs, Int128 rhs)
            => Define(lhs.lo & rhs.lo, lhs.hi & rhs.hi);

        [MethodImpl(Inline)]
        public static Int128 operator ^(Int128 lhs, Int128 rhs)
            => Define(lhs.lo ^ rhs.lo, lhs.hi ^ rhs.hi);

        [MethodImpl(Inline)]
        public static Int128 operator ~(Int128 src)
            => Define(~ src.lo, ~ src.hi);

        [MethodImpl(Inline)]
        public Int128(long x0, long x1)
            : this()
        {
            this.lo = x0;
            this.hi = x1;

        }         
 
        [MethodImpl(Inline)]
        public bool Equals(Int128 lhs)
            => lo == lhs.lo && hi == lhs.hi;

        public override bool Equals(object obj)
            => obj is Int128 x ? Equals(x) : false;

        public override int GetHashCode()
            => HashCode.Combine(lo,hi);
       
    }


}