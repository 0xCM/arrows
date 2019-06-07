//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Xunit;
    
    using static zfunc;

    
    public class RandomTest : UnitTest<RandomTest>
    {

        [Fact]
        public void I8DomainSatisifed()
        {
            var samples = Pow2.T11;
            var domain = closed((sbyte)(-100),(sbyte)(100));
            var data = Randomizer.Stream<sbyte>(domain).Take(samples);
            var h = Histogram.define(domain,10);
            h.Deposit(data,false);
        }

        [Fact]
        public void U32DomainSatisifed()
        {
            var samples = Pow2.T11;
            var domain = closed(1u,1000u);
            var data = Randomizer.Stream<uint>(domain).Take(samples);
            var h = Histogram.define(domain);
            h.Deposit(data,false);
        }


        [Fact]
        public void U64DomainSatisfied()
        {
            var samples = Pow2.T11;
            var domain = closed(1ul,1000ul);
            var data = Randomizer.Stream<ulong>(domain).Take(samples);
            var h = Histogram.define(domain);
            h.Deposit(data,false);
        }

        [Fact]
        public void I64DomainSatisfied()
        {
            var samples = Pow2.T11;
            var domain = closed(-250L,250L);
            var data = Randomizer.Stream<long>(domain).Take(samples);
            var h = Histogram.define(domain);
            h.Deposit(data,false);
        
        }

    }


}