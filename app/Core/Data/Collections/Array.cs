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

    public readonly struct Array<N,T> : C.Array<N,T>
        where N : C.TypeNat
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

}