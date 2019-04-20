//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
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

    partial class Structures
    {
        public interface LeftDistributive<S>: Multiplicative<S>, Additive<S>
            where S : LeftDistributive<S>, new()
        {
            /// <summary>
            /// Characterizes a type that defines an operator that left-distributes
            /// multiplication over addition
            /// </summary>
            /// <typeparam name="X">The operand type</typeparam>
            S distributeL((S x, S y) rhs);

        }

        public interface RightDistributive<S> : Multiplicative<S>, Additive<S>
            where S : RightDistributive<S>, new()
        {
            /// <summary>
            /// Characterizes a type that defines an operator that left-distributes
            /// multiplication over addition
            /// </summary>
            /// <typeparam name="X">The operand type</typeparam>
            S distributeR((S x, S y) rhs);

        }
        
        public interface Distributive<S> : LeftDistributive<S>, RightDistributive<S> 
            where S : Distributive<S>, new()
        {}

        public interface LeftDistributive<S,T>  : LeftDistributive<S>, Multiplicative<S,T>, Additive<S>
            where S : LeftDistributive<S,T>, new() { }

        public interface RightDistributive<S,T>  : RightDistributive<S>, Multiplicative<S,T>, Additive<S>
            where S : RightDistributive<S,T>, new() { }

        public interface Distributive<S,T> : Distributive<S>, LeftDistributive<S,T>, RightDistributive<S,T>
            where S : Distributive<S,T>,new() { }

    }
}