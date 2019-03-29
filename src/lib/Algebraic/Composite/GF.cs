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
            where N : TypeNat, new()
        {

            IEnumerable<T> members {get;}

            /// <summary>
            /// Reduces an integer mod N
            /// </summary>
            /// <param name="src">The source value</param>
            /// <returns></returns>
            T reduce(T src);
        }


        public interface ModN<N,S,T> : ModN<N,S>, Structural<S,T>
            where S : ModN<N,S,T>, new()
            where N : TypeNat, new()
        {

        }

        public interface GF<N, S, T> : ModN<N, S, T>, Structural<S,T>
            where N : TypeNat, Demands.PrimePower<N>, new()
            where S : GF<N,S,T>,new()
            
        {

        }

    }


}

