//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;


    public interface IKinded<K>
        where K : Enum
    {
        K Kind {get;}
    }


    public interface IPrimalInfo : IKinded<PrimalKind>
    {
        
        bool Signed {get;}

        int Size {get;}
        
    }
    
    public interface IPrimalInfo<T> : IPrimalInfo
        where T : struct, IEquatable<T>
    {
        T MinVal {get;}

        T MaxVal {get;}
    }   




}