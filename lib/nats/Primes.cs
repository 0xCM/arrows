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

    using static nfunc;
    using static zfunc;


    
    public class Primes
    {
        static IEnumerable<ulong> defined()
            => from f in type<Primes>().GetFields()
                where f.FieldType == typeof(ulong)
                select (ulong)f.GetRawConstantValue();
        
        static IEnumerable<ulong> primenats()
            => from f in type<Primes>().GetFields()
                where f.FieldType.Realizes<ITypeNat>()
                select ((ITypeNat)f.GetValue(null)).value;
        
        static readonly HashSet<ulong> Cached = new HashSet<ulong>(defined());
                
        /// <summary>
        /// Returns true if the supplied value is prime, false otherwise
        /// </summary>
        /// <param name="n">The value to test</param>
        /// <returns></returns>
        public static bool prime(ulong n)
            => Cached.Contains(n) ? true : throw new Exception();

        public static readonly N2 P2 = default; 
        public static readonly N3 P3 = default; 
        public static readonly N7 P7 = default;
        public static readonly NatSeq<N1,N1> P11 = default;
        public static readonly NatSeq<N1,N7> P17 = default;
        public static readonly NatSeq<N1,N9> P19 = default;
        public static readonly NatSeq<N2,N3> P23 = default;
        public static readonly NatSeq<N2,N9> P29 = default;
        public static readonly NatSeq<N3,N1> P31 = default;
        public static readonly NatSeq<N3,N7> P37 = default;
        public static readonly NatSeq<N4,N1> P41 = default;
        public static readonly NatSeq<N4,N3> P43 = default;
        public static readonly NatSeq<N4,N7> P47 = default;
        public static readonly NatSeq<N5,N3> P53 = default;
        public static readonly NatSeq<N5,N9> P59 = default;
        public static readonly NatSeq<N6,N1> P61 = default;
        public static readonly NatSeq<N6,N7> P67 = default;
        public static readonly NatSeq<N7,N1> P71 = default;
        public static readonly NatSeq<N7,N3> P73 = default;
        public static readonly NatSeq<N7,N9> P79 = default;
        public static readonly NatSeq<N8,N3> P83 = default;
        public static readonly NatSeq<N8,N9> P89 = default;

        /*
            97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199        
         */


    }

}