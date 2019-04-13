//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using X86 = System.Runtime.Intrinsics.X86;
    using static zcore;

    /// <summary>
    /// Specifies the intrisinc instruction sets available on the
    /// executing machine
    /// </summary>
    public class IntrisicFeatures
    {
        public static IntrisicFeatures get()
            => new IntrisicFeatures();

        IntrisicFeatures()
        {
            Aes = X86.Aes.IsSupported;
            Avx = X86.Avx.IsSupported;
            Avx2 = X86.Avx2.IsSupported;
            Bmi1 = X86.Bmi1.IsSupported;
            Bmi2 = X86.Bmi2.IsSupported;
            Fma = X86.Fma.IsSupported;
            Lzcnt = X86.Lzcnt.IsSupported;
            Pclmulqdq =  X86.Pclmulqdq.IsSupported;
            Popcnt = X86.Popcnt.IsSupported;
            Sse = X86.Sse.IsSupported;
            Sse2 = X86.Sse2.IsSupported;
            Sse3 = X86.Sse3.IsSupported;
            Sse41 = X86.Sse41.IsSupported;
            Sse42 = X86.Sse42.IsSupported;
        }
        

        public bool Aes {get;}

        public bool Avx {get;}

        public bool Avx2 {get;}

        public bool Bmi1 {get;}

        public bool Bmi2 {get;}

        public bool Fma {get;}

        public bool Lzcnt {get;}

        public bool Pclmulqdq {get;}

        public bool Popcnt {get;}

        public bool Sse {get;}

        public bool Sse2 {get;}

        public bool Sse3 {get;}

        public bool Sse41 {get;}

        public bool Sse42 {get;}

        public override string ToString()
            => GetType().Properties().WithGet().Select(x => (x.Name, x.GetValue(this))).Format();
    }
}