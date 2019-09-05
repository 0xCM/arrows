//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// A basic statistical accumulator that accrues information over an 
    /// arbitrary number of input sequences
    /// </summary>
    public class Accumulator
    {
        public static Accumulator Create(params double[] initial)
        {
            var a = new Accumulator();
            a.Accumulate(initial);
            return a;
        }

        public static Accumulator Create(bool sum, params double[] initial)
        {
            var a = new Accumulator(sum);
            a.Accumulate(initial);
            return a;
        }

        public static Accumulator operator +(Accumulator a, double value)
        {
            a.Accumulate(value);
            return a;
        }

        public static Accumulator operator +(Accumulator a, Span<double> value)
        {
            a.Accumulate(value);
            return a;
        }

        public static Accumulator operator +(Accumulator a, double[] value)
        {
            a.Accumulate(value);
            return a;
        }

        public static Accumulator operator +(Accumulator a, ReadOnlySpan<double> value)
        {
            a.Accumulate(value);
            return a;
        }

        public Accumulator(bool sum = false)
        {
            AccumulateSum = sum;
        }

        public void Accumulate(ReadOnlySpan<double> values,bool sum = false)
        {
            for(var i=0; i< values.Length; i++)
                Accumulate(i);
        }

        public readonly bool AccumulateSum;

        public void Accumulate(Span<double> values)
            => Accumulate(values.ReadOnly());

        public void Accumulate(params double[] values)
            => Accumulate(values.ToSpan());

        [MethodImpl(Inline)]
        public void Accumulate(IEnumerable<double> values)
            => values.Iterate(Accumulate);


        [MethodImpl(Inline)]
        void AccumulateHead(double value)
        {
            m1 = value;
            m0 = value;
            s0 = 0;
        }

        [MethodImpl(Inline)]
        void AccumulateTail(double value)
        {
            var delta = value - m0;
            m1 = m0 + delta/count;
            s1 = s0 + delta*(value - m1);
            
            m0 = m1;
            s0 = s1;                
        }

        [MethodImpl(Inline)]
        public void Accumulate(double value)
        {
            count++;
            if(count == 1)
                AccumulateHead(value);
            else
                AccumulateTail(value);
            
            if(AccumulateSum)
                checked{sum += value;}                
        }

        [MethodImpl(Inline)]
        public void Accumulate(int value)
            => Accumulate((double)value);

        [MethodImpl(Inline)]
        public void Accumulate(long value)
            => Accumulate((double)value);

        int count = 0;
        
        double m0 = 0;

        double m1 = 0;

        double s0 = 0;

        double s1 = 0;

        double sum = 0;

        public int Count 
            => count;

        public double Mean
            => m1;
        
        public double Sum
            => sum;
            
        public double Variance        
            => count > 1 ? s0/(count - 1) : 0;

        public double StandardDeviation
            => fmath.sqrt(Variance);

        public string Format(int? scale = null)
        {
            return $"mean={Mean.Round(scale ?? 4)}, stdev={StandardDeviation.Round(scale ?? 4)}";
        }

    }
}