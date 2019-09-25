//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static BitParts;
    using static As;

    class IntrinsicScenarios : Deconstructable<IntrinsicScenarios>
    {
        public IntrinsicScenarios()
            : base(callerfile())
        {

        }


        public BitVector64 newBv64(ulong src)
            => bitvector.bv64(src);

        public BitVector64 newBv64(int src)
            => bitvector.bv64(src);

        public BitVector64 newBv8(int src)
            => bitvector.bv64(src);

        public int abs(int x)
            => gmath.abs(x);

        public static uint add(uint a, uint b)
            => gmath.add(a,b);

        public static uint and(uint a, uint b)
            => gmath.and(a,b);

        public static Vector256<byte> load(in byte src)
            => ginx.lddqu256(in src);

        public static uint xor32u(uint x, uint y)
        {
            var z = gmath.xor(x,y);
            return gmath.xor(ref z, y);            
        }
                  
        public static Vector256<uint> xor256x32u(Vector256<uint> ymm0, Vector256<uint> ymm1)
            => gbits.vxor(ymm0, ymm1);

        public static Vector256<uint> and256x32u(Vector256<uint> ymm0, Vector256<uint> ymm1)
            => gbits.vand(ymm0, ymm1);

        public static Vector256<byte> vpxor(in byte ymm0, in byte ymm1, in byte ymm2, in byte ymm3)
        {
            dinx.load256(in ymm0, in ymm1, out Vector256<byte> v0, out Vector256<byte> v1);
            dinx.load256(in ymm2, in ymm3, out Vector256<byte> v2, out Vector256<byte> v3);
                        
            var a0 = Xor(v0, v1);
            var a1 = Xor(v2, v3);

            var b0 = Xor(a0, a1);
        
            return b0;
        }


        public static Vector256<ulong> vpaddq(
            in ulong ymm0, in ulong ymm1, in ulong ymm2, in ulong ymm3, 
            in ulong ymm4, in ulong ymm5, in ulong ymm6, in ulong ymm7,
            in ulong ymm8, in ulong ymm9, in ulong ymm10, in ulong ymm11,
            in ulong ymm12, in ulong ymm13, in ulong ymm14, in ulong ymm15            
            )
        {
            var v0 = dinx.lddqu256(in ymm0);
            var v1 = dinx.lddqu256(in ymm1);
            var v2 = dinx.lddqu256(in ymm2);
            var v3 = dinx.lddqu256(in ymm3);
            var v4 = dinx.lddqu256(in ymm4);
            var v5 = dinx.lddqu256(in ymm5);
            var v6 = dinx.lddqu256(in ymm6);
            var v7 = dinx.lddqu256(in ymm7);
            var v8 = dinx.lddqu256(in ymm8);
            var v9 = dinx.lddqu256(in ymm9);
            var v10 = dinx.lddqu256(in ymm10);
            var v11 = dinx.lddqu256(in ymm11);
            var v12 = dinx.lddqu256(in ymm12);
            var v13 = dinx.lddqu256(in ymm13);
            var v14 = dinx.lddqu256(in ymm14);
            var v15 = dinx.lddqu256(in ymm15);
            
            var a0 = Add(v0, v1);
            var a1 = Add(v2, v3);
            var a2 = Add(v4, v5);
            var a3 = Add(v6, v7);
            var a4 = Add(v8, v9);
            var a5 = Add(v10, v11);
            var a6 = Add(v12, v13);
            var a7 = Add(v14, v15);

            var b0 = Add(a0, a1);
            var b1 = Add(a2, a3);
            var b2 = Add(a3, a4);
            var b3 = Add(a4, a5);
            var b4 = Add(a6, a7);
        
            var c0 = Add(b0, b1);
            var c1 = Add(b2, b3);

            var d0 = Add(c0, c1);
            var d1 = Add(d0, b4);

            return d1;
        }



    }
}