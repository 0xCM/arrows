//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    /// <summary>
    /// Represents a numeric or logical bit
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Boolean_algebra</remarks>
    public readonly struct bit : IComparable<bit>, Structure.Equatable<bit>, Operative.Equatable<bit>
    {

        public static bit Zero = false;

        public static bit One = true;

        [MethodImpl(Inline)]
        public static implicit operator bool(bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator bit(bool src)
            => new bit(src);
        
        [MethodImpl(Inline)]
        public static implicit operator BinaryDigit(bit src)
            => src.value ? BinaryDigit.B1 : BinaryDigit.B0;

        [MethodImpl(Inline)]
        public static implicit operator bit(BinaryDigit src)
            => new bit(src == BinaryDigit.B1);

        [MethodImpl(Inline)]
        public static bool operator true(bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static bool operator false(bit src)
            => !src.value;

        [MethodImpl(Inline)]
        public static bool operator ==(bit lhs, bit rhs)
            => lhs.value == rhs.value;

        [MethodImpl(Inline)]
        public static bool operator !=(bit lhs, bit rhs)
            => lhs.value != rhs.value;

        [MethodImpl(Inline)]
        public static bit operator & (bit lhs, bit rhs) 
            => lhs.value & rhs.value;

        [MethodImpl(Inline)]
        public static bit operator | (bit lhs, bit rhs) 
            => lhs.value | rhs.value;

        [MethodImpl(Inline)]
        public static bit operator ^ (bit lhs, bit rhs) 
            => lhs.value ^ rhs.value;


        [MethodImpl(Inline)]
        public static bit operator + (bit lhs, bit rhs) 
            => (lhs.value,rhs.value) switch
                {
                    (true, true) => false,
                    (false, false) => false,
                    (false, true) => true,
                    (true, false) => true
                };

        [MethodImpl(Inline)]
        public static bit operator * (bit lhs, bit rhs) 
            => (lhs.value,rhs.value) switch
                {
                    (true, true) => true,
                    (false, false) => false,
                    (false, true) => false,
                    (true, false) => false
                };


        [MethodImpl(Inline)]
        public static bit operator - (bit x) 
            => !x;

        [MethodImpl(Inline)]
        public static bit operator ~ (bit x) 
            => ~ x;

        [MethodImpl(Inline)]
        public static bit operator ! (bit x) 
            => ! x;

        [MethodImpl(Inline)]
        public bit(bool value)        
            => this.value = value;
        
        [MethodImpl(Inline)]
        public int CompareTo(bit rhs)
            => value.CompareTo(rhs);

        [MethodImpl(Inline)]
        public bool Equals(bit rhs)
            => value == rhs.value;

        public bool value {get;}

        public override bool Equals(object rhs)
            => rhs is bit ? Equals((bit)rhs) : false;

        public override int GetHashCode()
            => value ? 1 : 0;
    
        public override string ToString()
            => (value ? 1 : 0).ToString();

        public bool eq(bit rhs)
            => this.value == rhs.value;

        public bool neq(bit rhs)
            => not(eq(rhs));

        bool Operative.Equatable<bit>.eq(bit lhs, bit rhs)
            => lhs.eq(rhs);

        bool Operative.Equatable<bit>.neq(bit lhs, bit rhs)
            => lhs.neq(rhs);
    }


}