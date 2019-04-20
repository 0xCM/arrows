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
    using static inxfunc;

   public readonly struct Vec128<T> : IEquatable<Vec128<T>>
        where T : struct, IEquatable<T>
    {
        public static readonly int Length = Vector128<T>.Count;

        public static readonly int PrimSize = SizeOf<T>.Size;
        
        readonly Vector128<T> data;        
    

        [MethodImpl(Inline)]
        public static implicit operator Vec128<T>(in Vector128<T> src)
            => new Vec128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(in Vec128<T> src)
            => src.As<T>();

        [MethodImpl(Inline)]
        public Vec128(in Vector128<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        static T component(Vector128<T> src, int idx)
        {
            ref T e0 = ref Unsafe.As<Vector128<T>, T>(ref src);                    
            return Unsafe.Add(ref e0, idx);           
        }

        /// <summary>
        /// Extracts a component via its 0-based index
        /// </summary>
        public  T this[int idx]
        {
            [MethodImpl(Inline)]
            get => Vector128.GetElement(data,idx);

        }

        /// <summary>
        /// Copies the vector components to a supplied array
        /// </summary>
        [MethodImpl(Inline)]
        public T[] components(ref T[] dst)
        {
            for(var i = 0; i< Length; i++)
                dst[i] = Vector128.GetElement(data,i);
            return dst;
        }    

        /// <summary>
        /// Extracts the components from the vector
        /// </summary>
        [MethodImpl(Inline)]
        public unsafe T[] ToArray()
        {      
             var dst = new T[Length];
             return components(ref dst);
        }


        [MethodImpl(Inline)]
        public Vec256<T> ToVec256()
            => data.ToVector256Unsafe();

        [MethodImpl(Inline)]
        public Num128<T> ToNum128()
            => data;

        [MethodImpl(Inline)]
        public bool Equals(Vec128<T> rhs)
            => data.Equals(rhs.data);

        public override string ToString()
            => data.ToString();
 
        [MethodImpl(Inline)]
        public Vector128<U> As<U>() 
            where U : struct        
                => Unsafe.As<Vector128<T>, Vector128<U>>(ref Unsafe.AsRef(in data));        
    }     
}