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

        void Rot256u32(int cycles = DefaltCycleCount)
        {
            for(var cycle=0; cycle< cycles; cycle++)
            {
                var src = Random.CpuVec256<uint>();
                var offsets = Random.CpuVec256(closed(2u, 30u));
                
                var vL = Bits.rotl(src,offsets);
                var vRL = Bits.rotr(vL,offsets);
                Claim.eq(src,vRL);
                
                var vR = Bits.rotr(src,offsets);
                var vLR = Bits.rotl(vR,offsets);
                Claim.eq(src,vLR);

                for(var i=0; i<src.Length(); i++)
                {
                    Claim.eq(Bits.rotl(src[i], offsets[i]), vL[i]);
                    Claim.eq(Bits.rotr(vL[i], offsets[i]), vRL[i]);
                    
                    Claim.eq(Bits.rotr(src[i], offsets[i]), vR[i]);
                    Claim.eq(Bits.rotl(vR[i], offsets[i]), vLR[i]);
                }
        
            }
        }

        void TraceRot(Vec256<uint> src, Vec256<uint> offsets)
        {
            var vL = Bits.rotl(src, offsets);
            var vX = Bits.rotr(vL, offsets);

            Trace("src", src.FormatHex(), 20);
            Trace("offsets", offsets.FormatHex(), 20);                
            Trace("rotl(src)", vL.FormatHex(), 20);
            Trace("rotr(rotl(src))", vX.FormatHex(), 20);

        }
        public void Rot256()
        {
            Rot256u32();

        }

    }

}