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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    
    using static math;
    using static global::mfunc;

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

        [MethodImpl(Inline)]
        public static Vec128<float> permute(Vec128<float> value, byte control)
            => Permute(value, control);

        [MethodImpl(Inline)]
        public static Vec128<float> permute(Vec128<float> value, PermuteControl control)
            => Permute(value, control);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> permute(Vec256<sbyte> lhs, Vec256<sbyte> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<byte> permute(Vec256<byte> lhs, Vec256<byte> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<short> permute(Vec256<short> lhs, Vec256<short> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<ushort> permute(Vec256<ushort> lhs, Vec256<ushort> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<int> permute(Vec256<int> lhs, Vec256<int> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<uint> permute(Vec256<uint> lhs, Vec256<uint> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<long> permute(Vec256<long> lhs, Vec256<long> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<ulong> permute(Vec256<ulong> lhs, Vec256<ulong> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<float> permute(Vec256<float> lhs, Vec256<float> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<double> permute(Vec256<double> lhs, Vec256<double> rhs, byte control)
            => Permute2x128(lhs,rhs,control);
    }
}