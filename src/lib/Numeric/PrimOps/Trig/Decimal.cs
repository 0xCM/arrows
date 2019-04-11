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
    using operand = System.Decimal;
    using SysMath = System.Math;

    partial class PrimOps { partial class Reify {
        public readonly partial struct Trig : Trigonmetric<operand> 
        {

            // !! Decimal
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public operand sin(operand x)
                => (operand)Math.Sin((double)x);

            [MethodImpl(Inline)]   
            public operand sinh(operand x)
                => (operand)Math.Sinh((double)x);

            [MethodImpl(Inline)]   
            public operand asin(operand x)
                => (operand)Math.Asin((double)x);

            [MethodImpl(Inline)]   
            public operand asinh(operand x)
                => (operand)Math.Asinh((double)x);

            [MethodImpl(Inline)]   
            public operand cos(operand x)
                => (operand)Math.Cos((double)x);

            [MethodImpl(Inline)]   
            public operand cosh(operand x)
                => (operand)Math.Cosh((double)x);

            [MethodImpl(Inline)]   
            public operand acos(operand x)
                => (operand)Math.Acos((double)x);

            [MethodImpl(Inline)]   
            public operand acosh(operand x)
                => (operand)Math.Acosh((double)x);

            [MethodImpl(Inline)]   
            public operand tan(operand x)
                => (operand)Math.Tan((double)x);

            [MethodImpl(Inline)]   
            public operand tanh(operand x)
                => (operand)Math.Tanh((double)x);

            [MethodImpl(Inline)]   
            public operand atan(operand x)
                => (operand)Math.Atan((double)x);

            [MethodImpl(Inline)]   
            public operand atanh(operand x)
                => (operand)Math.Atanh((double)x);
      }

    }
}}