//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class tv_avg : UnitTest<tv_avg>
    {     
        public void avg256u8()
        {            
            for(var j=0; j < SampleSize; j++)
            {
                var x = Polyrand.CpuVec256<byte>();
                var y = Polyrand.CpuVec256<byte>();
                var a = dinx.avg(x,y);
                var b = math.avgi(x.ToSpan(), y.ToSpan());
                for(var i=0; i< b.Length; i++)
                    Claim.eq(a[i], b[i]);
            }
        }

        public void avg256u16()
        {            
            for(var j=0; j < SampleSize; j++)
            {
                var x = Polyrand.CpuVec256<ushort>();
                var y = Polyrand.CpuVec256<ushort>();
                var a = dinx.avg(x,y);
                var b = math.avgi(x.ToSpan(), y.ToSpan());
                for(var i=0; i< b.Length; i++)
                    Claim.eq(a[i], b[i]);
            }
        }

        public void avg256u8_bench()
        {
            Collect(avg_bench(true));
            Collect(avg_bench(false));
        }

        OpTime avg_bench(bool reference)
        {

            OpTime refbench()        
            {
                var sw = stopwatch(false);
                for(var i=0; i<SampleSize; i++)
                {
                    var x = Polyrand.Span256<byte>();
                    var y = Polyrand.Span256<byte>();
                    sw.Start();
                    var b = math.avgi(x, y);
                    sw.Stop();
                }
                return OpTime.Define<byte>(SampleSize, sw, $"vavg-ref");
            }

            OpTime opbench()
            {
                var sw = stopwatch(false);
                for(var i=0; i<SampleSize; i++)
                {
                    var x = Polyrand.CpuVec256<byte>();
                    var y = Polyrand.CpuVec256<byte>();
                    sw.Start();
                    var a = dinx.avg(x,y);
                    sw.Stop();
                }
                return OpTime.Define<byte>(SampleSize, sw, $"vavg");        

            }

            if(reference)
                return refbench();
            else
                return opbench();
        }

    }

}
