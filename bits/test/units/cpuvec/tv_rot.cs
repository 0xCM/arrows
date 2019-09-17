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



        void rotv_128x32u()
        {
            rotv_128<uint>((2u, 30u));
        }

        public void rotv_128x64u()
        {
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVec128<ulong>();
                var offsets = Random.CpuVec128(closed(2ul, 30ul));
                
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

        public void rot_256x8u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVec256<byte>();
                var offset = Random.Next(closed<byte>(2, 6));
                
                var vL = Bits.rotl(src,offset);                
                var vRL = Bits.rotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = Bits.rotr(src,offset);
                var vLR = Bits.rotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);

            }

        }

        public void rot_256x16u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVec256<ushort>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = Bits.rotl(src,offset);
                var vRL = Bits.rotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = Bits.rotr(src,offset);
                var vLR = Bits.rotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);
            }
        }

        public void rot_256x32u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVec256<uint>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = Bits.rotl(src,offset);
                var vRL = Bits.rotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = Bits.rotr(src,offset);
                var vLR = Bits.rotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);
            }
        }

        public void rot_256x64u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVec256<ulong>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = Bits.rotl(src,offset);
                var vRL = Bits.rotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = Bits.rotr(src,offset);
                var vLR = Bits.rotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);
            }
        }


        public void rotv_256x32u()
        {
            for(var sample=0; sample < SampleSize; sample++)
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

        public void rotv_256x64u()
        {
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVec256<ulong>();
                var offsets = Random.CpuVec256(closed(2ul, 30ul));
                
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


        void rotl_check(Vec256<byte> src, byte offset, Vec256<byte> computed)        
            => Claim.eq(Bits.rotl(src.ToSpan(), offset), computed.ToSpan());

        void rotr_check(Vec256<byte> src, byte offset, Vec256<byte> computed)        
            => Claim.eq(Bits.rotr(src.ToSpan(), offset), computed.ToSpan());

        void rotl_check(Vec256<ushort> src, ushort offset, Vec256<ushort> computed)        
            => Claim.eq(Bits.rotl(src.ToSpan(), offset), computed.ToSpan());

        void rotr_check(Vec256<ushort> src, ushort offset, Vec256<ushort> computed)        
            => Claim.eq(Bits.rotr(src.ToSpan(), offset), computed.ToSpan());

        void rotl_check(Vec256<uint> src, uint offset, Vec256<uint> computed)        
            => Claim.eq(Bits.rotl(src.ToSpan(), offset), computed.ToSpan());

        void rotr_check(Vec256<uint> src, uint offset, Vec256<uint> computed)        
            => Claim.eq(Bits.rotr(src.ToSpan(), offset), computed.ToSpan());

        void rotl_check(Vec256<ulong> src, ulong offset, Vec256<ulong> computed)        
            => Claim.eq(Bits.rotl(src.ToSpan(), offset), computed.ToSpan());

        void rotr_check(Vec256<ulong> src, ulong offset, Vec256<ulong> computed)        
            => Claim.eq(Bits.rotr(src.ToSpan(), offset), computed.ToSpan());

        void TraceRot(Vec256<uint> src, Vec256<uint> offsets)
        {
            var vL = Bits.rotl(src, offsets);
            var vX = Bits.rotr(vL, offsets);

            Trace("src", src.FormatHex(), 20);
            Trace("offsets", offsets.FormatHex(), 20);                
            Trace("rotl(src)", vL.FormatHex(), 20);
            Trace("rotr(rotl(src))", vX.FormatHex(), 20);
        }

        void rotv_128<T>(Interval<T> shiftRange)
            where T : unmanaged
        {
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVec128<T>();
                var offsets = Random.CpuVec128(shiftRange);
                
                var vL = gbits.rotl(src,offsets);
                var vRL = gbits.rotr(vL,offsets);
                Claim.eq(src,vRL);
                
                var vR = gbits.rotr(src,offsets);
                var vLR = gbits.rotl(vR,offsets);
                Claim.eq(src,vLR);


                for(var i=0; i<src.Length(); i++)
                {
                    Claim.eq(gbits.rotl(src[i], offsets[i]), vL[i]);
                    Claim.eq(gbits.rotr(vL[i], offsets[i]), vRL[i]);
                    
                    Claim.eq(gbits.rotr(src[i], offsets[i]), vR[i]);
                    Claim.eq(gbits.rotl(vR[i], offsets[i]), vLR[i]);
                }        
            }
        }


    }

}