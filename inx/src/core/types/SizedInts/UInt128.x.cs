//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    public static class UInt128X
    {         
        [MethodImpl(Inline)]
        public static Vec128<ulong> ToVec128(this UInt128 src)
            => src;

        [MethodImpl(Inline)]
        public static UInt128 ToUInt128(this in Vec128<ulong> src)
            => src;

        [MethodImpl(Inline)]
        public static UInt128 ToUInt128(this in Vector128<ulong> src)
            => src;
 
        public static string Format(this UInt128 src)
        {
            if(src.hi != 0)
                return $"{src.hi.FormatHex(false,true)}{src.lo.FormatHex(true,false)}";
            else
                return src.lo.FormatHex(false,true);
        }

   }

}