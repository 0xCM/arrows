//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static Registers;
    using static Cpu;
    

    public static class Asm
    {
        public static ref YMM vpxor(in YMM a, in YMM b, ref YMM dst)
        {
            dst.Assign(Xor(vec<ulong>(in a), vec<ulong>(in b)));
            return ref dst;
        }

        public static ref XMM pxor(in XMM a, in XMM b, ref XMM dst)
        {
            dst.Assign(Xor(vec<ulong>(in a), vec<ulong>(in b)));
            return ref dst;
        }

        public static XMM pxor(in XMM a, in XMM b)        
            => Xor(vec<ulong>(in a), vec<ulong>(in b));
        

    }


}