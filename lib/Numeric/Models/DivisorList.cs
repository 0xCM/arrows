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

    using static zcore;

    public static class DivisorList
    {
        /// <summary>
        /// Constructs a divisor list
        /// </summary>
        /// <param name="dividend">The dividend</param>
        /// <param name="divisors">The values that divide the dividend</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static DivisorList<T> define<T>(T dividend, T[] divisors)
            where T : struct, IEquatable<T>
                => new DivisorList<T>(dividend, divisors);

        public static DivisorList<T> define<T>(T dividend, IReadOnlyList<T> divisors)
            where T : struct, IEquatable<T>
                => new DivisorList<T>(dividend, divisors);

    }

    /// <summary>
    /// Encapsulates a divisor along with its dividends
    /// </summary>
    public readonly struct DivisorList<T> : Formattable
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
        /// <value></value>
        public IReadOnlyList<T> Divisors {get;}


        public bool Prime 
            => Divisors.Count == 0;

        public string format()
        {
            return Prime ? $"{Dividend}" 
            : $"{Dividend}, " + string.Join(", ",Divisors);
        }

        public override string ToString()
            => format();
    }


}