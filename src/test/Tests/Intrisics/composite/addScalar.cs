//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    public static class InXComposites
    {
        [MethodImpl(Inline)]
        public static ref T spanref<T>(Span<T> span)
            => ref MemoryMarshal.GetReference(span);

        public static unsafe void addScalar(Span<float> src, float value)
        {
            fixed (float* pDst = &spanref(src))
            {
                var pDstEnd = pDst + src.Length;
                var pDstCurrent = pDst;
                var pVectorizationEnd = pDstEnd - 4;

                var vScalar = Vec128.define(value);
                while (pDstCurrent <= pVectorizationEnd)
                {
                    InX.load(pDstCurrent, out Vec128<float> dstVector);
                    InX.add(dstVector, vScalar, pDstCurrent);
                    pDstCurrent += 4;
                }

                var numScalar = vScalar.ToNum128();
                while (pDstCurrent < pDstEnd)
                {
                    InX.load(pDstCurrent, out Num128<float> dstVector);
                    InX.add(numScalar, dstVector, pDstCurrent);
                    pDstCurrent++;
                }

            }

        }
        
    }

}