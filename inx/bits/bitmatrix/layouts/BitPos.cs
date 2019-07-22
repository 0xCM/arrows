namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

	/// <summary>
	/// Identifies a bit position within a contiguous sequence of T-element values
	/// </summary>
	public struct BitPos<T> 
        where T : struct
	{
		/// <summary>
		/// The container-relative 0-based offset of the segment
		/// </summary>
		public ushort SegIdx;

		/// <summary>
		/// The segment-relative offset of the bit
		/// </summary>
		public byte BitOffset;

        /// <summary>
        /// The zero position
        /// </summary>
		public static readonly BitPos<T> Zero = default(BitPos<T>);

		/// <summary>
		/// Specifies the number of bits that can be placed in one segment
		/// </summary>
		public static readonly BitSize SegCapacity = SizeOf<T>.BitSize;

		/// <summary>
		/// Modulus for number of potential bits in T
		/// </summary>
		static readonly Mod TMod = Mod.Define((uint)BitPos<T>.SegCapacity.Bits, 0u);

        /// <summary>
        /// Computes the segment of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        static ushort IndexSegment(uint index)
            => (ushort)BitPos<T>.TMod.div(index);

        /// <summary>
        /// Computes the offset of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        static byte IndexOffset(uint index)
            => (byte)BitPos<T>.TMod.mod(index);

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromIndex(uint index)
			=> new BitPos<T>(IndexSegment(index), IndexOffset(index));

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromIndex(int index)
			=> new BitPos<T>((ushort)BitPos<T>.TMod.div((uint)index), 
                (byte)BitPos<T>.TMod.mod((uint)index));

		[MethodImpl(Inline)]
		public static BitPos<T>operator +(BitPos<T> pos, uint bitcount)
		{
			pos.Add(bitcount);
            return pos;
		}

		[MethodImpl(Inline)]
		public static BitPos<T> operator -(BitPos<T> lhs, uint bitcount)
		{
            lhs.Sub(bitcount);
            return lhs;
		}

		[MethodImpl(Inline)]
		public static int operator -(BitPos<T> lhs, BitPos<T> rhs)
		{
			return lhs.CountTo(rhs);
		}

		[MethodImpl(Inline)]
		public static BitPos<T> operator --(BitPos<T> src)
		{
            src.Dec();
            return src;
		}

		[MethodImpl(Inline)]
		public static BitPos<T> operator ++(BitPos<T> src)
		{
			src.Inc();
            return src;
		}

		[MethodImpl(Inline)]
		public static bool operator ==(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator !=(BitPos<T> lhs, BitPos<T> rhs)
			=> !lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator <(BitPos<T> lhs, BitPos<T> rhs)		
			=> lhs.LinearIndex < rhs.LinearIndex;		

		[MethodImpl(Inline)]
		public static bool operator <=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex <= rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex > rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex >= rhs.LinearIndex;

		[MethodImpl(Inline)]
        public static implicit operator BitPos<T>((ushort SegId, byte BitOffset) x)
            => Define(x.SegId, x.BitOffset);

		[MethodImpl(Inline)]
		public static BitPos<T> Define(ushort SegIdx, byte BitOffset)
			=> new BitPos<T>(SegIdx, BitOffset);

		[MethodImpl(Inline)]
		public BitPos(ushort SegIdx, byte BitOffset)
		{
			this.SegIdx = SegIdx;
			this.BitOffset = BitOffset;
		}

		public int LinearIndex
		{
			[MethodImpl(Inline)]
			get => this.SegIdx * BitPos<T>.SegCapacity + this.BitOffset;
		}

		[MethodImpl(Inline)]
		public int CountTo(BitPos<T> other)
		{
			return Math.Abs(this.LinearIndex - other.LinearIndex) + 1;
		}

		[MethodImpl(Inline)]
        public void Add(uint rhs)
        {
            var newIndex = (uint)(LinearIndex + rhs);
            this.SegIdx = IndexSegment(newIndex);
            this.BitOffset = IndexOffset(newIndex);
        }

        [MethodImpl(Inline)]
        void UpdateFrom(uint index)
        {
            this.SegIdx = IndexSegment(index);
            this.BitOffset = IndexOffset(index);
        }

        [MethodImpl(Inline)]
        void ClampLower()
        {
            this.SegIdx = 0;
            this.BitOffset = 0;
        }

		[MethodImpl(Inline)]
        public void Sub(uint rhs)
        {
            var newIndex = LinearIndex - rhs;
            if(newIndex > 0)
                UpdateFrom((uint)newIndex);
            else
                ClampLower();
        }

		[MethodImpl(Inline)]
        public void Dec()
        {
            if(BitOffset > 0)
                --BitOffset;
            else
            {
                if(SegIdx != 0)
                {
                    BitOffset = (byte)(SegCapacity - 1);
                    --SegIdx;
                }            
            }
        }

		[MethodImpl(Inline)]
        public void Inc()
        {
            if(BitOffset < SegCapacity - 1)
                BitOffset++;
            else
            {
                SegIdx++;
                BitOffset = 0;
            }
        }

		[MethodImpl(Inline)]
		public bool Equals(BitPos<T> rhs)
			=> this.SegIdx == rhs.SegIdx 
            && this.BitOffset == rhs.BitOffset;

		public string Format()
			=> string.Format("({0},{1}/{2})", this.LinearIndex, this.SegIdx, this.BitOffset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> LinearIndex.GetHashCode();

		public override bool Equals(object rhs)
            => rhs is BitPos<T> x ? Equals(x) : false;

	}

	public static class BitPos
	{
		public static BitPos<T> Define<T>(uint index)
			where T : struct
				=> BitPos<T>.FromIndex(index);
	}

	/// <summary>
	/// Identifies a bit position within a contiguous sequence of N T-element values
	/// </summary>
	public struct BitPos<N,T> 
        where N : ITypeNat, new()
		where T : struct
	{
		/// <summary>
		/// The container-relative 0-based offset of the segment
		/// </summary>
		public ushort SegIdx;

		/// <summary>
		/// The segment-relative offset of the bit
		/// </summary>
		public byte BitOffset;

        /// <summary>
        /// The zero position
        /// </summary>
		public static readonly BitPos<N,T> Zero = default(BitPos<N,T>);

		/// <summary>
		/// Specifies the number of bits that can be placed in one segment
		/// </summary>
		public static readonly BitSize SegCapacity = SizeOf<T>.BitSize;

		public static readonly int MaxBitIndex = (int)(new N().value - 1);

		/// <summary>
		/// Modulus for number of potential bits in T
		/// </summary>
		static readonly Mod TMod = Mod.Define((uint)SegCapacity.Bits, 0u);

        /// <summary>
        /// Computes the segment of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        static ushort IndexSegment(uint index)
            => (ushort)TMod.div(index);

        /// <summary>
        /// Computes the offset of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        static byte IndexOffset(uint index)
            => (byte)BitPos<N,T>.TMod.mod(index);

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<N,T> FromIndex(uint index)
			=> new BitPos<N,T>(IndexSegment(index), IndexOffset(index));

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<N,T> FromIndex(int index)
			=> new BitPos<N,T>((ushort)TMod.div((uint)index), 
                (byte)TMod.mod((uint)index));

		[MethodImpl(Inline)]
		public static BitPos<N,T>operator +(BitPos<N,T> pos, uint bitcount)
		{
			pos.Add(bitcount);
            return pos;
		}

		[MethodImpl(Inline)]
		public static BitPos<N,T> operator -(BitPos<N,T> lhs, uint bitcount)
		{
            lhs.Sub(bitcount);
            return lhs;
		}

		[MethodImpl(Inline)]
		public static int operator -(BitPos<N,T> lhs, BitPos<N,T> rhs)
		{
			return lhs.CountTo(rhs);
		}

		[MethodImpl(Inline)]
		public static BitPos<N,T> operator --(BitPos<N,T> src)
		{
            src.Dec();
            return src;
		}

		[MethodImpl(Inline)]
		public static BitPos<N,T> operator ++(BitPos<N,T> src)
		{
			src.Inc();
            return src;
		}

		[MethodImpl(Inline)]
		public static bool operator ==(BitPos<N,T> lhs, BitPos<N,T> rhs)
			=> lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator !=(BitPos<N,T> lhs, BitPos<N,T> rhs)
			=> !lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator <(BitPos<N,T> lhs, BitPos<N,T> rhs)		
			=> lhs.LinearIndex < rhs.LinearIndex;		

		[MethodImpl(Inline)]
		public static bool operator <=(BitPos<N,T> lhs, BitPos<N,T> rhs)
			=> lhs.LinearIndex <= rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >(BitPos<N,T> lhs, BitPos<N,T> rhs)
			=> lhs.LinearIndex > rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >=(BitPos<N,T> lhs, BitPos<N,T> rhs)
			=> lhs.LinearIndex >= rhs.LinearIndex;

		[MethodImpl(Inline)]
        public static implicit operator BitPos<N,T>((ushort SegId, byte BitOffset) x)
            => Define(x.SegId, x.BitOffset);

		[MethodImpl(Inline)]
		public static BitPos<N,T> Define(ushort SegIdx, byte BitOffset)
			=> new BitPos<N,T>(SegIdx, BitOffset);

        [MethodImpl(Inline)]
        static int CheckIndex(int index)
            => index >= 0 && index <= MaxBitIndex ? index  : Errors.ThrowOutOfRange<int>(index, 0, MaxBitIndex);

        [MethodImpl(Inline)]
        static uint CheckIndex(uint index)
            => index >= 0 && index <= MaxBitIndex ? index  : Errors.ThrowOutOfRange<uint>((int)index, 0, MaxBitIndex);

	
		[MethodImpl(Inline)]
		public BitPos(ushort SegIdx, byte BitOffset)
		{
			this.SegIdx = SegIdx;
			this.BitOffset = BitOffset;
			CheckIndex(LinearIndex);
		}

		public int LinearIndex
		{
			[MethodImpl(Inline)]
			get => this.SegIdx * SegCapacity + this.BitOffset;
		}

		[MethodImpl(Inline)]
		public int CountTo(BitPos<N,T> other)
		{
			return Math.Abs(this.LinearIndex - other.LinearIndex) + 1;
		}

		[MethodImpl(Inline)]
        public void Add(uint rhs)
        {
            var newIndex = CheckIndex((uint)(LinearIndex + rhs));
            this.SegIdx = IndexSegment(newIndex);
            this.BitOffset = IndexOffset(newIndex);
        }

        [MethodImpl(Inline)]
        void UpdateFrom(uint index)
        {
            CheckIndex(index);
			this.SegIdx = IndexSegment(index);
            this.BitOffset = IndexOffset(index);
        }

        [MethodImpl(Inline)]
        void ClampLower()
        {
            this.SegIdx = 0;
            this.BitOffset = 0;
        }

		[MethodImpl(Inline)]
        public void Sub(uint rhs)
        {
            var newIndex = LinearIndex - rhs;
            if(newIndex > 0)
                UpdateFrom((uint)newIndex);
            else
                ClampLower();
        }

		[MethodImpl(Inline)]
        public void Dec()
        {
            if(BitOffset > 0)
                --BitOffset;
            else
            {
                if(SegIdx != 0)
                {
                    BitOffset = (byte)(SegCapacity - 1);
                    --SegIdx;
                }            
            }
        }

		[MethodImpl(Inline)]
        public void Inc()
        {
            if(BitOffset < SegCapacity - 1)
                BitOffset++;
            else
            {
                SegIdx++;
                BitOffset = 0;
            }
        }

		[MethodImpl(Inline)]
		public bool Equals(BitPos<N,T> rhs)
			=> this.SegIdx == rhs.SegIdx 
            && this.BitOffset == rhs.BitOffset;

		public string Format()
			=> string.Format("({0},{1}/{2})", this.LinearIndex, this.SegIdx, this.BitOffset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> LinearIndex.GetHashCode();

		public override bool Equals(object rhs)
            => rhs is BitPos<N,T> x ? Equals(x) : false;

	}

}
