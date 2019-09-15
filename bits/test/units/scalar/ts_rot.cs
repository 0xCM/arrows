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
        public void scalar_rotl_8u()
        {
            Collect(scalar_rotl_check<byte>());
        }

        public void scalar_rotl_16u()
        {
            Collect(scalar_rotl_check<ushort>());            
        }

        public void scalar_rotl_32u()
        {
            Collect(scalar_rotl_check<uint>());
        }

        public void scalar_rotl_64u()
        {
            Collect(scalar_rotl_check<ulong>());
        }

        OpTimePair scalar_rotl_check<T>()
            where T : struct
        {
            var sw = stopwatch(false);
            var swBs = stopwatch(false);
            var offset = Random.Next(closed<uint>(1, bitsize<T>()));
            var offsetT = convert<uint,T>(offset);
            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.Next<T>();                
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

            OpTime otBs = (CycleCount,snapshot(swBs), $"rotlBs<{typeof(T).DisplayName()}>");
            OpTime ot = (CycleCount,snapshot(sw), $"rotl<{typeof(T).DisplayName()}>");

            return (ot,otBs);
        }
    }
}