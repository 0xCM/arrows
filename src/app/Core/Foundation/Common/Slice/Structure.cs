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
    /// Encapsulates a linear data segment with length determined at runtime
    /// </summary>
    public readonly struct Slice<T> : Traits.Slice<T>
    {                    
        public IReadOnlyList<T> cells {get;}

        public static implicit operator Slice<T>(T[] src)
            => new Slice<T>(src);

        public Slice(params T[] src)
        {
            this.length = src.length();
            this.cells = src;
        }

        public Slice(IReadOnlyList<T> src)
        {
            this.cells = src;
            this.length = this.cells.length();
        }

        public Slice(IEnumerable<T> src)
        {
            this.cells = src.ToArray();
            this.length = this.cells.length();
        }

        public intg<uint> length {get;}

        public T this[int i] 
            => cells[i];

        public override string ToString() 
            => embrace(string.Join(',' ,cells));

        public IEnumerator<T> GetEnumerator()
            => cells.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public Slice<N,T> ToNatLenth<N>()
            where N : TypeNat, new()
                => new Slice<N,T>(cells);

    }        


    /// <summary>
    /// Encapsulates a linear data segment with naturally-typed length
    /// </summary>
    public readonly struct Slice<N,T> : Traits.Slice<Slice<N,T>,N,T>
        where N : TypeNat, new()
    {                    
        public IReadOnlyList<T> cells {get;}

        public static implicit operator Slice<N,T>(T[] src)
            => new Slice<N,T>(src);

        public Slice(params T[] src)
        {
            this.cells = src;
            this.length = natcheck<N>(cells.length());
        }

        public Slice(IReadOnlyList<T> src)
        {
            this.cells = src;
            this.length = natcheck<N>(cells.length());
        }

        public Slice(IEnumerable<T> src)
        {
            this.cells = src.ToArray();
            this.length = natcheck<N>(cells.length());
        }

        public intg<uint> length {get;}

        public T this[int i] 
            => cells[i];

        public override string ToString() 
            => embrace(string.Join(',' ,cells));

        public IEnumerator<T> GetEnumerator()
            => cells.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }        

}