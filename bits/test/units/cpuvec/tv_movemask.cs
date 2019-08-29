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
    
    using static zfunc;

    public class tv_movemask : UnitTest<tv_movemask>
    {
        public void movemask256u8()
        {
            var n = Pow2.T12;
            var src = Random.Span256<byte>(n);

            for(var i=0; i<n; i++)
            {
                var srcVector = src.ToCpuVec256(i);
                var extract = srcVector.ToSpan();
                var srcBv = extract.ToBitVector();
                Claim.eq(256, srcBv.Length);

                var srcBvBs = srcBv.ToBitString();
                var srcBits = srcVector.ToBitString().ToBits();
                Claim.eq(srcBits.ToBitString(), srcBvBs);
                                                
                var mv = 0u;
                for(var r=0; r<srcVector.Length(); r++)
                    if(BitMask.test(srcVector[r], 7))
                        BitMask.enable(ref mv, r);
                
                var mmExpect = mv.ToBitVector32();
                var mmActual = gbits.movemask(srcVector).ToBitVector32();
                Claim.eq(mmExpect.ToBitString(), mmActual.ToBitString());
            }
        }

        public void movemask128u8()
        {
            var n = Pow2.T12;
            var src = Random.Span128<byte>(n);
            for(var i=0; i<n; i++)
            {
                var srcVector = src.ToCpuVec128(i);

                var mmExpect = BitVector32.Alloc();
                for(byte r=0; r<srcVector.Length(); r++)
                    if(BitMask.test(srcVector[r], 7))
                        mmExpect.Enable(r);
                
                var mmActual = gbits.movemask(srcVector).ToBitVector32();
                Claim.yea(mmExpect == mmActual);
            }
        }

        public void movemask256f32()
        {
            var n = Pow2.T12;
            var src = Random.Span256<float>(n);
            for(var i=0; i<n; i++)
            {
                var srcVector = src.ToCpuVec256(i);

                var mmExpect = BitVector32.Alloc();
                for(byte r=0; r<srcVector.Length(); r++)
                    if(BitMask.test(srcVector[r], 31))
                        mmExpect.Enable(r);
                
                var mmActual = gbits.movemask(srcVector).ToBitVector32();
                Claim.yea(mmExpect == mmActual);
            }
        }


        public void movemask256f64()
        {
            var n = Pow2.T12;
            var src = Random.Span256<double>(n);
            for(var i=0; i<n; i++)
            {
                var srcVector = src.ToCpuVec256(i);

                var mmExpect = BitVector32.Alloc();
                for(byte r=0; r<srcVector.Length(); r++)
                    if(BitMask.test(srcVector[r], 63))
                        mmExpect.Enable(r);
                
                var mmActual = gbits.movemask(srcVector).ToBitVector32();
                Claim.yea(mmExpect == mmActual);
            }
        }
    }
}