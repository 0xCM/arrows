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

        /// <summary>
        /// A one-dimensional array with lenght encoded by typenat parameter
        /// </summary>
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
        /// A 2-dimensional array with length encoded by two typenat parameters
        /// </summary>
        public readonly struct Array<K1,K2,T> 
            where K1 : TypeNat
            where K2 : TypeNat
        {
            readonly T[,] data;
            
            readonly (int k1, int k2) dim;
            
            public Array(IEnumerable<T> src)
            {
                dim = (natval<K1>(), natval<K2>());
                data = new T[dim.k1,dim.k2];
                foreach(var axis0 in src.Partition<K1,T>().Iteri())
                foreach(var axis1 in axis0.value.Iteri())
                    data[axis0.i, axis1.i] = axis1.value;                                                    
            }

            public T this[int i, int j] => data[i,j];
        }        

         /// <summary>
        /// A e-dimensional array with length encoded by three typenat parameters
        /// </summary>
       public readonly struct Array<K1,K2,K3,T> 
            where K1 : TypeNat
            where K2 : TypeNat
            where K3 : TypeNat
        {
            readonly T[,,] data;
            
            readonly (int k1, int k2, int k3) dim;

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
        }        


    }

}