//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;


    partial class Structures
    {
        public interface BitString :  Formattable, Lengthwise
        {
            

        }
        
        public interface BitString<S> : BitString, FreeMonoid<S>
            where S : BitString<S>, new()
        {


        }

        public interface BitString<S,N> : BitString<S>
            where S : BitString<S,N>, new()
            where N : TypeNat, new()
        {


        }

    }

    public readonly struct BitString : Structures.BitString<BitString>
    {
        [MethodImpl(Inline)]   
        public static BitString Parse(string src)
            => new BitString(src);

        public static readonly BitString Empty = default;

        [MethodImpl(Inline)]   
        public static BitString define(IEnumerable<bit> src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString defineG<T>(intg<T> src)
        {
            var len = (int)src.bitsize;
            var bits = new bit[len];
            for(var i = 0; i < len; i++)
                bits[i] = src.testbit(i);
            return new BitString(bits);
        }

        [MethodImpl(Inline)]   
        public static BitString define(byte src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(sbyte src)
            => new BitString(src);


        [MethodImpl(Inline)]   
        public static BitString define(short src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(ushort src)
            => new BitString(src);


        [MethodImpl(Inline)]   
        public static BitString define(int src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(uint src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(long src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(ulong src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(double src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(decimal src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(float src)
            => new BitString(src);

        [MethodImpl(Inline)]   
        public static BitString define(BigInteger src)
            => new BitString(src);

        [MethodImpl(Inline)]
        public static BitString operator + (BitString lhs, BitString rhs) 
            => lhs.concat(rhs);

        public Slice<bit> bits {get;}

        public BitString zero 
            => Empty;


        [MethodImpl(Inline)]
        public bool nonzero()
            => bits.length != 0;


        [MethodImpl(Inline)]
        public BitString(params bit[] src)
            => this.bits = src;

        [MethodImpl(Inline)]
        public BitString(Slice<bit> src)
            => this.bits = src;

        [MethodImpl(Inline)]
        public BitString(IEnumerable<bit> src)
            => this.bits = slice(src);

        [MethodImpl(Inline)]
        static Slice<bit> parse(string src)
            => slice(map(src,c => bit.Parse(c)));

        [MethodImpl(Inline)]
        public BitString(byte src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(sbyte src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(short src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(ushort src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(int src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(uint src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(long src)
            => bits = parse(bitchars(src));
        
        [MethodImpl(Inline)]
        public BitString(ulong src)
            => bits = parse(bitchars(src));
                                                       
        [MethodImpl(Inline)]
        public BitString(double src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(decimal src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(float src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(BigInteger src)
            => bits = parse(bitchars(src));

        [MethodImpl(Inline)]
        public BitString(string src)
            => bits = slice(map(src,c => bit.Parse(c)));

        [MethodImpl(Inline)]
        public BitString concat(BitString rhs)
            => new BitString(bits + rhs.bits);

        [MethodImpl(Inline)]
        public bool eq(BitString rhs)
            => bits.eq(rhs.bits);

        [MethodImpl(Inline)]
        public bool eq(BitString lhs, BitString rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(BitString rhs)
            => this.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(BitString rhs)
            => bits.neq(rhs.bits);

        [MethodImpl(Inline)]
        public bool neq(BitString lhs, BitString rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public string format()
            => string.Concat(map(bits,b =>  b.format()));

        [MethodImpl(Inline)]
        public int hash()
            => bits.hash();

        public uint length
            => bits.length;

        public override string ToString()
            => format();

        public override int GetHashCode()
            => hash();

    }

 
}