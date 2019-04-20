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
            var vLen = Vec128<float>.Length;
            var vScalar = Vec128.define(value);
            var numScalar = vScalar.ToNum128();

            var vScalar2 = Vector128.Create(value);
            var numScalar2 = Vector128.CreateScalar(value);

            var srcLen = src.Length;

            fixed (float* dst = &spanref(src))
            {
                var limit = dst + srcLen;
                var buffer = dst;
                var vLimit = limit - vLen;

                while (buffer <= vLimit)
                {
                    InX.load(buffer, out Vec128<float> dstVector); 
                    InX.add(dstVector, vScalar, out Vec128<float> result);
                    InX.store(result, buffer);
                    buffer += vLen;
                }

                while (buffer < limit)
                {
                    InX.load(buffer, out Num128<float> dstVector);
                    InX.add(dstVector, numScalar, out Num128<float> result);
                    InX.store(result, buffer);
                    buffer++;
                }

            }

        }
        
    }

}