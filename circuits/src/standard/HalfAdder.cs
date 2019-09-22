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

    public readonly struct HalfAdder
    {
        static readonly AndGate andg = Gates.andg();
        
        static readonly XOrGate xorg = Gates.xorg();

        [MethodImpl(Inline)]
        public (Bit s, Bit c) Send(Bit a, Bit b)        
            => (xorg.Send(a, b), andg.Send(a, b));

    }

    public readonly struct HalfAdder<T> : ICircuit<T, T, (T s, T c)>,        
        ICircuit<Vec128<T>, Vec128<T>, (Vec128<T> s, Vec128<T> c)>,
        ICircuit<Vec256<T>, Vec256<T>, (Vec256<T> s, Vec256<T> c)>
        where T : unmanaged
    {
        public static readonly HalfAdder<T> Circuit = default;
        
        static readonly XOrGate<T> xorg = Gates.xorg<T>();

        static readonly AndGate<T> andg = Gates.andg<T>();


        [MethodImpl(Inline)]
        public (T s, T c) Send(in T a, in T b)
            => (xorg.Send(in a,in b), andg.Send(in a,in b));

        [MethodImpl(Inline)]
        public (Vec128<T> s, Vec128<T> c) Send(in Vec128<T> a, in Vec128<T> b)
            => (xorg.Send(a,b), andg.Send(a,b));

        [MethodImpl(Inline)]
        public (Vec256<T> s, Vec256<T> c) Send(in Vec256<T> a, in Vec256<T> b)
            => (xorg.Send(in a,in b), andg.Send(in a,in b));
        
    }

}