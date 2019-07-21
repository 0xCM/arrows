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


    public class InXPermTest : UnitTest<InXPermTest>
    {
        public void Swap()
        {
            var subject = Vec256.define(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = dinx.swap(subject, 2, 3);
            var expect = Vec256.define(2, 4, 8, 6, 10, 12, 14, 16);
            Claim.eq(expect, swapped);
        }

        public void Reverse()
        {
            var subject = Vec256.define(11u, 13u, 17u, 19u, 27u, 31u, 37u, 39u);
            var control = Vec256.define(7u, 5u, 6u, 4u, 3u, 2u, 1u, 0u);
            var result = dinx.permute(subject,control);
            Claim.eq(dinx.reverse(subject), result);
        }

        public void Perm1()
        {
            var mask = (byte)0b11101010;
            var src = Random.Vec128<float>();
            var dst = dinx.permute(src,mask);
            
            var bsMask = mask.ToBitString();
            var bsSrc = src.FormatHex();
            var bsDst = dst.FormatHex();

            //mask = 00000011
            //       A          B          C          D  
            //src =  3f3c17d5 | 3f5de953 | 3f3df422 | 3e02d662
            //       D          D          D          A 
            //dst =  3e02d662 | 3e02d662 | 3e02d662 | 3f3c17d5

            //mask = 00001011
            //       A          B          C          D  
            //src =  3f3c17d5 | 3f5de953 | 3f3df422 | 3e02d662
            //       D          D          B          A  
            //dst =  3e02d662 | 3e02d662 | 3f5de953 | 3f3c17d5

            //mask = 10101010
            //       A          B          C          D  
            //src =  3f3c17d5 | 3f5de953 | 3f3df422 | 3e02d662
            //       A          B          C          D  
            //dst =  3f5de953 | 3f5de953 | 3f5de953 | 3f5de953

            //mask = 11101010
            //       A          B          C          D  
            //src =  3f3c17d5 | 3f5de953 | 3f3df422 | 3e02d662
            //       A          B          B          B  
            //dst =  3f3c17d5 | 3f5de953 | 3f5de953 | 3f5de953

            Trace($"//mask = {bsMask}");
            Trace($"//src =  {bsSrc}");
            Trace($"//dst =  {bsDst}");

        }

    }


}