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
    using operand = System.Byte;
    using SysMath = System.MathF;

    partial class PrimOps { partial class Reify {
        public readonly partial struct Trig : Trigonmetric<operand> 
        {

            // !! UInt16
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public operand sin(operand x)
                => (operand)SysMath.Sin(x);

            [MethodImpl(Inline)]   
            public operand sinh(operand x)
                => (operand)SysMath.Sinh(x);

            [MethodImpl(Inline)]   
            public operand asin(operand x)
                => (operand)SysMath.Asin(x);

            [MethodImpl(Inline)]   
            public operand asinh(operand x)
                => (operand)SysMath.Asinh(x);

            [MethodImpl(Inline)]   
            public operand cos(operand x)
                => (operand)SysMath.Cos(x);

            [MethodImpl(Inline)]   
            public operand cosh(operand x)
                => (operand)SysMath.Cosh(x);

            [MethodImpl(Inline)]   
            public operand acos(operand x)
                => (operand)SysMath.Acos(x);

            [MethodImpl(Inline)]   
            public operand acosh(operand x)
                => (operand)SysMath.Acosh(x);

            [MethodImpl(Inline)]   
            public operand tan(operand x)
                => (operand)SysMath.Tan(x);

            [MethodImpl(Inline)]   
            public operand tanh(operand x)
                => (operand)SysMath.Tanh(x);

            [MethodImpl(Inline)]   
            public operand atan(operand x)
                => (operand)SysMath.Atan(x);

            [MethodImpl(Inline)]   
            public operand atanh(operand x)
                    => (operand)SysMath.Atanh(x);
            }

    }
}}