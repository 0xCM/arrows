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
    using static zfunc;

    public static class NatArray
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
        
        static readonly (uint x0, uint x1) Dim = ((uint)natu<K1>(), (uint)natu<K2>());
        
        public Array(IEnumerable<T> src)
        {
            data = new T[Dim.x0,Dim.x1];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in axis0.value.Iteri())
                data[axis0.i, axis1.i] = axis1.value;                                                    
        }

        public T this[int i, int j] 
            => data[i,j];

        public IEnumerable<(int i, int j, T value)> Content 
        {
            get
            {
                for(var i = 0; i< Dim.x0; i++)
                for(var j = 0; j < Dim.x1; j++)
                    yield return (i,j,data[i,j]);

            }
        }

        public bool Equals(Array<K1, K2, T> rhs)
        {
            for(var i = 0; i< Dim.x0; i++)
            for(var j = 0; j < Dim.x1; j++)
            {
                if(!data[i,j].Equals(rhs[i,j]))
                    return false;
            }
            return true;
        }

    }        

    /// <summary>
    /// A 3-dimensional array with length encoded by three natural parameters
    /// </summary>
    public struct Array<K1,K2,K3,T> : IDiscreteContainer<Array<K1,K2,K3,T>, (int i, int j, int k, T value)>
        where K1 : ITypeNat, new()
        where K2 : ITypeNat, new()
        where K3 : ITypeNat, new()
        where T : IEquatable<T>
    {
        T[,,] data;
        
        static readonly (uint x0, uint x1, uint x2) Dim = ((uint)natu<K1>(), (uint)natu<K2>(), (uint)natu<K3>());

        public Array(IEnumerable<T> src)
        {
            data = new T[Dim.x0,Dim.x1,Dim.x2];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in src.Partition<K2,T>().Iteri())
            foreach(var axis2 in axis1.value.Iteri())
                data[axis0.i, axis1.i, axis2.i] = axis2.value;                                                    
        }

        public T this[int i, int j, int k] 
        {
            get => data[i,j,k];
            set => data[i,j,k] = value;
        }
            
        public IEnumerable<(int i, int j, int k, T value)> Content 
        {
            get
            {
                for(var i = 0; i < Dim.x0; i++)
                for(var j = 0; j < Dim.x1; j++)
                for(var k = 0; k < Dim.x2; k++)
                    yield return (i,j,k,data[i,j,k]);

            }
        }

        public bool Equals(Array<K1, K2, K3, T> rhs)
        {
            for(var i = 0; i < Dim.x0; i++)
            for(var j = 0; j < Dim.x1; j++)
            for(var k = 0; k < Dim.x2; k++)
            {
                if(!data[i,j,k].Equals(rhs[i,j,k]))
                    return false;
            }
            return true;                             
        }
    }        

}