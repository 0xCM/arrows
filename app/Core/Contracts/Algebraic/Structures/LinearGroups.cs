//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    public interface GL<N,K> : Group<Matrix<N,N,K>>
        where N : TypeNat
    {
        
    }

}