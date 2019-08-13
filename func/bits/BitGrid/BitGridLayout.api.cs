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

    public static class BitGridLayout
    {        
        /// <summary>
        /// Calculates the maximum number of bits a storage segment can contain
        /// </summary>
        /// <typeparam name="T">The storage segment type</typeparam>
        public static BitSize SegmentCapacity<T>()
            where T : struct
                => Unsafe.SizeOf<T>() * 8;

        /// <summary>
        /// Calculates a canonical bijection from a contiguous sequence of bits onto a contiguous sequence of segments
        /// </summary>
        /// <param name="bitcount">The total number of bits to distribute over one or more segments</param>        
        public static BitPos<T>[] BitMap<T>(BitSize bitcount)
            where T : struct
        {
            var dst =  new BitPos<T>[bitcount];
            var capacity = SegmentCapacity<T>();            
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
                var q = Math.DivRem(bitcount, capacity, out int r);
                //var qr = math.quorem(bitcount, capacity);
                return r == 0 ? q : q + 1;
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
                => MinSegmentCount(BitGridLayout.SegmentCapacity<T>(), bitcount);
    }
}