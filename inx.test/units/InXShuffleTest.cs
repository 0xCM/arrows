//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static Constants;


    public class InXShuffleTest : UnitTest<InXShuffleTest>
    {
        const byte Mask255 = 0b00000011;
        
        const byte Mask128 = 0b10000000;

        const byte Mask64 = 0b01000000;
        
        public void Shuffle1()
        {
            var mask = Mask128.FillVec128();
            var src = Random.Vec128<byte>();
            var dst = dinx.shuffle(in src, in mask);
            var zed = U8Zero.FillVec128();
            
            Claim.eq(dst,zed);
                            
        }

        public void Shuffle2()
        {
            var mask = ((byte)0b00001111).FillVec128();
            var src = Random.Vec128<byte>();
            var dst = dinx.shuffle(in src, in mask);
            //mask = 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111 | 00001111
            //src =  11110110 | 10000110 | 01010010 | 11111000 | 00010100 | 01101011 | 10000001 | 01011000 | 01000111 | 10010100 | 11101100 | 10101100 | 01000011 | 00101000 | 11011010 | 00100110
            //dst =  11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110 | 11110110
            var bsMask = mask.ToBlockedBitString();
            var bsSrc = src.ToBlockedBitString();
            var bsDst = dst.ToBlockedBitString();


        }

    }

}
