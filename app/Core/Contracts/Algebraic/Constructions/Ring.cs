//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    public enum Ordering
    {
        LT = -1,
        EQ = 0,
        GT = 1
    }

    partial class Class
    {

        /// <summary>
        /// Characterizes a (unital) ring
        /// </summary>
        public interface Ring<T> : Unital<T>, Multiplicative<T>, Distributive<T>
        {
            
        }

        public interface Ring<H,T> : TypeClass<H>, Ring<T>
            where H : Ring<H,T>, new()
        {
            
        }

        /// <summary>
        /// Characterizes a commutative, unital ring
        /// </summary>
        public interface CommutativeRing<T> : Ring<T>
        {
            
        }

        public interface CommutativeRing<H,T> : TypeClass<H>,  CommutativeRing<T>
            where H : CommutativeRing<H,T>, new()
        {


        }


        public interface DivisionRing<T> : Ring<T>, EuclideanDiv<T>
        {


        }

        public interface DivisionRing<H,T> : TypeClass<H>, DivisionRing<T>
            where H : DivisionRing<H,T>, new()
        {


        }

    }
}
