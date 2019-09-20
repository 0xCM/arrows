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

    public class t_bitpar16 : BitPartTest<t_bitpar16>
    {                    


        public void bitpart_32x16()
        {                 
            bitpart_check<uint,ushort>(BitParts.part32x16, (int)Part32x16.Count, (int)Part32x16.Width);
        }

        



    }

}