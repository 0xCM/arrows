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

    using static zfunc;

    public readonly struct BitLayout
    {        
        /// <summary>
        /// Calculates the maximum number of bits one segment can hold
        /// </summary>
        /// <typeparam name="T">The segment type</typeparam>
        public static BitSize SegmentCapacity<T>()     
            where T : struct
                => Unsafe.SizeOf<T>()* 8;

        /// <summary>
        /// Calculates the minimum number of segments required to hold a contiguous sequence of bits
        /// </summary>
        /// <param name="capacity">The number of bits that comprise each segment</param>
        /// <param name="bitcount">The number of bits</param>
        public static int MinSegmentCount(BitSize capacity, BitSize bitcount)
        {
            if(capacity >= bitcount)
                return 1;
            else
            {
                var qr = math.quorem(bitcount, capacity);
                return qr.Remainder == 0 ? qr.Quotient : qr.Quotient + 1;
            }
        }

        /// <summary>
        /// Calculates the minimum number of segments required to hold a contiguous sequence of bits
        /// </summary>
        /// <param name="segsize">The number of bytes that comprise each segment</param>
        /// <param name="bitcount">The number of bits</param>
        /// <typeparam name="T">The segment type</typeparam>
        public static int MinSegmentCount<T>(BitSize bitcount)
            where T : struct
                => MinSegmentCount(SegmentCapacity<T>(), bitcount);

        /// <summary>
        /// Calculates a canonical bijection from a contiguous sequence of bits onto a contiguous sequence of segments
        /// </summary>
        /// <param name="capacity">The maximum number of bits a segment can contain</param>        
        /// <param name="bitcount">The total number of bits to distribute over one or more segments</param>        
        public static BitPos<T>[] BitMap<T>(BitSize capacity, BitSize bitcount)
            where T : struct
        {
            var dst =  new BitPos<T>[bitcount];
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
        /// Calculates the bijection between a contiguous bit sequence onto a contiguous segment sequence
        /// </summary>
        /// <param name="bitcount">The number of bits</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitPos<T>[] BitMap<T>(int bitcount)
            where T : struct       
                => BitMap<T>(SegmentCapacity<T>(), bitcount);

        public BitLayout(BitGridSpec spec, IEnumerable<BitGridCell> Cells)
        {
            this.GridSpec = spec;
            this.RowCount = spec.RowCount;
            this.ColCount = spec.ColCount;
            this.CellCount = spec.RowCount * spec.ColCount;
            this.RowSegments = spec.RowSegLength();
            this.TotalSegments = RowSegments * spec.RowCount;
            this.RowLayout = Cells.CreateRowIndex();
            Claim.eq(spec.RowCount, RowLayout.Count);
            Claim.eq(spec.ColCount, RowLayout.First().Value.Length);                         
        }

        readonly IReadOnlyDictionary<int, BitGridCell[]> RowLayout;

        /// <summary>
        /// The specification from which the layout was calculated
        /// </summary>
        public readonly BitGridSpec GridSpec;
        
        /// <summary>
        /// The number of rows in the layout
        /// </summary>
        public readonly BitSize RowCount;
        
        /// <summary>
        /// The number of columns in the layout
        /// </summary>
        public readonly BitSize ColCount;

        /// <summary>
        /// The Total number of bits accounted for in the layout
        /// and is equal to <see cref='RowCount'/> * <see cref='ColCount'/>
        /// </summary>
        public readonly BitSize CellCount;

        /// <summary>
        /// The minimal length of a primal span sufficient to store a row of grid data
        /// </summary>
        public readonly int RowSegments;

        /// <summary>
        /// The length of a span required to store all cells, padded as determined by the
        /// <see cref='RowSegments'/>
        /// </summary>
        public readonly int TotalSegments;
        
        public Span<BitGridCell> Row(int index)
            => RowLayout[index];            
    }
}