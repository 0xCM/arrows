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
    /// Defines a bit index/offset relative to some structure
    /// </summary>
    public struct BitIndex
    {
        byte pos;
        
        [MethodImpl(Inline)]
        public static BitIndex Define(byte value)
            => new BitIndex(value);

        [MethodImpl(Inline)]
        public static implicit operator byte(BitIndex src)
            => src.pos;

        [MethodImpl(Inline)]
        public static implicit operator int(BitIndex src)
            => src.pos;

        [MethodImpl(Inline)]
        public static implicit operator BitIndex(int src)
            => BitIndex.Define((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator BitIndex(byte src)
            => BitIndex.Define(src);

        [MethodImpl(Inline)]
        public static byte operator -(in BitIndex lhs, in BitIndex rhs)
            => (byte)Math.Abs(lhs.pos - rhs.pos);

        [MethodImpl(Inline)]
        public static BitIndex operator ++(in BitIndex lhs)
            => Increment(ref asRef(in lhs));

        [MethodImpl(Inline)]
        public static BitIndex operator --(in BitIndex lhs)
            => Decrement(ref asRef(in lhs));

        [MethodImpl(Inline)]
        public static bool operator ==(BitIndex lhs, BitIndex rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitIndex lhs, BitIndex rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitIndex(byte index)        
            => this.pos = index;

        [MethodImpl(Inline)]
        public bool Equals(BitIndex rhs)
            => pos == rhs.pos;

        public override int GetHashCode()
            => pos;

        public override bool Equals(object obj)
            => obj is BitSize x ? Equals(x) : false;

        [MethodImpl(Inline)]
        static ref BitIndex Decrement(ref BitIndex src)
        {
            --src.pos;
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref BitIndex Increment(ref BitIndex src)
        {
            ++src.pos;
            return ref src;
        }
    }


}