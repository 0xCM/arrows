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

    using static nfunc;
    using static nats;
    using static zfunc;

    public static class Arr
    {
        /// <summary>
        /// Allocates an array of of natural length
        /// </summary>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">Then element type</typeparam>
        public static Array<N,T> define<N,T>()
            where N : ITypeNat, new()
                => new Array<N,T>();

        /// <summary>
        /// Wraps an existing array within an array of natural length
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">Then element type</typeparam>
        public static Array<N,T> define<N,T>(params T[] src)
            where N : ITypeNat, new()
                => new Array<N,T>(src);

        public static Array<N,T> define<N,T>(N len, params T[] src)
            where N : ITypeNat, new()
                => new Array<N,T>(src);

        /// <summary>
        /// Creates an array from the first N elements of a sequence
        /// </summary>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">Then element type</typeparam>
        /// <returns></returns>
        public static Array<N,T> define<N,T>(IEnumerable<T> src)
            where N : ITypeNat, new()
                => new Array<N,T>(src);

        /// <summary>
        /// Creates an array from the first N elements of a sequence
        /// </summary>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">Then element type</typeparam>
        /// <returns></returns>
        public static Array<N,T> define<N,T>(N len, IEnumerable<T> src)
            where N : ITypeNat, new()
                => new Array<N,T>(src);



    }

    /// <summary>
    /// A one-dimensional array with lenght encoded by typenat parameter
    /// </summary>
    public struct Array<N,T> : IArray<N,T>
        where N : ITypeNat, new()
    {
        public static readonly int Length = nati<N>();

        T[] data;

        public ref T this[int ix] 
        { 
            [MethodImpl(Inline)]
            get => ref data[ix]; 
                    
        }

        [MethodImpl(Inline)]
        internal Array(int len)
        {
            Prove.claim<N>(len);
            data = new T[len];
        }

        [MethodImpl(Inline)]
        internal Array(IEnumerable<T> src)
        {
            var len = natu<N>();
            data = src.Take((int)len).ToArray();
        }

        [MethodImpl(Inline)]
        public Array(params T[] data)
        {
            if(data.Length == 0)
                this.data = array<T>(nati<N>());
            else
            {
                Prove.claim<N>(data.Length);
                this.data = data;
            }
        }

        public uint length 
            => (uint)Length;

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            =>(from item in data select item).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => data.GetEnumerator();

        public T[] unwrap()
            => data;
    }


    /// <summary>
    /// A 2-dimensional array with length encoded by two typenat parameters
    /// </summary>
    public readonly struct Array<K1,K2,T> : IDiscreteContainer<Array<K1,K2,T>,(int i, int j, T value)>
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
    {
        readonly T[,] data;
        
        readonly (uint k1, uint k2) dim;
        
        public Array(IEnumerable<T> src)
        {
            dim = ((uint)natu<K1>(), (uint)natu<K2>());
            data = new T[dim.k1,dim.k2];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in axis0.value.Iteri())
                data[axis0.i, axis1.i] = axis1.value;                                                    
        }

        public T this[int i, int j] => data[i,j];

        public IEnumerable<(int i, int j, T value)> Content 
        {
            get
            {
                for(var i = 0; i< dim.k1; i++)
                for(var j = 0; j < dim.k2; j++)
                    yield return (i,j,data[i,j]);

            }
        }

        public bool eq(Array<K1, K2, T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Array<K1, K2, T> other)
        {
            throw new NotImplementedException();
        }

        public int hash()
        {
            throw new NotImplementedException();
        }

        public bool neq(Array<K1, K2, T> rhs)
        {
            throw new NotImplementedException();
        }
    }        

    /// <summary>
    /// A 3-dimensional array with length encoded by three natural parameters
    /// </summary>
    public readonly struct Array<K1,K2,K3,T> : IDiscreteContainer<Array<K1,K2,K3,T>, (int i, int j, int k, T value)>
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
        where K3 : ITypeNat, new()
    {
        readonly T[,,] data;
        
        readonly (uint k1, uint k2, uint k3) dim;

        public Array(IEnumerable<T> src)
        {
            dim = ((uint)natu<K1>(), (uint)natu<K2>(), (uint)natu<K3>());
            data = new T[dim.k1,dim.k2,dim.k3];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in src.Partition<K2,T>().Iteri())
            foreach(var axis2 in axis1.value.Iteri())
                data[axis0.i, axis1.i, axis2.i] = axis2.value;                                                    
        }

        public T this[int i, int j, int k] => data[i,j,k];

        public T this[uint i, uint j, uint k] => data[i,j,k];

        public T this[ulong i, ulong j, ulong k] => data[i,j,k];

        public IEnumerable<(int i, int j, int k, T value)> Content 
        {
            get
            {
                for(var i = 0; i< dim.k1; i++)
                for(var j = 0; j < dim.k2; j++)
                for(var k = 0; k< dim.k3; k++)
                    yield return (i,j,k,data[i,j,k]);

            }
        }

        public bool eq(Array<K1, K2, K3, T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Array<K1, K2, K3, T> other)
        {
            throw new NotImplementedException();
        }

        public int hash()
        {
            throw new NotImplementedException();
        }

        public bool neq(Array<K1, K2, K3, T> rhs)
        {
            throw new NotImplementedException();
        }
    }        

}