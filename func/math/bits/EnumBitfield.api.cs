//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines primary api for negotiating bitfields predicated on enumerations
    /// </summary>
    public static class EnumBitField
    {
        public static EnumBitField<T> Define<T>(ulong data)
            where T : Enum
                => EnumBitField<T>.Define(data);
    }


}