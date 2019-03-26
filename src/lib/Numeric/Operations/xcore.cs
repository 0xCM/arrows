//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static Traits;



    partial class xcore
    {
        public static string ToBitString(this byte src)
            => lpadZ(Convert.ToString(src,2), UInt8Ops.MaxBitLength);


        public static string ToBitString(this ushort src)
            => lpadZ(Convert.ToString(src,2), UInt16Ops.MaxBitLength);

    }
}