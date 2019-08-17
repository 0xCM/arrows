//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class BitRotateTest : UnitTest<BitRotateTest>
    {
        OpTimePair RotL<T>(int cycles = DefaltCycleCount)
            where T : struct
        {
            var sw = stopwatch(false);
            var swBs = stopwatch(false);
            var offset = Random.Next(closed<uint>(1, bitsize<T>()));
            var offsetT = convert<uint,T>(offset);
            for(var i=0; i<cycles; i++)
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

            OpTime otBs = (cycles,snapshot(swBs), $"rotlBs<{typeof(T).DisplayName()}>");
            OpTime ot = (cycles,snapshot(sw), $"rotl<{typeof(T).DisplayName()}>");

            return (ot,otBs);
        }


        public void RotLeftU8()
        {
            Collect(RotL<byte>(Pow2.T12));

            //Trace($"{bsRef} |> rotl {offset} |> {bs}");            

        }

        

        public void RotLeft256u16()
        {
            var x = Random.CpuVec256<ushort>();
            var offset = (byte)3;
            var xR = Bits.rotl(x,offset);

            var y = new ushort[x.Length()];
            for(var i=0; i<y.Length(); i++)
                y[i] = Bits.rotl(x[i],offset);
            var yR = Vec256.Load(y);

            Claim.eq(xR,yR);
                    
        }

        public void RotLeftU16()
        {

            Collect(RotL<ushort>(Pow2.T12));
            
        }

        public void RotLeftU32()
        {
            Collect(RotL<uint>(Pow2.T12));

        }

        public void RotLeftU64()
        {
            Collect(RotL<ulong>(Pow2.T12));

        }

    }

}