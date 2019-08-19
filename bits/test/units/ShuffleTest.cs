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
            var control = Vec256.Decrements((byte)31);
            var src = Vec256.Increments((byte)0);
            var dst = dinx.arrange(src,control);

            //Mask to reverse both 128-bit lanes
            var lrMask1 = Span256.AllocBlocks<byte>(1);
            byte counter = 0;
            for(var i=0; i< lrMask1.Length; i++, counter++)
            {
                if(counter == 16)
                    counter = 0;
                lrMask1[i] = (byte)(15 - counter);
            }

            var rMask = Span256.AllocBlocks<byte>(1);
            for(var i=0; i< rMask.Length; i++)
                rMask[i] = (byte)(31 - i);
            var m2 = Vec256.Load(rMask);

            var v1 = Vec256.Increments((byte)0);
            var m1 = Vec256.Load(lrMask1);
            var v2 = dinx.shuffle(v1, m1);
            // Trace($"{v1.FormatHex()}");
            // Trace($"{m1.FormatHex()}");
            // Trace($"{v2.FormatHex()}");

            var v4 = Vec256.Increments((byte)0);
            var v6 = dinx.swaphl(v4);
            var v5 = dinx.arrange(v4, m2);
            Trace($"input:  {v4.FormatHex()}");
            Trace($"mask:   {m2.FormatHex()}");
            Trace($"v6  :   {v6.FormatHex()}");
            Trace($"result: {v5.FormatHex()}");

            
            
            // Trace($"control: {control.FormatHex()}");
            // Trace($" source: {src.FormatHex()}");
            // Trace($" result: {dst.FormatHex()}");

        }

    }

}