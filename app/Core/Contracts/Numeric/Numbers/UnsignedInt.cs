//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public interface UnsignedInt<T> : Integer<T>
        where T:new()
    {
        
    }


    public interface UnsignedInt<S,T> : Integer<S,T>, Unsigned<S,T>
        where S : UnsignedInt<S,T>, new()
        where T : new()
    {
    

    }


}