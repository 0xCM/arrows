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

    public static class DivisorList
    {
        /// <summary>
        /// Constructs a divisor list
        /// </summary>
        /// <param name="dividend">The dividend</param>
        /// <param name="divisors">The values that divide the dividend</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static DivisorList<T> Define<T>(T dividend, T[] divisors)
            where T : struct, IEquatable<T>
                => new DivisorList<T>(dividend, divisors);

        public static DivisorList<T> Define<T>(T dividend, IReadOnlyList<T> divisors)
            where T : struct, IEquatable<T>
                => new DivisorList<T>(dividend, divisors);

    }

    /// <summary>
    /// Encapsulates a divisor along with its dividends
    /// </summary>
    public readonly struct DivisorList<T> 
        where T : struct, IEquatable<T>
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