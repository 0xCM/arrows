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

        public void reverse()
        {
            YMM src = Vec256Pattern.Increasing<uint>();
            YMM expect = Vec256Pattern.Decrements(7u);
            var actual = vpermd(in src, Perm8.Reverse);
            Claim.eq(expect,actual);            
        }

        public void identity()
        {
            YMM src = Vec256Pattern.Increasing<uint>();
            YMM expect =Vec256Pattern.Increasing<uint>();
            var actual = vpermd(in src, Perm.Assemble8());
            Claim.eq(expect,actual);            
        }
        
    }
}