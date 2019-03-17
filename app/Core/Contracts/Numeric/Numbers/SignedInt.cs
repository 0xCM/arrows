//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public interface SignedInt<T> : Signed<T>, Integer<T>
        where T:new()
    {
    }


    public interface SignedInt<S,T> : Integer<S,T>, Signed<S,T>
        where S : SignedInt<S,T>, new()
        where T : new()
    {
    }



}