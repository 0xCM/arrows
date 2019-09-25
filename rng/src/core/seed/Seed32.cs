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


    public static class Seed32
    {    

        public static uint Seed00 => (uint)Seed64.Lookup(0);

        public static uint Seed01 => (uint)(Seed64.Lookup(0) >> 16);

        public static uint Seed02 => (uint)Seed64.Lookup(1);

        public static uint Seed03 =>  (uint)(Seed64.Lookup(1) >> 16);

        public static uint Seed04 => (uint)Seed64.Lookup(2);

        public static uint Seed05 =>  (uint)(Seed64.Lookup(2) >> 16);

        public static uint Seed06 => (uint)Seed64.Lookup(3);

        public static uint Seed07 =>  (uint)(Seed64.Lookup(3) >> 16);


    }

}