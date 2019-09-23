//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static IMM;


    public static partial class AsmRef
    {

    }

    public class AsmEncodingAttribute : Attribute
    {
        public AsmEncodingAttribute(string Name, string Spec = null, string Call = null, string Code = null)
        {
            this.Instruction = Name;
            this.Spec = Spec ?? string.Empty;
            this.AsmCall = Call ?? string.Empty;
            this.Encoding = Code ?? string.Empty;
        }

        /// <summary>
        /// The name of the instuction
        /// </summary>
        public string Instruction {get;}

        /// <summary>
        /// The encoding spec as defined by intel
        /// </summary>
        public string Spec {get;}

        /// <summary>
        /// A sample instruction call
        /// </summary>
        /// <value></value>
        public string AsmCall {get;}

        /// <summary>
        /// An encoding of the sample call
        /// </summary>
        public string Encoding {get;}
    }

}