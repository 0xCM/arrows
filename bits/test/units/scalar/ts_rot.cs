//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class ts_rot : UnitTest<ts_rot>
    {
        public void rotl8u()
        {
            Collect(rotl_check<byte>(CycleCount));
        }

        public void rotl16u()
        {
            Collect(rotl_check<ushort>(CycleCount));            
        }

        public void rotl32u()
        {
            Collect(rotl_check<uint>(CycleCount));
        }

        public void rotl64u()
        {
            Collect(rotl_check<ulong>(CycleCount));
        }

        OpTimePair rotl_check<T>(int cycles = DefaltCycleCount)
            where T : struct
        {
            var sw = stopwatch(false);
            var swBs = stopwatch(false);
            var offset = Polyrand.Next(closed<uint>(1, bitsize<T>()));
            var offsetT = convert<uint,T>(offset);
            for(var i=0; i<cycles; i++)
            {
                var x = Polyrand.Next<T>();                
                var bsx = BitString.FromScalar(in x);
                var bsxRef = bsx.Replicate();
                Claim.eq(x,bsx.TakeValue<T>());

                sw.Start();
                gbits.rotl(ref x, offsetT);
                sw.Stop();

                swBs.Start();
                bsx.RotL(offset);
                swBs.Stop();
                
                var y = bsx.TakeValue<T>();
                if(gmath.neq(x,y))
                {
                    Trace($"{bsxRef} |> rotl {offset} |> {bsx} != {BitString.FromScalar(x)}");
                }
                Claim.eq(x,y);

            }

            OpTime otBs = (cycles,snapshot(swBs), $"rotlBs<{typeof(T).DisplayName()}>");
            OpTime ot = (cycles,snapshot(sw), $"rotl<{typeof(T).DisplayName()}>");

            return (ot,otBs);
        }
    }
}