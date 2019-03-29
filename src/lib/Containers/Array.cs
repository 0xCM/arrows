//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    

    public static class NArray
    {
        /// <summary>
        /// Allocates an array of of natural length
        /// </summary>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">Then element type</typeparam>
        /// <returns></returns>
        public static Array<N,T> define<N,T>()
            where N : TypeNat, new()
                => new Array<N,T>();

        /// <summary>
        /// Creates an array from the first N elements of a sequence
        /// </summary>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">Then element type</typeparam>
        /// <returns></returns>
        public static Array<N,T> define<N,T>(IEnumerable<T> src)
            where N : TypeNat, new()
                => new Array<N,T>(src);

    }

    /// <summary>
    /// A one-dimensional array with lenght encoded by typenat parameter
    /// </summary>
    public struct Array<N,T> : Traits.Array<N,T>
        where N : TypeNat, new()
    {
        T[] data;

        public T this[int ix] 
        { 
            [MethodImpl(Inline)]
            get => data[ix]; 
            
            [MethodImpl(Inline)]
            set => data[ix] = value;
        }

        [MethodImpl(Inline)]
        internal Array(int len)
        {
            Prove.claim<N>(len);
            data = new T[]{};
        }

        [MethodImpl(Inline)]
        internal Array(IEnumerable<T> src)
        {
            var len = natval<N>();
            data = src.Take((int)len).ToArray();
        }


        [MethodImpl(Inline)]
        public Array(params T[] data)
        {
            if(data.Length == 0)
                this.data = array<T>(natval<N>());
            else
            {
                Prove.claim<N>(data.Length());
                this.data = data;
            }
        }

        public uint length 
            => (uint)data.Length;

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            =>(from item in data select item).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => data.GetEnumerator();
    }


    /// <summary>
    /// A 2-dimensional array with length encoded by two typenat parameters
    /// </summary>
    public readonly struct Array<K1,K2,T> : Container<(int i, int j, T value)>
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
    {
        readonly T[,] data;
        
        readonly (uint k1, uint k2) dim;
        
        public Array(IEnumerable<T> src)
        {
            dim = (natval<K1>(), natval<K2>());
            data = new T[dim.k1,dim.k2];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in axis0.value.Iteri())
                data[axis0.i, axis1.i] = axis1.value;                                                    
        }

        public T this[int i, int j] => data[i,j];

        public IEnumerable<(int i, int j, T value)> content 
        {
            get
            {
                for(var i = 0; i< dim.k1; i++)
                for(var j = 0; j < dim.k2; j++)
                    yield return (i,j,data[i,j]);

            }
        }

    }        

    /// <summary>
    /// A 3-dimensional array with length encoded by three natural parameters
    /// </summary>
    public readonly struct Array<K1,K2,K3,T> : Container<(int i, int j, int k, T value)>
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
        where K3 : TypeNat, new()
    {
        readonly T[,,] data;
        
        readonly (uint k1, uint k2, uint k3) dim;

        public Array(IEnumerable<T> src)
        {
            dim = (natval<K1>(), natval<K2>(), natval<K3>());
            data = new T[dim.k1,dim.k2,dim.k3];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in src.Partition<K2,T>().Iteri())
            foreach(var axis2 in axis1.value.Iteri())
                data[axis0.i, axis1.i, axis2.i] = axis2.value;                                                    
        }

        public T this[int i, int j, int k] => data[i,j,k];

        public IEnumerable<(int i, int j, int k, T value)> content 
        {
            get
            {
                for(var i = 0; i< dim.k1; i++)
                for(var j = 0; j < dim.k2; j++)
                for(var k = 0; k< dim.k3; k++)
                    yield return (i,j,k,data[i,j,k]);

            }
        }

    }        

}
