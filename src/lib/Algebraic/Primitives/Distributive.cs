//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Traits
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


        /// <summary>
        /// Characterizes a type that defines an operator that right-distributes
        /// multiplication over addition
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface RightDistributive<T> : Multiplicative<T>, Additive<T>
        {
            T distribute((T x, T y) lhs, T rhs);
        }



        /// <summary>
        /// Characterizes a type that defines both left and right distribution
        /// over addition
        /// </summary>
        public interface Distributive<T> : LeftDistributive<T>, RightDistributive<T>
        {

        }

    }

    partial class Structure
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