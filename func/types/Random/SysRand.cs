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

    using static zfunc;
    using static As;

    /// <summary>
    /// Adapter for client code that expects to interface with the System.Random class
    /// </summary>
    public class SysRand : System.Random
    {
        /// <summary>
        /// Derives the system random rng from polyrand
        /// </summary>
        /// <param name="rng">The source rng</param>
        public static System.Random Derive(IPolyrand rng)
            => new SysRand(rng);

        public SysRand(IPolyrand rng)
        {
            this.Polyrand = rng;
        }

        IPolyrand Polyrand {get;}

        public override int Next()
            => Polyrand.Next(Int32.MaxValue);

        public override int Next(int maxValue)
            => Polyrand.Next(maxValue);

        public override int Next(int minValue, int maxValue)
            => Polyrand.Next(minValue,maxValue);

        public override void NextBytes(byte[] buffer)
        {
            var src = Bytes().Take(buffer.Length);
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                buffer[i++] = it.Current;
        }

        public override void NextBytes(Span<byte> buffer)
        {
            var src = Bytes().Take(buffer.Length);
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                buffer[i++] = it.Current;
        }
     
        public override double NextDouble()
            => Polyrand.Next<double>();
 
        IEnumerable<byte> Bytes()
        {
            var queue = new Queue<byte>(8);
            while(true)
            {
                if(queue.TryDequeue(out byte b))
                    yield return b;
                else
                {
                    var bytes = BitConverter.GetBytes(Polyrand.Next<ulong>());
                    for(var i = 0; i< bytes.Length; i++)
                        if(i == 0)
                            yield return bytes[i];
                        else
                            queue.Enqueue(bytes[i]);
                }                
            }
        } 
    }
}