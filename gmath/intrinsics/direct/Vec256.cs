//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static zcore;
    using static mfunc;

   public readonly struct Vec256<T> : IEquatable<Vec256<T>>
        where T : struct, IEquatable<T>
    {

        public static readonly int Length = Vector256<T>.Count;
                
        readonly Vector256<T> data;        
    

        [MethodImpl(Inline)]
        public static implicit operator Vec256<T>(in Vector256<T> src)
            => new Vec256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<T>(in Vec256<T> src)
            => src.As<T>();

        [MethodImpl(Inline)]
        public Vec256(in Vector256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        static T component(Vector256<T> src, int idx)
        {
            ref T e0 = ref Unsafe.As<Vector256<T>, T>(ref src);                    
            return Unsafe.Add(ref e0, idx);           
        }

        /// <summary>
        /// Extracts a component via its 0-based index
        /// </summary>
        public T this[int idx]
        {
            [MethodImpl(Inline)]
            get => component(data,idx);
        }

        /// <summary>
        /// Extracts the components from the vector
        /// </summary>
        [MethodImpl(Inline)]
        public T[] components()
        {
            var dst = new T[Length];
            for(var i = 0; i<Length; i++)
                dst[i] = component(data,i);
            return dst;
        }

        /// <summary>
        /// Copies the vector components to a supplied array
        /// </summary>
        [MethodImpl(Inline)]
        public T[] components(ref T[] dst)
        {
            for(var i = 0; i< Length; i++)
                dst[i] = component(data,i);
            return dst;
        }    


        [MethodImpl(Inline)]
        public Vector256<U> As<U>() 
            where U : struct        
                => Unsafe.As<Vector256<T>, Vector256<U>>(ref Unsafe.AsRef(in data));        

        [MethodImpl(Inline)]
        public bool Equals(Vec256<T> rhs)
            => data.Equals(rhs.data);

        public override string ToString()
            => data.ToString();
    }     
}