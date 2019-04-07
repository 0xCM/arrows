//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;
    using Primal = PrimOps.Reify;

    partial class PrimOps
    {
        /// <summary>
        /// Provides the primitive numeric operations for a specified type 
        /// if they exist; otherwise, raises an error
        /// </summary>
        /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
        public static Operative.PrimOps<T> get<T>()
            => PrimOps<T>.Inhabitant;
    
        /// <summary>
        /// Provides the primitive numeric operations for a specified type 
        /// if they exist; otherwise, raises an error
        /// </summary>
        /// <param name="exemplar">An instance of the type to permit inference</param>
        /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
        public static Operative.PrimOps<T> get<T>(T specimen)
            => PrimOps<T>.Inhabitant;
    }

    partial class Operative
    {
        public interface PrimOps<T> :
            Additive<T>, 
            Additive<IEnumerable<T>>, 
            Additive<IReadOnlyList<T>>,            

            Multiplicative<T>, 
            Multiplicative<IEnumerable<T>>, 
            Multiplicative<IReadOnlyList<T>>,            

            Divisive<T>, 
            Divisive<IEnumerable<T>>, 
            Divisive<IReadOnlyList<T>>,             

            Negatable<T>, 
            Negatable<IEnumerable<T>>, 
            Negatable<IReadOnlyList<T>>,             

            Absolutive<T>, 
            Absolutive<IEnumerable<T>>, 
            Absolutive<IReadOnlyList<T>>,             

            Stepwise<T>,
            Stepwise<IEnumerable<T>>, 
            Stepwise<IReadOnlyList<T>>,            

            Bitwise<T>,            
            BitLogic<IEnumerable<T>>, 
            BitLogic<IReadOnlyList<T>>,

            Nullary<T>, 
            Unital<T>,
            Ordered<T>,
            Semigroup<T>                             
        {
            
        }
    }

}