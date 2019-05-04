// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//This code in this file was extracted from the MSML project
namespace MS
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using nuint = System.UInt64;

    using static zcore;

    public static class MsSse
    {
                // The count of bytes in Vector128<T>, corresponding to _cbAlign in AlignedArray
        private const int Vector128Alignment = 16;


        public static readonly uint[] SseLeadingAlignmentMask = new uint[16]
        {
            0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0x00000000, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0xFFFFFFFF, 0x00000000, 0x00000000,
            0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0x00000000,
        };

        public static readonly uint[] SseTrailingAlignmentMask = new uint[16]
        {
            0x00000000, 0x00000000, 0x00000000, 0x00000000,
            0x00000000, 0x00000000, 0x00000000, 0xFFFFFFFF,
            0x00000000, 0x00000000, 0xFFFFFFFF, 0xFFFFFFFF,
            0x00000000, 0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF,
        };


        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static unsafe float* GetAlignedBase(AlignedArray alignedArray, float* unalignedBase)
        {
            Contracts.AssertValue(alignedArray);
            float* alignedBase = unalignedBase + alignedArray.GetBase((long)unalignedBase);
            Contracts.Assert(((long)alignedBase & (Vector128Alignment - 1)) == 0);
            return alignedBase;
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static bool HasCompatibleAlignment(AlignedArray alignedArray)
        {
            Contracts.AssertValue(alignedArray);
            Contracts.Assert(alignedArray.Size > 0);
            return (alignedArray.CbAlign % Vector128Alignment) == 0;
        }


        internal static readonly Vector128<float> AbsMask128 = Sse2.IsSupported ?
            Vector128.Create(0x7FFFFFFF).AsSingle() :
            Vector128.Create(BitConverter.Int32BitsToSingle(0x7FFFFFFF));

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        internal static unsafe Vector128<float> Load1(float* src, int* idx)
             => Vector128.CreateScalar(src[idx[0]]);

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        internal static unsafe Vector128<float> Load4(float* src, int* idx)
            => Vector128.Create(src[idx[0]], src[idx[1]], src[idx[2]], src[idx[3]]);

        // The control byte shuffles the four 32-bit floats of x: ABCD -> BCDA.
        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        internal static Vector128<float> Rotate(in Vector128<float> x)
            => Sse.Shuffle(x, x, 0x39);

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        internal static unsafe void Store4(in Vector128<float> x, float* dst, int* idx)
        {
            Sse.StoreScalar(dst + idx[0], x);
            Vector128<float> rotated = Rotate(in x);
            Sse.StoreScalar(dst + idx[1], rotated);
            rotated = Rotate(in rotated);
            Sse.StoreScalar(dst + idx[2], rotated);
            rotated = Rotate(in rotated);
            Sse.StoreScalar(dst + idx[3], rotated);
        }


        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> VectorMax128(in Vector128<float> vector)
        {
            // The control byte shuffles the four 32-bit floats of partialMax: ABCD -> BADC.
            Vector128<float> x1 = Sse.Shuffle(vector, vector, 0xB1);

            // Performs element-wise maximum operation: The 1st and 3rd 32-bit slots become
            // max(A, B) and max(C, D).
            Vector128<float> partialMax = Sse.Max(vector, x1);

            // The control byte shuffles the four 32-bit floats of partialMax: ABCD -> CAAA.
            x1 = Sse.Shuffle(partialMax, partialMax, 0x02);

            // Performs element-wise maximum operation: The 1st 32-bit slot becomes
            // max(A, B, C, D).
            return Sse.MaxScalar(partialMax, x1);
        }


        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        internal static Vector128<float> GetNewDst128(in Vector128<float> xDst1, in Vector128<float> xThreshold)
        {
            Vector128<float> signMask = Vector128.Create(-0.0f); // 0x8000 0000
            Vector128<float> xSign = Sse.And(xDst1, signMask); // result = 0x8000 0000 if xDst1 is negative or 0x0000 0000 otherwise
            Vector128<float> xDst1Abs = Sse.Xor(xDst1, xSign);
            Vector128<float> xCond = Sse.CompareGreaterThan(xDst1Abs, xThreshold); // result = 0xFFFF FFFF if true
            Vector128<float> x2 = Sse.Xor(xSign, xThreshold); // -xThreshold if xDst1 is negative and +xThreshold otherwise
            return Sse.And(Sse.Subtract(xDst1, x2), xCond);
        }



        public static unsafe void SdcaL1UpdateU(float primalUpdate, int count, ReadOnlySpan<float> src, float threshold, Span<float> v, Span<float> w)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst1 = &MemoryMarshal.GetReference(v))
            fixed (float* pdst2 = &MemoryMarshal.GetReference(w))
            {
                float* pSrcEnd = psrc + count;
                float* pSrcCurrent = psrc;
                float* pDst1Current = pdst1;
                float* pDst2Current = pdst2;

                Vector128<float> xPrimal = Vector128.Create(primalUpdate);

                Vector128<float> signMask = Vector128.Create(-0.0f); // 0x8000 0000
                Vector128<float> xThreshold = Vector128.Create(threshold);

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> xSrc = Sse.LoadVector128(pSrcCurrent);

                    Vector128<float> xDst1 = Sse.LoadVector128(pDst1Current);
                    xDst1 = Sse.Add(xDst1, Sse.Multiply(xSrc, xPrimal));
                    Vector128<float> xDst2 = GetNewDst128(xDst1, xThreshold);

                    Sse.Store(pDst1Current, xDst1);
                    Sse.Store(pDst2Current, xDst2);

                    pSrcCurrent += 4;
                    pDst1Current += 4;
                    pDst2Current += 4;
                }

                while (pSrcCurrent < pSrcEnd)
                {
                    *pDst1Current += (*pSrcCurrent) * primalUpdate;
                    float dst1 = *pDst1Current;
                    *pDst2Current = Math.Abs(dst1) > threshold ? (dst1 > 0 ? dst1 - threshold : dst1 + threshold) : 0;

                    pSrcCurrent++;
                    pDst1Current++;
                    pDst2Current++;
                }
            }
        }

        public static unsafe void SdcaL1UpdateSU(float primalUpdate, int count, ReadOnlySpan<float> src, ReadOnlySpan<int> indices, float threshold, Span<float> v, Span<float> w)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (int* pidx = &MemoryMarshal.GetReference(indices))
            fixed (float* pdst1 = &MemoryMarshal.GetReference(v))
            fixed (float* pdst2 = &MemoryMarshal.GetReference(w))
            {
                int* pIdxEnd = pidx + count;
                float* pSrcCurrent = psrc;
                int* pIdxCurrent = pidx;

                Vector128<float> xPrimal = Vector128.Create(primalUpdate);

                Vector128<float> signMask = Vector128.Create(-0.0f); // 0x8000 0000
                Vector128<float> xThreshold = Vector128.Create(threshold);

                while (pIdxCurrent + 4 <= pIdxEnd)
                {
                    Vector128<float> xSrc = Sse.LoadVector128(pSrcCurrent);

                    Vector128<float> xDst1 = Load4(pdst1, pIdxCurrent);
                    xDst1 = Sse.Add(xDst1, Sse.Multiply(xSrc, xPrimal));
                    Vector128<float> xDst2 = GetNewDst128(xDst1, xThreshold);

                    Store4(in xDst1, pdst1, pIdxCurrent);
                    Store4(in xDst2, pdst2, pIdxCurrent);

                    pIdxCurrent += 4;
                    pSrcCurrent += 4;
                }

                while (pIdxCurrent < pIdxEnd)
                {
                    int index = *pIdxCurrent;
                    pdst1[index] += (*pSrcCurrent) * primalUpdate;
                    float dst1 = pdst1[index];
                    pdst2[index] = Math.Abs(dst1) > threshold ? (dst1 > 0 ? dst1 - threshold : dst1 + threshold) : 0;

                    pIdxCurrent++;
                    pSrcCurrent++;
                }
            }
        }
    }    
}

