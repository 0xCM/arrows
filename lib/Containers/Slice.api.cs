namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static nats;
    using static zfunc;


    /// <summary>
    /// Defines slice construction/manipulation routines
    /// </summary>
    public static class Slice
    {        
        /// <summary>
        /// Constructs a slice of natural length from a parameter array
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The individual type</typeparam>
        /// <typeparam name="N">The natural length type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> define<N,T>(params T[] src)
            where N : ITypeNat, new() 
            where T : struct, IEquatable<T>
                => new Slice<N,T>(src);


        /// <summary>
        /// Constructs a slice of natural length from a stream
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The individual type</typeparam>
        /// <typeparam name="N">The natural length type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,T> define<N,T>(IEnumerable<T> src)
            where N : ITypeNat, new() 
            where T : struct, IEquatable<T>
                => new Slice<N,T>(src);


 
        [MethodImpl(Inline)]
        public static T reduce<N,T>(Slice<N,T> s, Func<T,T,T> reducer)
                where N : Z0.ITypeNat, new()
                where T : struct, Structures.Semiring<T>
                    => fold(s,reducer);


        [MethodImpl(Inline)]
        public static T sum<N,T>(Slice<N,T> x)
            where N : Z0.ITypeNat, new() 
            where T : struct, Structures.Semiring<T>
                => reduce(x, (a,b) => a.add(b));


    } 
}