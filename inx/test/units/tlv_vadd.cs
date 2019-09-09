//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using VecLen = NatSeq<N1,N2,N3>;
    
    using static zfunc;

    public class tlv_vadd : UnitTest<tlv_vadd>
    {   
        public void vadd()
        {
            vadd_check<VecLen,byte>();
            vadd_check<VecLen,sbyte>();
            vadd_check<VecLen,short>();
            vadd_check<VecLen,ushort>();
            vadd_check<VecLen,int>();
            vadd_check<VecLen,uint>();
            vadd_check<VecLen,long>();
            vadd_check<VecLen,ulong>();
            vadd_check<VecLen,float>();
            vadd_check<VecLen,double>();
            
        }

        public void vsub()
        {
            vsub_check<VecLen,byte>();
            vsub_check<VecLen,sbyte>();
            vsub_check<VecLen,short>();
            vsub_check<VecLen,ushort>();
            vsub_check<VecLen,int>();
            vsub_check<VecLen,uint>();
            vsub_check<VecLen,long>();
            vsub_check<VecLen,ulong>();
            vsub_check<VecLen,float>();
            vsub_check<VecLen,double>();
        }

        public void vadd_bench()
        {
            var labelPad = 30;
            TracePerf(vadd_check(0ul, 2048ul, n5), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n16), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n32), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n64), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n128), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n256), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n512), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n1024), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n2048), labelPad);
            TracePerf(vadd_check(0ul, 2048ul, n4096), labelPad);

            TracePerf(vadd_check(0d, 2048d, n5), labelPad);
            TracePerf(vadd_check(0d, 2048d, n16), labelPad);
            TracePerf(vadd_check(0d, 2048d, n32), labelPad);
            TracePerf(vadd_check(0d, 2048d, n64), labelPad);
            TracePerf(vadd_check(0d, 2048d, n128), labelPad);
            TracePerf(vadd_check(0d, 2048d, n256), labelPad);
            TracePerf(vadd_check(0d, 2048d, n512), labelPad);
            TracePerf(vadd_check(0d, 2048d, n1024), labelPad);
            TracePerf(vadd_check(0d, 2048d, n2048), labelPad);
            TracePerf(vadd_check(0d, 2048d, n4096), labelPad);           
        }

        OpTimePair vadd_check<N,T>(T min, T max, N n = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var domain = closed(min, max);
            var v1 = Vector.Alloc<N,T>();
            var v2 = Vector.Alloc<N,T>();
            var v3 = Vector.Alloc<N,T>();
            var e3 = Vector.Alloc<N,T>();
            var sw1 = stopwatch(false);            
            var sw2 = stopwatch(false);

            for(var cycle = 0; cycle <CycleCount; cycle++)
            {
                Random.Fill(domain, ref v1);
                Random.Fill(domain, ref v2);

                sw1.Start();
                ginx.add(v1, v2, ref v3);
                sw1.Stop();

                sw2.Start();
                Linear.add(v1, v2, ref e3);
                sw2.Stop();
                Claim.eq(e3.Unsized,v3.Unsized);
            }
            
            var label = $"add<{n},{PrimalKinds.kind<T>()}>";            
            return (
                (CycleCount, sw1,$"{label}/inx"), 
                (CycleCount, sw2, $"{label}/ref")
            );
        }


        void vadd_check<N,T>()
            where N : ITypeNat, new()
            where T : struct
        {
            var n = new N();
            for(var i=0; i< CycleCount; i++)            
            {
                var v1 = Random.NatVec<N,T>();
                var v2 = Random.NatVec<N,T>();
                var v3 = Vector.Load(gmath.add(v1.Unsized,v2.Unsized), n);
                var v4 = Linear.add(ref v1,v2);
                Claim.yea(v3 == v4);
            }
        }

        void vsub_check<N,T>()
            where N : ITypeNat, new()
            where T : struct
        {
            var n = new N();
            for(var i=0; i< CycleCount; i++)            
            {
                var v1 = Random.NatVec<N,T>();
                var v2 = Random.NatVec<N,T>();
                var v3 = Vector.Load(gmath.sub(v1.Unsized,v2.Unsized), n);
                var v4 = Linear.sub(ref v1,v2);
                Claim.yea(v3 == v4);
            }
        }

    }

}