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
    using static Constants;
    using static Shuffle256;
    
    public enum Shuffle256
    {
        X0 = 0X0,   Y0 = 0x10,
        X1 = 0X1,   Y1 = 0x11,
        X2 = 0X2,   Y2 = 0x12,
        X3 = 0X3,   Y3 = 0x13, 
        X4 = 0X4,   Y4 = 0x14,
        X5 = 0X5,   Y5 = 0x15,
        X6 = 0X6,   Y6 = 0x16,
        X7 = 0X7,   Y7 = 0x17, 
        X8 = 0X8,   Y8 = 0x18,
        X9 = 0X9,   Y9 = 0x19,
        XA = 0XA,   YA = 0x1A,
        XB = 0XB,   YB = 0x1B,
        XC = 0XA,   YC = 0x1C,
        XD = 0XD,   YD = 0x1D,
        XE = 0XE,   YE = 0x1E,
        XF = 0XF,   YF = 0x1F,

    }


    public class InXShuffleTest : UnitTest<InXShuffleTest>
    {        
        public void Shuffle1()
        {
            var mask = Vec128.Fill((byte)0b10000000);
            var src = Random.CpuVec128<byte>();
            var dst = dinx.shuffle(in src, in mask);
            var zed = Vec128.Fill((byte)0);            
            Claim.eq(dst,zed);
                            
        }

        public void Permute4()
        {
            var id = Vec128.FromParts(0,1,2,3);
            Claim.eq(dinx.permute(id, Perm4.ADCB), Vec128.FromParts(0,3,2,1));
            Claim.eq(dinx.permute(id, Perm4.DBCA), Vec128.FromParts(3,1,2,0));
            Permute4i32();
        
        }


        public void Shufle128i32()
        {
            var v1 = Vec128.FromParts(0, 1, 2, 3);
            
            //Produces the identity permutation
            var m1 = (byte)0b11_10_01_00;
            
            //Reversal
            var m2 = (byte)0b00_01_10_11;

            //RotL(1)
            var m3 = (byte)0b10_01_00_11;

            var s1 = dinx.shuffle(v1,m1);
            var s2 = dinx.shuffle(v1,m2);
            var s3 = dinx.shuffle(v1,m3);

            
        }

        public void TestPermIncrement()
        {
            var p = Perm.Identity(16);
            for(var i=0; i<16; i++)
                p.Inc();
            Claim.eq(p, Perm.Identity(16));
        }

        public void TestDecrement()
        {
            var p = Perm.Identity(16);
            for(var i=0; i<16; i++)
                p.Dec();

            Claim.eq(p, Perm.Identity(16));
        }

        void Permute4i32(int cycles = DefaltCycleCount, bool trace = false)
        {
            var pSrc = Random.EnumStream<Perm4>(x => (byte)x > 5);
            
            for(var i=0; i<cycles; i++)
            {
                var v1 = Random.CpuVec128<int>(); 
                var p = pSrc.First();
                
                // Disassemble the spec
                var p0 = Bits.extract((byte)p, 0b11);                
                var p1 = Bits.extract((byte)p, 0b1100);
                var p2 = Bits.extract((byte)p, 0b110000);
                var p3 = Bits.extract((byte)p, 0b11000000);
                
                // Reassemble the spec
                Perm4 q = (Perm4)(p0 | p1 << 2 | p2 << 4 | p3 << 6);
                
                // Same?
                Claim.eq(p,q);

                // Permute vector via api
                var v2 = dinx.permute(v1,p);

                // Permute vector manually
                var v3 = Vec128.FromParts(v1[p0],v1[p1],v1[p2],v1[p3]);

                // Same?
                Claim.eq(v3,v2);

                if(trace)
                {
                    Trace("v1",v1.FormatHex());                
                    Trace("p", p.Format());
                    Trace("perm(v1,p)", v2.FormatHex());
                }
                                
            }
        }

    }

}
