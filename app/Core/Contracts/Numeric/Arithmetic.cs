//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;


    public interface Arithmetic<T> : 
        Additive<T>,
        Nullary<T>, 
        Subtractive<T>,
        Multiplicative<T>,
        Unital<T>,
        Powered<T,int>,
        Ordered<T>,
        Fused<T>
    {                    

    }

    public interface Fused<T>
    {
        T muladd(T x, T y, T z);

    }

}