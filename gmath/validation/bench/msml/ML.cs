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
    using Z0;

    
    using static mfunc;

    public static partial class ML
    {
        public static readonly uint[] AvxLeadingAlignmentMask = new uint[64]
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

        public static readonly uint[] AvxTrailingAlignmentMask = new uint[64]
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


        private static readonly Vector256<float> _absMask256 = Vector256.Create(0x7FFFFFFF).AsSingle();

        internal static readonly Vector128<float> AbsMask128 = Sse2.IsSupported ?
            Vector128.Create(0x7FFFFFFF).AsSingle() :
            Vector128.Create(BitConverter.Int32BitsToSingle(0x7FFFFFFF));

        private const int Vector256Alignment = 32;

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        internal static unsafe Vector128<float> Load1(float* src, int* idx)
             => Vector128.CreateScalar(src[idx[0]]);

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        internal static unsafe Vector128<float> Load4(float* src, int* idx)
            => Vector128.Create(src[idx[0]], src[idx[1]], src[idx[2]], src[idx[3]]);

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static Vector256<float> GetNewDst256(in Vector256<float> xDst1, in Vector256<float> xThreshold)
        {
            Vector256<float> signMask = Vector256.Create(-0.0f); // 0x8000 0000
            Vector256<float> xSign = Avx.And(xDst1, signMask); // result = 0x8000 0000 if xDst1 is negative or 0x0000 0000 otherwise
            Vector256<float> xDst1Abs = Avx.Xor(xDst1, xSign);
            Vector256<float> xCond = Avx.Compare(xDst1Abs, xThreshold, FloatComparisonMode.OrderedGreaterThanNonSignaling); // result = 0xFFFF FFFF if true
            Vector256<float> x2 = Avx.Xor(xSign, xThreshold); // -xThreshold if xDst1 is negative and +xThreshold otherwise
            return Avx.And(Avx.Subtract(xDst1, x2), xCond);
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static bool HasCompatibleAlignment(AlignedArray alignedArray)
        {
            Contracts.AssertValue(alignedArray);
            Contracts.Assert(alignedArray.Size > 0);
            return (alignedArray.CbAlign % Vector256Alignment) == 0;
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static unsafe float* GetAlignedBase(AlignedArray alignedArray, float* unalignedBase)
        {
            float* alignedBase = unalignedBase + alignedArray.GetBase((long)unalignedBase);
            Contracts.Assert(((long)alignedBase % Vector256Alignment) == 0);
            return alignedBase;
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static Vector128<float> GetHigh(in Vector256<float> x)
            => Avx.ExtractVector128(x, 1);


        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static unsafe Vector256<float> Load8(float* src, int* idx)
        {
            if (Avx2.IsSupported)
            {
                Vector256<int> idx256 = Avx.LoadVector256(idx);
                return Avx2.GatherVector256(src, idx256, 4);
            }
            else
            {
                return Vector256.Create(src[idx[0]], src[idx[1]], src[idx[2]], src[idx[3]], src[idx[4]], src[idx[5]], src[idx[6]], src[idx[7]]);
            }
        }

        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static unsafe void Store8(in Vector256<float> x, float* dst, int* idx)
        {
            Vector128<float> tmp = x.GetLower();
            System.Runtime.Intrinsics.X86.Sse.StoreScalar(dst + idx[0], tmp);
            tmp = MsSse.Rotate(in tmp);
            System.Runtime.Intrinsics.X86.Sse.StoreScalar(dst + idx[1], tmp);
            tmp = MsSse.Rotate(in tmp);
            System.Runtime.Intrinsics.X86.Sse.StoreScalar(dst + idx[2], tmp);
            tmp = MsSse.Rotate(in tmp);
            System.Runtime.Intrinsics.X86.Sse.StoreScalar(dst + idx[3], tmp);
            tmp = GetHigh(in x);
            System.Runtime.Intrinsics.X86.Sse.StoreScalar(dst + idx[4], tmp);
            tmp = MsSse.Rotate(in tmp);
            System.Runtime.Intrinsics.X86.Sse.StoreScalar(dst + idx[5], tmp);
            tmp = MsSse.Rotate(in tmp);
            System.Runtime.Intrinsics.X86.Sse.StoreScalar(dst + idx[6], tmp);
            tmp = MsSse.Rotate(in tmp);
            System.Runtime.Intrinsics.X86.Sse.StoreScalar(dst + idx[7], tmp);
        }

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


        [MethodImpl(Inline)]
        public static Vector128<float> VectorSum128(in Vector128<float> vector)
        {
            if (Sse3.IsSupported)
            {
                Vector128<float> partialSum = Sse3.HorizontalAdd(vector, vector);
                return Sse3.HorizontalAdd(partialSum, partialSum);
            }
            else
            {
                Vector128<float> partialSum = Sse.Add(vector, Sse.MoveHighToLow(vector, vector));
                // The control byte shuffles the four 32-bit floats of partialSum: ABCD -> BADC.
                return Sse.Add(partialSum, Sse.Shuffle(partialSum, partialSum, 0xB1));
            }
        }


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

        public static unsafe void Add128(ReadOnlySpan<float> src, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pEnd = psrc + count;

                while (pSrcCurrent + 4 <= pEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = Sse.LoadVector128(pDstCurrent);

                    Vector128<float> result = Sse.Add(srcVector, dstVector);
                    Sse.Store(pDstCurrent, result);

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                while (pSrcCurrent < pEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    Vector128<float> dstVector = Sse.LoadScalarVector128(pDstCurrent);

                    Vector128<float> result = Sse.AddScalar(srcVector, dstVector);
                    Sse.StoreScalar(pDstCurrent, result);

                    pSrcCurrent++;
                    pDstCurrent++;
                }
            }
        }

        public static unsafe void Add256(ReadOnlySpan<float> src, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pEnd = psrc + count;

                while (pSrcCurrent + 8 <= pEnd)
                {
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);
                    Vector256<float> dstVector = Avx.LoadVector256(pDstCurrent);

                    Vector256<float> result = Avx.Add(srcVector, dstVector);
                    Avx.Store(pDstCurrent, result);

                    pSrcCurrent += 8;
                    pDstCurrent += 8;
                }

                if (pSrcCurrent + 4 <= pEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDstCurrent);

                    Vector128<float> result = System.Runtime.Intrinsics.X86.Sse.Add(srcVector, dstVector);
                    System.Runtime.Intrinsics.X86.Sse.Store(pDstCurrent, result);

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                while (pSrcCurrent < pEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pDstCurrent);

                    Vector128<float> result = System.Runtime.Intrinsics.X86.Sse.AddScalar(srcVector, dstVector);
                    System.Runtime.Intrinsics.X86.Sse.StoreScalar(pDstCurrent, result);

                    pSrcCurrent++;
                    pDstCurrent++;
                }
            }
        }

        public static unsafe void AddS128(ReadOnlySpan<float> src, ReadOnlySpan<int> idx, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            Contracts.Assert(count <= idx.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (int* pidx = &MemoryMarshal.GetReference(idx))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                int* pIdxCurrent = pidx;
                float* pDstCurrent = pdst;
                int* pEnd = pidx + count;

                while (pIdxCurrent + 4 <= pEnd)
                {
                    Vector128<float> dstVector = Load4(pDstCurrent, pIdxCurrent);
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);

                    dstVector = Sse.Add(dstVector, srcVector);
                    Store4(in dstVector, pDstCurrent, pIdxCurrent);

                    pIdxCurrent += 4;
                    pSrcCurrent += 4;
                }

                while (pIdxCurrent < pEnd)
                {
                    pDstCurrent[*pIdxCurrent] += *pSrcCurrent;

                    pIdxCurrent++;
                    pSrcCurrent++;
                }
            }
        }

        public static unsafe void AddS256(ReadOnlySpan<float> src, ReadOnlySpan<int> idx, Span<float> dst, int count)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (int* pidx = &MemoryMarshal.GetReference(idx))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                int* pIdxCurrent = pidx;
                float* pDstCurrent = pdst;
                int* pEnd = pidx + count;

                while (pIdxCurrent + 8 <= pEnd)
                {
                    Vector256<float> dstVector = Load8(pDstCurrent, pIdxCurrent);
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);

                    dstVector = Avx.Add(dstVector, srcVector);
                    Store8(in dstVector, pDstCurrent, pIdxCurrent);

                    pIdxCurrent += 8;
                    pSrcCurrent += 8;
                }

                if (pIdxCurrent + 4 <= pEnd)
                {
                    Vector128<float> dstVector = MsSse.Load4(pDstCurrent, pIdxCurrent);
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);

                    dstVector = System.Runtime.Intrinsics.X86.Sse.Add(dstVector, srcVector);
                    MsSse.Store4(in dstVector, pDstCurrent, pIdxCurrent);

                    pIdxCurrent += 4;
                    pSrcCurrent += 4;
                }

                while (pIdxCurrent < pEnd)
                {
                    pDstCurrent[*pIdxCurrent] += *pSrcCurrent;

                    pIdxCurrent++;
                    pSrcCurrent++;
                }
            }
        }

        public static unsafe void AddScale128(float scale, ReadOnlySpan<float> src, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pEnd = pdst + count;

                Vector128<float> scaleVector = Vector128.Create(scale);

                while (pDstCurrent + 4 <= pEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = Sse.LoadVector128(pDstCurrent);

                    srcVector = Sse.Multiply(srcVector, scaleVector);
                    dstVector = Sse.Add(dstVector, srcVector);
                    Sse.Store(pDstCurrent, dstVector);

                    pDstCurrent += 4;
                    pSrcCurrent += 4;
                }

                while (pDstCurrent < pEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    Vector128<float> dstVector = Sse.LoadScalarVector128(pDstCurrent);

                    srcVector = Sse.MultiplyScalar(srcVector, scaleVector);
                    dstVector = Sse.AddScalar(dstVector, srcVector);
                    Sse.StoreScalar(pDstCurrent, dstVector);

                    pDstCurrent++;
                    pSrcCurrent++;
                }
            }
        }

        // dst[i] = a * (dst[i] + b)
        public static unsafe void AddScale256(float scale, ReadOnlySpan<float> src, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pEnd = pdst + count;

                Vector256<float> scaleVector256 = Vector256.Create(scale);

                while (pDstCurrent + 8 <= pEnd)
                {
                    Vector256<float> dstVector = Avx.LoadVector256(pDstCurrent);

                    dstVector = MultiplyAdd(pSrcCurrent, scaleVector256, dstVector);
                    Avx.Store(pDstCurrent, dstVector);

                    pSrcCurrent += 8;
                    pDstCurrent += 8;
                }

                Vector128<float> scaleVector128 = Vector128.Create(scale);

                if (pDstCurrent + 4 <= pEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDstCurrent);

                    srcVector = System.Runtime.Intrinsics.X86.Sse.Multiply(srcVector, scaleVector128);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.Add(dstVector, srcVector);
                    System.Runtime.Intrinsics.X86.Sse.Store(pDstCurrent, dstVector);

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                while (pDstCurrent < pEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pDstCurrent);

                    srcVector = System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(srcVector, scaleVector128);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.AddScalar(dstVector, srcVector);
                    System.Runtime.Intrinsics.X86.Sse.StoreScalar(pDstCurrent, dstVector);

                    pSrcCurrent++;
                    pDstCurrent++;
                }
            }
        }

        public static unsafe void AddScaleCopy128(float scale, ReadOnlySpan<float> src, ReadOnlySpan<float> dst, Span<float> result, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            Contracts.Assert(count <= result.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            fixed (float* pres = &MemoryMarshal.GetReference(result))
            {
                float* pResEnd = pres + count;
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pResCurrent = pres;

                Vector128<float> scaleVector = Vector128.Create(scale);

                while (pResCurrent + 4 <= pResEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = Sse.LoadVector128(pDstCurrent);
                    srcVector = Sse.Multiply(srcVector, scaleVector);
                    dstVector = Sse.Add(dstVector, srcVector);
                    Sse.Store(pResCurrent, dstVector);

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                    pResCurrent += 4;
                }

                while (pResCurrent < pResEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    Vector128<float> dstVector = Sse.LoadScalarVector128(pDstCurrent);
                    srcVector = Sse.MultiplyScalar(srcVector, scaleVector);
                    dstVector = Sse.AddScalar(dstVector, srcVector);
                    Sse.StoreScalar(pResCurrent, dstVector);

                    pSrcCurrent++;
                    pDstCurrent++;
                    pResCurrent++;
                }
            }
        }

        public static unsafe void AddScaleCopy256(float scale, ReadOnlySpan<float> src, ReadOnlySpan<float> dst, Span<float> result, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            Contracts.Assert(count <= result.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            fixed (float* pres = &MemoryMarshal.GetReference(result))
            {
                float* pResEnd = pres + count;
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pResCurrent = pres;

                Vector256<float> scaleVector256 = Vector256.Create(scale);

                while (pResCurrent + 8 <= pResEnd)
                {
                    Vector256<float> dstVector = Avx.LoadVector256(pDstCurrent);
                    dstVector = MultiplyAdd(pSrcCurrent, scaleVector256, dstVector);
                    Avx.Store(pResCurrent, dstVector);

                    pSrcCurrent += 8;
                    pDstCurrent += 8;
                    pResCurrent += 8;
                }

                Vector128<float> scaleVector128 = Vector128.Create(scale);

                if (pResCurrent + 4 <= pResEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDstCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.Multiply(srcVector, scaleVector128);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.Add(dstVector, srcVector);
                    System.Runtime.Intrinsics.X86.Sse.Store(pResCurrent, dstVector);

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                    pResCurrent += 4;
                }

                while (pResCurrent < pResEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pDstCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(srcVector, scaleVector128);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.AddScalar(dstVector, srcVector);
                    System.Runtime.Intrinsics.X86.Sse.StoreScalar(pResCurrent, dstVector);

                    pSrcCurrent++;
                    pDstCurrent++;
                    pResCurrent++;
                }
            }
        }

        public static unsafe float Dot128(ReadOnlySpan<float> src, ReadOnlySpan<float> dst, int count)
        {
            demand(count <= src.Length);
            demand(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pSrcEnd = psrc + count;

                Vector128<float> result = Vector128<float>.Zero;

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = Sse.LoadVector128(pDstCurrent);

                    result = Sse.Add(result, Sse.Multiply(srcVector, dstVector));

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                result = VectorSum128(in result);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    Vector128<float> dstVector = Sse.LoadScalarVector128(pDstCurrent);

                    result = Sse.AddScalar(result, Sse.MultiplyScalar(srcVector, dstVector));

                    pSrcCurrent++;
                    pDstCurrent++;
                }

                return result.ToScalar();
            }
        }

        public static unsafe float Dot256(ReadOnlySpan<float> src, ReadOnlySpan<float> dst, int count)
        {
            // Contracts.Assert(count <= src.Length);
            // Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pSrcEnd = psrc + count;

                Vector256<float> result256 = Vector256<float>.Zero;

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> dstVector = Avx.LoadVector256(pDstCurrent);
                    result256 = MultiplyAdd(pSrcCurrent, dstVector, result256);
                    pSrcCurrent += 8;
                    pDstCurrent += 8;
                }

                result256 = VectorSum256(in result256);
                Vector128<float> resultPadded = System.Runtime.Intrinsics.X86.Sse.AddScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDstCurrent);

                    result128 = System.Runtime.Intrinsics.X86.Sse.Add(result128, System.Runtime.Intrinsics.X86.Sse.Multiply(srcVector, dstVector));

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                result128 = VectorSum128(in result128);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pDstCurrent);

                    result128 = System.Runtime.Intrinsics.X86.Sse.AddScalar(result128, System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(srcVector, dstVector));

                    pSrcCurrent++;
                    pDstCurrent++;
                }

                return Sse.AddScalar(result128, resultPadded).ToScalar();
            }
        }

        public static unsafe float DotS128(ReadOnlySpan<float> src, ReadOnlySpan<float> dst, ReadOnlySpan<int> idx, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            Contracts.Assert(count <= idx.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            fixed (int* pidx = &MemoryMarshal.GetReference(idx))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                int* pIdxCurrent = pidx;
                int* pIdxEnd = pidx + count;

                Vector128<float> result = Vector128<float>.Zero;

                while (pIdxCurrent + 4 <= pIdxEnd)
                {
                    Vector128<float> srcVector = Load4(pSrcCurrent, pIdxCurrent);
                    Vector128<float> dstVector = Sse.LoadVector128(pDstCurrent);

                    result = Sse.Add(result, Sse.Multiply(srcVector, dstVector));

                    pIdxCurrent += 4;
                    pDstCurrent += 4;
                }

                result = VectorSum128(in result);

                while (pIdxCurrent < pIdxEnd)
                {
                    Vector128<float> srcVector = Load1(pSrcCurrent, pIdxCurrent);
                    Vector128<float> dstVector = Sse.LoadScalarVector128(pDstCurrent);

                    result = Sse.AddScalar(result, Sse.MultiplyScalar(srcVector, dstVector));

                    pIdxCurrent++;
                    pDstCurrent++;
                }

                return result.ToScalar();
            }
        }

        public static unsafe float DotS256(ReadOnlySpan<float> src, ReadOnlySpan<float> dst, ReadOnlySpan<int> idx, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            Contracts.Assert(count <= idx.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            fixed (int* pidx = &MemoryMarshal.GetReference(idx))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                int* pIdxCurrent = pidx;
                int* pIdxEnd = pidx + count;

                Vector256<float> result256 = Vector256<float>.Zero;

                while (pIdxCurrent + 8 <= pIdxEnd)
                {
                    Vector256<float> srcVector = Load8(pSrcCurrent, pIdxCurrent);
                    result256 = MultiplyAdd(pDstCurrent, srcVector, result256);
                    pIdxCurrent += 8;
                    pDstCurrent += 8;
                }

                result256 = VectorSum256(in result256);
                Vector128<float> resultPadded = System.Runtime.Intrinsics.X86.Sse.AddScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;

                if (pIdxCurrent + 4 <= pIdxEnd)
                {
                    Vector128<float> srcVector = MsSse.Load4(pSrcCurrent, pIdxCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDstCurrent);

                    result128 = System.Runtime.Intrinsics.X86.Sse.Add(result128, System.Runtime.Intrinsics.X86.Sse.Multiply(srcVector, dstVector));

                    pIdxCurrent += 4;
                    pDstCurrent += 4;
                }

                result128 = VectorSum128(in result128);

                while (pIdxCurrent < pIdxEnd)
                {
                    Vector128<float> srcVector = MsSse.Load1(pSrcCurrent, pIdxCurrent);
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pDstCurrent);

                    result128 = System.Runtime.Intrinsics.X86.Sse.AddScalar(result128, System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(srcVector, dstVector));

                    pIdxCurrent++;
                    pDstCurrent++;
                }

                return Sse.AddScalar(result128, resultPadded).ToScalar();
            }
        }

        public static unsafe float Dist128(ReadOnlySpan<float> src, ReadOnlySpan<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pSrcEnd = psrc + count;

                Vector128<float> sqDistanceVector = Vector128<float>.Zero;

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> distanceVector = Sse.Subtract(Sse.LoadVector128(pSrcCurrent),
                                                                    Sse.LoadVector128(pDstCurrent));
                    sqDistanceVector = Sse.Add(sqDistanceVector,
                                                Sse.Multiply(distanceVector, distanceVector));

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                sqDistanceVector = VectorSum128(in sqDistanceVector);

                float norm = sqDistanceVector.ToScalar();
                while (pSrcCurrent < pSrcEnd)
                {
                    float distance = (*pSrcCurrent) - (*pDstCurrent);
                    norm += distance * distance;

                    pSrcCurrent++;
                    pDstCurrent++;
                }

                return norm;
            }
        }


        public static unsafe float Dist256(ReadOnlySpan<float> src, ReadOnlySpan<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pSrcEnd = psrc + count;

                Vector256<float> sqDistanceVector256 = Vector256<float>.Zero;

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> distanceVector = Avx.Subtract(Avx.LoadVector256(pSrcCurrent),
                                                                    Avx.LoadVector256(pDstCurrent));
                    sqDistanceVector256 = MultiplyAdd(distanceVector, distanceVector, sqDistanceVector256);
                    pSrcCurrent += 8;
                    pDstCurrent += 8;
                }

                sqDistanceVector256 = VectorSum256(in sqDistanceVector256);
                Vector128<float> sqDistanceVectorPadded = System.Runtime.Intrinsics.X86.Sse.AddScalar(sqDistanceVector256.GetLower(), GetHigh(sqDistanceVector256));

                Vector128<float> sqDistanceVector128 = Vector128<float>.Zero;

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> distanceVector = System.Runtime.Intrinsics.X86.Sse.Subtract(System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent),
                                                                    System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDstCurrent));
                    sqDistanceVector128 = System.Runtime.Intrinsics.X86.Sse.Add(sqDistanceVector128,
                                                System.Runtime.Intrinsics.X86.Sse.Multiply(distanceVector, distanceVector));

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                sqDistanceVector128 = VectorSum128(in sqDistanceVector128);

                float norm = Sse.AddScalar(sqDistanceVector128, sqDistanceVectorPadded).ToScalar();
                while (pSrcCurrent < pSrcEnd)
                {
                    float distance = (*pSrcCurrent) - (*pDstCurrent);
                    norm += distance * distance;

                    pSrcCurrent++;
                    pDstCurrent++;
                }

                return norm;
            }
        }

        public static unsafe float MaxAbsDiff128(float mean, ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector128<float> result = Vector128<float>.Zero;
                Vector128<float> meanVector = Vector128.Create(mean);

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    srcVector = Sse.Subtract(srcVector, meanVector);
                    result = Sse.Max(result, Sse.And(srcVector, AbsMask128));

                    pSrcCurrent += 4;
                }

                result = VectorMax128(in result);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    srcVector = Sse.SubtractScalar(srcVector, meanVector);
                    result = Sse.MaxScalar(result, Sse.And(srcVector, AbsMask128));

                    pSrcCurrent++;
                }

                return result.ToScalar();
            }
        }

        public static unsafe float MaxAbs128(ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector128<float> result = Vector128<float>.Zero;

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    result = Sse.Max(result, Sse.And(srcVector, AbsMask128));

                    pSrcCurrent += 4;
                }

                result = VectorMax128(in result);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    result = Sse.MaxScalar(result, Sse.And(srcVector, AbsMask128));

                    pSrcCurrent++;
                }

                return result.ToScalar();
            }
        }

        public static unsafe float MaxAbs256(ReadOnlySpan<float> src)
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
                Vector128<float> resultPadded = System.Runtime.Intrinsics.X86.Sse.MaxScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    result128 = System.Runtime.Intrinsics.X86.Sse.Max(result128, System.Runtime.Intrinsics.X86.Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent += 4;
                }

                result128 = MsSse.VectorMax128(in result128);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    result128 = System.Runtime.Intrinsics.X86.Sse.MaxScalar(result128, System.Runtime.Intrinsics.X86.Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent++;
                }

                return Sse.MaxScalar(result128, resultPadded).ToScalar();
            }
        }

        public static unsafe float MaxAbsDiffU(float mean, ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector256<float> result256 = Vector256<float>.Zero;
                Vector256<float> meanVector256 = Vector256.Create(mean);

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);
                    srcVector = Avx.Subtract(srcVector, meanVector256);
                    result256 = Avx.Max(result256, Avx.And(srcVector, _absMask256));

                    pSrcCurrent += 8;
                }

                result256 = VectorMax256(in result256);
                Vector128<float> resultPadded = System.Runtime.Intrinsics.X86.Sse.MaxScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;
                Vector128<float> meanVector128 = Vector128.Create(mean);

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.Subtract(srcVector, meanVector128);
                    result128 = System.Runtime.Intrinsics.X86.Sse.Max(result128, System.Runtime.Intrinsics.X86.Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent += 4;
                }

                result128 = MsSse.VectorMax128(in result128);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.SubtractScalar(srcVector, meanVector128);
                    result128 = System.Runtime.Intrinsics.X86.Sse.MaxScalar(result128, System.Runtime.Intrinsics.X86.Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent++;
                }

                return Sse.MaxScalar(result128, resultPadded).ToScalar();
            }
        }

        public static unsafe void MatMul128(AlignedArray mat, AlignedArray src, AlignedArray dst, int crow, int ccol)
        {
            Contracts.Assert(HasCompatibleAlignment(mat));
            Contracts.Assert(HasCompatibleAlignment(src));
            Contracts.Assert(HasCompatibleAlignment(dst));

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
                    Vector128<float> res0 = Vector128<float>.Zero;
                    Vector128<float> res1 = res0;
                    Vector128<float> res2 = res0;
                    Vector128<float> res3 = res0;

                    float* pSrcCurrent = psrc;

                    while (pSrcCurrent < pSrcEnd)
                    {
                        float* pMatTemp = pMatCurrent;

                        Vector128<float> x01 = Sse.LoadAlignedVector128(pMatTemp);
                        Vector128<float> x11 = Sse.LoadAlignedVector128(pMatTemp += ccol);
                        Vector128<float> x21 = Sse.LoadAlignedVector128(pMatTemp += ccol);
                        Vector128<float> x31 = Sse.LoadAlignedVector128(pMatTemp += ccol);
                        Vector128<float> x02 = Sse.LoadAlignedVector128(pSrcCurrent);

                        res0 = Sse.Add(res0, Sse.Multiply(x01, x02));
                        res1 = Sse.Add(res1, Sse.Multiply(x11, x02));
                        res2 = Sse.Add(res2, Sse.Multiply(x21, x02));
                        res3 = Sse.Add(res3, Sse.Multiply(x31, x02));

                        pSrcCurrent += 4;
                        pMatCurrent += 4;
                    }

                    // Add up the entries of each, with the 4 results in res0
                    res0 = Sse3.HorizontalAdd(res0, res1);
                    res2 = Sse3.HorizontalAdd(res2, res3);
                    res0 = Sse3.HorizontalAdd(res0, res2);

                    Sse.StoreAligned(pDstCurrent, res0);

                    pDstCurrent += 4;
                    pMatCurrent += 3 * ccol;
                }
            }
        }

        public static unsafe void MatMul256(AlignedArray mat, AlignedArray src, AlignedArray dst, int crow, int ccol)
        {
            Contracts.Assert(HasCompatibleAlignment(mat));
            Contracts.Assert(HasCompatibleAlignment(src));
            Contracts.Assert(HasCompatibleAlignment(dst));

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

                    Vector128<float> sum = System.Runtime.Intrinsics.X86.Sse.Add(res0.GetLower(), GetHigh(in res0));
                    System.Runtime.Intrinsics.X86.Sse.StoreAligned(pDstCurrent, sum);

                    pDstCurrent += 4;
                    pMatCurrent += 3 * ccol;
                }
            }
        }

        public static unsafe void MatMulTran128(AlignedArray mat, AlignedArray src, AlignedArray dst, int crow, int ccol)
        {
            Contracts.Assert(HasCompatibleAlignment(mat));
            Contracts.Assert(HasCompatibleAlignment(src));
            Contracts.Assert(HasCompatibleAlignment(dst));

            fixed (float* pSrcStart = &src.Items[0])
            fixed (float* pDstStart = &dst.Items[0])
            fixed (float* pMatStart = &mat.Items[0])
            {
                float* psrc = GetAlignedBase(src, pSrcStart);
                float* pdst = GetAlignedBase(dst, pDstStart);
                float* pmat = GetAlignedBase(mat, pMatStart);

                float* pSrcEnd = psrc + ccol;
                float* pDstEnd = pdst + crow;
                float* pSrcCurrent = psrc;
                float* pMatCurrent = pmat;

                Vector128<float> x01 = Sse.LoadAlignedVector128(pSrcCurrent);
                // Replicate each 32-bit slot of x01 (ABCD) into its own register.
                Vector128<float> x11 = Sse.Shuffle(x01, x01, 0x55); // B
                Vector128<float> x21 = Sse.Shuffle(x01, x01, 0xAA); // C
                Vector128<float> x31 = Sse.Shuffle(x01, x01, 0xFF); // D
                x01 = Sse.Shuffle(x01, x01, 0x00); // A

                pSrcCurrent += 4;

                float* pDstCurrent = pdst;

                while (pDstCurrent < pDstEnd)
                {
                    float* pMatTemp = pMatCurrent;
                    Vector128<float> x02 = Sse.LoadAlignedVector128(pMatTemp);
                    Vector128<float> x12 = Sse.LoadAlignedVector128(pMatTemp += crow);
                    Vector128<float> x22 = Sse.LoadAlignedVector128(pMatTemp += crow);
                    Vector128<float> x32 = Sse.LoadAlignedVector128(pMatTemp += crow);

                    x02 = Sse.Multiply(x01, x02);
                    x12 = Sse.Multiply(x11, x12);
                    x22 = Sse.Multiply(x21, x22);
                    x32 = Sse.Multiply(x31, x32);

                    x02 = Sse.Add(x02, x12);
                    x22 = Sse.Add(x22, x32);
                    x02 = Sse.Add(x02, x22);

                    Sse.StoreAligned(pDstCurrent, x02);

                    pDstCurrent += 4;
                    pMatCurrent += 4;
                }

                pMatCurrent += 3 * crow;

                while (pSrcCurrent < pSrcEnd)
                {
                    x01 = Sse.LoadAlignedVector128(pSrcCurrent);
                    // Replicate each 32-bit slot of x01 (ABCD) into its own register.
                    x11 = Sse.Shuffle(x01, x01, 0x55); // B
                    x21 = Sse.Shuffle(x01, x01, 0xAA); // C
                    x31 = Sse.Shuffle(x01, x01, 0xFF); // D
                    x01 = Sse.Shuffle(x01, x01, 0x00); // A

                    pDstCurrent = pdst;

                    while (pDstCurrent < pDstEnd)
                    {
                        float* pMatTemp = pMatCurrent;

                        Vector128<float> x02 = Sse.LoadAlignedVector128(pMatTemp);
                        Vector128<float> x12 = Sse.LoadAlignedVector128(pMatTemp += crow);
                        Vector128<float> x22 = Sse.LoadAlignedVector128(pMatTemp += crow);
                        Vector128<float> x32 = Sse.LoadAlignedVector128(pMatTemp += crow);
                        Vector128<float> x3 = Sse.LoadAlignedVector128(pDstCurrent);

                        x02 = Sse.Multiply(x01, x02);
                        x12 = Sse.Multiply(x11, x12);
                        x22 = Sse.Multiply(x21, x22);
                        x32 = Sse.Multiply(x31, x32);

                        x02 = Sse.Add(x02, x12);
                        x22 = Sse.Add(x22, x32);
                        x02 = Sse.Add(x02, x22);
                        x3 = Sse.Add(x02, x3);

                        Sse.StoreAligned(pDstCurrent, x3);

                        pDstCurrent += 4;
                        pMatCurrent += 4;
                    }

                    pMatCurrent += 3 * crow;
                    pSrcCurrent += 4;
                }
            }
        }


        public static unsafe void MatMulTran256(AlignedArray mat, AlignedArray src, AlignedArray dst, int crow, int ccol)
        {
            Contracts.Assert(HasCompatibleAlignment(mat));
            Contracts.Assert(HasCompatibleAlignment(src));
            Contracts.Assert(HasCompatibleAlignment(dst));

            fixed (float* pSrcStart = &src.Items[0])
            fixed (float* pDstStart = &dst.Items[0])
            fixed (float* pMatStart = &mat.Items[0])
            {
                float* psrc = GetAlignedBase(src, pSrcStart);
                float* pdst = GetAlignedBase(dst, pDstStart);
                float* pmat = GetAlignedBase(mat, pMatStart);

                float* pSrcEnd = psrc + ccol;
                float* pDstEnd = pdst + crow;
                float* pSrcCurrent = psrc;
                float* pMatCurrent = pmat;

                // We do 4-way unrolling
                Vector128<float> h01 = System.Runtime.Intrinsics.X86.Sse.LoadAlignedVector128(pSrcCurrent);
                // Replicate each slot of h01 (ABCD) into its own register.
                Vector128<float> h11 = System.Runtime.Intrinsics.X86.Sse.Shuffle(h01, h01, 0x55); // B
                Vector128<float> h21 = System.Runtime.Intrinsics.X86.Sse.Shuffle(h01, h01, 0xAA); // C
                Vector128<float> h31 = System.Runtime.Intrinsics.X86.Sse.Shuffle(h01, h01, 0xFF); // D
                h01 = System.Runtime.Intrinsics.X86.Sse.Shuffle(h01, h01, 0x00); // A

                Vector256<float> x01 = Vector256.Create(h01, h01);
                Vector256<float> x11 = Vector256.Create(h11, h11);
                Vector256<float> x21 = Vector256.Create(h21, h21);
                Vector256<float> x31 = Vector256.Create(h31, h31);

                pSrcCurrent += 4;

                float* pDstCurrent = pdst;

                while (pDstCurrent < pDstEnd)
                {
                    float* pMatTemp = pMatCurrent;
                    Contracts.Assert(((nuint)(pMatTemp) % 32) == 0);

                    // The JIT will only fold away unaligned loads due to the semantics behind
                    // the VEX-encoding of the memory operand for `ins xmm, xmm, [mem]`. Since
                    // modern hardware has unaligned loads that are as fast as aligned loads,
                    // when it doesn't cross a cache-line/page boundary, we will just assert
                    // that the alignment is correct and allow for the more-efficient codegen.
                    Vector256<float> x02 = Avx.LoadVector256(pMatTemp);
                    Vector256<float> x12 = Avx.LoadVector256(pMatTemp += crow);
                    Vector256<float> x22 = Avx.LoadVector256(pMatTemp += crow);
                    Vector256<float> x32 = Avx.LoadVector256(pMatTemp += crow);

                    x02 = Avx.Multiply(x01, x02);
                    x02 = MultiplyAdd(x11, x12, x02);

                    x22 = Avx.Multiply(x21, x22);
                    x22 = MultiplyAdd(x31, x32, x22);

                    x02 = Avx.Add(x02, x22);
                    Avx.StoreAligned(pDstCurrent, x02);

                    pDstCurrent += 8;
                    pMatCurrent += 8;
                }

                pMatCurrent += 3 * crow;

                while (pSrcCurrent < pSrcEnd)
                {
                    h01 = System.Runtime.Intrinsics.X86.Sse.LoadAlignedVector128(pSrcCurrent);
                    // Replicate each slot of h01 (ABCD) into its own register.
                    h11 = System.Runtime.Intrinsics.X86.Sse.Shuffle(h01, h01, 0x55); // B
                    h21 = System.Runtime.Intrinsics.X86.Sse.Shuffle(h01, h01, 0xAA); // C
                    h31 = System.Runtime.Intrinsics.X86.Sse.Shuffle(h01, h01, 0xFF); // D
                    h01 = System.Runtime.Intrinsics.X86.Sse.Shuffle(h01, h01, 0x00); // A

                    x01 = Vector256.Create(h01, h01);
                    x11 = Vector256.Create(h11, h11);
                    x21 = Vector256.Create(h21, h21);
                    x31 = Vector256.Create(h31, h31);

                    pDstCurrent = pdst;

                    while (pDstCurrent < pDstEnd)
                    {
                        float* pMatTemp = pMatCurrent;

                        Contracts.Assert(((nuint)(pMatTemp) % 32) == 0);
                        Contracts.Assert(((nuint)(pDstCurrent) % 32) == 0);

                        // The JIT will only fold away unaligned loads due to the semantics behind
                        // the VEX-encoding of the memory operand for `ins xmm, xmm, [mem]`. Since
                        // modern hardware has unaligned loads that are as fast as aligned loads,
                        // when it doesn't cross a cache-line/page boundary, we will just assert
                        // that the alignment is correct and allow for the more-efficient codegen.
                        Vector256<float> x02 = Avx.LoadVector256(pMatTemp);
                        Vector256<float> x12 = Avx.LoadVector256(pMatTemp += crow);
                        Vector256<float> x22 = Avx.LoadVector256(pMatTemp += crow);
                        Vector256<float> x32 = Avx.LoadVector256(pMatTemp += crow);
                        Vector256<float> x3 = Avx.LoadVector256(pDstCurrent);

                        x02 = Avx.Multiply(x01, x02);
                        x02 = MultiplyAdd(x11, x12, x02);

                        x22 = Avx.Multiply(x21, x22);
                        x22 = MultiplyAdd(x31, x32, x22);

                        x02 = Avx.Add(x02, x22);
                        x3 = Avx.Add(x02, x3);
                        Avx.StoreAligned(pDstCurrent, x3);

                        pDstCurrent += 8;
                        pMatCurrent += 8;
                    }

                    pMatCurrent += 3 * crow;
                    pSrcCurrent += 4;
                }
            }
        }

        public static unsafe void MulElementWise256(ReadOnlySpan<float> src1, ReadOnlySpan<float> src2, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src1.Length);
            Contracts.Assert(count <= src2.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc1 = &MemoryMarshal.GetReference(src1))
            fixed (float* psrc2 = &MemoryMarshal.GetReference(src2))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrc1Current = psrc1;
                float* pSrc2Current = psrc2;
                float* pDstCurrent = pdst;
                float* pEnd = pdst + count;

                while (pDstCurrent + 8 <= pEnd)
                {
                    Vector256<float> src1Vector = Avx.LoadVector256(pSrc1Current);
                    Vector256<float> src2Vector = Avx.LoadVector256(pSrc2Current);
                    src2Vector = Avx.Multiply(src1Vector, src2Vector);
                    Avx.Store(pDstCurrent, src2Vector);

                    pSrc1Current += 8;
                    pSrc2Current += 8;
                    pDstCurrent += 8;
                }

                if (pDstCurrent + 4 <= pEnd)
                {
                    Vector128<float> src1Vector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrc1Current);
                    Vector128<float> src2Vector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrc2Current);
                    src2Vector = System.Runtime.Intrinsics.X86.Sse.Multiply(src1Vector, src2Vector);
                    System.Runtime.Intrinsics.X86.Sse.Store(pDstCurrent, src2Vector);

                    pSrc1Current += 4;
                    pSrc2Current += 4;
                    pDstCurrent += 4;
                }

                while (pDstCurrent < pEnd)
                {
                    Vector128<float> src1Vector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrc1Current);
                    Vector128<float> src2Vector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrc2Current);
                    src2Vector = System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(src1Vector, src2Vector);
                    System.Runtime.Intrinsics.X86.Sse.StoreScalar(pDstCurrent, src2Vector);

                    pSrc1Current++;
                    pSrc2Current++;
                    pDstCurrent++;
                }
            }
        }

        public static unsafe void AddScaleS128(float scale, ReadOnlySpan<float> src, ReadOnlySpan<int> idx, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            Contracts.Assert(count <= idx.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (int* pidx = &MemoryMarshal.GetReference(idx))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                int* pIdxCurrent = pidx;
                float* pDstCurrent = pdst;
                int* pEnd = pidx + count;

                Vector128<float> scaleVector = Vector128.Create(scale);

                while (pIdxCurrent + 4 <= pEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = Load4(pDstCurrent, pIdxCurrent);

                    srcVector = Sse.Multiply(srcVector, scaleVector);
                    dstVector = Sse.Add(dstVector, srcVector);
                    Store4(in dstVector, pDstCurrent, pIdxCurrent);

                    pIdxCurrent += 4;
                    pSrcCurrent += 4;
                }

                while (pIdxCurrent < pEnd)
                {
                    pDstCurrent[*pIdxCurrent] += scale * (*pSrcCurrent);

                    pIdxCurrent++;
                    pSrcCurrent++;
                }
            }
        }

        public static unsafe void AddScaleS256(float scale, ReadOnlySpan<float> src, ReadOnlySpan<int> idx, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            Contracts.Assert(count <= idx.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (int* pidx = &MemoryMarshal.GetReference(idx))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrcCurrent = psrc;
                int* pIdxCurrent = pidx;
                float* pDstCurrent = pdst;
                int* pEnd = pidx + count;

                Vector256<float> scaleVector256 = Vector256.Create(scale);

                while (pIdxCurrent + 8 <= pEnd)
                {
                    Vector256<float> dstVector = Load8(pDstCurrent, pIdxCurrent);
                    dstVector = MultiplyAdd(pSrcCurrent, scaleVector256, dstVector);
                    Store8(in dstVector, pDstCurrent, pIdxCurrent);

                    pIdxCurrent += 8;
                    pSrcCurrent += 8;
                }

                Vector128<float> scaleVector128 = Vector128.Create(scale);

                if (pIdxCurrent + 4 <= pEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    Vector128<float> dstVector = MsSse.Load4(pDstCurrent, pIdxCurrent);

                    srcVector = System.Runtime.Intrinsics.X86.Sse.Multiply(srcVector, scaleVector128);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.Add(dstVector, srcVector);
                    MsSse.Store4(in dstVector, pDstCurrent, pIdxCurrent);

                    pIdxCurrent += 4;
                    pSrcCurrent += 4;
                }

                while (pIdxCurrent < pEnd)
                {
                    pDstCurrent[*pIdxCurrent] += scale * (*pSrcCurrent);

                    pIdxCurrent++;
                    pSrcCurrent++;
                }
            }
        }

        // dst[i] += scale
        public static unsafe void AddScalar128(float scalar, Span<float> dst)
        {
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pDstEnd = pdst + dst.Length;
                float* pDstCurrent = pdst;
                float* pVectorizationEnd = pDstEnd - 4;

                Vector128<float> scalarVector = Vector128.Create(scalar);

                while (pDstCurrent <= pVectorizationEnd)
                {
                    Vector128<float> dstVector = Sse.LoadVector128(pDstCurrent);
                    dstVector = Sse.Add(dstVector, scalarVector);
                    Sse.Store(pDstCurrent, dstVector);

                    pDstCurrent += 4;
                }

                while (pDstCurrent < pDstEnd)
                {
                    Vector128<float> dstVector = Sse.LoadScalarVector128(pDstCurrent);
                    dstVector = Sse.AddScalar(dstVector, scalarVector);
                    Sse.StoreScalar(pDstCurrent, dstVector);

                    pDstCurrent++;
                }
            }
        }

        // dst[i] += scale
        public static unsafe void AddScalar256(float scalar, Span<float> dst)
        {
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pDstEnd = pdst + dst.Length;
                float* pDstCurrent = pdst;
                float* pVectorizationEnd = pDstEnd - 4;

                Vector256<float> scalarVector256 = Vector256.Create(scalar);

                while (pDstCurrent + 8 <= pDstEnd)
                {
                    Vector256<float> dstVector = Avx.LoadVector256(pDstCurrent);
                    dstVector = Avx.Add(dstVector, scalarVector256);
                    Avx.Store(pDstCurrent, dstVector);

                    pDstCurrent += 8;
                }

                Vector128<float> scalarVector128 = Vector128.Create(scalar);

                if (pDstCurrent <= pVectorizationEnd)
                {
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDstCurrent);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.Add(dstVector, scalarVector128);
                    System.Runtime.Intrinsics.X86.Sse.Store(pDstCurrent, dstVector);

                    pDstCurrent += 4;
                }

                while (pDstCurrent < pDstEnd)
                {
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pDstCurrent);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.AddScalar(dstVector, scalarVector128);
                    System.Runtime.Intrinsics.X86.Sse.StoreScalar(pDstCurrent, dstVector);

                    pDstCurrent++;
                }
            }
        }

        public static unsafe void Scale128(float scale, Span<float> dst)
        {
            fixed (uint* pLeadingAlignmentMask = &SseLeadingAlignmentMask[0])
            fixed (uint* pTrailingAlignmentMask = &SseTrailingAlignmentMask[0])
            fixed (float* pd = &MemoryMarshal.GetReference(dst))
            {
                float* pDstCurrent = pd;
                int length = dst.Length;
                Vector128<float> scaleVector128 = Vector128.Create(scale);

                nuint address = (nuint)(pd);
                int misalignment = (int)(address % 16);
                int remainder = 0;

                if ((misalignment & 3) != 0)
                {
                    // Handles cases where the data is not 32-bit aligned and we can't ever use aligned operations
                    remainder = length % 4;

                    for (float* pEnd = pd + (length - remainder); pDstCurrent < pEnd; pDstCurrent += 4)
                    {
                        Vector128<float> temp = Sse.LoadVector128(pDstCurrent);
                        temp = Sse.Multiply(scaleVector128, temp);
                        Sse.Store(pDstCurrent, temp);
                    }
                }
                else
                {
                    if (misalignment != 0)
                    {
                        // Handle cases where the data is not 128-bit aligned by doing an unaligned read and then
                        // masking any elements that will be included in the first aligned read

                        misalignment >>= 2;
                        misalignment = 4 - misalignment;

                        Vector128<float> result = Sse.LoadVector128(pDstCurrent);

                        Vector128<float> leadingMask = Sse.LoadVector128(((float*)(pLeadingAlignmentMask)) + (misalignment * 4));
                        Vector128<float> trailingMask = Sse.LoadVector128(((float*)(pTrailingAlignmentMask)) + ((4 - misalignment) * 4));

                        Vector128<float> temp = Sse.And(result, trailingMask);
                        result = Sse.Multiply(scaleVector128, result);

                        // Masking operation is done at the end to avoid doing an Or operation with negative Zero.
                        result = Sse.And(result, leadingMask);
                        result = Sse.Or(result, temp);

                        Sse.Store(pDstCurrent, result);

                        pDstCurrent += misalignment;
                        length -= misalignment;
                    }

                    if (length > 3)
                    {
                        // Handle all the 128-bit blocks that we can now that we have offset to an aligned address
                        remainder = length % 4;

                        for (float* pEnd = pDstCurrent + (length - remainder); pDstCurrent < pEnd; pDstCurrent += 4)
                        {
                            // If we aren't using the VEX-encoding, the JIT will only fold away aligned loads
                            // (due to semantics of the legacy encoding).
                            // We don't need an assert, since the instruction will throw for unaligned inputs.
                            Vector128<float> temp = Sse.LoadAlignedVector128(pDstCurrent);
                            temp = Sse.Multiply(scaleVector128, temp);
                            Sse.Store(pDstCurrent, temp);
                        }
                    }
                    else
                    {
                        // Handle the "worst-case" scenario, which is when we have 4-8 elements and the input is not
                        // 128-bit aligned. This means we can't do any aligned loads and will just end up doing two
                        // unaligned loads where we mask the input each time.
                        remainder = length;
                    }
                }

                if (remainder != 0)
                {
                    // Handle any trailing elements that don't fit into a 128-bit block by moving back so that the next
                    // unaligned load will read to the end of the array and then mask out any elements already processed

                    pDstCurrent -= (4 - remainder);

                    Vector128<float> result = Sse.LoadVector128(pDstCurrent);

                    Vector128<float> trailingMask = Sse.LoadVector128(((float*)(pTrailingAlignmentMask)) + (remainder * 4));
                    Vector128<float> leadingMask = Sse.LoadVector128(((float*)(pLeadingAlignmentMask)) + ((4 - remainder) * 4));

                    Vector128<float> temp = Sse.And(result, leadingMask);
                    result = Sse.Multiply(scaleVector128, result);

                    // Masking operation is done at the end to avoid doing an Or operation with negative Zero.
                    result = Sse.And(result, trailingMask);
                    result = Sse.Or(result, temp);

                    Sse.Store(pDstCurrent, result);
                }
            }
        }

        public static unsafe void Scale256(float scale, Span<float> dst)
        {
            fixed (uint* pLeadingAlignmentMask = &AvxLeadingAlignmentMask[0])
            fixed (uint* pTrailingAlignmentMask = &AvxTrailingAlignmentMask[0])
            fixed (float* pd = &MemoryMarshal.GetReference(dst))
            {
                float* pDstCurrent = pd;
                int length = dst.Length;
                Vector256<float> scaleVector256 = Vector256.Create(scale);

                nuint address = (nuint)(pd);
                int misalignment = (int)(address % 32);
                int remainder = 0;

                if ((misalignment & 3) != 0)
                {
                    // Handles cases where the data is not 32-bit aligned and we can't ever use aligned operations
                    remainder = length % 8;

                    for (float* pEnd = pd + (length - remainder); pDstCurrent < pEnd; pDstCurrent += 8)
                    {
                        Vector256<float> temp = Avx.LoadVector256(pDstCurrent);
                        temp = Avx.Multiply(scaleVector256, temp);
                        Avx.Store(pDstCurrent, temp);
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

                        Vector256<float> result = Avx.LoadVector256(pDstCurrent);

                        Vector256<float> leadingMask = Avx.LoadVector256(((float*)(pLeadingAlignmentMask)) + (misalignment * 8));
                        Vector256<float> trailingMask = Avx.LoadVector256(((float*)(pTrailingAlignmentMask)) + ((8 - misalignment) * 8));

                        Vector256<float> temp = Avx.And(result, trailingMask);
                        result = Avx.Multiply(scaleVector256, result);

                        // Masking operation is done at the end to avoid doing an Or operation with negative Zero.
                        result = Avx.And(result, leadingMask);
                        result = Avx.Or(result, temp);

                        Avx.Store(pDstCurrent, result);

                        pDstCurrent += misalignment;
                        length -= misalignment;
                    }

                    if (length > 7)
                    {
                        // Handle all the 256-bit blocks that we can now that we have offset to an aligned address

                        remainder = length % 8;

                        for (float* pEnd = pDstCurrent + (length - remainder); pDstCurrent < pEnd; pDstCurrent += 8)
                        {
                            // The JIT will only fold away unaligned loads due to the semantics behind
                            // the VEX-encoding of the memory operand for `ins xmm, xmm, [mem]`. Since
                            // modern hardware has unaligned loads that are as fast as aligned loads,
                            // when it doesn't cross a cache-line/page boundary, we will just assert
                            // that the alignment is correct and allow for the more-efficient codegen.

                            Contracts.Assert(((nuint)(pDstCurrent) % 32) == 0);
                            Vector256<float> temp = Avx.LoadVector256(pDstCurrent);
                            temp = Avx.Multiply(scaleVector256, temp);
                            Avx.Store(pDstCurrent, temp);
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

                    pDstCurrent -= (8 - remainder);

                    Vector256<float> result = Avx.LoadVector256(pDstCurrent);

                    Vector256<float> trailingMask = Avx.LoadVector256(((float*)(pTrailingAlignmentMask)) + (remainder * 8));
                    Vector256<float> leadingMask = Avx.LoadVector256(((float*)(pLeadingAlignmentMask)) + ((8 - remainder) * 8));

                    Vector256<float> temp = Avx.And(result, leadingMask);
                    result = Avx.Multiply(scaleVector256, result);

                    // Masking operation is done at the end to avoid doing an Or operation with negative Zero.
                    result = Avx.And(result, trailingMask);
                    result = Avx.Or(result, temp);

                    Avx.Store(pDstCurrent, result);
                }
            }
        }

        // dst[i] = a * (dst[i] + b)
        public static unsafe void ScaleAdd128(float a, float b, Span<float> dst)
        {
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pDstEnd = pdst + dst.Length;
                float* pDstCurrent = pdst;
                float* pVectorizationEnd = pDstEnd - 4;

                Vector128<float> aVector = Vector128.Create(a);
                Vector128<float> bVector = Vector128.Create(b);

                while (pDstCurrent <= pVectorizationEnd)
                {
                    Vector128<float> dstVector = Sse.LoadVector128(pDstCurrent);
                    dstVector = Sse.Add(dstVector, bVector);
                    dstVector = Sse.Multiply(dstVector, aVector);
                    Sse.Store(pDstCurrent, dstVector);

                    pDstCurrent += 4;
                }

                while (pDstCurrent < pDstEnd)
                {
                    Vector128<float> dstVector = Sse.LoadScalarVector128(pDstCurrent);
                    dstVector = Sse.AddScalar(dstVector, bVector);
                    dstVector = Sse.MultiplyScalar(dstVector, aVector);
                    Sse.StoreScalar(pDstCurrent, dstVector);

                    pDstCurrent++;
                }
            }
        }

        public static unsafe void ScaleAdd256(float a, float b, Span<float> dst)
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
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDstCurrent);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.Add(dstVector, b128);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.Multiply(dstVector, a128);
                    System.Runtime.Intrinsics.X86.Sse.Store(pDstCurrent, dstVector);

                    pDstCurrent += 4;
                }

                while (pDstCurrent < pDstEnd)
                {
                    Vector128<float> dstVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pDstCurrent);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.AddScalar(dstVector, b128);
                    dstVector = System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(dstVector, a128);
                    System.Runtime.Intrinsics.X86.Sse.StoreScalar(pDstCurrent, dstVector);

                    pDstCurrent++;
                }
            }
        }

        public static unsafe void ScaleSrc128(float scale, ReadOnlySpan<float> src, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pDstEnd = pdst + count;
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pVectorizationEnd = pDstEnd - 4;

                Vector128<float> scaleVector = Vector128.Create(scale);

                while (pDstCurrent <= pVectorizationEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    srcVector = Sse.Multiply(srcVector, scaleVector);
                    Sse.Store(pDstCurrent, srcVector);

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                while (pDstCurrent < pDstEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    srcVector = Sse.MultiplyScalar(srcVector, scaleVector);
                    Sse.StoreScalar(pDstCurrent, srcVector);

                    pSrcCurrent++;
                    pDstCurrent++;
                }
            }
        }

        public static unsafe void ScaleSrc256(float scale, ReadOnlySpan<float> src, Span<float> dst, int count)
        {
            Contracts.Assert(count <= src.Length);
            Contracts.Assert(count <= dst.Length);
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pDstEnd = pdst + count;
                float* pSrcCurrent = psrc;
                float* pDstCurrent = pdst;
                float* pVectorizationEnd = pDstEnd - 4;

                Vector256<float> scaleVector256 = Vector256.Create(scale);

                while (pDstCurrent + 8 <= pDstEnd)
                {
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);
                    srcVector = Avx.Multiply(srcVector, scaleVector256);
                    Avx.Store(pDstCurrent, srcVector);

                    pSrcCurrent += 8;
                    pDstCurrent += 8;
                }

                Vector128<float> scaleVector128 = Vector128.Create(scale);

                if (pDstCurrent <= pVectorizationEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.Multiply(srcVector, scaleVector128);
                    System.Runtime.Intrinsics.X86.Sse.Store(pDstCurrent, srcVector);

                    pSrcCurrent += 4;
                    pDstCurrent += 4;
                }

                while (pDstCurrent < pDstEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(srcVector, scaleVector128);
                    System.Runtime.Intrinsics.X86.Sse.StoreScalar(pDstCurrent, srcVector);

                    pSrcCurrent++;
                    pDstCurrent++;
                }
            }
        }


        public static unsafe void Mul256(ReadOnlySpan<float> src1, ReadOnlySpan<float> src2, Span<float> dst, int count)
        {
            demand(count <= src1.Length);
            demand(count <= src2.Length);
            demand(count <= dst.Length);
            fixed (float* psrc1 = &MemoryMarshal.GetReference(src1))
            fixed (float* psrc2 = &MemoryMarshal.GetReference(src2))
            fixed (float* pdst = &MemoryMarshal.GetReference(dst))
            {
                float* pSrc1Current = psrc1;
                float* pSrc2Current = psrc2;
                float* pDstCurrent = pdst;
                float* pEnd = pdst + count;

                while (pDstCurrent + 8 <= pEnd)
                {
                    Vector256<float> src1Vector = Avx.LoadVector256(pSrc1Current);
                    Vector256<float> src2Vector = Avx.LoadVector256(pSrc2Current);
                    src2Vector = Avx.Multiply(src1Vector, src2Vector);
                    Avx.Store(pDstCurrent, src2Vector);

                    pSrc1Current += 8;
                    pSrc2Current += 8;
                    pDstCurrent += 8;
                }

                if (pDstCurrent + 4 <= pEnd)
                {
                    Vector128<float> src1Vector = Sse.LoadVector128(pSrc1Current);
                    Vector128<float> src2Vector = Sse.LoadVector128(pSrc2Current);
                    src2Vector = Sse.Multiply(src1Vector, src2Vector);
                    Sse.Store(pDstCurrent, src2Vector);

                    pSrc1Current += 4;
                    pSrc2Current += 4;
                    pDstCurrent += 4;
                }

                while (pDstCurrent < pEnd)
                {
                    Vector128<float> src1Vector = Sse.LoadScalarVector128(pSrc1Current);
                    Vector128<float> src2Vector = Sse.LoadScalarVector128(pSrc2Current);
                    src2Vector = Sse.MultiplyScalar(src1Vector, src2Vector);
                    Sse.StoreScalar(pDstCurrent, src2Vector);

                    pSrc1Current++;
                    pSrc2Current++;
                    pDstCurrent++;
                }
            }
        }


        public static unsafe float Sum128(ReadOnlySpan<float> src)
        {
            fixed (float* pSrc = &MemoryMarshal.GetReference(src))
            fixed (uint* pLeadingAlignmentMask = &SseLeadingAlignmentMask[0])
            fixed (uint* pTrailingAlignmentMask = &SseTrailingAlignmentMask[0])
            {
                float* pValues = pSrc;
                int length = src.Length;
                Vector128<float> result = Vector128<float>.Zero;

                nuint address = (nuint)(pValues);
                int misalignment = (int)(address % 16);
                int remainder = 0;

                if ((misalignment & 3) != 0)
                {
                    // Handles cases where the data is not 32-bit aligned and we can't ever use aligned operations

                    remainder = length % 4;

                    for (float* pEnd = pValues + (length - remainder); pValues < pEnd; pValues += 4)
                    {
                        result = Sse.Add(result, Sse.LoadVector128(pValues));
                    }
                }
                else
                {
                    if (misalignment != 0)
                    {
                        // Handle cases where the data is not 128-bit aligned by doing an unaligned read and then
                        // masking any elements that will be included in the first aligned read

                        misalignment >>= 2;
                        misalignment = 4 - misalignment;

                        Vector128<float> mask = Sse.LoadVector128(((float*)(pLeadingAlignmentMask)) + (misalignment * 4));
                        Vector128<float> temp = Sse.And(mask, Sse.LoadVector128(pValues));
                        result = Sse.Add(result, temp);

                        pValues += misalignment;
                        length -= misalignment;
                    }

                    if (length > 3)
                    {
                        // Handle all the 128-bit blocks that we can now that we have offset to an aligned address

                        remainder = length % 4;

                        for (float* pEnd = pValues + (length - remainder); pValues < pEnd; pValues += 4)
                        {
                            // If we aren't using the VEX-encoding, the JIT will only fold away aligned loads
                            // (due to semantics of the legacy encoding).
                            // We don't need an assert, since the instruction will throw for unaligned inputs.

                            result = Sse.Add(result, Sse.LoadAlignedVector128(pValues));
                        }
                    }
                    else
                    {
                        // Handle the "worst-case" scenario, which is when we have 4-8 elements and the input is not
                        // 128-bit aligned. This means we can't do any aligned loads and will just end up doing two
                        // unaligned loads where we mask the input each time.
                        remainder = length;
                    }
                }

                if (remainder != 0)
                {
                    // Handle any trailing elements that don't fit into a 128-bit block by moving back so that the next
                    // unaligned load will read to the end of the array and then mask out any elements already processed

                    pValues -= (4 - remainder);

                    Vector128<float> mask = Sse.LoadVector128(((float*)(pTrailingAlignmentMask)) + (remainder * 4));
                    Vector128<float> temp = Sse.And(mask, Sse.LoadVector128(pValues));
                    result = Sse.Add(result, temp);
                }

                // Sum all the elements together and return the result
                result = VectorSum128(in result);
                return result.ToScalar();
            }
        }

        public static unsafe float Sum256(ReadOnlySpan<float> src)
        {
            fixed (float* pSrc = &MemoryMarshal.GetReference(src))
            fixed (uint* pLeadingAlignmentMask = &AvxLeadingAlignmentMask[0])
            fixed (uint* pTrailingAlignmentMask = &AvxTrailingAlignmentMask[0])
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

                            demand(((nuint)(pValues) % 32) == 0);
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

        public static unsafe float SumSqDiff128(float mean, ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector128<float> result = Vector128<float>.Zero;
                Vector128<float> meanVector = Vector128.Create(mean);

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    srcVector = Sse.Subtract(srcVector, meanVector);
                    result = Sse.Add(result, Sse.Multiply(srcVector, srcVector));

                    pSrcCurrent += 4;
                }

                result = VectorSum128(in result);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    srcVector = Sse.SubtractScalar(srcVector, meanVector);
                    result = Sse.AddScalar(result, Sse.MultiplyScalar(srcVector, srcVector));

                    pSrcCurrent++;
                }

                return result.ToScalar();
            }
        }

        public static unsafe float SumSq128(ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector128<float> result = Vector128<float>.Zero;

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    result = Sse.Add(result, Sse.Multiply(srcVector, srcVector));

                    pSrcCurrent += 4;
                }

                result = VectorSum128(in result);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    result = Sse.AddScalar(result, Sse.MultiplyScalar(srcVector, srcVector));

                    pSrcCurrent++;
                }

                return result.ToScalar();
            }
        }

        public static unsafe float SumSq256(ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector256<float> result256 = Vector256<float>.Zero;

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);
                    result256 = MultiplyAdd(srcVector, srcVector, result256);

                    pSrcCurrent += 8;
                }

                result256 = VectorSum256(in result256);
                Vector128<float> resultPadded = System.Runtime.Intrinsics.X86.Sse.AddScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    result128 = System.Runtime.Intrinsics.X86.Sse.Add(result128, System.Runtime.Intrinsics.X86.Sse.Multiply(srcVector, srcVector));

                    pSrcCurrent += 4;
                }

                result128 = VectorSum128(in result128);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    result128 = System.Runtime.Intrinsics.X86.Sse.AddScalar(result128, System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(srcVector, srcVector));

                    pSrcCurrent++;
                }

                return Sse.AddScalar(result128, resultPadded).ToScalar();
            }
        }

        public static unsafe float SumSqDiff256(float mean, ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector256<float> result256 = Vector256<float>.Zero;
                Vector256<float> meanVector256 = Vector256.Create(mean);

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);
                    srcVector = Avx.Subtract(srcVector, meanVector256);
                    result256 = MultiplyAdd(srcVector, srcVector, result256);
                    pSrcCurrent += 8;
                }

                result256 = VectorSum256(in result256);
                Vector128<float> resultPadded = System.Runtime.Intrinsics.X86.Sse.AddScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;
                Vector128<float> meanVector128 = Vector128.Create(mean);

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.Subtract(srcVector, meanVector128);
                    result128 = System.Runtime.Intrinsics.X86.Sse.Add(result128, System.Runtime.Intrinsics.X86.Sse.Multiply(srcVector, srcVector));

                    pSrcCurrent += 4;
                }

                result128 = VectorSum128(in result128);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.SubtractScalar(srcVector, meanVector128);
                    result128 = System.Runtime.Intrinsics.X86.Sse.AddScalar(result128, System.Runtime.Intrinsics.X86.Sse.MultiplyScalar(srcVector, srcVector));

                    pSrcCurrent++;
                }

                return Sse.AddScalar(result128, resultPadded).ToScalar();
            }
        }

        public static unsafe float SubAbs128(ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector128<float> result = Vector128<float>.Zero;

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    result = Sse.Add(result, Sse.And(srcVector, AbsMask128));

                    pSrcCurrent += 4;
                }

                result = VectorSum128(in result);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    result = Sse.AddScalar(result, Sse.And(srcVector, AbsMask128));

                    pSrcCurrent++;
                }

                return result.ToScalar();
            }
        }

        public static unsafe float SumAbs256(ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector256<float> result256 = Vector256<float>.Zero;

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);
                    result256 = Avx.Add(result256, Avx.And(srcVector, _absMask256));

                    pSrcCurrent += 8;
                }

                result256 = VectorSum256(in result256);
                Vector128<float> resultPadded = System.Runtime.Intrinsics.X86.Sse.AddScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    result128 = System.Runtime.Intrinsics.X86.Sse.Add(result128, System.Runtime.Intrinsics.X86.Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent += 4;
                }

                result128 = VectorSum128(in result128);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    result128 = System.Runtime.Intrinsics.X86.Sse.AddScalar(result128, System.Runtime.Intrinsics.X86.Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent++;
                }

                return Sse.AddScalar(result128, resultPadded).ToScalar();
            }
        }

        public static unsafe float SumAbsDiff128(float mean, ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector128<float> result = Vector128<float>.Zero;
                Vector128<float> meanVector = Vector128.Create(mean);

                while (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadVector128(pSrcCurrent);
                    srcVector = Sse.Subtract(srcVector, meanVector);
                    result = Sse.Add(result, Sse.And(srcVector, AbsMask128));

                    pSrcCurrent += 4;
                }

                result = VectorSum128(in result);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = Sse.LoadScalarVector128(pSrcCurrent);
                    srcVector = Sse.SubtractScalar(srcVector, meanVector);
                    result = Sse.AddScalar(result, Sse.And(srcVector, AbsMask128));

                    pSrcCurrent++;
                }

                return result.ToScalar();
            }
        }

        public static unsafe float SumAbsDiff256(float mean, ReadOnlySpan<float> src)
        {
            fixed (float* psrc = &MemoryMarshal.GetReference(src))
            {
                float* pSrcEnd = psrc + src.Length;
                float* pSrcCurrent = psrc;

                Vector256<float> result256 = Vector256<float>.Zero;
                Vector256<float> meanVector256 = Vector256.Create(mean);

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> srcVector = Avx.LoadVector256(pSrcCurrent);
                    srcVector = Avx.Subtract(srcVector, meanVector256);
                    result256 = Avx.Add(result256, Avx.And(srcVector, _absMask256));

                    pSrcCurrent += 8;
                }

                result256 = VectorSum256(in result256);
                Vector128<float> resultPadded = System.Runtime.Intrinsics.X86.Sse.AddScalar(result256.GetLower(), GetHigh(result256));

                Vector128<float> result128 = Vector128<float>.Zero;
                Vector128<float> meanVector128 = Vector128.Create(mean);

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.Subtract(srcVector, meanVector128);
                    result128 = System.Runtime.Intrinsics.X86.Sse.Add(result128, System.Runtime.Intrinsics.X86.Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent += 4;
                }

                result128 = VectorSum128(in result128);

                while (pSrcCurrent < pSrcEnd)
                {
                    Vector128<float> srcVector = System.Runtime.Intrinsics.X86.Sse.LoadScalarVector128(pSrcCurrent);
                    srcVector = System.Runtime.Intrinsics.X86.Sse.SubtractScalar(srcVector, meanVector128);
                    result128 = System.Runtime.Intrinsics.X86.Sse.AddScalar(result128, System.Runtime.Intrinsics.X86.Sse.And(srcVector, MsSse.AbsMask128));

                    pSrcCurrent++;
                }

                return Sse.AddScalar(result128, resultPadded).ToScalar();
            }
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

                Vector256<float> xPrimal256 = Vector256.Create(primalUpdate);
                Vector256<float> xThreshold256 = Vector256.Create(threshold);

                while (pSrcCurrent + 8 <= pSrcEnd)
                {
                    Vector256<float> xDst1 = Avx.LoadVector256(pDst1Current);
                    xDst1 = MultiplyAdd(pSrcCurrent, xPrimal256, xDst1);
                    Vector256<float> xDst2 = GetNewDst256(xDst1, xThreshold256);

                    Avx.Store(pDst1Current, xDst1);
                    Avx.Store(pDst2Current, xDst2);

                    pSrcCurrent += 8;
                    pDst1Current += 8;
                    pDst2Current += 8;
                }

                Vector128<float> xPrimal128 = Vector128.Create(primalUpdate);
                Vector128<float> xThreshold128 = Vector128.Create(threshold);

                if (pSrcCurrent + 4 <= pSrcEnd)
                {
                    Vector128<float> xSrc = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);

                    Vector128<float> xDst1 = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pDst1Current);
                    xDst1 = System.Runtime.Intrinsics.X86.Sse.Add(xDst1, System.Runtime.Intrinsics.X86.Sse.Multiply(xSrc, xPrimal128));
                    Vector128<float> xDst2 = MsSse.GetNewDst128(xDst1, xThreshold128);

                    System.Runtime.Intrinsics.X86.Sse.Store(pDst1Current, xDst1);
                    System.Runtime.Intrinsics.X86.Sse.Store(pDst2Current, xDst2);

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

                Vector256<float> xPrimal256 = Vector256.Create(primalUpdate);
                Vector256<float> xThreshold = Vector256.Create(threshold);

                while (pIdxCurrent + 8 <= pIdxEnd)
                {
                    Vector256<float> xDst1 = Load8(pdst1, pIdxCurrent);
                    xDst1 = MultiplyAdd(pSrcCurrent, xPrimal256, xDst1);
                    Vector256<float> xDst2 = GetNewDst256(xDst1, xThreshold);

                    Store8(in xDst1, pdst1, pIdxCurrent);
                    Store8(in xDst2, pdst2, pIdxCurrent);

                    pIdxCurrent += 8;
                    pSrcCurrent += 8;
                }

                Vector128<float> xPrimal128 = Vector128.Create(primalUpdate);
                Vector128<float> xThreshold128 = Vector128.Create(threshold);

                if (pIdxCurrent + 4 <= pIdxEnd)
                {
                    Vector128<float> xSrc = System.Runtime.Intrinsics.X86.Sse.LoadVector128(pSrcCurrent);

                    Vector128<float> xDst1 = MsSse.Load4(pdst1, pIdxCurrent);
                    xDst1 = System.Runtime.Intrinsics.X86.Sse.Add(xDst1, System.Runtime.Intrinsics.X86.Sse.Multiply(xSrc, xPrimal128));
                    Vector128<float> xDst2 = MsSse.GetNewDst128(xDst1, xThreshold128);

                    MsSse.Store4(in xDst1, pdst1, pIdxCurrent);
                    MsSse.Store4(in xDst2, pdst2, pIdxCurrent);

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
