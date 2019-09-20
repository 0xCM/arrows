//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using static BitParts;

    public class t_bitpart1 : BitPartTest<t_bitpart1>
    {
        
        public void bitpart_32x1()
        {
            bitpart_check<uint,byte>(BitParts.part32x1, (int)Part32x1.Count,(int)Part32x1.Width);            
        }

        public void bitpart_32x1_bench()
        {
            void bitstring()
            {
                var opname = "part32x1_bitstring";
                var sw = stopwatch(false);
                var bs = default(BitString);
                for(var i=0; i< OpCount; i++)  
                {
                    var src = Random.Next<uint>();
                    sw.Start();
                    bs =src.ToBitString();
                    sw.Stop();
                }
                Collect((OpCount, sw, opname));

            }

            void blockstyle()
            {
                var opname = "part32x1_block32";
                var sw = stopwatch(false);
                BitBlock32 last  = default;
                for(var i=0; i< OpCount; i++)  
                {
                    var src = Random.Next<uint>();
                    sw.Start();
                    BitParts.part32x1(src, ref last);
                    sw.Stop();
                }
                Collect((OpCount, sw, opname));
            }
        
            void spanstyle()
            {
                var opname = "part32x1";
                var sw = stopwatch(false);
                Span<byte> dst = stackalloc byte[32];
                for(var i=0; i< OpCount; i++)  
                {
                    var src = Random.Next<uint>();
                    sw.Start();
                    BitParts.part32x1(src, dst);
                    sw.Stop();
                }
                Collect((OpCount, sw, opname));

            }

            void bittest()
            {
                var opname = "part32x1_test";
                var sw = stopwatch(false);
                Span<byte> dst = stackalloc byte[32];
                for(var i=0; i< OpCount; i++)  
                {
                    var src = Random.Next<uint>();
                    sw.Start();
                    part32x1_test(src, dst);
                    sw.Stop();
                }
                Collect((OpCount, sw, opname));

            }

            spanstyle();
        }

        static void part32x1_test(uint src, Span<byte> dst)
        {
            dst[0] = ((src & (1u << 0)) != 0u).ToByte();
            dst[1] = ((src & (1u << 1)) != 0u).ToByte();
            dst[2] = ((src & (1u << 2)) != 0u).ToByte();
            dst[3] = ((src & (1u << 3)) != 0u).ToByte();
            dst[4] = ((src & (1u << 4)) != 0u).ToByte();
            dst[5] = ((src & (1u << 5)) != 0u).ToByte();
            dst[6] = ((src & (1u << 6)) != 0u).ToByte();
            dst[7] = ((src & (1u << 7)) != 0u).ToByte();
            dst[8] = ((src & (1u << 8)) != 0u).ToByte();
            dst[9] = ((src & (1u << 9)) != 0u).ToByte();
            dst[10] = ((src & (1u << 10)) != 0u).ToByte();
            dst[11] = ((src & (1u << 11)) != 0u).ToByte();
            dst[12] = ((src & (1u << 12)) != 0u).ToByte();
            dst[13] = ((src & (1u << 13)) != 0u).ToByte();
            dst[14] = ((src & (1u << 14)) != 0u).ToByte();
            dst[15] = ((src & (1u << 15)) != 0u).ToByte();
            dst[16] = ((src & (1u << 16)) != 0u).ToByte();
            dst[17] = ((src & (1u << 17)) != 0u).ToByte();
            dst[18] = ((src & (1u << 18)) != 0u).ToByte();
            dst[19] = ((src & (1u << 19)) != 0u).ToByte();
            dst[20] = ((src & (1u << 20)) != 0u).ToByte();
            dst[21] = ((src & (1u << 21)) != 0u).ToByte();
            dst[22] = ((src & (1u << 22)) != 0u).ToByte();
            dst[23] = ((src & (1u << 23)) != 0u).ToByte();
            dst[24] = ((src & (1u << 24)) != 0u).ToByte();
            dst[25] = ((src & (1u << 25)) != 0u).ToByte();
            dst[26] = ((src & (1u << 26)) != 0u).ToByte();
            dst[27] = ((src & (1u << 27)) != 0u).ToByte();
            dst[28] = ((src & (1u << 29)) != 0u).ToByte();
            dst[29] = ((src & (1u << 29)) != 0u).ToByte();
            dst[30] = ((src & (1u << 30)) != 0u).ToByte();
            dst[31] = ((src & (1u << 31)) != 0u).ToByte();
        }

    }

}