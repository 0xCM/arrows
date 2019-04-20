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
    using operand = System.Single;
    using SysMath = System.MathF;

    partial class PrimOps { partial class Reify {
        public readonly partial struct Trig : Trigonmetric<operand> 
        {

            // !! Float32
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public operand acos(operand x)
                => SysMath.Acos(x);

            [MethodImpl(Inline)]   
            public operand acosh(operand x)
                => SysMath.Acosh(x);

            [MethodImpl(Inline)]   
            public operand asin(operand x)
                => SysMath.Asin(x);

            [MethodImpl(Inline)]   
            public operand asinh(operand x)
                => SysMath.Asinh(x);

            [MethodImpl(Inline)]   
            public operand atan(operand x)
                => SysMath.Atan(x);

            [MethodImpl(Inline)]   
            public operand atanh(operand x)
                => SysMath.Atanh(x);

            [MethodImpl(Inline)]   
            public operand cos(operand x)
                => SysMath.Cos(x);

            [MethodImpl(Inline)]   
            public operand cosh(operand x)
                => SysMath.Cosh(x);

            [MethodImpl(Inline)]   
            public operand sin(operand x)
                => SysMath.Sin(x);

            [MethodImpl(Inline)]   
            public operand sinh(operand x)
                => SysMath.Sinh(x);
            
            [MethodImpl(Inline)]   
            public operand tan(operand x)
                => SysMath.Tan(x);

            [MethodImpl(Inline)]   
            public operand tanh(operand x)
                => SysMath.Tanh(x);
        }

    }
}}