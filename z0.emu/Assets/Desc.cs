//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.InteropServices;
    using static Pow2;

    public static class Desc
    {
        public const string GpRegId = "Defines the set of general-purpose registers";        

        public const string RegIdInfo = "Defines labeled identifiers for known %d registers";

        public const string BaseRegId = "Defines starting values for register identifiers";

        public const string BaseRegIdLit = "Defines the first %d-bit register identifier";

    }

}