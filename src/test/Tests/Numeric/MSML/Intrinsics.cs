// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//This code in this file was extracted from the MSML project
namespace  Z0.Testing
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    public static partial class MSML
    {
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

    }    
}

