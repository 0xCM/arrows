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
    using System.Runtime.InteropServices;
    
    using static zfunc;
    using static Reg;
    using static Asm;

    public class t_vpermd : t_cpu<t_vpermd>
    {

        public void represent()
        {
            var r = Perm8.Reverse;
            var f = r.ToPerm();

            for(int i=0, j=7; i<8; i++, j--)
            {
                var x = (Perm8)f[i];
                var y = (Perm8)j;
                Claim.eq(x,y);

            }
            
        }

        void reverse()
        {
            YMM src = YmmPattern.Increasing<uint>();
            YMM expect = YmmPattern.Decrements(7u);
            var actual = vpermd(src, Perm8.Reverse);
            Claim.eq(expect,actual);            
        }

        public void identity()
        {
            YMM src = YmmPattern.Increasing<uint>();
            YMM expect =YmmPattern.Increasing<uint>();
            var actual = vpermd(src, Perm.Assemble8());
            Claim.eq(expect,actual);            
        }
        
    }
}