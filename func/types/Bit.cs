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
        public Bit(bool value)        
            => this.value = value;

        readonly bool value;

        public static readonly Bit Off = false;

        public static readonly Bit On = true;

        /// <summary>
        /// Parses the bits from a string of bit characters
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Bit[] Parse(string src)
        {
            var dst = alloc<Bit>(src.Length);            
            for(var i = 0; i< src.Length; i++)
                dst[i] = Parse(src[i]);
            return dst;            
        }

        /// <summary>
        /// Parses a bit from a character
        /// </summary>
        /// <param name="c">The source value</param>
        public static Bit Parse(char c)
            => c != '0' ? On : Off;
        
        [MethodImpl(Inline)]
        public static implicit operator bool(Bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator Bit(bool src)
            => new Bit(src);
        
        [MethodImpl(Inline)]
        public static explicit operator byte(Bit src)
            => src.value ? (byte)1 : (byte)0;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Bit src)
            => src.value ? (ushort)1 : (ushort)0;


        [MethodImpl(Inline)]
        public static explicit operator int(Bit src)
            => src.value ? 1 : 0;

        [MethodImpl(Inline)]
        public static explicit operator uint(Bit src)
            => src.value ? 1u : 0u;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Bit src)
            => src.value ? 1ul : 0ul;

        [MethodImpl(Inline)]
        public static implicit operator Bit(sbyte src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(byte src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(short src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(ushort src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(int src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(uint src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(long src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator Bit(ulong src)
            => src == 0 ? Off : On;

        [MethodImpl(Inline)]
        public static implicit operator BinaryDigit(Bit src)
            => src.value ? BinaryDigit.One : BinaryDigit.Zed;

        [MethodImpl(Inline)]
        public static implicit operator Bit(BinaryDigit src)
            => new Bit(src == BinaryDigit.One);

        [MethodImpl(Inline)]
        public static bool operator true(Bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static bool operator false(Bit src)
            => !src.value;

        [MethodImpl(Inline)]
        public static bool operator ==(Bit lhs, Bit rhs)
            => lhs.value == rhs.value;

        [MethodImpl(Inline)]
        public static bool operator !=(Bit lhs, Bit rhs)
            => lhs.value != rhs.value;

        [MethodImpl(Inline)]
        public static Bit operator ~ (Bit src) 
            => src.Flip();

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



        public Bit Flip()
            => ! value;

        [MethodImpl(Inline)]
        public bool Equals(Bit rhs)
            => value == rhs.value;

        public override bool Equals(object rhs)
            => rhs is Bit ? Equals((Bit)rhs) : false;

        public override int GetHashCode()
            => value == true ? 1 : 0;
    
        public override string ToString()
            => value == true ? "1" : "0";
    }
}