//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using Z0.Cpu;


    [DisplayName("scenarios-inline")]
    class InlineScenarios
    {
        public BitSize GetWidth(IImm<byte> src)
            => src.Width;

        public string GetLabel(IImm<byte> src)
            => src.Label;

        public byte GetValue1(IImm<byte> src)
            => src.Value;

        public byte GetValue2(Imm8 src)
            => src.Value;
        
        public byte GetValue3(IImm<byte> src)        
            => imagine(ref src, out Imm8 dst).Value;

        public byte GetValue4(IImm<byte> src)        
            => imagine(ref src, out byte dst);

        public byte GetValue5(IImm<byte> src)
            => Imm<byte>.From(src).Value;

        public bool IsSignExtended(IImm<byte> src)
            => src.IsSignExtended;
    }

}