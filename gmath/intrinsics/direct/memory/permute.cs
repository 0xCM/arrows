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
    
    using static zcore;
    using static math;

    public sealed class PermuteControl : Literal<PermuteControl,byte>
    {

        public static byte Control(PermuteControl x0, PermuteControl x1, PermuteControl x2, PermuteControl x3)
            => or(lshift(x0, 0), lshift(x1, 2), lshift(x2, 4), lshift(x3, 6)); 

        PermuteControl(byte value)
            : base(value)
            {

            }

        public static byte Identity()
            => Control(PermuteControl.A, PermuteControl.B, PermuteControl.C, PermuteControl.D);

        public static readonly PermuteControl A = new PermuteControl(0b00);


        public static readonly PermuteControl B = new PermuteControl(0b01);


        public static readonly PermuteControl C = new PermuteControl(0b10);


        public static readonly PermuteControl D = new PermuteControl(0b11);

    }


    partial class dinx
    {


        public static Vec128<float> permute(Vec128<float> value, byte control)
            => Avx2.Permute(value, control);

        public static Vec128<float> permute(Vec128<float> value, PermuteControl control)
            => Avx2.Permute(value, control);

    }

}