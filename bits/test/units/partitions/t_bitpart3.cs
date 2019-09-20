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

    public class t_bitpart3 : BitPartTest<t_bitpart3>
    {
        public void bitpart_15x3()
        {                 
            bitpart_check<ushort,byte>(BitParts.part15x3, (int)Part15x3.Count,(int)Part15x3.Width);
        }

        public void bitpart_18x3()
        {                 
            bitpart_check<uint,byte>(BitParts.part18x3, (int)Part18x3.Count,(int)Part18x3.Width);
        }

        public void bitpart_21x3()
        {                 
            bitpart_check<uint,byte>(BitParts.part21x3, (int)Part21x3.Count,(int)Part21x3.Width);
        }

        public void bitpart_24x3()
        {                 
            bitpart_check<uint,byte>(BitParts.part24x3, (int)Part24x3.Count,(int)Part24x3.Width);
        }

        public void bitpart_27x3()
        {                 
            bitpart_check<uint,byte>(BitParts.part27x3, (int)Part27x3.Count,(int)Part27x3.Width);
        }

        public void bitpart_30x3()
        {                 
            bitpart_check<uint,byte>(BitParts.part30x3, (int)Part30x3.Count,(int)Part30x3.Width);
        }

    }

}