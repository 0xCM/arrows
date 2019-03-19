//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static corefunc;

    using C = Contracts;
    using System.Collections;

    /// <summary>
    /// Defines the backing store for NArray types
    /// </summary>    
    public ref struct Slice<T>
    {
        readonly ReadOnlySpan<T> data;

        readonly IReadOnlyList<uint> dim;
        
        public Slice(IReadOnlyList<uint> dim, IEnumerable<T> data)
        {
            var arr = data.ToArray();
            if(arr.Length != fold(dim, (x,y) => x*y))
                throw new ArgumentException();
            this.dim = dim;
            this.data = new Span<T>(data.ToArray());
        }

    }

    public readonly struct Slice<N,T> : C.Slice<N,T>
        where N : C.TypeNat
    {
        readonly IReadOnlyList<T> data;
        
        public Slice(IEnumerable<T> data)
        {
            this.data = data.ToArray();
            this.length = natcheck<N>(this.data.Count);
        }

        public int length {get;}

        public T this[int i] => data[i];

        int IReadOnlyCollection<T>.Count 
            => length;

        IEnumerator IEnumerable.GetEnumerator()
            => data.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => data.GetEnumerator();
    }        

    public readonly struct NArray<K1,K2,T> 
        where K1 : C.TypeNat
        where K2 : C.TypeNat
    {
        readonly T[,] data;
        
        readonly (int k1, int k2) dim;
        
        public NArray(IEnumerable<T> src)
        {
            dim = (natval<K1>(), natval<K2>());
            data = new T[dim.k1,dim.k2];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in axis0.value.Iteri())
                data[axis0.i, axis1.i] = axis1.value;                                                    
        }

        public T this[int i, int j] => data[i,j];
    }        

    public readonly struct NArray<K1,K2,K3,T> 
        where K1 : C.TypeNat
        where K2 : C.TypeNat
        where K3 : C.TypeNat
    {
        readonly T[,,] data;
        
        readonly (int k1, int k2, int k3) dim;

        public NArray(IEnumerable<T> src)
        {
            dim = (natval<K1>(), natval<K2>(), natval<K3>());
            data = new T[dim.k1,dim.k2,dim.k3];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in src.Partition<K2,T>().Iteri())
            foreach(var axis2 in axis1.value.Iteri())
                data[axis0.i, axis1.i, axis2.i] = axis2.value;                                                    
        }

        public T this[int i, int j, int k] => data[i,j,k];
    }        
}