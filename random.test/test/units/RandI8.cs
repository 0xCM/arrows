//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rng
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    
    public class RandI8 : UnitTest<RandomTest>
    {    
        // public void PointSourceU8()
        // {
        //     var source = Random.PointSource<ulong>().Require().DeriveSource(Interval<byte>.Full);
        //     var samples = source.Take(Pow2.T16);
        //     var bins = new Dictionary<byte,int>();
        //     foreach(var sample in samples)
        //     {
        //         if(bins.TryGetValue(sample, out int count))
        //             bins[sample] = ++count;
        //         else
        //             bins[sample] = 1;
        //     }

        //     var avg = bins.Values.Average();
        //     var delta = bins.Map(kvp =>  (kvp.Key,  Math.Abs((((double)kvp.Value - avg) / avg)))).OrderBy(x => x.Key);
        //     foreach(var d in delta)
        //         Claim.lteq(d.Item2, .2);
        // }

        // public void PointSourceI8()
        // {
        //     var source = Random.PointSource<ulong>().Require().DeriveSource(Interval<byte>.Full).DeriveSource(Interval<sbyte>.Full);
        //     var samples = source.Take(Pow2.T16);
        //     var bins = new Dictionary<sbyte,int>();
        //     foreach(var sample in samples)
        //     {
        //         if(bins.TryGetValue(sample, out int count))
        //             bins[sample] = ++count;
        //         else
        //             bins[sample] = 1;
        //     }



        // }

    }

}