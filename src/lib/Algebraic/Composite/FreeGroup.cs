//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class Structure
    {
        public interface FreeGroup<S> : Group<S>, FreeMonoid<S>
        {
            
        }
        public interface FreeGroup<S,T> : Group<S,T>, FreeMonoid<S,T>
            where S : FreeGroup<S,T>, new()
        {
            
        }

        public interface FreeAbelianGroup<S,T> : FreeGroup<S,T>, GroupA<S,T>,  FreeMonoid<S,T>
            where S : FreeAbelianGroup<S,T>, new()
        {
            
        }

    }

}