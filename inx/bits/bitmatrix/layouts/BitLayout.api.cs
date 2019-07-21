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


    public static class BitLayout
    {
        /// <summary>
        /// Defines a bit layout grid as determined by specified type parameters
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        public static BitGridSpec<T> Grid<M,N,T>(M m = default, N n = default, T x = default)
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct
                => new BitGridSpec<T>(bitsize<T>(), m.value, n.value);

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
                => MinSegmentCount(BitLayout.SegmentCapacity<T>(), bitcount);
    }
}