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

    /// <summary>
    /// Reifies a structural slice
    /// </summary>
    public readonly struct Slice<N,T> : Traits.Slice<Slice<N,T>,N,T>
        where N : TypeNat, new()
    {                    
        public IReadOnlyList<T> cells {get;}

        public static implicit operator Slice<N,T>(T[] src)
            => new Slice<N,T>(src);

        public Slice(params T[] src)
        {
            this.length = natcheck<N>(src.length());
            this.cells = src;
        }

        public Slice(IReadOnlyList<T> src)
        {
            this.cells = src;
            this.length = natcheck<N>(this.cells.length());
        }

        public Slice(IEnumerable<T> src)
        {
            this.cells = src.ToArray();
            this.length = natcheck<N>(this.cells.length());
        }

        public uint length {get;}

        public T this[int i] => cells[i];

        public override string ToString() 
            => embrace(string.Join(',' ,cells));
    }        

}