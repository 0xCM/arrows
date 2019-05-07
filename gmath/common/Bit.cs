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

    using static zcore;
    using static zfunc;
    using static mfunc;

    public interface Bit<S> : IComparable<S>, IEquatable<S>
        where S : Bit<S>, new()
    {

    }

    /// <summary>
    /// Represents a numeric or logical bit
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Boolean_algebra</remarks>
    public readonly struct bit : IEquatable<bit> 
    {
        public static readonly bit Off = false;

        public static readonly bit On = true;

        public static bit Read(byte src, byte pos)
            => ((src >> pos) & 1) != 0;

        /// <summary>
        /// Parses the bits from a string of bit characters
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bit[] Parse(string src)
        {
            var dst = alloc<bit>(src.Length);            
            for(var i = 0; i< src.Length; i++)
                dst[i] = Z0.bit.Parse(src[i]);
            return dst;
            
        }

        /// <summary>
        /// Parses a bit from a character
        /// </summary>
        /// <param name="c">The source value</param>
        public static bit Parse(char c)
            => c != '0' ? On : Off;
        
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
        public static implicit operator bit(sbyte src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator bit(byte src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator bit(short src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator bit(ushort src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator bit(int src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator bit(uint src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator bit(long src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator bit(ulong src)
            => src == 0 ? Off : On;

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
        public static bit operator ~ (bit src) 
            => src.flip();

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

        public bit flip()
            => ! value;

        [MethodImpl(Inline)]
        public string format()
            => value == true ? "1" : "0";


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