//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public interface BoundUnsignedInt<T> : UnsignedInt<T>, BoundInt<T>
        where T : new()
    {

        
    }

    public interface BoundUnsignedInt<S,T> : UnsignedInt<S,T>, Bounded<S,T>
        where S : BoundUnsignedInt<S,T>, new()
        where T : new()
    {
    

    }





}