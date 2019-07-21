namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

	/// <summary>
	/// Identifies a bit position within a contiguous sequence of T-element values
	/// </summary>
	public readonly struct BitPos<T> where T : struct
	{
		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromIndex(uint index)
		{
			return new BitPos<T>((ushort)BitPos<T>.TMod.div(index), (byte)BitPos<T>.TMod.mod(index));
		}

		/// <summary>
		/// Constructs a bit position from a linear/absolute index
		/// </summary>
		/// <param name="index">The linear index</param>
		[MethodImpl(Inline)]
		public static BitPos<T> FromIndex(int index)
		{
			return new BitPos<T>((ushort)BitPos<T>.TMod.div((uint)index), (byte)BitPos<T>.TMod.mod((uint)index));
		}

		[MethodImpl(Inline)]
		public static BitPos<T>operator +(BitPos<T> lhs, uint rhs)
		{
			return BitPos<T>.FromIndex((uint)(lhs.LinearIndex + (int)rhs));
		}

		[MethodImpl(Inline)]
		public static BitPos<T>operator -(BitPos<T> lhs, uint rhs)
		{
			long x = (long)lhs.LinearIndex - (long)((ulong)rhs);
			if (x > 0L)
			{
				return BitPos<T>.FromIndex((uint)x);
			}
			return BitPos<T>.Zero;
		}

		[MethodImpl(Inline)]
		public static int operator -(BitPos<T> lhs, BitPos<T> rhs)
		{
			return lhs.CountTo(rhs);
		}

		[MethodImpl(Inline)]
		public static BitPos<T>operator --(BitPos<T> src)
		{
			if (src.LinearIndex == 0)
			{
				return BitPos<T>.Zero;
			}
			return BitPos<T>.FromIndex(src.LinearIndex - 1);
		}

		[MethodImpl(Inline)]
		public static BitPos<T>operator ++(BitPos<T> src)
		{
			return BitPos<T>.FromIndex(src.LinearIndex + 1);
		}

		[MethodImpl(Inline)]
		public static bool operator ==(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex == rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator !=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex != rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator <(BitPos<T> lhs, BitPos<T> rhs)		
			=> lhs.LinearIndex < rhs.LinearIndex;		

		[MethodImpl(Inline)]
		public static bool operator <=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex <= rhs.LinearIndex;

		[MethodImpl(Inline)]
		public static bool operator >(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex > rhs.LinearIndex;

		// Token: 0x06000116 RID: 278 RVA: 0x00003EAC File Offset: 0x000020AC
		[MethodImpl(Inline)]
		public static bool operator >=(BitPos<T> lhs, BitPos<T> rhs)
			=> lhs.LinearIndex >= rhs.LinearIndex;

        public static implicit operator BitPos<T>((ushort SegId, byte BitOffset) x)
            => Define(x.SegId, x.BitOffset);

		[MethodImpl(Inline)]
		public static BitPos<T> Define(ushort SegIdx, byte BitOffset)
		{
			return new BitPos<T>(SegIdx, BitOffset);
		}

		// // Token: 0x0600011A RID: 282 RVA: 0x00003EF0 File Offset: 0x000020F0
		// [MethodImpl(Inline)]
		// public static BitPos<T> Define([TupleElementNames(new string[]
		// {
		// 	"SegIdx",
		// 	"BitOffset"
		// })] ValueTuple<int, int> src)
		// {
		// 	return new BitPos<T>((ushort)src.Item1, (byte)src.Item2);
		// }

		// Token: 0x0600011B RID: 283 RVA: 0x00003F05 File Offset: 0x00002105
		[MethodImpl(Inline)]
		public BitPos(ushort SegIdx, byte BitOffset)
		{
			this.SegIdx = SegIdx;
			this.BitOffset = BitOffset;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00003F15 File Offset: 0x00002115
		public int LinearIndex
		{
			[MethodImpl(Inline)]
			get
			{
				return this.SegIdx * BitPos<T>.SegCapacity + this.BitOffset;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003F41 File Offset: 0x00002141
		[MethodImpl(Inline)]
		public BitPos<T> Step(int amount)
		{
			if (amount < 0)
			{
				return this - (uint)(-(uint)amount);
			}
			return this + (uint)amount;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003F61 File Offset: 0x00002161
		[MethodImpl(Inline)]
		public int CountTo(BitPos<T> other)
		{
			return Math.Abs(this.LinearIndex - other.LinearIndex) + 1;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003F78 File Offset: 0x00002178
		public string Format()
		{
			return string.Format("({0},{1}/{2})", this.LinearIndex, this.SegIdx, this.BitOffset);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00003FA5 File Offset: 0x000021A5
		public override string ToString()
		{
			return this.Format();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00003FB0 File Offset: 0x000021B0
		public override int GetHashCode()
		{
			return this.LinearIndex.GetHashCode();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003FCB File Offset: 0x000021CB
		[MethodImpl(Inline)]
		public bool Equals(BitPos<T> rhs)
		{
			return this.SegIdx == rhs.SegIdx && this.BitOffset == rhs.BitOffset;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003FEC File Offset: 0x000021EC
		public override bool Equals(object rhs)
		{
			if (rhs is BitPos<T>)
			{
				BitPos<T> x = (BitPos<T>)rhs;
				return this.Equals(x);
			}
			return false;
		}

		// Token: 0x04000028 RID: 40
		public static readonly BitPos<T> Zero = default(BitPos<T>);

		/// <summary>
		/// Specifies the number of bits that can be placed in one segment
		/// </summary>
		// Token: 0x04000029 RID: 41
		public static readonly BitSize SegCapacity = SizeOf<T>.BitSize;

		/// <summary>
		/// Modulus for number of potential bits in T
		/// </summary>
		// Token: 0x0400002A RID: 42
		private static readonly Mod TMod = Mod.Define((uint)BitPos<T>.SegCapacity.Bits, 0u);

		/// <summary>
		/// The container-relative 0-based offset of the segment
		/// </summary>
		// Token: 0x0400002B RID: 43
		public readonly ushort SegIdx;

		/// <summary>
		/// The segment-relative offset of the bit
		/// </summary>
		// Token: 0x0400002C RID: 44
		public readonly byte BitOffset;
	}
}
