//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Linq;

    using static zcore;


    public readonly struct Factorization<T>
    {
        public Factorization(params T[] factors)
            => this.factors = factors;

        public Slice<T> factors {get;}
    }
    
    public class Primes
    {
        static IEnumerable<ulong> defined()
            => from f in type<Primes>().GetFields()
                where f.FieldType == typeof(ulong)
                select (ulong)f.GetRawConstantValue();
        static readonly HashSet<ulong> Cached = new HashSet<ulong>(defined());
        
        static readonly ConcurrentDictionary<ulong,Factorization<ulong>> factored = new ConcurrentDictionary<ulong, Factorization<ulong>>();
        
        /// <summary>
        /// Returns true if the supplied value is prime, false otherwise
        /// </summary>
        /// <param name="n">The value to test</param>
        /// <returns></returns>
        public static bool prime(ulong n)
            => Cached.Contains(n) ? true : throw new Exception();

        // static bool test(ulong n)
        // {
            
        // }

        public const ulong P2 = 2; 
        public const ulong P3 = 3; 
        public const ulong P7 = 7;
        public const ulong P11 = 11;
        public const ulong P17 = 17;
        public const ulong P19 = 19;
        public const ulong P23 = 23;
        public const ulong P29 = 29;
        public const ulong P31 = 31;
        public const ulong P37 = 37;
        public const ulong P41 = 41;
        public const ulong P43 = 43;
        public const ulong P47 = 47;
        public const ulong P53 = 53;
        public const ulong P59 = 59;
        public const ulong P61 = 61;
        public const ulong P67 = 67;
        public const ulong P71 = 71;
        public const ulong P73 = 73;
        public const ulong P79 = 79;
        public const ulong P83 = 83;

        /*
            89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199        
         */


    }

}