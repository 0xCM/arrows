//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;


    partial class Traits
    {
        public interface NatOp<S,T1,T2> : TypeNat<S>
            where S : NatOp<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {
            
        }

        public interface NatOp<S,T1,T2,T3> : TypeNat<S>
            where S : NatOp<S,T1,T2,T3>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
        {
        }

        public interface NatOp<S,T1,T2,T3,T4> : TypeNat<S>
            where S : NatOp<S,T1,T2,T3,T4>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
        {
        }


    }

}