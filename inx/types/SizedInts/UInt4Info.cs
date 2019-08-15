//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zfunc;    

    /// <summary>
    /// Encapsulates UInt4 characteristics/facets
    /// </summary>
    public readonly struct UInt4Info
    {        
        public readonly UInt4 Zero;

        public readonly UInt4 One;

        public readonly UInt4 MinValue;

        public readonly UInt4 MaxValue;

        public UInt4Info(UInt4 Zero, UInt4 One, UInt4 MinValue, UInt4 MaxValue)
        {
            this.Zero = Zero;
            this.One = One;
            this.MinValue = MinValue;
            this.MaxValue = MaxValue;
        }
    }


}