//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using static AsIn;
    using static As;

    using static zfunc;


    /// <summary>
    /// Specifies a memory size UOM in bits
    /// </summary>
    public readonly struct BitSize
    {
        /// <summary>
        /// Calculates the (minimum) number of segments required to hold 
        /// a contiguous sequence of bits
        /// </summary>
        /// <param name="capacity">The number of bits that comprise each segment</param>
        /// <param name="bitcount">The number of bits</param>
        public static int Segments(BitSize capacity, BitSize bitcount)
        {
            if(capacity >= bitcount)
                return 1;
            else
            {
                var q = Math.DivRem(bitcount, capacity, out int r);
                return r == 0 ? q : q + 1;
            }
        }

        /// <summary>
        /// Calculates the minimum number of segments required to hold a contiguous sequence of bits
        /// </summary>
        /// <param name="segsize">The number of bytes that comprise each segment</param>
        /// <param name="bitcount">The number of bits</param>
        /// <typeparam name="T">The segment type</typeparam>
        public static int Segments<T>(BitSize bitcount)
            where T : struct
                => Segments(bitsize<T>(), bitcount);

        /// <summary>
        /// Calculates a canonical bijection from a contiguous sequence of bits onto a contiguous sequence of segments
        /// </summary>
        /// <param name="bitcount">The total number of bits to distribute over one or more segments</param>        
        public static CellIndex<T>[] BitMap<T>(BitSize bitcount)
            where T : struct
        {
            var dst =  new CellIndex<T>[bitcount];
            var capacity = bitsize<T>();            
            ushort seg = 0;
            byte offset = 0;
            for(var i = 0; i < bitcount; i++)          
            {
                if(i != 0)
                {
                    if((i % capacity) == 0)
                    {
                        seg++;
                        offset = 0;
                    }
                }
                dst[i] = (seg, offset++);
            }
            return dst;
        }

        /// <summary>
        /// Specifies a bit count
        /// </summary>
        public readonly ulong Bits;

        /// <summary>
        /// The canonical zero size
        /// </summary>
        public static readonly BitSize Zero = default;
         
        public static readonly BitSize x8 = 8;

        public static readonly BitSize x16 = 16;

        public static readonly BitSize x32 = 32;

        public static readonly BitSize x64 = 64;

        public static readonly BitSize x128 = 128;

        public static readonly BitSize x256 = 256;

        /// <summary>
        /// Returns the minimum number of bytes required to apprehend 
        /// the size of the source bits.
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static explicit operator ByteSize(BitSize src)
            => src.UpperByteCount;

        [MethodImpl(Inline)]
        public static explicit operator byte(BitSize src)
            => (byte)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator int(BitSize src)
            => (int)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator uint(BitSize src)
            => (uint)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator long(BitSize src)
            => (long)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitSize src)
            => src.Bits;

        [MethodImpl(Inline)]
        public static explicit operator double(BitSize src)
            => src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator BitSize(int src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(long src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(byte src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ushort src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(uint src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ulong src)
            => new BitSize(src);

        [MethodImpl(Inline)]
        public static explicit operator BitSize(ByteSize src)
            => src.Bytes * 8;

        /// <summary>
        /// Returns the bit size of a type
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline)]
        public static BitSize Size<T>()
            where T : struct
                => Unsafe.SizeOf<T>()*8;
        
        [MethodImpl(Inline)]
        public static bool operator ==(BitSize lhs, BitSize rhs)
            => lhs.Bits == rhs.Bits;

        [MethodImpl(Inline)]
        public static bool operator !=(BitSize lhs, BitSize rhs)
            => lhs.Bits != rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator +(BitSize lhs, BitSize rhs)
            => lhs.Bits + rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator -(BitSize lhs, BitSize rhs)
            => lhs.Bits - rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator *(BitSize lhs, BitSize rhs)
            => lhs.Bits * rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator /(BitSize lhs, BitSize rhs)
            => lhs.Bits / rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator %(BitSize lhs, BitSize rhs)
            => lhs.Bits % rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize Define(int bits)
            => new BitSize((ulong)bits);

        [MethodImpl(Inline)]
        public static BitSize Define(long bits)
            => new BitSize((ulong)bits);

        [MethodImpl(Inline)]
        public static BitSize Define(ulong bits)
            => new BitSize(bits);

        [MethodImpl(Inline)]
        public BitSize(ulong Bits)
            => this.Bits = Bits;

        public override string ToString()
            => Bits.ToString();

        [MethodImpl(Inline)]
        public bool Equals(BitSize rhs)
            => Bits == rhs.Bits;

        public override int GetHashCode()
            => Bits.GetHashCode();

        public override bool Equals(object obj)
            => obj is BitSize x ? Equals(x) : false;

        public ByteSize UpperByteCount
        {
            [MethodImpl(Inline)]
            get
            {
                var q = Math.DivRem((long)Bits, 8L, out long r);
                return r == 0 ? (ulong)q : (ulong)(q + 1);
            }
        }

        public ByteSize LowerByteCount
        {
            [MethodImpl(Inline)]
            get => Bits/8ul;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Bits != 0;
        }
    }
}