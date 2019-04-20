//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static zcore;

    partial class Demands
    {
        public interface Demand 
        {

        }


        /// <summary>
        /// Characterizes a constraint on a nat
        /// </summary>
        /// <typeparam name="K1">The Nat type</typeparam>
        public interface Demand<K1> : Demand
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
        public interface Demand<K1,K2> : Demand
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
        public interface Demand<K1,K2,K3> : Demand
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
        {
            
        }

    }
 

    public class DemandException : Exception
    {
        public string Expect {get;}
        
        public string Actual{get;}

        public string Constraint {get;}

        public DemandException(string constraint, object expect, object actual)
        {
            this.Constraint = constraint;
            this.Expect = expect.ToString();
            this.Actual = actual.ToString();            
        }

        public DemandException(string constraint, (uint x, uint y) relation )
        {
            this.Constraint = constraint;
            this.Expect = $"({relation.x}, {relation.y})";            
            this.Actual = string.Empty;
        }

        public DemandException(string constraint, (ulong x, ulong y) relation )
        {
            this.Constraint = constraint;
            this.Expect = $"({relation.x}, {relation.y})";            
            this.Actual = string.Empty;
        }

        public override string Message 
            => Actual != string.Empty 
             ? $"Natural number {Constraint} failed. Expected: {Expect} | Actual: {Actual}"
             : $"Natural invariant {Constraint} failed: {Expect}";

    }

}