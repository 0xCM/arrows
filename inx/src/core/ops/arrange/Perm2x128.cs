//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Collections.Generic;

    using static zfunc;

    public static class Perm2x128
    {
        static string FormatVec<T>(Vec256<T> src)
            where T : struct
                => src.FormatHex(false, AsciSym.Space);

        // public static string Describe2x128Perm<T>(Vec256<T> x, Vec256<T> y, byte spec, Vec256<T> z)
        //     where T : struct
        // {
        //     var xFmt = FormatVec(x);
        //     var yFmt = FormatVec(y);
        //     var zFmt = FormatVec(z);
        //     var specFmt = spec.ToBitString();
        //     var fmt = sbuild();
        //     var dataType = typeof(T).Name;
        //     fmt.AppendLine(new string(AsciSym.Minus, 80));
        //     fmt.AppendLine($"permute2x28 | (a:{dataType}, b:{dataType}) > {specFmt}");
        //     fmt.AppendLine(xFmt);
        //     fmt.AppendLine($"{yFmt}");
        //     fmt.AppendLine(zFmt);
        //     return fmt.ToString();
        // }

    }


}