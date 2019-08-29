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
            var mask =      0b00000000_00000000_00000000_11111111u; 
            var src =       0b00000000_00000000_00000000_00011100u;
            //var expect =    0b00000000_00000000_00000000_10101010u;
            var deposited = gbits.deposit(src, mask);
            Trace("mask", mask.ToBitString().Format(blockWidth:8));
            Trace("source", src.ToBitString().Format(blockWidth:8));
            Trace("deposited", deposited.ToBitString().Format(blockWidth:8));
            //Claim.eq(expect,actual);
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