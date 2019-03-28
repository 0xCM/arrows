//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

   partial class Demands
    {
        public interface Constraint
        {

        }


        /// <summary>
        /// Characterizes a constraint on a nat
        /// </summary>
        /// <typeparam name="K1">The Nat type</typeparam>
        public interface Demand<K1> : Constraint
            where K1 : TypeNat, new()
        {
            /// <summary>
            /// Specifies whether reification satisfies demand
            /// </summary>
            /// <remarks>
            /// Any attempt to instantiate an invalid reification should fail
            /// and thus this attribute should always be true
            /// </remarks>
            bool valid {get;}
        }
        
        /// <summary>
        /// Characterizes binary relationship between two nats
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface Demand<K1,K2> : Constraint
            where K1 : TypeNat, new()
            where K2 : TypeNat
        {
            
        }

        /// <summary>
        /// Characterizes ternary relationship among three nats
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        /// <typeparam name="K3">The third nat type</typeparam>
        public interface Demand<K1,K2,K3> : Constraint
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
        {
            
        }

    }
 


}