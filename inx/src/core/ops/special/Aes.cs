//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
            

    using static zfunc;    

    using AES = System.Runtime.Intrinsics.X86.Aes;

    /// <summary>
    /// Surfaces AES intrinsics
    /// </summary>
    public static class Aes
    {
        /// <summary>
        /// __m128i _mm_aesenc_si128 (__m128i a, __m128i RoundKey) AESENC xmm, xmm/m128
        /// Performs one round of an AES encryption flow on the source data using the round key
        /// </summary>
        /// <param name="src">The data to be encrypted</param>
        /// <param name="key">The round key</param>
        /// <algorithm>
        /// state := a
        /// a[127:0] := ShiftRows(a[127:0])
        /// a[127:0] := SubBytes(a[127:0])
        /// a[127:0] := MixColumns(a[127:0])
        /// dst[127:0] := a[127:0] XOR RoundKey[127:0]        
        /// </algorithm>        
        [MethodImpl(Inline)]
        public static Vec128<byte> enc(Vec128<byte> src, Vec128<byte> key)
            => AES.Encrypt(src,key);

        /// <summary>
        /// __m128i _mm_aesenclast_si128 (__m128i a, __m128i RoundKey) AESENCLAST xmm, xmm/m128
        /// AES Encrypt (last)
        /// </summary>
        /// <param name="src">The last block of data to be encrypted</param>
        /// <param name="key">The round key</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> encl(Vec128<byte> src, Vec128<byte> key)
            => AES.EncryptLast(src,key);

        /// <summary>
        /// __m128i _mm_aesdec_si128 (__m128i a, __m128i RoundKey) AESDEC xmm, xmm/m128
        /// Performs one round of an AES decryption flow on the source data using the round key
        /// </summary>
        /// <param name="src">The data to be decrypted</param>
        /// <param name="key">The round key</param>
        /// <algorithm>
        /// state := a
        /// a[127:0] := InvShiftRows(a[127:0])
        /// a[127:0] := InvSubBytes(a[127:0])
        /// a[127:0] := InvMixColumns(a[127:0])
        /// dst[127:0] := a[127:0] XOR RoundKey[127:0]
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec128<byte> dec(Vec128<byte> src, Vec128<byte> key)
            => AES.Decrypt(src,key);

        /// <summary>
        /// __m128i _mm_aesdeclast_si128 (__m128i a, __m128i RoundKey) AESDECLAST xmm, xmm/m128
        /// Performs the last round of an AES decryption flow on the source data using the round key
        /// </summary>
        /// <param name="src">The data to be decrypted</param>
        /// <param name="key">The round key</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> decl(Vec128<byte> src, Vec128<byte> key)
            => AES.DecryptLast(src,key);

        /// <summary>
        /// __m128i _mm_aesimc_si128 (__m128i a) AESIMC xmm, xmm/m128
        /// Applies the InvMixColumns transformation to the source
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> invmix(Vec128<byte> src)
            => AES.InverseMixColumns(src);

        /// <summary>
        /// _m128i _mm_aeskeygenassist_si128 (__m128i a, const int imm8) AESKEYGENASSIST xmm, xmm/m128, imm8
        /// Assist in expanding the AES cipher key by computing steps towards generating a round key for 
        /// encryption cipher using data from a and an 8-bit round constant specified in imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="imm8"></param>
        /// <algorithm>
        /// X3[31:0] := a[127:96]
        /// X2[31:0] := a[95:64]
        /// X1[31:0] := a[63:32]
        /// X0[31:0] := a[31:0]
        /// RCON[31:0] := ZeroExtend(imm8[7:0])
        /// dst[31:0] := SubWord(X1)
        /// dst[63:32] := RotWord(SubWord(X1)) XOR RCON
        /// dst[95:64] := SubWord(X3)
        /// dst[127:96] := RotWord(SubWord(X3)) XOR RCON
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec128<byte> kgassist(Vec128<byte> src,byte imm8)
            => AES.KeygenAssist(src,imm8);

        public static void enc(Span128<byte> src, Vec128<byte> key, Span128<byte> dst)            
        {
            for(var block = 0; block < src.BlockCount; block++)
                 vstore(enc(src.LoadVec128(block),key), ref dst.Block(block));
        }

        public static void dec(Span128<byte> src, Vec128<byte> key, Span128<byte> dst)            
        {
            for(var block = 0; block < src.BlockCount; block++)
                 vstore(dec(src.LoadVec128(block),key), ref dst.Block(block));
        }

    }

}