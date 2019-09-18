//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static zfunc;

    /// <summary>
    /// Encapsulates a divisor along with its dividends
    /// </summary>
    public readonly struct DivisorList<T> 
        where T : struct
    {
        public DivisorList(T Dividend, IReadOnlyList<T> Divisors)
        {
            this.Dividend = Dividend;
            this.Divisors = Divisors;
        }
        
        /// <summary>
        /// The dividend
        /// </summary>
        public T Dividend {get;}        

        /// <summary>
        /// The values that divide the dividend
        /// </summary>
        public IReadOnlyList<T> Divisors {get;}


        public bool IsPrime 
            => Divisors.Count == 0;


        public override string ToString()
        {
            return IsPrime ? $"{Dividend}" 
            : $"{Dividend}, " + string.Join(", ",Divisors);
        }
    }


}