//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    # pragma warning disable 0219

    public class ShuffleTest : UnitTest<ShuffleTest>
    {

        //Hi nibble mask for operations within a uint
        const uint NM1 = 0x88888888u;

        //High nibble mask for operations within a byte
        const byte NM2 = 0x88;

        //High byte mask for operations within a uint
        const uint BMH = 0x80808080; 

        //Low byte mask for operations within a uint
        const uint  BML = 0x01010101;
        
        const uint x = 4u;
        
        const uint y = 5u;
                
        const byte x2 = 4;
        
        const byte y2 = 5;
        
        const byte add2 = ((x2 &~NM2) + (y2 &~NM2)) ^ ((x2 ^ y2) & NM2);
        
        const byte sub2 = ((x2 | NM2) - (y2 &~NM2)) ^ ((x2 ^~y2) & NM2);
        
        const uint _add = ((x &~NM1) + (y &~NM1)) ^ ((x ^ y) & NM1);
        
        const uint _sub = ((x | NM1) - (y &~NM1)) ^ ((x ^~y) & NM1);
        
        //See https://www.chessprogramming.org/Byte
        static uint add8(uint x, uint y)
            => ((x &~BMH) + (y &~BMH)) ^ ((x ^ y) & BMH);

        static uint sub8(uint x, uint y)
            => ((x | BMH) - (y &~BMH)) ^ ((x ^~y) & BMH);

        void TestBytes()
        {
            var a = add8(0x11AAAA, 0x99FF2211);
            Trace(a.FormatHex());

        }

        //http://programming.sirrida.de:perm_64.asm 
        ulong shuffle_64_0_6(ulong src, ulong mask = 0x5555555555555555ul)
            => Bits.deposit(src, mask) | Bits.deposit(src >> 32, ~mask) ;  

        public void ShuffleBytes()
        {


        }

    }

}