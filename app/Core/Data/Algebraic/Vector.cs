//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static corefunc;

    using static Class;
    partial class Reify
    {

        public readonly struct Vector<N, T> : Class.Vector<N, T>
            where N : TypeNat        
            where T : Semiring<T>, new()
        {

            public IReadOnlyList<T> cells {get;}

            [MethodImpl(Inline)]   
            public Vector(params T[] src)
                => cells = natcheck<N,T>(src);

            [MethodImpl(Inline)]   
            public Vector(IEnumerable<T> src)
                => cells = natcheck<N,T>(src.ToList());

            [MethodImpl(Inline)]   
            public Vector(IReadOnlyList<T> src)
                => cells = natcheck<N,T>(src);

            public T this[int index] 
                => cells[index];

            public int length 
                => cells.Count;


            public Class.Covector<N, T> tranpose(Class.Vector<N, T> src)
                => new Covector<N,T>(src.cells);
        }

        public readonly struct Covector<N, T> : Class.Covector<N, T>
            where T : Class.Semiring<T>, new()
            where N : TypeNat        
        {
            public IReadOnlyList<T> cells {get;}

            [MethodImpl(Inline)]   
            public Covector(params T[] src)
                => cells = natcheck<N,T>(src);

            [MethodImpl(Inline)]   
            public Covector(IEnumerable<T> src)
                => cells = natcheck<N,T>(src.ToList());

            [MethodImpl(Inline)]   
            public Covector(IReadOnlyList<T> src)
                => cells = natcheck<N,T>(src);

            public T this[int index] 
                => cells[index];

            public int length 
                => cells.Count;
        
            Class.Vector<N, T> Tranposable<Class.Covector<N, T>, Class.Vector<N, T>>.tranpose(Class.Covector<N, T> src)
                => tranpose(src);
            
            public Vector<N, T> tranpose(Class.Covector<N, T> src)
                => new Vector<N,T>(src.cells);
        }

    }
}