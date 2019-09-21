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
    /// Defines the value of a bit
    /// </summary>
    public readonly struct Bit
    {
        readonly bool value;
        
        [MethodImpl(Inline)]
        public Bit(bool value)        
            => this.value = value;

        public static readonly Bit Off = false;

        public static readonly Bit On = true;

        public const char Zero = '0';

        public const char One = '1';

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
            
        const string ZeroS = "0";

        const string OneS = "1";
        
        [MethodImpl(Inline)]
        public static Bit Parse(char c)
            => c == One;

        [MethodImpl(Inline)]
        public static implicit operator bool(Bit src)
            => src.value;

        [MethodImpl(Inline)]
        public static implicit operator Bit(bool src)
            => new Bit(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator char(Bit src)
            => src ? One : Zero;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator int(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator uint(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator long(Bit src)
            => src.ToByte();

        [MethodImpl(Inline)]
        public static explicit operator ulong(Bit src)
            => src.ToByte();

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(sbyte src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(byte src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(short src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(ushort src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(int src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(uint src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(long src)
            => src == 0 ? Off : On;

        /// <summary>
        /// Implicitly converts an integral value to a bit where nonzero values
        /// are interpreted as an On bit
        /// </summary>
        /// <param name="src">The source value</param>
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

        /// <summary>
        /// Converts a bool to a byte quickly
        /// </summary>
        /// <param name="src"></param>
        /// <remarks>Taken from https://stackoverflow.com/questions/4980881/what-is-fastest-way-to-convert-bool-to-byte</remarks>
        [MethodImpl(Inline)]
        static unsafe byte ToByte(bool src)
            =>  *((byte*)(&src));

        [MethodImpl(Inline)]
        public byte ToByte()
            => ToByte(value);

        [MethodImpl(Inline)]
        public bool Equals(Bit rhs)
            => value == rhs.value;

        [MethodImpl(Inline)]
        public override bool Equals(object rhs)
            => rhs is Bit ? Equals((Bit)rhs) : false;

        [MethodImpl(Inline)]
        public override int GetHashCode()
            => value ? 1 : 0;
    
        [MethodImpl(Inline)]
        public override string ToString()
            => value  ? OneS : ZeroS;
    }
}