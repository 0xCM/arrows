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
            var r = Perm8Symbol.Reverse;
            var f = r.ToPerm();

            for(int i=0, j=7; i<8; i++, j--)
            {
                var x = (Perm8Symbol)f[i];
                var y = (Perm8Symbol)j;
                Claim.eq(x,y);

            }
            
        }

        public void identity()
        {
            YMM src = YmmPattern.Increasing<uint>();
            YMM expect = YmmPattern.Increasing<uint>();
            var actual = vpermd(src, Perm8.Identity);
            Claim.eq(expect,actual);            
        }
        
    }
}