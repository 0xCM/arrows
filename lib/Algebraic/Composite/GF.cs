//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Structures;
    
    using static zcore;

    public interface IModNOps<N,T> : IRingOps<T>
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

    public interface IModN<N,S> : IRing<S>
        where S : IModN<N,S>, new()
    {

    }

    public interface IGF<N, S> : IModN<N, S>
        where S : IGF<N,S>, new()
    {

    }

    public interface IModN<N,S,T> : IModN<N,S>, IRing<S,T>
        where S : IModN<N,S,T>, new()
        where N : ITypeNat, new()
    {

    }

    public interface IGF<N, S, T> : IGF<N,S>, IModN<N, S, T>
        where N : ITypeNat, IPrimePower<N>, new()
        where S : IGF<N,S,T>,new()
        
    {

    }

}

