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

        public void Perm1()
        {
            var mask = (byte)0b11101010;
            var src = Randomizer.Vec128<float>();
            var dst = dinx.permute(src,mask);
            
            var bsMask = mask.ToBitString();
            var bsSrc = src.ToBlockedHexString();
            var bsDst = dst.ToBlockedHexString();

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