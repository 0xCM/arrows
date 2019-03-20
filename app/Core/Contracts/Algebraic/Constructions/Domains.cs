//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {
        public static class AlgeraicDomain
        {


            /// <summary>
            /// Characterizes an integral domain, which is a nonzero commutative ring
            /// such that for every pair of nonzero elements a and b, the product
            /// ab is nonzero, i.e., ab = 0 iff a = 0 or b = 0
            /// </summary>
            /// <typeparam name="T">The individual type</typeparam>
            /// <remarks>See https://en.wikipedia.org/wiki/Integral_domain</remarks>
            public interface Integral<T> : CommutativeRing<T>
            {
                
            }

            public interface Integral<H,T> : TypeClass<H>, Integral<T>
                where H : Integral<H,T>, new()
            {
                
            }

            /// <summary>
            /// Characterizes a GCD domain
            /// </summary>
            /// <typeparam name="T">The individual type</typeparam>
            /// <remarks>See https://en.wikipedia.org/wiki/GCD_domain</remarks>
            public interface Gcd<T> : Integral<T>
                where T : Gcd<T>, new()
            {


            }

            /// <summary>
            /// Characterizes a **unique** factorization domain
            /// </summary>
            /// <typeparam name="T">The individual type</typeparam>
            public interface UniqueFactor<T> : Gcd<T>
                where T : UniqueFactor<T>, new()
            {

                
            }

            /// <summary>
            /// Characterizes a principal ideal domain
            /// </summary>
            /// <typeparam name="T">The individual type</typeparam>
            public interface PrincipalIdeal<T> : UniqueFactor<T>
                where T : PrincipalIdeal<T>, new()
            {

                
            }

            /// <summary>
            /// Characterizes a Euclidean domain
            /// </summary>
            /// <typeparam name="T">The individual type</typeparam>
            public interface Euclidean<T> : PrincipalIdeal<T>
                where T : Euclidean<T>, new()
            {


            }
        }
    }
}