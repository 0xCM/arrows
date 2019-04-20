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

    using static zcore;

    public static class MsSse
    {

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

        // dst[i] += scale
        public static unsafe void AddScalarU(float scalar, Span<float> dst)
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


        public static unsafe float DotU(ReadOnlySpan<float> src, ReadOnlySpan<float> dst, int count)
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


        public static unsafe void MulElementWiseU(ReadOnlySpan<float> src1, ReadOnlySpan<float> src2, Span<float> dst, int count)
        {
            zcore.demand(count <= src1.Length);
            zcore.demand(count <= src2.Length);
            zcore.demand(count <= dst.Length);
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

    }    
}

