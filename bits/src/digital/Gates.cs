//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public static class Gates
    {
        [MethodImpl(Inline)]
        public static ref readonly AndGate andg()
            => ref AndGate.Gate;

        [MethodImpl(Inline)]
        public static ref readonly XOrGate xorg()
            => ref XOrGate.Gate;
            
        [MethodImpl(Inline)]
        public static ref readonly AndGate<T> andg<T>()
            where T : unmanaged
                => ref AndGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly OrGate<T> org<T>()
            where T : unmanaged
                => ref OrGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly XOrGate<T> xorg<T>()
            where T : unmanaged
                => ref XOrGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly NotGate<T> notg<T>()
            where T : unmanaged
                => ref NotGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly NAndGate<T> nandg<T>()
            where T : unmanaged
                => ref NAndGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly NOrGate<T> norg<T>()
            where T : unmanaged
                => ref NOrGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly XNOrGate<T> xnorg<T>()
            where T : unmanaged
                => ref XNOrGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly MuxGate<T> muxg<T>()
            where T : unmanaged
                => ref MuxGate<T>.Gate;

    }

}