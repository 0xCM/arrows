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
    /// Defines a linear/absolute 0-based bit position/index within some structure
    /// </summary>
    public struct BitPos
    {
        uint index;
        
        [MethodImpl(Inline)]
        public static BitPos Define(byte value)
            => new BitPos(value);

        [MethodImpl(Inline)]
        public static BitPos Define(ushort value)
            => new BitPos(value);

        [MethodImpl(Inline)]
        public static BitPos Define(uint value)
            => new BitPos(value);

        [MethodImpl(Inline)]
        public static BitPos Define(int value)
            => new BitPos(value);

        [MethodImpl(Inline)]
        public static implicit operator byte(BitPos src)
            => (byte)src.index;

        [MethodImpl(Inline)]
        public static implicit operator ushort(BitPos src)
            => (ushort)src.index;

        [MethodImpl(Inline)]
        public static implicit operator int(BitPos src)
            => (int)src.index;

        [MethodImpl(Inline)]
        public static implicit operator uint(BitPos src)
            => src.index;

        [MethodImpl(Inline)]
        public static implicit operator BitPos(int src)
            => BitPos.Define((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator BitPos(byte src)
            => BitPos.Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BitPos(ushort src)
            => BitPos.Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BitPos(uint src)
            => BitPos.Define(src);

        [MethodImpl(Inline)]
        public static implicit operator BitPos(BitSize src)
            => BitPos.Define((uint)src.Bits);

        /// <summary>
        /// Computes the inclusive number of bits between min/max positions
        /// </summary>
        /// <param name="lhs">The minimum bit position</param>
        /// <param name="rhs">The maximum bit position</param>
        [MethodImpl(Inline)]
        public static BitSize operator -(in BitPos i0, in BitPos i1)
            =>  Math.Abs((int)i1.index - (int)i0.index) + 1;
        
        [MethodImpl(Inline)]
        public static BitPos operator ++(in BitPos lhs)
            => Increment(ref asRef(in lhs));

        [MethodImpl(Inline)]
        public static BitPos operator --(in BitPos lhs)
            => Decrement(ref asRef(in lhs));

        [MethodImpl(Inline)]
        public static bool operator ==(BitPos lhs, BitPos rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitPos lhs, BitPos rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitPos(byte index)        
            => this.index = index;

        [MethodImpl(Inline)]
        public BitPos(uint index)        
            => this.index = index;

        [MethodImpl(Inline)]
        public BitPos(int index)        
            => this.index = (uint)index;

        [MethodImpl(Inline)]
        public bool Equals(BitPos rhs)
            => index == rhs.index;

        public override int GetHashCode()
            => index.GetHashCode();

        public override bool Equals(object obj)
            => obj is BitSize x ? Equals(x) : false;

        [MethodImpl(Inline)]
        static ref BitPos Decrement(ref BitPos src)
        {
            --src.index;
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref BitPos Increment(ref BitPos src)
        {
            ++src.index;
            return ref src;
        }

        [MethodImpl(Inline)]
        static BitSize BitCount(BitPos i0, BitPos i1)
            => (ulong)Math.Abs((long)i1.index - (long)i0.index + 1L);


    }
}