//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static Nats;
    
    public class AvxPackTest : UnitTest<AvxPackTest>
    {

        public void Pack1()
        {
            var blockWidth = 8;

            uint BitPattern(int i)
                =>  i < 10 ? 1u : 0u; //mod<N5>((uint)i) != 0 ? 1u : 0u;

            Span<uint> input = new uint[256];
            for(var i=0; i<input.Length; i++)
                input[i] = BitPattern(i);

            Span<byte> bitseq = new byte[256];
            for(var i=0; i<input.Length; i++)
                bitseq[i] = (byte)input[i];
            var expect = BitString.FromBitSeq(bitseq);

            var sb = sbuild();
            for(var i=0; i< input.Length; i++)
            {
                sb.Append(input[i] == 0 ? '0' : '1');
                if((i + 1) % blockWidth == 0)
                    sb.Append(' ');
            }
            var parsed = BitString.Parse(new string(sb.ToString().ToCharArray().Reverse()));            
            var output = AvxPack.pack(Nats.N1, input);

            Trace("parsed", parsed.Format(blockWidth:blockWidth));
            Trace("expect", expect.Format(blockWidth:blockWidth));
            Trace("packed", output.ToBitString().Format(blockWidth:blockWidth));

            Claim.eq(parsed, expect);

            
            
        }
    }

}

