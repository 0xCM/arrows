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
    using System.Text;

    using static zcore;


    partial class xcore
    {
        /// <summary>
        /// Converts a generic integer to a stream of generic digts in base 10
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        public static IEnumerable<Digit<N10,DeciDigit>> ToDecimalDigitsG<T>(this num<T> src)
            where T : struct, IEquatable<T>    
        {
            var it = DeciDigits.Parse(src.ToString()).GetEnumerator();
            while(it.MoveNext())
                yield return NatDigits.Define(it.Current, Nats.N10);
        }

    }
}