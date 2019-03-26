//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zcore;

    partial class Traits
    {

        public interface ModN<N,T> : Ring<T>
            where N : TypeNat
        {

            IEnumerable<T> members {get;}

            /// <summary>
            /// Reduces an integer mod N
            /// </summary>
            /// <param name="src">The source value</param>
            /// <returns></returns>
            T reduce(T src);
        }

        public interface GF<N,T> : ModN<N,T>
            where N : TypeNat, Demands.PrimePower<N>, new()
            
        {

        }

        public interface ModN<N,S,T> : Ring<S,T>
            where S : ModN<N,S,T>, new()
            where N : TypeNat
        {

            IEnumerable<T> members {get;}
        }

    }


}
