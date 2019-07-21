//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zfunc;    
    using static Bits;
    using static Bytes;

    public ref struct BitVector16
    {
        ushort data;

        [MethodImpl(Inline)]
        public BitVector16(in ushort data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N16,ushort>(in BitVector16 src)
            => new BitVector<N16,ushort>(src.data);

        [MethodImpl(Inline)]
        public static BitVector16 Define(in ushort src)
            => new BitVector16(src);    

        [MethodImpl(Inline)]
        public static BitVector16 Define(in ReadOnlySpan<Bit> src)
            => Define(in pack(src, out ushort dst));

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(in ushort src)
            => new BitVector16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(in BitVector16 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector16 lhs, in BitVector16 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector16 lhs, in BitVector16 rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static Bit operator *(in BitVector16 lhs, in BitVector16 rhs)
            => (lhs & rhs) != 0;

        [MethodImpl(Inline)]
        public static BitVector16 operator |(in BitVector16 lhs, in BitVector16 rhs)
            => Define((ushort)(lhs.data | rhs.data));

        [MethodImpl(Inline)]
        public static BitVector16 operator &(in BitVector16 lhs, in BitVector16 rhs)
            => Define((ushort)(lhs.data & rhs.data));

        [MethodImpl(Inline)]
        public static BitVector16 operator ^(in BitVector16 lhs, in BitVector16 rhs)
            => Define((ushort)(lhs.data ^ rhs.data));

        [MethodImpl(Inline)]
        public static BitVector16 operator ~(in BitVector16 src)
            => Define((ushort) ~ src.data);

        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => test(in data, pos);
            
            [MethodImpl(Inline)]
            set
            {
                if(value)
                    enable(ref data, pos);
                else
                     disable(ref data, pos);                    
            }            
        }

        [MethodImpl(Inline)]
        public void EnableBit(byte pos)
            => enable(ref data, pos);

        [MethodImpl(Inline)]
        public void DisableBit(byte pos)
            => disable(ref data, pos);

        [MethodImpl(Inline)]
        public bool TestBit(byte pos)
            => test(in data, pos);


        public BitVector8 Hi
        {
            [MethodImpl(Inline)]
            get => hi(in data);        
        }
        
        public BitVector8 Lo
        {
            [MethodImpl(Inline)]
            get => lo(in data);        
        }

         [MethodImpl(Inline)]
        public BitString BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);

        [MethodImpl(Inline)]
        public ulong PopCount()
            => pop(data);

        [MethodImpl(Inline)]
        public ulong Nlz()
            => nlz(data);

        [MethodImpl(Inline)]
        public ulong Ntz()
            => ntz(data);

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (UInt16.MaxValue & data) == UInt16.MaxValue;

        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public bool Eq(in BitVector16 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVector16 rhs)
            => data != rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }

}