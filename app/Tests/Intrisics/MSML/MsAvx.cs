// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//This code in this file was extracted from the MSML project
namespace Z0.External
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using nuint = System.UInt64;

    public static partial class MsAvx
    {
        public static readonly uint[] LeadingAlignmentMask = new uint[64]
        {
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0xFFFFFFFF, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0x00000000, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0x00000000,
        };

        public static readonly uint[] TrailingAlignmentMask = new uint[64]
        {
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0xFFFFFFFF,
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0xFFFFFFFF, 0xFFFFFFFF,
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0x00000000, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF,
            0x00000000, 0x00000000, 0x00000000, 0x00000000, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF,
            0x00000000, 0x00000000, 0x00000000, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF,
            0x00000000, 0x00000000, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF,
            0x00000000, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF,
        };

        private static readonly Vector256<float> _absMask256 = Vector256.Create(0x7FFFFFFF).AsSingle();

        private const int Vector256Alignment = 32;

        // dst[i] = a * (dst[i] + b)
        public static unsafe void ScaleAddU(float a, float b, Span<float> dst)
        {
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pDstEnd = pdst + dst.Length;
                float* pDstCurrent = pdst;
                float* pVectorizationEnd = pDstEnd - 4;

                Vector256<float> a256 = Vector256.Create(a);
                Vector256<float> b256 = Vector256.Create(b);

                while (pDstCurrent + 8 <= pDstEnd)
                {
                    Vector256<float> dstVector = Avx.LoadVector256(pDstCurrent);
                    dstVector = Avx.Add(dstVector, b256);
                    dstVector = Avx.Multiply(dstVector, a256);
                    Avx.Store(pDstCurrent, dstVector);

                    pDstCurrent += 8;
                }

                Vector128<float> a128 = Vector128.Create(a);
                Vector128<float> b128 = Vector128.Create(b);

                if (pDstCurrent <= pVectorizationEnd)
                {
                    Vector128<float> dstVector = Sse.LoadVector128(pDstCurrent);
                    dstVector = Sse.Add(dstVector, b128);
                    dstVector = Sse.Multiply(dstVector, a128);
                    Sse.Store(pDstCurrent, dstVector);

                    pDstCurrent += 4;
                }

                while (pDstCurrent < pDstEnd)
                {
                    Vector128<float> dstVector = Sse.LoadScalarVector128(pDstCurrent);
                    dstVector = Sse.AddScalar(dstVector, b128);
                    dstVector = Sse.MultiplyScalar(dstVector, a128);
                    Sse.StoreScalar(pDstCurrent, dstVector);

                    pDstCurrent++;
                }
            }
        }


        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> GetHigh(in Vector256<float> x)
            => Avx.ExtractVector128(x, 1);

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> VectorSum256(in Vector256<float> vector)
        {
            Vector256<float> partialSum = Avx.HorizontalAdd(vector, vector);
            return Avx.HorizontalAdd(partialSum, partialSum);
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector256<float> MultiplyAdd(float* psrc1, Vector256<float> src2, Vector256<float> src3)
        {
            if (Fma.IsSupported)
            {
                return Fma.MultiplyAdd(Avx.LoadVector256(psrc1), src2, src3);
            }
            else
            {
                Vector256<float> product = Avx.Multiply(src2, Avx.LoadVector256(psrc1));
                return Avx.Add(product, src3);
            }
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static Vector256<float> MultiplyAdd(Vector256<float> src1, Vector256<float> src2, Vector256<float> src3)
        {
            if (Fma.IsSupported)
            {
                return Fma.MultiplyAdd(src1, src2, src3);
            }
            else
            {
                Vector256<float> product = Avx.Multiply(src1, src2);
                return Avx.Add(product, src3);
            }
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static Vector256<float> VectorMax256(in Vector256<float> vector)
        {
            // The control byte shuffles the eight 32-bit floats of partialMax: ABCD|EFGH -> BADC|FEHG.
            Vector256<float> x1 = Avx.Shuffle(vector, vector, 0xB1);

            // Performs element-wise maximum operation: The 1st, 3rd, 5th, and 7th 32-bit slots become
            // max(A, B), max(C, D), max(E, F), and max(G, H).
            Vector256<float> partialMax = Avx.Max(vector, x1);

            // The control byte shuffles the eight 32-bit floats of partialMax: ABCD|EFGH -> CAAA|GEEE.
            x1 = Avx.Shuffle(partialMax, partialMax, 0x02);

            // Performs element-wise maximum operation: The 1st and 5th 32-bit slots become
            // max(max(A, B), max(C, D)) = max(A, B, C, D) and
            // max(max(E, F), max(G, H)) = max(E, F, G, H).
            return Avx.Max(partialMax, x1);
        }


        public static unsafe float MaxAbsU(ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector256<float> result256 = Vector256<float>.Zero;

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);
                    result256 = Avx.Max(result256, Avx.And(srcVector, _absMask256));

                    pSrcCurrent += 8;
                }

                result256 = VectorMax256(in result256);
                Vector128<float> resultPadded = Sse.MaxScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    result128 = Sse.Max(result128, Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent += 4;
                }

                result128 = MsSse.VectorMax128(in result128);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    result128 = Sse.MaxScalar(result128, Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent++;
                }

                return Sse.MaxScalar(result128, resultPadded).ToScalar();
            }
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static unsafe float* GetAlignedBase(AlignedArray alignedArray, float* unalignedBase)
        {
            float* alignedBase = unalignedBase + alignedArray.GetBase((long)unalignedBase);
            //Contracts.Assert(((long)alignedBase % Vector256Alignment) == 0);
            return alignedBase;
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static bool HasCompatibleAlignment(AlignedArray alignedArray)
        {
            // Contracts.AssertValue(alignedArray);
            // Contracts.Assert(alignedArray.Size > 0);
            return (alignedArray.CbAlign % Vector256Alignment) == 0;
        }


        public static unsafe void MatMul(AlignedArray mat, AlignedArray src, AlignedArray dst, int crow, int ccol)
        {
            // Contracts.Assert(HasCompatibleAlignment(mat));
            // Contracts.Assert(HasCompatibleAlignment(src));
            // Contracts.Assert(HasCompatibleAlignment(dst));

            fixed (float* pSrcStart = &src.Items[0])
            fixed (float* pDstStart = &dst.Items[0])
            fixed (float* pMatStart = &mat.Items[0])
            {
                float* psrc = GetAlignedBase(src, pSrcStart);
                float* pdst = GetAlignedBase(dst, pDstStart);
                float* pmat = GetAlignedBase(mat, pMatStart);

                float* pSrcEnd = psrc + ccol;
                float* pDstEnd = pdst + crow;
                float* pDstCurrent = pdst;
                float* pMatCurrent = pmat;

                while (pDstCurrent < pDstEnd)
                {
                    Vector256<float> res0 = Vector256<float>.Zero;
                    Vector256<float> res1 = res0;
                    Vector256<float> res2 = res0;
                    Vector256<float> res3 = res0;

                    float* pSrcCurrent = psrc;

                    while (pSrcCurrent < pSrcEnd)
                    {
                        float* pMatTemp = pMatCurrent;
                        Claim.eq((nuint)(pMatTemp) % 32,0ul);
                        Claim.eq(((nuint)(pSrcCurrent) % 32), 0ul);

                        // The JIT will only fold away unaligned loads due to the semantics behind
                        // the VEX-encoding of the memory operand for `ins xmm, xmm, [mem]`. Since
                        // modern hardware has unaligned loads that are as fast as aligned loads,
                        // when it doesn't cross a cache-line/page boundary, we will just assert
                        // that the alignment is correct and allow for the more-efficient codegen.
                        Vector256<float> x01 = Avx.LoadVector256(pMatTemp);
                        Vector256<float> x11 = Avx.LoadVector256(pMatTemp += ccol);
                        Vector256<float> x21 = Avx.LoadVector256(pMatTemp += ccol);
                        Vector256<float> x31 = Avx.LoadVector256(pMatTemp += ccol);
                        Vector256<float> x02 = Avx.LoadVector256(pSrcCurrent);

                        res0 = MultiplyAdd(x01, x02, res0);
                        res1 = MultiplyAdd(x11, x02, res1);
                        res2 = MultiplyAdd(x21, x02, res2);
                        res3 = MultiplyAdd(x31, x02, res3);

                        pSrcCurrent += 8;
                        pMatCurrent += 8;
                    }

                    // Add up the entries of each, with the 4 results in res0
                    res0 = Avx.HorizontalAdd(res0, res1);
                    res2 = Avx.HorizontalAdd(res2, res3);
                    res0 = Avx.HorizontalAdd(res0, res2);

                    Vector128<float> sum = Sse.Add(res0.GetLower(), GetHigh(in res0));
                    Sse.StoreAligned(pDstCurrent, sum);

                    pDstCurrent += 4;
                    pMatCurrent += 3 * ccol;
                }
            }
        }


        public static unsafe float Sum(ReadOnlySpan<float> src)
        {
            fixed (float* pSrc = &MemoryMarshal.GetReference(src))
            fixed (uint* pLeadingAlignmentMask = &LeadingAlignmentMask[0])
            fixed (uint* pTrailingAlignmentMask = &TrailingAlignmentMask[0])
            {
                float* pValues = pSrc;
                int length = src.Length;
                Vector256<float> result = Vector256<float>.Zero;

                nuint address = (nuint)(pValues);
                int misalignment = (int)(address % 32);
                int remainder = 0;

                if ((misalignment & 3) != 0)
                {
                    // Handles cases where the data is not 32-bit aligned and we can't ever use aligned operations

                    remainder = length % 8;

                    for (float* pEnd = pValues + (length - remainder); pValues < pEnd; pValues += 8)
                    {
                        result = Avx.Add(result, Avx.LoadVector256(pValues));
                    }
                }
                else
                {
                    if (misalignment != 0)
                    {
                        // Handle cases where the data is not 256-bit aligned by doing an unaligned read and then
                        // masking any elements that will be included in the first aligned read

                        misalignment >>= 2;
                        misalignment = 8 - misalignment;

                        Vector256<float> mask = Avx.LoadVector256(((float*)(pLeadingAlignmentMask)) + (misalignment * 8));
                        Vector256<float> temp = Avx.And(mask, Avx.LoadVector256(pValues));
                        result = Avx.Add(result, temp);

                        pValues += misalignment;
                        length -= misalignment;
                    }

                    if (length > 7)
                    {
                        // Handle all the 256-bit blocks that we can now that we have offset to an aligned address

                        remainder = length % 8;

                        for (float* pEnd = pValues + (length - remainder); pValues < pEnd; pValues += 8)
                        {
                            // The JIT will only fold away unaligned loads due to the semantics behind
                            // the VEX-encoding of the memory operand for `ins xmm, xmm, [mem]`. Since
                            // modern hardware has unaligned loads that are as fast as aligned loads,
                            // when it doesn't cross a cache-line/page boundary, we will just assert
                            // that the alignment is correct and allow for the more-efficient codegen.

                            zcore.demand(((nuint)(pValues) % 32) == 0);
                            result = Avx.Add(result, Avx.LoadVector256(pValues));
                        }
                    }
                    else
                    {
                        // Handle the "worst-case" scenario, which is when we have 8-16 elements and the input is not
                        // 256-bit aligned. This means we can't do any aligned loads and will just end up doing two
                        // unaligned loads where we mask the input each time.
                        remainder = length;
                    }
                }

                if (remainder != 0)
                {
                    // Handle any trailing elements that don't fit into a 128-bit block by moving back so that the next
                    // unaligned load will read to the end of the array and then mask out any elements already processed

                    pValues -= (8 - remainder);

                    Vector256<float> mask = Avx.LoadVector256(((float*)(pTrailingAlignmentMask)) + (remainder * 8));
                    Vector256<float> temp = Avx.And(mask, Avx.LoadVector256(pValues));
                    result = Avx.Add(result, temp);
                }

                // Sum all the elements together and return the result
                result = VectorSum256(in result);
                return Sse.AddScalar(result.GetLower(), GetHigh(result)).ToScalar();
            }
        }


    }


}
