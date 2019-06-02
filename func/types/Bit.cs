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
            => src.value ? U8One : U8Zero;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Bit src)
            => src.value ? U16One : U16Zero;

        [MethodImpl(Inline)]
        public static explicit operator int(Bit src)
            => src.value ? I32One : I32Zero;

        [MethodImpl(Inline)]
        public static explicit operator uint(Bit src)
            => src.value ? U32One : U32Zero;

        [MethodImpl(Inline)]
        public static explicit operator long(Bit src)
            => src.value ? I64One : I64Zero;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Bit src)
            => src.value ? U64One : U64Zero;

        [MethodImpl(Inline)]
        public static implicit operator Bit(sbyte src)
            => src == I8Zero ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(byte src)
            => src == U8Zero ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(short src)
            => src == I16Zero ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(ushort src)
            => src == U16Zero ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(int src)
            => src == I32Zero ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(uint src)
            => src == U32Zero ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(long src)
            => src == I64Zero ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(ulong src)
            => src == U64Zero ? Off : On;

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
            => value ? I32One : I32Zero;
    
        [MethodImpl(Inline)]
        public override string ToString()
            => value  ? OneS : ZeroS;
    }
}