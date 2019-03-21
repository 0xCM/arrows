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
    using static Reify;

    public static class Vector
    {
        [MethodImpl(Inline)]
        public static Vector<N,T> add<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
                where N : TypeNat => Slice.add(lhs.cells,rhs.cells);

        [MethodImpl(Inline)]
        public static Vector<N,T> mul<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
                where N : TypeNat => Slice.mul(lhs.cells,rhs.cells);

        [MethodImpl(Inline)]
        public static T sum<N,T>(Vector<N,T> x) 
                where N : TypeNat => Slice.sum(x.cells);

    }

    partial class Traits
    {

        public interface Vector<N,T> : Tranposable<Reify.Vector<N,T>, Reify.Covector<N,T>>
            where N : TypeNat
        {
            
        }

        public interface Covector<N,T> : Tranposable<Reify.Covector<N,T>, Reify.Vector<N,T>>
            where N : TypeNat
        {
            
        }


    }

    partial class Reify
    {

        public readonly struct Vector<N, T> : Traits.Vector<N, T>
            where N : TypeNat        
        {

            /// <summary>
            /// Vector => Slice
            /// </summary>
            /// <param name="src">The source vector</param>
            /// <typeparam name="N">The natural length</typeparam>
            /// <typeparam name="T">THe component type</typeparam>
            [MethodImpl(Inline)]   
            public static implicit operator Slice<N,T>(Vector<N,T> src)
                => src.cells;

            /// <summary>
            /// Slice => Vector
            /// </summary>
            /// <param name="src">The source vector</param>
            /// <typeparam name="N">The natural length</typeparam>
            /// <typeparam name="T">THe component type</typeparam>
            [MethodImpl(Inline)]   
            public static implicit operator Vector<N,T>(Slice<N,T> src)
                => new Vector<N,T>(src.cells);

            /// <summary>
            /// The underlying data
            /// </summary>
            public Slice<N,T> cells {get;}

            [MethodImpl(Inline)]   
            public Vector(params T[] src)
                => cells = natcheck<N,T>(src);

            [MethodImpl(Inline)]   
            public Vector(IEnumerable<T> src)
                => cells = natcheck<N,T>(src.ToArray());

            [MethodImpl(Inline)]   
            public Vector(IReadOnlyList<T> src)
                => cells = new Slice<N,T>(natcheck<N,T>(src));

            [MethodImpl(Inline)]   
            public Vector(Slice<N,T> src)
                => cells = src;

            public T this[int index] 
                => cells[index];

            public uint length 
                => cells.length;

            public Covector<N, T> tranpose(Vector<N, T> src)
                => new Covector<N,T>(src.cells);

            public override string ToString()
                => cells.ToString();
        }

        public readonly struct Covector<N, T> : Traits.Covector<N, T>
            where N : TypeNat        
        {
            /// <summary>
            /// Vector => Slice
            /// </summary>
            /// <param name="src">The source vector</param>
            /// <typeparam name="N">The natural length</typeparam>
            /// <typeparam name="T">THe component type</typeparam>
            [MethodImpl(Inline)]   
            public static implicit operator Slice<N,T>(Covector<N,T> src)
                => src.cells;

            /// <summary>
            /// Slice => Vector
            /// </summary>
            /// <param name="src">The source vector</param>
            /// <typeparam name="N">The natural length</typeparam>
            /// <typeparam name="T">THe component type</typeparam>
            [MethodImpl(Inline)]   
            public static implicit operator Covector<N,T>(Slice<N,T> src)
                => new Covector<N,T>(src.cells);

            /// <summary>
            /// The underlying data
            /// </summary>
            public Slice<N,T> cells {get;}

            [MethodImpl(Inline)]   
            public Covector(params T[] src)
                => cells = natcheck<N,T>(src);

            [MethodImpl(Inline)]   
            public Covector(Slice<N,T> src)
                => cells = src;

            [MethodImpl(Inline)]   
            public Covector(IEnumerable<T> src)
                => cells = natcheck<N,T>(src.ToArray());

            [MethodImpl(Inline)]   
            public Covector(IReadOnlyList<T> src)
                => cells = new Slice<N,T>(natcheck<N,T>(src));

            public T this[int index] 
                => cells[index];

            public uint length 
                => cells.length;

            public Vector<N,T> tranpose(Covector<N, T> src)
                => new Vector<N,T>(src.cells);

            public override string ToString()
                => cells.ToString();
        }

    }

 
}