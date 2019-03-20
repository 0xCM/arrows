//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;
    using C = Contracts;

    partial class Reify
    {
        public readonly struct Array<N,T> : Core.Array<N,T>
            where N : TypeNat
        {
            readonly T[] data;

            public T this[int ix] 
            { 
                [MethodImpl(Inline)]
                get => data[ix]; 
                
                [MethodImpl(Inline)]
                set => data[ix] = value;
            }

            [MethodImpl(Inline)]
            public Array(params T[] data)
            {
                if(data.Length == 0)
                    this.data = array<T>(natval<N>());
                else
                {
                    natcheck<N>(data.Length);
                    this.data = data;
                }
            }

            public int length 
                => data.Length;

            IEnumerator<T> IEnumerable<T>.GetEnumerator()
                =>(from item in data select item).GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => data.GetEnumerator();
        }

        /// <summary>
        /// Characterizes a structural integer that is bounded and signed
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <remarks>
        /// Applies to structures, for instance, with underlying types of {sbyte, short, int, long}
        /// </remarks>        
        public interface FiniteSignedInt<S,T> : Struct.SignedInt<S,T>, Struct.Finite<S,T>
            where S : FiniteSignedInt<S,T>, new()
            where T:new()
        {

        }
    }

}