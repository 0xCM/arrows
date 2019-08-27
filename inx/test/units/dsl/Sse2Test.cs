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

    public class Sse2Test : UnitTest<Sse2Test>
    {

        public void _mm_sll_epi16()
        {
            void test()
            {
                var x1 = Random.CpuVec128<ushort>();
                var x1ctrl = Random.CpuVec128<ushort>();            
                var y1 = x86._mm_sll_epi16(x1,x1ctrl);
                var z1 = Bits.sll(x1,(byte)x1ctrl[0]);
                Claim.eq(y1,z1);
            }

            Verify(test);                                

        }

        public void _mm_sll_epi32_test()
        {
            void test()
            {
                var x1 = Random.CpuVec128<uint>();
                var x1ctrl = Random.CpuVec128<uint>();            
                var y1 = x86._mm_sll_epi16(x1,x1ctrl);
                var z1 = Bits.sll(x1,(byte)x1ctrl[0]);
                Claim.eq(y1,z1);
            }

            Verify(test);                                
            
        }

        public void _mm_sll_epi64_test()
        {
            void test()
            {
                var x1 = Random.CpuVec128<ulong>();
                var x1ctrl = Random.CpuVec128<ulong>();            
                var y1 = x86._mm_sll_epi16(x1,x1ctrl);
                var z1 = Bits.sll(x1,(byte)x1ctrl[0]);
                Claim.eq(y1,z1);
            }

            Verify(test);                                
            
        }

        public void _mm_slli_epi16_test()
        {
            void test()
            {
                var x1 = Random.CpuVec128<ushort>();
                var x1ctrl = Random.Next((byte)1, (byte)4);
                var y1 = x86._mm_slli_epi16(x1,x1ctrl);
                var z1 = Bits.slli(x1,x1ctrl);
                Claim.eq(y1,z1);
            }

            Verify(test);                                

        }


        public void _mm_slli_epi32_test()
        {
            void test()
            {
                var x1 = Random.CpuVec128<uint>();
                var x1ctrl = Random.Next((byte)1, (byte)4);
                var y1 = x86._mm_slli_epi32(x1,x1ctrl);
                var z1 = Bits.slli(x1,x1ctrl);
                Claim.eq(y1,z1);
            }

            Verify(test);                                


        }

        public void _mm_slli_epi64_test()
        {
            void test()
            {
                var x1 = Random.CpuVec128<ulong>();
                var x1ctrl = Random.Next((byte)1, (byte)4);
                var y1 = x86._mm_slli_epi64(x1,x1ctrl);
                var z1 = Bits.slli(x1,x1ctrl);
                Claim.eq(y1,z1);
            }

            Verify(test);                                

        }

    }


}