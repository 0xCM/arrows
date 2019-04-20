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
