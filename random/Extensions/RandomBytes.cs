//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public static class RandomBytes
    {
        /// <summary>
        /// Produces a stream of uniformly random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<byte> Bytes(this IRandomSource random)
        {
            var q = (random as Rng).ByteQ;
            while(true)
            {
                if(q.TryDequeue(out byte b))
                    yield return b;
                else
                {
                    var bytes = BitConverter.GetBytes(random.NextInt());
                    for(var i = 0; i< bytes.Length; i++)
                        if(i == 0)
                            yield return bytes[i];
                        else
                            q.Enqueue(bytes[i]);
                }                
            }
        }
    }
}