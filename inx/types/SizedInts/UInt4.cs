//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Constants;

    /// <summary>
    /// Defines a four-bit unsigned integer
    /// </summary>
    public ref struct UInt4
    {   
        const byte MinValue = 0x0;     
        
        const byte MaxValue = 0xF;
        
        byte value;
        
        [MethodImpl(Inline)]
        public static explicit operator UInt4(byte src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static explicit operator UInt4(int src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(UInt4 src)
            => src.value;

        [MethodImpl(Inline)]
        public static UInt4 operator &(UInt4 lhs, UInt4 rhs)
            => new UInt4(lhs.value & rhs.value);

        [MethodImpl(Inline)]
        public static UInt4 operator |(UInt4 lhs, UInt4 rhs)
            => new UInt4(lhs.value | rhs.value);

        [MethodImpl(Inline)]
        public static UInt4 operator ^(UInt4 lhs, UInt4 rhs)
            => new UInt4(lhs.value ^ rhs.value);

        [MethodImpl(Inline)]
        public static UInt4 operator >>(UInt4 lhs, int rhs)
            => new UInt4(lhs.value >> rhs);

        [MethodImpl(Inline)]
        public static UInt4 operator <<(UInt4 lhs, int rhs)
            => new UInt4(lhs.value << rhs);

        [MethodImpl(Inline)]
        public static UInt4 operator ~(UInt4 src)
            => new UInt4(~src.value);

        [MethodImpl(Inline)]
        public static UInt4 FromLo(byte src)        
            => new UInt4(src & MaxValue);

        [MethodImpl(Inline)]
        public static UInt4 FromLo(int src)        
            => new UInt4((byte)src & MaxValue);

        [MethodImpl(Inline)]
        public static UInt4 FromHi(byte src)        
            => new UInt4((src >> 4) & MaxValue);
        
        [MethodImpl(Inline)]
        UInt4(int src)
            => value = (byte) src;
        
        [MethodImpl(Inline)]
        UInt4(byte value)
            => this.value = value;     

        [MethodImpl(Inline)]
        public bool Test(in int pos)
            => pos < 4 ?  (value & (1 << pos)) != 0 : false;
        
        [MethodImpl(Inline)]
        public void Enable(in int pos)
        {
            if(pos < 4)
                value |= (byte)(1 << pos);
        }

        [MethodImpl(Inline)]
        public void disable(in int pos)
        {
            if(pos < 4)
                value =  ~ (UInt4)(1 << pos);
        }
    }

}