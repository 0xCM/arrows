//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    /// <summary>
    /// Represents a numeric or logical bit
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Boolean_algebra</remarks>
    public readonly struct Bit
    {
        [MethodImpl(Inline)]
        public static char And(char lhs, char rhs)
            => (lhs == One & rhs == One) ? One : Zero;

        [MethodImpl(Inline)]
        public static char Or(char lhs, char rhs)
            => (lhs == One | rhs == One) ? One : Zero;

        [MethodImpl(Inline)]
        public static char XOr(char lhs, char rhs)
            => (lhs == One ^ rhs == One) ? One : Zero;

        [MethodImpl(Inline)]
        public static char Flip(char src)
            => src == One ? Zero : One;

        readonly bool value;
        
        [MethodImpl(Inline)]
        public Bit(bool value)        
            => this.value = value;

        public static readonly Bit Off = false;

        public static readonly Bit On = true;

        public const char Zero = '0';

        public const char One = '1';

        const string ZeroS = "0";

        const string OneS = "1";
        

        public static Bit Parse(char c)
            => c == One;

        [MethodImpl(Inline)]
        public static implicit operator bool(Bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator Bit(bool src)
            => new Bit(src);

        [MethodImpl(Inline)]
        public static implicit operator char(Bit src)
            => src ? One : Zero;

        [MethodImpl(Inline)]
        public static explicit operator byte(Bit src)
            => src.value ? OneU8 : ZeroU8;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Bit src)
            => src.value ? OneU16 : ZeroU16;

        [MethodImpl(Inline)]
        public static explicit operator int(Bit src)
            => src.value ? OneI32 : ZeroI32;

        [MethodImpl(Inline)]
        public static explicit operator uint(Bit src)
            => src.value ? OneU32 : ZeroU32;

        [MethodImpl(Inline)]
        public static explicit operator long(Bit src)
            => src.value ? OneI64 : ZeroI64;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Bit src)
            => src.value ? OneU64 : ZeroU64;

        [MethodImpl(Inline)]
        public static implicit operator Bit(sbyte src)
            => src == ZeroI8 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(byte src)
            => src == ZeroU8 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(short src)
            => src == ZeroI16 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(ushort src)
            => src == ZeroU16 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(int src)
            => src == ZeroI32 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(uint src)
            => src == ZeroU32 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(long src)
            => src == ZeroI64 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(ulong src)
            => src == ZeroU64 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator BinaryDigit(Bit src)
            => src.value ? BinaryDigit.One : BinaryDigit.Zed;

        [MethodImpl(Inline)]
        public static implicit operator Bit(BinaryDigit src)
            => new Bit(src == BinaryDigit.One);

        [MethodImpl(Inline)]
        public static bool operator ==(Bit lhs, Bit rhs)
            => lhs.value == rhs.value;

        [MethodImpl(Inline)]
        public static bool operator !=(Bit lhs, Bit rhs)
            => lhs.value != rhs.value;

        [MethodImpl(Inline)]
        public static Bit operator & (Bit lhs, Bit rhs) 
            => lhs.value & rhs.value;

        [MethodImpl(Inline)]
        public static Bit operator | (Bit lhs, Bit rhs) 
            => lhs.value | rhs.value;

        [MethodImpl(Inline)]
        public static Bit operator ^ (Bit lhs, Bit rhs) 
            => lhs.value ^ rhs.value;

        [MethodImpl(Inline)]
        public static Bit operator ~ (Bit src) 
            => ! src.value;

        [MethodImpl(Inline)]
        public static Bit operator ! (Bit src) 
            => !src.value;

        [MethodImpl(Inline)]
        public static bool operator true(Bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static bool operator false(Bit src)
            => !src.value;

        [MethodImpl(Inline)]
        public static Bit operator + (Bit lhs, Bit rhs) 
            => (lhs.value,rhs.value) switch
                {
                    (true, true) => false,
                    (false, false) => false,
                    (false, true) => true,
                    (true, false) => true
                };

        [MethodImpl(Inline)]
        public static Bit operator * (Bit lhs, Bit rhs) 
            => (lhs.value,rhs.value) switch
                {
                    (true, true) => true,
                    (false, false) => false,
                    (false, true) => false,
                    (true, false) => false
                };


        [MethodImpl(Inline)]
        public bool Equals(Bit rhs)
            => value == rhs.value;

        [MethodImpl(Inline)]
        public override bool Equals(object rhs)
            => rhs is Bit ? Equals((Bit)rhs) : false;

        [MethodImpl(Inline)]
        public override int GetHashCode()
            => value ? OneI32 : ZeroI32;
    
        [MethodImpl(Inline)]
        public override string ToString()
            => value  ? OneS : ZeroS;
    }
}