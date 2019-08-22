//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class BlendTests : UnitTest<BlendTests>
    {     



        public void Blend256u8()
        {
            void Test()
            {
                var v0 = Random.CpuVec256<byte>();
                var v1 = Random.CpuVec256<byte>();
                var bits = Random.BitString<N32>();
                var mask = Vec256.Load(bits.Map(x => x ? (byte)0xFF : (byte)0));
                var v3 = dinx.blendv(v0,v1,mask);
                
                var selection = Span256.AllocBlocks<byte>(1);
                for(var i=0; i< selection.Length; i++)
                    selection[i] = bits[i] ? v1[i] : v0[i];
                var v4 =  selection.ToVec256();            
                
                Claim.eq(v3, v4);
            }

            Verify(Test);
        }




    }

}