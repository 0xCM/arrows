//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {         
        static uint GetBits32(Vec256<byte> x, Vec256<uint> pos)
        {
            var pshufb_mask = Vec256.FromBytes(0,0,0,0, 0,0,0,0, 128,64,32,16, 8,4,2,1, 0,0,0,0, 0,0,0,0, 128,64,32,16, 8,4,2,1);
            var byte_pos = shiftr(pos,3);
            byte_pos = and(byte_pos, Vec256.Fill((byte)0x1F).As<uint>());
            var bit_pos = and(pos, Vec256.Fill((byte)0x07u).As<uint>()).As<byte>();
            dinx.shuffle(pshufb_mask, bit_pos);

            return default;
        }



    }

}






//https://stackoverflow.com/questions/54408726/whats-the-fastest-way-to-perform-an-arbitrary-128-256-512-bit-permutation-using?noredirect=1&lq=1
/*
uint32_t get_32_bits(__m256i x, __m256i pos){
    __m256i pshufb_mask  = _mm256_set_epi8(0,0,0,0, 0,0,0,0, 128,64,32,16, 8,4,2,1, 0,0,0,0, 0,0,0,0, 128,64,32,16, 8,4,2,1);
    __m256i byte_pos     = _mm256_srli_epi32(pos, 3);                       // which byte within the 32 bytes    
            byte_pos     = _mm256_and_si256(byte_pos, _mm256_set1_epi8(0x1F)); // mask off the unwanted bits
    __m256i bit_pos      = _mm256_and_si256(pos, _mm256_set1_epi8(0x07));   // which bit within the byte    
    __m256i bit_pos_mask = _mm256_shuffle_epi8(pshufb_mask, bit_pos);       // get bit mask
    __m256i bytes_wanted = shuf_epi8_lc(x, byte_pos);                       // get the right bytes
    __m256i bits_wanted  = _mm256_and_si256(bit_pos_mask, bytes_wanted);    // apply the bit mask to get rid of the unwanted bits within the byte
    __m256i bits_x8      = _mm256_cmpeq_epi8(bits_wanted, bit_pos_mask);    // check if the bit is set
            return _mm256_movemask_epi8(bits_x8);
}
*/