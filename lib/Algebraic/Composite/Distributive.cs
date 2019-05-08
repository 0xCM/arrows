//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {
        public interface ILeftDistributiveOps<T>  : IMultiplicativeOps<T>, IAdditiveOps<T>
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
        public interface IRightDistributiveOps<T> : IMultiplicativeOps<T>, IAdditiveOps<T>
        {
            T distribute((T x, T y) lhs, T rhs);
        }



        /// <summary>
        /// Characterizes a type that defines both left and right distribution
        /// over addition
        /// </summary>
        public interface IDistributiveOps<T> : ILeftDistributiveOps<T>, IRightDistributiveOps<T>
        {

        }

    }

    partial class Structures
    {
        public interface LeftDistributive<S>: IMultiplicative<S>, IAdditive<S>
            where S : LeftDistributive<S>, new()
        {
            /// <summary>
            /// Characterizes a type that defines an operator that left-distributes
            /// multiplication over addition
            /// </summary>
            /// <typeparam name="X">The operand type</typeparam>
            S distributeL((S x, S y) rhs);

        }

        public interface RightDistributive<S> : IMultiplicative<S>, IAdditive<S>
            where S : RightDistributive<S>, new()
        {
            /// <summary>
            /// Characterizes a type that defines an operator that left-distributes
            /// multiplication over addition
            /// </summary>
            /// <typeparam name="X">The operand type</typeparam>
            S distributeR((S x, S y) rhs);

        }
        
        public interface IDistributive<S> : LeftDistributive<S>, RightDistributive<S> 
            where S : IDistributive<S>, new()
        {}

        public interface LeftDistributive<S,T>  : LeftDistributive<S>, IMultiplicative<S,T>, IAdditive<S>
            where S : LeftDistributive<S,T>, new() { }

        public interface RightDistributive<S,T>  : RightDistributive<S>, IMultiplicative<S,T>, IAdditive<S>
            where S : RightDistributive<S,T>, new() { }

        public interface IDistributive<S,T> : IDistributive<S>, LeftDistributive<S,T>, RightDistributive<S,T>
            where S : IDistributive<S,T>,new() { }

    }
}