//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public interface BoundSignedInt<T> : SignedInt<T>, Bounded<T>
        where T:new()
    {

    }

    public interface BoundSignedInt<S,T> : SignedInt<S,T>, Bounded<S,T>
        where S : BoundSignedInt<S,T>, new()
        where T:new()
    {

    }


}