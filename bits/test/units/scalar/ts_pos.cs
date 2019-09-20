//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class ts_pos : ScalarBitTest<ts_pos>
    {
        public void bitidx_increment()
        {
            var pos = CellIndex<byte>.Zero;
            CellIndex<byte> max = (1024, 35);
            while(pos < max)
                pos++;

            Claim.eq(pos.LinearIndex, max.LinearIndex);

        }

        public void bitidx_decrement()
        {
            var min = CellIndex<byte>.Zero;
            CellIndex<byte> pos = (1024, 35);
            while(pos > min)
                pos--;

            Claim.eq(pos.LinearIndex, min.LinearIndex);
        }

        public void bitidx_add()
        {
            var n = Pow2.T12;
            var positions = BitPositions<uint>(512, 1024).TakeArray(n);
            var additions = Random.Stream(closed(0u, 100u)).TakeArray(n);
            for(var i=0; i<n; i++)
            {
                var posX = positions[i];
                var add = additions[i];
                var posY = posX + add;
                Claim.yea(posY >= posX);

                var pos = posX;
                for(var j=0; j< add; j++)
                    pos++;
                
                Claim.eq(pos.LinearIndex, posY.LinearIndex);
            }            
        }

        /// <summary>
        /// Produces a stream of bit positions
        /// </summary>
        /// <param name="segMin">The minimum segment length</param>
        /// <param name="segMax">The maximum segment length</param>
        /// <typeparam name="T">The position's type</typeparam>
        IEnumerable<CellIndex<T>> BitPositions<T>(ushort segMin, ushort segMax)
            where T : struct
        {
            var tBits = Unsafe.SizeOf<T>()*8;
            var s2 = Random.Stream(closed(segMin,segMax)).GetEnumerator();            
            var s3 = Random.Stream<byte>(closed((byte)0, (byte)tBits)).GetEnumerator();
            while(true && s2.MoveNext() && s3.MoveNext())
                yield return CellIndex<T>.Define(s2.Current, s3.Current);
        }


    }

}