//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static cephes.Floor;
    partial class cephes
    {

        
        
        internal static class Floor
        {
            public static ushort[] bmask = {
                0xffff,
                0xfffe,
                0xfffc,
                0xfff8,
                0xfff0,
                0xffe0,
                0xffc0,
                0xff80,
                0xff00,
                0xfe00,
                0xfc00,
                0xf800,
                0xf000,
                0xe000,
                0xc000,
                0x8000,
                0x0000,
            };

        }



    }




}



