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

    public class ts_setif : UnitTest<ts_setif>
    {

        public void deposit32u()
        {
            var src1 = 0b00000000_00000000_00000000_10101010u;
            var m1 =   0b00000011_00000011_00000011_00000011u;             
            var d1e =  0b00000010_00000010_00000010_00000010u;
            var d1a = gbits.scatter(src1, m1);
            Claim.eq(d1e,d1a);

        }

        public void setif8u()
        {
            setif_check<byte>();
        }

        public void setif16u()
        {
            setif_check<ushort>();
        }

        public void setif32u()
        {
            setif_check<uint>();
        }

        public void setif64u()
        {
            setif_check<ulong>();
        }

        public void maskdef64u()
        {
            var m = 0ul;
            Bits.mask(ref m, 3, 9, 11);
            var bs = m.ToBitString();
            var seq = bs.BitSeq;
            Claim.yea(seq[3] == 1);
            Claim.yea(seq[9] == 1);
            Claim.yea(seq[11] == 1);

            
            seq[3] = 0;
            seq[9] = 0;
            seq[11] = 0;
            Claim.yea(bs.Format(true) == string.Empty);
        }

        void setif_check<T>(int cycles = DefaltCycleCount)
            where T : struct
        {
    
            var bitcount = gbits.width<T>();
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var src = Random.Next<T>();
                var dst = gmath.zero<T>();
                for(var i=0; i< bitcount; i++)
                gbits.setif(in src, i, ref dst, i);
                Claim.eq(src,dst);
            }
        }

    }

}