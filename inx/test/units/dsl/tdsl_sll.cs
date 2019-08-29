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

    public class tdsl_sll : UnitTest<tdsl_sll>
    {

        public void _mm_sll_epi16()
        {
            void test()
            {
                var x1 = Random.CpuVec128<ushort>();
                var offset = Random.Next(ShiftRange<ushort>());            
                var y1 = x86._mm_sll_epi16(x1,offset);
                var z1 = Bits.sll(x1,offset);
                Claim.eq(y1,z1);
            }

            Verify(test);                                

        }

        public void _mm_sll_epi32()
        {
            void test()
            {
                var x1 = Random.CpuVec128<uint>();
                var offset = Random.Next(ShiftRange<uint>());            
                var y1 = x86._mm_sll_epi32(x1,offset);
                var z1 = Bits.sll(x1,offset);
                Claim.eq(y1,z1);
            }

            Verify(test);                                
            
        }


        public void _mm_sll_epi64()
        {
            void test()
            {
                var x1 = Random.CpuVec128<ulong>();
                var offset = Random.Next(ShiftRange<ulong>());            
                var y1 = x86._mm_sll_epi64(x1,offset);
                var z1 = Bits.sll(x1,offset);
                Claim.eq(y1,z1);
            }

            Verify(test);                                
            
        }

        public void _mm_slli_epi16()
        {
            void test()
            {
                var x1 = Random.CpuVec128<ushort>();
                var offset = Random.Next(ShiftRange<ushort>());            
                var y1 = x86._mm_slli_epi16(x1,offset);
                var z1 = Bits.slli(x1,offset);
                Claim.eq(y1,z1);
            }

            Verify(test);                                
        }

        public void _mm_slli_epi32()
        {
            void test()
            {
                var x1 = Random.CpuVec128<uint>();
                var offset = Random.Next(ShiftRange<uint>());            
                var y1 = x86._mm_slli_epi32(x1,offset);
                var z1 = Bits.slli(x1,offset);
                Claim.eq(y1,z1);
            }

            Verify(test);                                
        }

        public void _mm_slli_epi64_test()
        {
            void test()
            {
                var x1 = Random.CpuVec128<ulong>();
                var offset = Random.Next(ShiftRange<ulong>());            
                var y1 = x86._mm_slli_epi64(x1,offset);
                var z1 = Bits.slli(x1,offset);
                Claim.eq(y1,z1);
            }

            Verify(test);                                

        }
    }
}