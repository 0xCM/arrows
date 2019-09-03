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

    public class tv_rot : UnitTest<tv_rot>
    {
        public override int CycleCount 
            => Pow2.T08;
        
        public void rot256u8()
        {
            rot256u8(CycleCount);

        }

        public void rot256u16()
        {
            rot256u16(CycleCount);                    
        }

        public void rot256u32()
        {
            rot256u32(CycleCount);
        }
                

        void rot256u8(int cycles)
        {
            

            for(var cycle=0; cycle< cycles; cycle++)
            {
                var src = Polyrand.CpuVec256<byte>();
                var offset = Polyrand.Next(closed<byte>(2, 6));
                
                var vL = Bits.rotl(src,offset);                
                var vRL = Bits.rotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = Bits.rotr(src,offset);
                var vLR = Bits.rotl(vR,offset);
                Claim.eq(src,vLR);

                CheckRotL(src, offset, vL);
                CheckRotR(vL, offset, vRL);
                CheckRotR(src, offset, vR);
                CheckRotL(vR, offset, vLR);

            }
        }

        void CheckRotL(Vec256<byte> src, byte offset, Vec256<byte> computed)        
            => Claim.eq(Bits.rotl(src.ToSpan(), offset), computed.ToSpan());

        void CheckRotR(Vec256<byte> src, byte offset, Vec256<byte> computed)        
            => Claim.eq(Bits.rotr(src.ToSpan(), offset), computed.ToSpan());

        void CheckRotL(Vec256<ushort> src, ushort offset, Vec256<ushort> computed)        
            => Claim.eq(Bits.rotl(src.ToSpan(), offset), computed.ToSpan());

        void CheckRotR(Vec256<ushort> src, ushort offset, Vec256<ushort> computed)        
            => Claim.eq(Bits.rotr(src.ToSpan(), offset), computed.ToSpan());

        void rot256u16(int cycles)
        {
            for(var cycle=0; cycle< cycles; cycle++)
            {
                var src = Polyrand.CpuVec256<ushort>();
                var offset = Polyrand.Next(closed<byte>(2, 14));
                
                var vL = Bits.rotl(src,offset);
                var vRL = Bits.rotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = Bits.rotr(src,offset);
                var vLR = Bits.rotl(vR,offset);
                Claim.eq(src,vLR);

                CheckRotL(src, offset, vL);
                CheckRotR(vL, offset, vRL);
                CheckRotR(src, offset, vR);
                CheckRotL(vR, offset, vLR);

            }

        }

        void rot256u32(int cycles)
        {
            for(var cycle=0; cycle< cycles; cycle++)
            {
                var src = Polyrand.CpuVec256<uint>();
                var offsets = Polyrand.CpuVec256(closed(2u, 30u));
                
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


    }

}