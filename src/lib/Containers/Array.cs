//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Z0
{

    using static zcore;

    partial class Traits
    {

    }

    public static class array
    {
        /// <summary>
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The position of the first element of the source array </param>
        /// <param name="endpos">The position of the last element of the source array</param>
        /// <returns></returns>
        public static T[] subset<T>(this T[] src, int startpos, int endpos)
        {
            var len = endpos - startpos + 1;
            var dst = new T[len];
            Array.Copy(src, startpos, dst, 0, len);
            return dst;
        } 

        /// <summary>
        /// Concatentates two byte arrays
        /// </summary>
        /// <param name="first">The first array of bytes</param>
        /// <param name="second">The second array of bytes</param>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        public static byte[] concat(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }


        /// <summary>
        /// Concatentates a parameter array of byte arrays
        /// </summary>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        public static byte[] concat(params byte[][] src)
        {
            byte[] ret = new byte[src.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in src)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }

        /// <summary>
        /// Concatenates a sequence of byte arrays
        /// </summary>
        /// <param name="src">The source arrays</param>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        public static byte[] concat(IEnumerable<byte[]> src)
        {
            byte[] ret = new byte[src.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in src)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }

        /// <summary>
        /// Concatenates a sequence of parameter arrays
        /// </summary>
        /// <param name="src">The source arrays</param>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        public static T[] concat<T>(params T[][] src)
        {
            var ret = new T[src.Sum(x => x.Length)];
            int offset = 0;
            foreach (var data in src)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }

        /// <summary>
        /// Concatenates a sequence of arrays
        /// </summary>
        /// <param name="src">The source arrays</param>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
        public static T[] concat<T>(IEnumerable<T[]> src)
        {
            var ret = new T[src.Sum(x => x.Length)];
            int offset = 0;
            foreach (var data in src)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }
    }

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

        /// <summary>
        /// Creates an array from the first N elements of a sequence
        /// </summary>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">Then element type</typeparam>
        /// <returns></returns>
        public static Array<N,T> define<N,T>(N len, IEnumerable<T> src)
            where N : TypeNat, new()
                => new Array<N,T>(src);

    }

    /// <summary>
    /// A one-dimensional array with lenght encoded by typenat parameter
    /// </summary>
    public struct Array<N,T> : Contain.Array<N,T>
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
                this.data = array<T>((uint)natval<N>());
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
    public readonly struct Array<K1,K2,T> : Contain.DiscreteContainer<Array<K1,K2,T>,(int i, int j, T value)>
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
    {
        readonly T[,] data;
        
        readonly (uint k1, uint k2) dim;
        
        public Array(IEnumerable<T> src)
        {
            dim = ((uint)natval<K1>(), (uint)natval<K2>());
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
    public readonly struct Array<K1,K2,K3,T> : Contain.DiscreteContainer<Array<K1,K2,K3,T>, (int i, int j, int k, T value)>
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
        where K3 : TypeNat, new()
    {
        readonly T[,,] data;
        
        readonly (uint k1, uint k2, uint k3) dim;

        public Array(IEnumerable<T> src)
        {
            dim = ((uint)natval<K1>(), (uint)natval<K2>(), (uint)natval<K3>());
            data = new T[dim.k1,dim.k2,dim.k3];
            foreach(var axis0 in src.Partition<K1,T>().Iteri())
            foreach(var axis1 in src.Partition<K2,T>().Iteri())
            foreach(var axis2 in axis1.value.Iteri())
                data[axis0.i, axis1.i, axis2.i] = axis2.value;                                                    
        }

        public T this[int i, int j, int k] => data[i,j,k];

        public T this[uint i, uint j, uint k] => data[i,j,k];

        public T this[ulong i, ulong j, ulong k] => data[i,j,k];

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

