//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu.Test
{
    using System;
    using System.Linq;
    using Z0.Test;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class ImmTest : UnitTest<ImmTest>
    {


        public void VerifyWidth()
        {
            var imm8 = Imm.Define(4);
            Claim.eq(8, Imm<byte>.Width);
            Claim.eq("imm8", imm8.Label);

            var imm16 = Imm.Define((ushort)16);
            Claim.eq(16, imm16.Width);
            Claim.eq("imm16", imm16.Label);

            var imm32 = Imm.Define(16u);
            Claim.eq(32, imm32.Width);
            Claim.eq("imm32", imm32.Label);

            var imm64 = Imm.Define(16ul);
            Claim.eq(64, imm64.Width);
            Claim.eq("imm64", imm64.Label);

        }

    }

}