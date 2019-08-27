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
    public struct UInt128
    {
        [FieldOffset(0)]
        public ulong lo;

        [FieldOffset(8)]
        public ulong hi;

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
        public static UInt128 Define(ulong x0, ulong x1)
            => new UInt128(x0, x1);

        [MethodImpl(Inline)]
        public static bool operator ==(UInt128 lhs, UInt128 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in UInt128 lhs, in UInt128 rhs)
            => !lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static UInt128 operator ~(UInt128 src)
            => Define(~ src.lo, ~ src.hi);

        [MethodImpl(Inline)]
        public static implicit operator UInt128(ulong src)
            => new UInt128(src, 0ul);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(in UInt128 src)
            => Vector128.Create(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static implicit operator Vec128<ulong>(in UInt128 src)
            => Vector128.Create(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static implicit operator UInt128(in Vector128<ulong> src)
            => Unsafe.As<Vector128<ulong>,UInt128>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static implicit operator UInt128(in Vec128<ulong> src)
            => Unsafe.As<Vec128<ulong>, UInt128>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static explicit operator ulong(in UInt128 src)
            => src.lo;

        [MethodImpl(Inline)]
        public UInt128(ulong lo, ulong hi)
            : this()
        {
            this.lo = lo;
            this.hi = hi;                                        
        }
            
        [MethodImpl(Inline)]
        public bool Equals(UInt128 lhs)
            => lo == lhs.lo && hi == lhs.hi;

        public override bool Equals(object obj)
            => obj is UInt128 x ? Equals(x) : false;

        public override int GetHashCode()
            => HashCode.Combine(lo,hi);
        
        public override string ToString() 
        {
            var str = string.Empty;
            if(hi != 0)
                str = "0x" + hi.ToString("X") + " "; 
            str += ("0x" +  lo.ToString("X"));            
            return str;
        }
        
    }    

}