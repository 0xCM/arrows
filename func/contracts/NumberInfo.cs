//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public interface INumInfoProvider<T>
    {
        NumberInfo<T> numinfo {get;}
    }

}