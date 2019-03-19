//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    
    public interface Divisive<T> : Operational<T>
    {
        T mod(T lhs, T rhs);

        T div(T lhs, T rhs);        
    }

    public interface Divisive<S,T> : Structural<S,T>
        where S : Divisive<S,T>, new()
        where T : new()
    {

        S mod(S rhs);

        S div(S rhs);        
    }


    public interface EuclideanDiv<T> : Divisive<T>
    {

        T gcd(T lhs, T rhs);

        QR<T> divrem(T lhs, T rhs);        
    }

    public interface EuclideanDiv<S,T> : Divisive<S,T>
        where S : EuclideanDiv<S,T>, new()
        where T : new()
    {
        S gcd(S rhs);

        QR<S> divrem(S rhs);        
    }
}