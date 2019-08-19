//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

	/// <summary>
	/// Identifies a bit position within a contiguous sequence of T-element values
	/// </summary>
	public struct CellIndex<T> 
        where T : struct
	{
		/// <summary>
		/// The container-relative 0-based offset of the segment
		/// </summary>
		public ushort Segment;

		/// <summary>
		/// The segment-relative offset of the bit
		/// </summary>
		public byte Offset;

        /// <summary>
        /// The zero position
        /// </summary>
		public static readonly CellIndex<T> Zero = default(CellIndex<T>);

		/// <summary>
		/// Specifies the number of bits that can be placed in one segment
		/// </summary>
		public static readonly BitSize SegCapacity = SizeOf<T>.BitSize;

		/// <summary>
		/// Modulus for number of potential bits in T
		/// </summary>
		static readonly Mod TMod = Mod.Define((uint)CellIndex<T>.SegCapacity.Bits, 0u);

        /// <summary>
        /// Computes the segment of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        static ushort IndexSegment(uint index)
            => (ushort)CellIndex<T>.TMod.div(index);

        /// <summary>
        /// Computes the offset of a linear index
        /// </summary>
        /// <param name="index">The source index</param>
		[MethodImpl(Inline)]
        static byte IndexOffset(uint index)
            => (byte)CellIndex<T>.TMod.mod(index);

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static CellIndex<T> FromIndex(uint index)
			=> new CellIndex<T>(IndexSegment(index), IndexOffset(index));

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static CellIndex<T> FromIndex(int index)
			=> new CellIndex<T>((ushort)CellIndex<T>.TMod.div((uint)index), 
                (byte)CellIndex<T>.TMod.mod((uint)index));

		[MethodImpl(Inline)]
		public static CellIndex<T>operator +(CellIndex<T> pos, uint bitcount)
		{
			pos.Add(bitcount);
            return pos;
		}

		[MethodImpl(Inline)]
		public static CellIndex<T> operator -(CellIndex<T> lhs, uint bitcount)
		{
            lhs.Sub(bitcount);
            return lhs;
		}

		[MethodImpl(Inline)]
		public static int operator -(CellIndex<T> lhs, CellIndex<T> rhs)
		{
			return lhs.CountTo(rhs);
		}

		[MethodImpl(Inline)]
		public static CellIndex<T> operator --(CellIndex<T> src)
		{
            src.Dec();
            return src;
		}

		[MethodImpl(Inline)]
		public static CellIndex<T> operator ++(CellIndex<T> src)
		{
			src.Inc();
            return src;
		}

		[MethodImpl(Inline)]
		public static bool operator ==(CellIndex<T> lhs, CellIndex<T> rhs)
			=> lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator !=(CellIndex<T> lhs, CellIndex<T> rhs)
			=> !lhs.Equals(rhs);

		[MethodImpl(Inline)]
		public static bool operator <(CellIndex<T> lhs, CellIndex<T> rhs)		
			=> lhs.LinearIndex < rhs.LinearIndex;		

		[MethodImpl(Inline)]
		public static bool operator <=(CellIndex<T> lhs, CellIndex<T> rhs)
			=> lhs.LinearIndex <= rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >(CellIndex<T> lhs, CellIndex<T> rhs)
			=> lhs.LinearIndex > rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >=(CellIndex<T> lhs, CellIndex<T> rhs)
			=> lhs.LinearIndex >= rhs.LinearIndex;

		[MethodImpl(Inline)]
        public static implicit operator CellIndex<T>((ushort SegId, byte BitOffset) x)
            => Define(x.SegId, x.BitOffset);

		[MethodImpl(Inline)]
		public static CellIndex<T> Define(ushort SegIdx, byte BitOffset)
			=> new CellIndex<T>(SegIdx, BitOffset);

		[MethodImpl(Inline)]
		public CellIndex(ushort Segment, byte Offset)
		{
			this.Segment = Segment;
			this.Offset = Offset;
		}

		public int LinearIndex
		{
			[MethodImpl(Inline)]
			get => this.Segment * CellIndex<T>.SegCapacity + this.Offset;
		}

		[MethodImpl(Inline)]
		public int CountTo(CellIndex<T> other)
			=> Math.Abs(this.LinearIndex - other.LinearIndex) + 1;

		[MethodImpl(Inline)]
        public void Add(uint rhs)
        {
            var newIndex = (uint)(LinearIndex + rhs);
            this.Segment = IndexSegment(newIndex);
            this.Offset = IndexOffset(newIndex);
        }

        [MethodImpl(Inline)]
        void UpdateFrom(uint index)
        {
            this.Segment = IndexSegment(index);
            this.Offset = IndexOffset(index);
        }

        [MethodImpl(Inline)]
        void ClampLower()
        {
            this.Segment = 0;
            this.Offset = 0;
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
            if(Offset > 0)
                --Offset;
            else
            {
                if(Segment != 0)
                {
                    Offset = (byte)(SegCapacity - 1);
                    --Segment;
                }            
            }
        }

		[MethodImpl(Inline)]
        public void Inc()
        {
            if(Offset < SegCapacity - 1)
                Offset++;
            else
            {
                Segment++;
                Offset = 0;
            }
        }

		[MethodImpl(Inline)]
		public bool Equals(CellIndex<T> rhs)
			=> this.Segment == rhs.Segment 
            && this.Offset == rhs.Offset;

		public string Format()
			=> string.Format("({0},{1}/{2})", this.LinearIndex, this.Segment, this.Offset);

		public override string ToString()
			=> Format();

		public override int GetHashCode()
			=> LinearIndex.GetHashCode();

		public override bool Equals(object rhs)
            => rhs is CellIndex<T> x ? Equals(x) : false;

	}

}
