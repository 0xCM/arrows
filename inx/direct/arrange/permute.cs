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
    
    
    using static zfunc;

    public abstract class Literal<T,L>
        where T : Literal<T,L>
    {
        [MethodImpl(Inline)]
        public static implicit operator L(Literal<T,L> src)
            => src.Value;

        public readonly L Value;

        protected Literal(L Value)
            => this.Value = Value;
    }

    public sealed class PermuteControl : Literal<PermuteControl,byte>
    {
        public static byte Control(PermuteControl x0, PermuteControl x1, PermuteControl x2, PermuteControl x3)
            => (byte)(x0 << 0 | x1 << 2 | x2 << 4 | x3 << 6); 

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
        public static Vec128<float> permute(in Vec128<float> value, byte control)
            => Permute(value, control);

        [MethodImpl(Inline)]
        public static Vec128<double> permute(in Vec128<double> value, byte control)
            => Permute(value, control);

        [MethodImpl(Inline)]
        public static Vec128<float> permute(in Vec128<float> lhs, in Vec128<int> control)
            => PermuteVar(lhs, control);

        [MethodImpl(Inline)]
        public static Vec128<double> permute(in Vec128<double> lhs, in Vec128<long> control)
            => PermuteVar(lhs, control);

        [MethodImpl(Inline)]
        public static Vec256<long> permute(in Vec256<long> value, byte control)
            => Permute4x64(value,control);

        [MethodImpl(Inline)]
        public static Vec256<ulong> permute(in Vec256<ulong> value, byte control)
            => Permute4x64(value,control);

        [MethodImpl(Inline)]
        public static Vec256<double> permute(in Vec256<double> value, byte control)
            => Permute4x64(value,control);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> permute(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<byte> permute(in Vec256<byte> lhs, in Vec256<byte> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<short> permute(in Vec256<short> lhs, in Vec256<short> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<ushort> permute(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<int> permute(in Vec256<int> lhs, in Vec256<int> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<uint> permute(in Vec256<uint> lhs, in Vec256<uint> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<long> permute(in Vec256<long> lhs, in Vec256<long> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<ulong> permute(in Vec256<ulong> lhs, in Vec256<ulong> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<float> permute(in Vec256<float> lhs, in Vec256<float> rhs, byte control)
            => Permute2x128(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<double> permute(in Vec256<double> lhs, in Vec256<double> rhs, byte control)
            => Permute2x128(lhs,rhs,control); 

        [MethodImpl(Inline)]
        public static Vec256<float> permute(Vec256<float> lhs, in Vec256<int> control)
            => PermuteVar(lhs, control);

        [MethodImpl(Inline)]
        public static Vec256<double> permute(Vec256<double> lhs, in Vec256<long> control)
            => PermuteVar(lhs, control);


    }
}