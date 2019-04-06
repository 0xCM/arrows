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

    public interface Bit<S> : IComparable<S>, Equatable<S>, Formattable
        where S : Bit<S>, new()
    {

    }

    public static class Bit
    {
        [MethodImpl(Inline)]
        public static bit read(byte src, int pos)
            => Bits.test(src,pos);

        [MethodImpl(Inline)]
        public static bit read(sbyte src, int pos)
            => Bits.test(src,pos);

        [MethodImpl(Inline)]
        public static bit read(short src, int pos)
            => Bits.test(src,pos);

        [MethodImpl(Inline)]
        public static bit read(ushort src, int pos)
            => Bits.test(src,pos);

        [MethodImpl(Inline)]
        public static bit read(int src, int pos)
            => Bits.test(src,pos);

        [MethodImpl(Inline)]
        public static bit read(uint src, int pos)
            => Bits.test(src,pos);

        [MethodImpl(Inline)]
        public static bit read(long src, int pos)
            => Bits.test(src,pos);

        [MethodImpl(Inline)]
        public static bit read(ulong src, int pos)
            => Bits.test(src,pos);

    }

    /// <summary>
    /// Represents a numeric or logical bit
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Boolean_algebra</remarks>
    public readonly struct bit : Bit<bit>, Wrapped<bool>
    {

        public static bit Parse(char c)
            => c != '0' ? One : Zero;
        
        public static readonly bit Zero = false;

        public static readonly bit One = true;

        [MethodImpl(Inline)]
        public static implicit operator bool(bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator bit(bool src)
            => new bit(src);
        
        [MethodImpl(Inline)]
        public static explicit operator byte(bit src)
            => src.value ? (byte)1 : (byte)0;

        [MethodImpl(Inline)]
        public static explicit operator ushort(bit src)
            => src.value ? (ushort)1 : (ushort)0;

        [MethodImpl(Inline)]
        public static explicit operator uint(bit src)
            => src.value ? 1u : 0u;

        [MethodImpl(Inline)]
        public static explicit operator ulong(bit src)
            => src.value ? 1ul : 0ul;

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
        public bit(bool value)        
            => this.value = value;


        [MethodImpl(Inline)]
        public bool unwrap()
            => value;

        [MethodImpl(Inline)]
        public bit(byte value, int pos = 0)        
            => this.value = Bits.test(value,pos);

        [MethodImpl(Inline)]
        public int CompareTo(bit rhs)
            => value.CompareTo(rhs);

        readonly bool value;

        [MethodImpl(Inline)]
        public bool eq(bit rhs)
            => value == rhs.value;

        [MethodImpl(Inline)]
        public bool neq(bit rhs)
            => value != rhs.value;

        [MethodImpl(Inline)]
        public bool eq(bit lhs, bit rhs)
            => lhs.value == rhs.value;

        [MethodImpl(Inline)]
        public bool neq(bit lhs, bit rhs)
            => lhs.value != rhs.value;

        [MethodImpl(Inline)]
        public string format()
            => value == true ? "1" : "0";

        [MethodImpl(Inline)]
        public intg<T> ToIntG<T>()
            => value ? intg<T>.One : intg<T>.Zero;

        [MethodImpl(Inline)]
        public int hash()
            => value == true ? 1 : 0;

        [MethodImpl(Inline)]
        public bool Equals(bit rhs)
            => value == rhs.value;

        public override bool Equals(object rhs)
            => rhs is bit ? Equals((bit)rhs) : false;

        public override int GetHashCode()
            => hash();
    
        public override string ToString()
            => format();
    }
}