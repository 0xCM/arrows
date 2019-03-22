//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class NatConstraints
    {

        public interface LT<K1,K2> : NatConstraint<K1,K2>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }

        public interface LTEQ<K1,K2> : Or<K1,K2,LT<K1,K2>,EQ<K1,K2>>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }

        public interface GT<K1,K2> : NatConstraint<K1,K2>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }
        public interface GTEQ<K1,K2> : Or<K1,K2,GT<K1,K2>,EQ<K1,K2>>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }

    }

}