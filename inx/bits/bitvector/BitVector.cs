//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    

    public ref struct BitVector<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        Span<T> bits;

        static readonly BitSize PrimalSize = SizeOf<T>.BitSize;

        static readonly BitSize BitCount = new N().value;

        static readonly int SegLength = CalcSegLength();
    
        static readonly (int segment, int offset)[] BitMap
            = CaclBitMap();

        [MethodImpl(Inline)]
        static (int segment, int offset) FindBit(int bitpos)
            => BitMap[bitpos];

        [MethodImpl(Inline)]
        public BitVector(params T[] bits)
            : this()
        {
            this.bits =bits;
            require(bits.Length * PrimalSize >= BitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(Span<T> bits)
            : this()
        {
            this.bits =bits;
            require(bits.Length * PrimalSize >= BitCount);
        }

        [MethodImpl(Inline)]
        public BitVector(ReadOnlySpan<T> bits)
            : this()
        {
            this.bits =bits.Replicate();
            require(bits.Length * PrimalSize >= BitCount);
        }

        [MethodImpl(Inline)]
        public static BitVector<N,T> Define(params T[] src)
            => new BitVector<N,T>(src);    

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static Bit operator *(in BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => (lhs & rhs).Pop() != 0;

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator |(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.or(ref lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator &(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.and(ref lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ^(BitVector<N,T> lhs, in BitVector<N,T> rhs)
            => new BitVector<N,T>(gbits.xor(ref lhs.bits, rhs.bits));

        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ~(BitVector<N,T> src)
            => new BitVector<N,T>(gbits.flip(ref src.bits));
        
        /// <summary>
        /// Retrieves the value of the bit at a specified position
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        [MethodImpl(Inline)]
        public Bit GetBit(in int pos)
        {
            (var seg, var offset) = FindBit(pos);
            return gbits.test(bits[seg], offset);
        }
            
        /// <summary>
        /// Sets the value of the bit at a specified position
        /// </summary>
        /// <param name="pos">The absolute bit position</param>
        [MethodImpl(Inline)]
        public void SetBit(in int pos, Bit value)
        {
            (var seg, var offset) = FindBit(pos);
            gbits.set(ref bits[seg], pos, value);
        }

        /// <summary>
        /// A bit-level accessor/manipulator
        /// </summary>
        public Bit this[in int pos]
        {
            [MethodImpl(Inline)]
            get => GetBit(pos);
            
            [MethodImpl(Inline)]
            set => SetBit(pos, value);
        }

        /// <summary>
        /// The data over which the bitvector is constructed
        /// </summary>
        public Span<T> Bits
        {
            [MethodImpl(Inline)]
            get => bits;
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public int Length
            => BitCount;

        [MethodImpl(Inline)]
        public void Toggle(in int pos)
        {         
            (var seg, var offset) = FindBit(pos);
            gbits.toggle(ref bits[seg], in offset);
        }

        /// <summary>
        /// Enables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(in int pos)
        {
            (var seg, var offset) = FindBit(pos);
            gbits.enable(ref bits[seg], in offset);
        }

        /// <summary>
        /// Disables an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to disable</param>
        [MethodImpl(Inline)]
        public void Disable(in int pos)
        {
            (var seg, var offset) = FindBit(pos);
            gbits.disable(ref bits[seg], in offset);
        }

        /// <summary>
        /// Tests the status of an identified bit
        /// </summary>
        /// <param name="pos">The position of the bit to test</param>
        [MethodImpl(Inline)]
        public bool Test(in int pos)
            => GetBit(pos);

        [MethodImpl(Inline)]
        public Span<byte> Bytes()
            => MemoryMarshal.AsBytes(Bits);

        /// <summary>
        /// Counts the vector's enabled bits
        /// </summary>
        [MethodImpl(Inline)]
        public ulong Pop()
        {
            var count = 0ul;
            for(var i=0; i< bits.Length; i++)
                count += gbits.pop(bits[i]);
            return count;
        }

        [MethodImpl(Inline)]
        public bool Eq(in BitVector<N,T> rhs)
            => bits.Eq(rhs.bits);

        [MethodImpl(Inline)]
        public bool NEq(in BitVector<N,T> rhs)
            => !bits.Eq(rhs.bits);
            
        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        static int CalcSegLength()
        {
            if(PrimalSize >= BitCount)
                return 1;
            else
            {
                var qr = math.quorem(BitCount, PrimalSize);
                return qr.Remainder == 0 ? qr.Quotient : qr.Quotient + 1;
            }
        }

        static (int segment, int offset)[] CaclBitMap()
        {
            var dst =  new (int segment, int offset)[BitCount];
            for(int i = 0, seg = 0, offset = 0; i < BitCount; i++)          
            {
                if(i != 0)
                {
                    if((i % PrimalSize) == 0)
                    {
                        seg++;
                        offset = 0;
                    }
                }
                dst[i] = (seg, offset++);
            }
            return dst;
        }
    }
}