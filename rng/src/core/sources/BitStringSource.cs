//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class BitStringSource : IPointSource<BitString>
    {        
        public BitStringSource(IPolyrand random, Interval<int> length)
        {
            this.Random = random;
            this.Length = length;
        }

        readonly IPolyrand Random;        

        public readonly Interval<int> Length;

        public RngKind RngKind 
            => Random.RngKind;

        public BitString Next()
            => Random.BitString(Length);
    }


}