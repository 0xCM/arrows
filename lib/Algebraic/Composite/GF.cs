//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zcore;

    partial class Operative
    {

        public interface ModN<N,T> : Ring<T>
            where N : ITypeNat, new()
        {

            IEnumerable<T> members {get;}

            /// <summary>
            /// Reduces an integer mod N
            /// </summary>
            /// <param name="src">The source value</param>
            /// <returns></returns>
            T reduce(T src);
        }



    }

    partial class Structures
    {
        public interface ModN<N,S> : Ring<S>
            where S : ModN<N,S>, new()
        {

        }

        public interface GF<N, S> : ModN<N, S>
            where S : GF<N,S>, new()
        {

        }

        public interface ModN<N,S,T> : ModN<N,S>, Ring<S,T>
            where S : ModN<N,S,T>, new()
            where N : ITypeNat, new()
        {

        }

        public interface GF<N, S, T> : GF<N,S>, ModN<N, S, T>
            where N : ITypeNat, IPrimePower<N>, new()
            where S : GF<N,S,T>,new()
            
        {

        }

    }

}

