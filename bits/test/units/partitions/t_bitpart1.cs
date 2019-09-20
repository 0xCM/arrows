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
                    BitParts.part32x1_test(src, dst);
                    sw.Stop();
                }
                Collect((OpCount, sw, opname));

            }

            spanstyle();
        }

    }

}