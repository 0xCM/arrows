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
        public static System.Random FromSource(IRandomSource rng)
            => new SysRand(rng);

        public SysRand(IRandomSource Source)
        {
            this.Source = Source;
        }

        IRandomSource Source {get;}

        Queue<byte> ByteQ {get;}
            = new Queue<byte>(8);

        public override int Next()
            => (int)Source.NextUInt64((ulong)Int32.MaxValue);

        public override int Next(int maxValue)
            => (int)Source.NextUInt64((ulong)maxValue);

        public override int Next(int minValue, int maxValue)
        {
            var delta = maxValue - minValue;
            if(delta > 0)
                return minValue + Next(delta);
            else
                return minValue + Next(-delta);
        }

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
            => Source.NextDouble();
 
        IEnumerable<byte> Bytes()
        {
            while(true)
            {
                if(ByteQ.TryDequeue(out byte b))
                    yield return b;
                else
                {
                    var bytes = BitConverter.GetBytes(Source.NextUInt64());
                    for(var i = 0; i< bytes.Length; i++)
                        if(i == 0)
                            yield return bytes[i];
                        else
                            ByteQ.Enqueue(bytes[i]);
                }                
            }
        } 
    }
}