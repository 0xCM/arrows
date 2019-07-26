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

    using static Bits;
    using static Bytes;

    using static zfunc;    
    using source = System.UInt64;

    public ref struct BitVector64
    {
        public const int ByteSize = 8;

        public const int BitSize = 8*ByteSize;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N64,ulong>(in BitVector64 src)
            => new BitVector<N64,ulong>(src.data);

        ulong data;


        [MethodImpl(Inline)]
        public BitVector64(in ulong data)
            => this.data = data;

        [MethodImpl(Inline)]
        public BitVector64(in Bit[] src)
        {
            this.data = 0;
            for(var i = 0; i< Math.Min(BitSize, src.Length); i++)
                if(src[i])
                    enable(ref data, i);
        }

        [MethodImpl(Inline)]
        public static BitVector64 Define(in ReadOnlySpan<Bit> src)
            => Define(in pack(src, out ulong data));

        [MethodImpl(Inline)]
        public static BitVector64 Define(in source src)
            => new BitVector64(src);    

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(in source src)
            => new BitVector64(src);

        [MethodImpl(Inline)]
        public static implicit operator source(in BitVector64 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static Bit operator *(in BitVector64 lhs, in BitVector64 rhs)
            => (lhs & rhs) != 0;

        [MethodImpl(Inline)]
        public static BitVector64 operator |(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static BitVector64 operator &(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static BitVector64 operator ^(in BitVector64 lhs, in BitVector64 rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static BitVector64 operator ~(in BitVector64 src)
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

        public BitVector32 Hi
        {
            [MethodImpl(Inline)]
            get => (uint)hi(data);        
        }
        
        public BitVector32 Lo
        {
            [MethodImpl(Inline)]
            get => (uint)lo(data);    
        }


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
            => (UInt64.MaxValue & data) == UInt64.MaxValue;

        [MethodImpl(Inline)]
        public bool AllZeros()
            => data == 0;

        [MethodImpl(Inline)]
        public bool Eq(in BitVector64 rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool NEq(in BitVector64 rhs)
            => data != rhs.data;

        [MethodImpl(Inline)]
        public ulong Extract(int first, int last)
        {
            var len = (byte)(last - first + 1);
            return Bits.extract(in data, (byte)first, len);
        }

        public ulong this[Range range]
        {
            [MethodImpl(Inline)]
            get => Extract(range.Start.Value, range.End.Value);
        }

        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => this[(byte)pos];
            [MethodImpl(Inline)]
            set => this[(byte)pos] = value;
        }

        [MethodImpl(Inline)]
        public BitString ToBitString()
            => data.ToBitString();

        [MethodImpl(Inline)]
        public string Format(bool tlz = false, bool specifier = false)
            => ToBitString().Format(tlz, specifier);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}