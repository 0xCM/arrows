//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class Fsm
    {
        public static Fsm<I,S> Define<I,S>(S s0, S sZ, TransFunc<I,S> f)
            =>  new Fsm<I, S>(s0, sZ, f);

        public static Fsm<E,S,A> Define<E,S,A>(S s0, S sZ, TransFunc<E,S> t, EntryFunc<S,A> entry)
            =>  new Fsm<E,S,A>(s0, sZ, t, entry);

    }
}