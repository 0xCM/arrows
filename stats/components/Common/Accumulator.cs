//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Threading;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class Accumulator
    {
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

        public Accumulator()
        {

        }

        public void Accumulate(Span<double> values)
        {
            for(var i=0; i< values.Length; i++)
                Accumulate(i);
        }
            
        public void Accumulate(IEnumerable<double> values)
            => values.Iterate(Accumulate);

        
        [MethodImpl(Inline)]
        public void Accumulate(double value)
        {
            count++;
            if(count == 1)
            {
                m1 = value;
                m0 = value;
                s0 = 0;
            }
            else
            {
                var delta = value - m0;
                m1 = m0 + delta/count;
                s1 = s0 + delta*(value - m1);
                
                m0 = m1;
                s0 = s1;                
            }
        }

        public int Count 
            => count;

        public double Mean
            => m1;
        
        public double Variance        
            => count > 1 ? s0/(count - 1) : 0;

        public double StandardDeviation
            => math.sqrt(Variance);

        int count = 0;
        
        double m0 = 0;

        double m1 = 0;

        double s0 = 0;

        double s1 = 0;

    }
}