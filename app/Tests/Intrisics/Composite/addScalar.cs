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

    public unsafe struct PIterF32
    {
        [MethodImpl(Inline)]
        public static PIterF32 define(Span<float> src, int step = 1)
        {
            fixed (float* dst = &MemoryMarshal.GetReference(src))
            {
                var max = dst + src.Length;
                return new PIterF32(dst, max, step);
            }
        }
        
        readonly float* start; 
        
        readonly float* max;
        
        readonly int step;       

        float* pos; 

        [MethodImpl(Inline)]
        public PIterF32(float* start, float* max, int step = 1)
        {
            this.start = start;
            this.max = max;
            this.step = step;
            this.pos = start;
        }

        [MethodImpl(Inline)]
        public float* next()
            => pos += 1;
        
        [MethodImpl(Inline)]
        public float* advance(int count)
            => pos += count;

        [MethodImpl(Inline)]
        public bool complete()
            => pos > max;

        [MethodImpl(Inline)]
        public bool more()
            => pos <= max;

        [MethodImpl(Inline)]
        public bool next(out float* dst)
        {
            if(pos < max)
            {
                dst = (pos += step);
                return true;
            }
            else
            {
                dst = null;
                return false;
            }
            
        }
    }

    public static class InXComposites
    {
        [MethodImpl(Inline)]
        public static ref T spanref<T>(Span<T> span)
            => ref MemoryMarshal.GetReference(span);


        static readonly InXAdd AddOps = InXAdd.TheOnly;
        public static unsafe void addScalar(Span<float> src, float value)
        {
            var vLen = Vec128<float>.Length;
            var vScalar = Vec128.define(value);
            var numScalar = vScalar.ToNum128();
            var offset = 0;

            fixed (float* dst = &spanref(src))
            {
                var limit = dst + src.Length;
                var buffer = dst;
                var vLimit = limit - vLen;

                while (buffer <= vLimit)
                {
                    InX.load(buffer, out Vec128<float> dstVector); 
                    

                    InX.add(dstVector, vScalar, out Vec128<float> result);
                    InX.store(result, buffer);
                    // Ops.add(dstVector,vScalar, out Vec128<float> result);
                    // Ops.store(result, buffer);

                    // InXG.add(dstVector,vScalar, out Vec128<float> result);
                    // InXG.store(result, buffer);                              

                    buffer += vLen;
                    offset += vLen;
                }

                while (buffer < limit)
                {
                    InX.load(buffer, out Num128<float> dstVector);
                    InX.add(dstVector, numScalar, out Num128<float> result);
                    InX.store(result, buffer);
                    buffer++;
                    offset++;
                }

            }

        }

        static float[] target;
        public static unsafe void addScalar2(Span<float> src, float value)
        {
            var vLen = Vec128<float>.Length;
            var vScalar = Vec128.define(value);
            var numScalar = vScalar.ToNum128();


            var srcLen = src.Length;
            if(target == null)
                target = array<float>(srcLen);

            var offset = 0;
            fixed (float* dst = &spanref(src))
            {
                var limit = dst + srcLen;
                var buffer = dst;
                var vLimit = limit - vLen;

                while (buffer <= vLimit)
                {
                    InX.load(buffer, out Vec128<float> dstVector); 
                    InX.add(dstVector, vScalar, out Vec128<float> result);
                    InX.store(result, target, offset);
                    buffer += vLen;
                    offset += vLen;
                }

                while (buffer < limit)
                {
                    InX.load(buffer, out Num128<float> dstVector);
                    InX.add(dstVector, numScalar, out Num128<float> result);
                    InX.store(result,target, offset);
                    buffer++;
                    offset++;
                }

            }
        }

        
    }

}