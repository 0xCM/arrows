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
    public unsafe struct UInt128
    {
        /// <summary>
        /// The 128-bit zero value
        /// </summary>
        public static readonly UInt128 Zero = new UInt128(0,0);

        /// <summary>
        /// The 128-bit one value
        /// </summary>
        public static readonly UInt128 One = new UInt128(1,0);

        /// <summary>
        /// The minimum value the type can represent
        /// </summary>
        public static readonly UInt128 MinVal = Zero;

        /// <summary>
        /// The maximum value the type can represent
        /// </summary>
        public static readonly UInt128 MaxVal = new UInt128(ulong.MaxValue, ulong.MinValue);

        /// <summary>
        /// Creates a new 128-bit integer with specifed lo/hi part values
        /// </summary>
        /// <param name="lo">The lo 64 bits</param>
        /// <param name="hi">The hi 64 bits</param>
        public static UInt128 From(ulong lo, ulong hi)
            => new UInt128(lo,hi);

        [FieldOffset(0)]
        public ulong lo;

        [FieldOffset(8)]
        public ulong hi;

        [FieldOffset(8)]
        fixed byte bytes[16];

        [FieldOffset(0)]
        uint x00;

        [FieldOffset(4)]
        uint x01;

        [FieldOffset(8)]
        uint x10;

        [FieldOffset(12)]
        uint x11;

        [FieldOffset(0)]
        ushort x000;

        [FieldOffset(2)]
        ushort x001;

        [FieldOffset(4)]
        ushort x010;

        [FieldOffset(6)]
        ushort x011;

        [FieldOffset(8)]
        ushort x100;

        [FieldOffset(10)]
        ushort x101;

        [FieldOffset(12)]
        ushort x110;

        [FieldOffset(12)]
        ushort x111;

        [FieldOffset(0)]        
        byte x0000;
        
        [FieldOffset(1)]
        byte x0001;
        
        [FieldOffset(2)]
        byte x0010;
        
        [FieldOffset(3)]
        byte x0011;

        [FieldOffset(4)]
        byte x0100;
        
        [FieldOffset(5)]
        byte x0101;
        
        [FieldOffset(6)]
        byte x0110;
        
        [FieldOffset(7)]
        byte x0111;

        [FieldOffset(8)]        
        byte x1000;
        
        [FieldOffset(9)]
        byte x1001;
        
        [FieldOffset(10)]
        byte x1010;
        
        [FieldOffset(11)]
        byte x1011;

        [FieldOffset(12)]
        byte x1100;
        
        [FieldOffset(13)]
        byte x1101;
        
        [FieldOffset(14)]
        byte x1110;
        
        [FieldOffset(15)]
        byte x1111;

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
        public static UInt128 operator ~(UInt128 src)
            => From(~ src.lo, ~ src.hi);

        [MethodImpl(Inline)]
        public static implicit operator UInt128(ulong src)
            => new UInt128(src, 0ul);


        [MethodImpl(Inline)]
        public static UInt128 operator ++(in UInt128 src)
        {
            src.Inc();
            return src;
        }

        [MethodImpl(Inline)]
        public static UInt128 operator --(in UInt128 src)
        {
            src.Dec();
            return src;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(UInt128 lhs, UInt128 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in UInt128 lhs, in UInt128 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public UInt128(ulong lo, ulong hi)
            : this()
        {
            this.lo = lo;
            this.hi = hi;                                        
        }

        /// <summary>
        /// Increments the value by one
        /// </summary>
        [MethodImpl(Inline)]
        public void Inc()   
        {
            if(lo != MaxVal)
                lo++;
            else
                hi++;
        }


        /// <summary>
        /// Decrements the value by one
        /// </summary>
        [MethodImpl(Inline)]
        public void Dec()   
        {
            if(hi != 0)
                hi--;
            else
                lo--;
        }

        /// <summary>
        /// Queries/manipulates an index-identified byte
        /// </summary>
        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref bytes[index];
        }

        [MethodImpl(Inline)]
        public bool Equals(UInt128 lhs)
            => lo == lhs.lo && hi == lhs.hi;

        public override bool Equals(object obj)
            => obj is UInt128 x && Equals(x);

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