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

    public ref struct BitVector32
    {
        uint data;

        [MethodImpl(Inline)]
        public BitVector32(in uint data)
            => this.data = data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N32,uint>(in BitVector32 src)
            => new BitVector<N32,uint>(src.data);


        [MethodImpl(Inline)]
        public static implicit operator BitVector32(uint src)
            => new BitVector32(src);


        [MethodImpl(Inline)]
        public BitVector32(in Bit[] src)
        {
            this.data = 0;
            for(var i = 0; i< Math.Min(32, src.Length); i++)
                if(src[i])
                    enable(ref data, i);
        }

        [MethodImpl(Inline)]
        public static BitVector32 Define(in uint src)
            => new BitVector32(src);    

        [MethodImpl(Inline)]
        public static BitVector32 Define(in byte x0, in byte x1, in byte x2, in byte x3)
            => BitConverter.ToUInt32(array(x0, x1, x2, x3), 0);

        [MethodImpl(Inline)]
        public static BitVector32 Define(in ReadOnlySpan<byte> src, int offset = 0)
            => Define(src[offset + 0], src[offset + 1], src[offset + 2], src[offset + 3]);
    

        [MethodImpl(Inline)]
        public static implicit operator uint(in BitVector32 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.NEq(rhs);


        [MethodImpl(Inline)]
        public static Bit operator *(in BitVector32 lhs, in BitVector32 rhs)
            => (lhs & rhs) != 0;

        [MethodImpl(Inline)]
        public static BitVector32 operator |(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVector32 operator &(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVector32 operator ^(in BitVector32 lhs, in BitVector32 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVector32 operator ~(in BitVector32 src)
            => ~src.data;

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


        public BitVector16 Hi
        {
            [MethodImpl(Inline)]
            get => hi(data);        
        }
        
        public BitVector16 Lo
        {
            [MethodImpl(Inline)]
            get => lo(data);    
        }

         [MethodImpl(Inline)]
        public BitString BitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => bytes(data);

        [MethodImpl(Inline)]
        public int PopCount()
            => (int)pop(data);
        
        [MethodImpl(Inline)]
        public ulong Nlz()
            => nlz(data);

        [MethodImpl(Inline)]
        public ulong Ntz()
            => ntz(data);

        [MethodImpl(Inline)]
        public bool AllOnes()
            => (UInt32.MaxValue & data) == UInt32.MaxValue;

        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public string Format()
            => BitString().ToString();

        [MethodImpl(Inline)]
        public bool Eq(in BitVector32 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVector32 rhs)
            => data != rhs.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}