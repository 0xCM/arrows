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
    public ref struct Quartet
    {   
        const byte MinValue = 0x0;     
        
        const byte MaxValue = 0xF;
        
        byte value;
        
        [MethodImpl(Inline)]
        public static explicit operator Quartet(byte src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static explicit operator Quartet(int src)
            => FromLo(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(Quartet src)
            => src.value;

        [MethodImpl(Inline)]
        public static Quartet operator &(Quartet lhs, Quartet rhs)
            => new Quartet(lhs.value & rhs.value);

        [MethodImpl(Inline)]
        public static Quartet operator |(Quartet lhs, Quartet rhs)
            => new Quartet(lhs.value | rhs.value);

        [MethodImpl(Inline)]
        public static Quartet operator ^(Quartet lhs, Quartet rhs)
            => new Quartet(lhs.value ^ rhs.value);

        [MethodImpl(Inline)]
        public static Quartet operator >>(Quartet lhs, int rhs)
            => new Quartet(lhs.value >> rhs);

        [MethodImpl(Inline)]
        public static Quartet operator <<(Quartet lhs, int rhs)
            => new Quartet(lhs.value << rhs);

        [MethodImpl(Inline)]
        public static Quartet operator ~(Quartet src)
            => new Quartet(~src.value);

        [MethodImpl(Inline)]
        public static Quartet FromLo(byte src)        
            => new Quartet(src & MaxValue);

        [MethodImpl(Inline)]
        public static Quartet FromLo(int src)        
            => new Quartet((byte)src & MaxValue);

        [MethodImpl(Inline)]
        public static Quartet FromHi(byte src)        
            => new Quartet((src >> 4) & MaxValue);
        
        [MethodImpl(Inline)]
        Quartet(int src)
            => value = (byte) src;
        
        [MethodImpl(Inline)]
        Quartet(byte value)
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
                value =  ~ (Quartet)(1 << pos);
        }
    }

}