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

    public class t_cpu_vpblend : t_cpu<t_cpu_vpblend>
    {


        public string vpblendw_report()
        {
            var report = sbuild();
            xmm(2) = XMM.FromCells<ushort>(1,2,3,4,5,6,7,8);
            report.AppendLine(FormatXmm<ushort>(2));
            
            xmm(3) = XMM.FromCells<ushort>(9,10,11,12,13,14,15,16);
            report.AppendLine(FormatXmm<ushort>(3));

            var imm = imm8(1,0,1,0,1,0,1,0);
            report.AppendLine(FormatImm<ushort>(imm));
            
            vpblendw(ref xmm(1), in xmm(2), in xmm(3), imm);

            report.Append(FormatXmm<ushort>(1));
            
            var text = report.ToString();
            Trace(text);
            return text;

        }
        public void vpblendw_check()
        {
            xmm(2) = XMM.FromCells<ushort>(1, 2,  3,  4,  5,  6,  7,  8);
            xmm(3) = XMM.FromCells<ushort>(9, 10, 11, 12, 13, 14, 15, 16);
            xmm(0) = XMM.FromCells<ushort>(9, 2,  11, 4,  13, 6,  15, 8);
            vpblendw(ref xmm(1), in xmm(2), in xmm(3), imm8(1,0,1,0,1,0,1,0));

                    
        }

    }

}