//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;
    using operand = System.Numerics.BigInteger;
    using SysMath = System.Math;

    partial class PrimOps { partial class Reify {
        public readonly partial struct Trig : Trigonmetric<operand> 
        {

            [MethodImpl(Inline)]   
            public operand sin(operand x)
                => (operand)SysMath.Sin((ulong)x);

            [MethodImpl(Inline)]   
            public operand sinh(operand x)
                => (operand)SysMath.Sinh((ulong)x);

            [MethodImpl(Inline)]   
            public operand asin(operand x)
                => (operand)SysMath.Asin((ulong)x);

            [MethodImpl(Inline)]   
            public operand asinh(operand x)
                => (operand)SysMath.Asinh((ulong)x);

            [MethodImpl(Inline)]   
            public operand cos(operand x)
                => (operand)SysMath.Cos((ulong)x);

            [MethodImpl(Inline)]   
            public operand cosh(operand x)
                => (operand)SysMath.Cosh((ulong)x);

            [MethodImpl(Inline)]   
            public operand acos(operand x)
                => (operand)SysMath.Acos((ulong)x);

            [MethodImpl(Inline)]   
            public operand acosh(operand x)
                => (operand)SysMath.Acosh((ulong)x);

            [MethodImpl(Inline)]   
            public operand tan(operand x)
                => (operand)SysMath.Tan((ulong)x);

            [MethodImpl(Inline)]   
            public operand tanh(operand x)
                => (operand)SysMath.Tanh((ulong)x);

            [MethodImpl(Inline)]   
            public operand atan(operand x)
                => (operand)SysMath.Atan((ulong)x);

            [MethodImpl(Inline)]   
            public operand atanh(operand x)
                    => (operand)SysMath.Atanh((ulong)x);
            }

    }
}}