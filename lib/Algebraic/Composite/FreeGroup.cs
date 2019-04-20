//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class Structures
    {
        public interface FreeGroup<S> : GroupA<S>, FreeMonoid<S>
            where S : FreeGroup<S>, new()
        {
            
        }
        
        public interface FreeGroup<S,T> : FreeGroup<S>
            where S : FreeGroup<S,T>, new()
        {
            
        }


    }

}