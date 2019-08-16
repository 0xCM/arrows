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

    public class BitMaskTest : UnitTest<BitMaskTest>
    {


        void SetBits<T>(int cycles = DefaltCycleCount)
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

        public void SetBits8()
        {
            SetBits<byte>();
        }

        public void SetBits16()
        {
            SetBits<ushort>();
        }

        public void SetBits32()
        {
            SetBits<uint>();
        }

        public void SetBits64()
        {
            SetBits<ulong>();
        }

        public void DefineMask64()
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

    }

}