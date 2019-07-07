//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using static zfunc;
    public class App : TestApp<App>
    {            

        void DslBench()
        {
            var lhs = Random.Span256<uint>(Pow2.T11);
            var rhs = Random.Span256<uint>(Pow2.T11);

            var sw2 = stopwatch();
            for(var i=0; i <lhs.BlockCount; i++)
            {
                var v1 = lhs.LoadVec256(i);
                var v2 = rhs.LoadVec256(i);
                dinx.mul(v1,v2);
            }
            print($"direct time = {snapshot(sw2)}");

            var sw1 = stopwatch();
            for(var i=0; i <lhs.BlockCount; i++)
            {
                var v1 = lhs.LoadVec256(i);
                var v2 = rhs.LoadVec256(i);
                x86._mm256_mul_epu32(v1, v2);
            }
            print($"dsl time = {snapshot(sw1)}");

            var sw3 = stopwatch();
            for(var i=0; i <lhs.BlockCount; i++)
            {
                var v1 = lhs.LoadVec256(i);
                var v2 = rhs.LoadVec256(i);
                ginx.mul<uint,ulong>(v1,v2);
            }
            print($"ginx time = {snapshot(sw3)}");

        }

        void RunBlah()
        {
            var ibase = Seed64.Seed10;

            var seeds = span(
                Seed64.Seed00, Seed64.Seed01, Seed64.Seed02, Seed64.Seed03,
                Seed64.Seed04, Seed64.Seed05, Seed64.Seed06, Seed64.Seed07
                );

            var indices = span(
                ibase += 2, ibase += 2, ibase += 2, ibase += 2,
                ibase += 2, ibase += 2,ibase += 2, ibase += 2 
                );
            
            var s0 = seeds.LoadVec256(0);
            var s1 = seeds.LoadVec256(4);
            var i0 = indices.LoadVec256();
            var i1 = indices.LoadVec256(4);

            
            var n = Pow2.T16;
            
            var pcgSuite = Pcg32.Suite(seeds, indices);
            var rngAvx = PcgAvx.Define(m512i.Define(s0,s1), m512i.Define(i0,i1));

            var x1 = pcgSuite.Next();
            var y1 = rngAvx.Next().Extract();

            print($"pcg: {x1.Format()}");
            print($"pcg: {y1.Format()}");

            var sw1 = stopwatch();
            for(var i=0; i<n; i++)
            {
                for(var j=0; j< 8; j++)
                    pcgSuite[j].Next();
            }
            
            var time1 = snapshot(sw1);            
            print($"Generated {n*8} uint32 values via standard algorithm in {time1}");
            
            var sw = stopwatch();
            for(var i=0; i<n; i++)
                rngAvx.Next();
            var time2 = snapshot(sw);
            print($"Generated {n*8} uint32 values via Avx algorithm in {time2}");
            
        }


        protected override void RunTests(string filter)
        {                        

            base.RunTests(filter);        
        }
        public static void Main(params string[] args)
            => Run(args);
    }
}