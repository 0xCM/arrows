//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {
        /// <summary>
        /// Characterizes an integral domain, which is a nonzero commutative ring
        /// such that for every pair of nonzero elements a and b, the product
        /// ab is nonzero, i.e., ab = 0 iff a = 0 or b = 0
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Integral_domain</remarks>
        public interface IntegralDomain<T> : CommutativeRing<T>
        {
            
        }


        /// <summary>
        /// Characterizes a GCD domain
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/GCD_domain</remarks>
        public interface GcdDomain<T> : IntegralDomain<T>
            where T : GcdDomain<T>, new()
        {


        }

        public interface Modular<T>
        {
            T mod(T lhs, T rhs);

        }

        public interface Divisive<T> : Modular<T>
        {
            T div(T lhs, T rhs);        

            T gcd(T lhs, T rhs);

            Quorem<T> divrem(T lhs, T rhs);
        }

        /// <summary>
        /// Characterizes a **unique** factorization domain
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface UniqueFactorDomain<T> : GcdDomain<T>
            where T : UniqueFactorDomain<T>, new()
        {

            
        }

        /// <summary>
        /// Characterizes a principal ideal domain
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface PrincipalIdealDomain<T> : UniqueFactorDomain<T>
            where T : PrincipalIdealDomain<T>, new()
        {

            
        }

        /// <summary>
        /// Characterizes a Euclidean domain
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface EuclideanDomain<T> : PrincipalIdealDomain<T>
            where T : EuclideanDomain<T>, new()
        {


        }

        public static class AlgeraicDomain
        {

        }
    }

    partial class Structures
    {
        public interface Modular<S> 
            where S : Modular<S>
        {
            S mod(S rhs);

        }
        public interface Divisive<S> : Modular<S>
            where S : Divisive<S>, new()
        {
            S div(S rhs);        

            S gcd(S rhs);


        }

        public interface Divisive<S,T> : Divisive<S>
            where S : Divisive<S,T>, new()
        {

        }        
    }
}