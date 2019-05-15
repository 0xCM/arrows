//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static nfunc;


    public static class Covector
    {
        /// <summary>
        /// Evaluates the covector on the covector
        /// </summary>
        /// <param name="cv">The covector to evaluate</param>
        /// <param name="v">The vector at which evaluation occurs</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">The type of the underlying semiring</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static T apply<N,T>(Covector<N,T> cv, Vector<N,T> v)
            where T : struct, ISemiringOps<T>
            where N : ITypeNat, new()        

        {
            var sr = new T();
            var result = sr.zero;
            for(var i = 0u; i<cv.Length; i++)
                result = sr.add(result, sr.mul(cv.cell(i), v.cell(i)));
            return result;
        }

        /// <summary>
        /// Constructs a covector from a parameter array
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="N">The covector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Covector<N,T> define<N,T>(Dim<N> dim, params T[] src) 
            where N : ITypeNat, new() 
            where T : struct    
                => new Covector<N,T>(src);

        /// <summary>
        /// Constructs a covector from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="N">The covector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Covector<N,T> define<N,T>(IEnumerable<T> src) 
            where T : struct    
            where N : ITypeNat, new() 
                => new Covector<N,T>(src);
        
        /// <summary>
        /// Constructs a covector from a parameter array
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="N">The covector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Covector<N,T> define<N,T>(params T[] src) 
            where T : struct    
            where N : ITypeNat, new() 
                => new Covector<N,T>(src);

        /// <summary>
        /// Sums the covector components
        /// </summary>
        /// <param name="src">The source covector</param>
        /// <typeparam name="N">The covector length type</typeparam>
        /// <typeparam name="T">The convector component type</typeparam>
        [MethodImpl(Inline)]
        public static T sum<N,T>(Covector<N,T> src) 
            where N : ITypeNat, new() 
            where T : struct, ISemiring<T>
                => sum<N,T>(src.cells);
    }
}