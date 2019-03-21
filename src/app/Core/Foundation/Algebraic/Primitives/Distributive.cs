//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {
        public interface LeftDistributive<T>  : Multiplicative<T>, Additive<T>
        {
            /// <summary>
            /// Characterizes a type that defines an operator that left-distributes
            /// multiplication over addition
            /// </summary>
            /// <typeparam name="X">The operand type</typeparam>
            T distribute(T lhs, (T x, T y) rhs);
        }

        public interface LeftDistributive<H,T>  : LeftDistributive<T>, TypeClass<H>
            where H : LeftDistributive<H,T>, new()
        {

        }

        /// <summary>
        /// Characterizes a type that defines an operator that right-distributes
        /// multiplication over addition
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface RightDistributive<T> : Multiplicative<T>, Additive<T>
        {
            T distribute((T x, T y) lhs, T rhs);
        }

        public interface RightDistributive<H,T>  : RightDistributive<T>, TypeClass<H>
            where H : RightDistributive<H,T>, new()
        {

        }

        /// <summary>
        /// Characterizes a type that defines both left and right distribution
        /// over addition
        /// </summary>
        public interface Distributive<T> : LeftDistributive<T>, RightDistributive<T>
        {

        }

        /// <summary>
        /// Characterizes a type that defines both left and right distribution
        /// over addition
        /// </summary>
        public interface Distributive<H,T> : LeftDistributive<H,T>, RightDistributive<H,T>
            where H : Distributive<H,T>, new()
        {

        }
    }

    partial class Struct
    {

         public interface LeftDistributive<S,T>  : Multiplicative<S,T>, Additive<S,T>
            where S : LeftDistributive<S,T>, new()
        {
            /// <summary>
            /// Characterizes a type that defines an operator that left-distributes
            /// multiplication over addition
            /// </summary>
            /// <typeparam name="X">The operand type</typeparam>
            S distributeL((S x, S y) rhs);
        }

        public interface RightDistributive<S,T>  : Multiplicative<S,T>, Additive<S,T>
            where S : RightDistributive<S,T>, new()
        {
            /// <summary>
            /// Characterizes a type that defines an operator that left-distributes
            /// multiplication over addition
            /// </summary>
            /// <typeparam name="X">The operand type</typeparam>
            S distributeR((S x, S y) rhs);
        }

        public interface Distributive<S,T> : LeftDistributive<S,T>, RightDistributive<S,T>
            where S : Distributive<S,T>,new()
        {

        }
       
    }
}