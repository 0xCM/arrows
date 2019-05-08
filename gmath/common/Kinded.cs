//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    



    public interface IKinded<K>
        where K : Enum
    {
        K Kind {get;}
    }


}