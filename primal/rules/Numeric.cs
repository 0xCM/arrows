//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;


    public abstract class DateRule : Rule<Date>
    {

    }
    
    public static class NumericRules
    {
        public abstract class NumericRule<T> : Rule<T>
            where T : struct
        {

        }

        public abstract class UnaryRule<T> : NumericRule<T>
            where T : struct
        {
            protected num<T> Operand {get;}

            protected UnaryRule(T Threshold)
            {
                this.Operand = Threshold;
            }

        }    

        public abstract class BinaryRule<T> : NumericRule<T>
            where T : struct
        {
            protected BinaryRule(T lhs, T rhs)
            {
                this.Lhs = lhs;
                this.Rhs = rhs;
            }

            protected num<T> Lhs {get;}

            protected num<T> Rhs {get;}


        }

        public sealed class Equal<T> : UnaryRule<T>
            where T : struct
        {
            public Equal(T operand)
                : base(operand)
            {

            }

            public override bool Satisfies(T value)
                => value == Operand;
        }

        public class Between<T> : BinaryRule<T>
            where T : struct
        {
            public Between(T lhs, bool leftInclusive, T rhs, bool rightInclusive)
                : base(lhs,rhs)
            {
                range = new Interval<T>(lhs, leftInclusive, rhs, rightInclusive);
            }

            Interval<T> range;

            public override bool Satisfies(T value)
                => range.Contains(value);
        }

        public class LessThan<T> : UnaryRule<T>
            where T : struct
        {
            public LessThan(T Threshold)
                : base(Threshold)
            {

            }

            public override bool Satisfies(T value)
                => value < Operand;
        }

        public class LessThanOrEqual<T> : UnaryRule<T>
            where T : struct
        {
            public LessThanOrEqual(T Threshold)
                : base(Threshold)
            {

            }

            public override bool Satisfies(T value)
                => value <= Operand;
        }

        public class GreaterThan<T> : UnaryRule<T>
            where T : struct
        {
            public GreaterThan(T operand)
                : base(operand)
            {

            }

            public override bool Satisfies(T value)
                => value > Operand;
        }

        public class GreaterThanOrEqual<T> : UnaryRule<T>
            where T : struct
        {
            public GreaterThanOrEqual(T operand)
                : base(operand)
            {

            }

            public override bool Satisfies(T value)
                => value >= Operand;
        }

    }
    
}