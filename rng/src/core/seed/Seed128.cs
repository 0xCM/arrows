//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    public static class Seed128
    {
        public static Vector<N2,ulong> Seed00 =>
            new ulong[]{Seed64.Seed00, Seed64.Seed01};

        public static Vector<N2,ulong> Seed01 =>
            new ulong[]{Seed64.Seed02, Seed64.Seed03};

        public static Vector<N2,ulong> Seed02 =>
            new ulong[]{Seed64.Seed04, Seed64.Seed05};

        public static Vector<N2,ulong> Seed03 =>
            new ulong[]{Seed64.Seed06, Seed64.Seed07};

        public static Vector<N2,ulong> Seed04 =>
            new ulong[]{Seed64.Seed08, Seed64.Seed09};

        public static Vector<N2,ulong> Seed05 =>
            new ulong[]{Seed64.Seed10, Seed64.Seed11};

        public static Vector<N2,ulong> Seed06 =>
            new ulong[]{Seed64.Seed12, Seed64.Seed13};

        public static Vector<N2,ulong> Seed07 =>
            new ulong[]{Seed64.Seed14, Seed64.Seed15};

       public static Vector<N2,ulong> Seed08 =>
            new ulong[]{Seed64.Seed16, Seed64.Seed17};

    }


}