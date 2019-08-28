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
    using System.Runtime.InteropServices;

    using static zfunc;    

    /// <summary>
    /// Represents a 128-bit cpu vector for use with intrinsic operations
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = ByteCount)]
    public readonly struct Vec128<T> : IEquatable<Vec128<T>>
        where T : struct
    {            
        /// <summary>
        /// The backing data
        /// </summary>
        public readonly Vector128<T> data;        

        /// <summary>
        /// The number of components in the vector
        /// </summary>
        public static readonly int Length = Vector128<T>.Count;
        
        /// <summary>
        /// The number of bytes occupied by a vector - which is invariant with respect to the primal component type
        /// </summary>
        public const int ByteCount = 16;

        /// <summary>
        /// The canonical zero vector
        /// </summary>
        public static readonly Vec128<T> Zero = default;

        [MethodImpl(Inline)]
        public static implicit operator Vec128<T>(Vector128<T> src)
            => new Vec128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(Vec128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator ==(in Vec128<T> lhs, in Vec128<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in Vec128<T> lhs, in Vec128<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public Vec128(Vector128<T> src)
            => this.data = src;

        /// <summary>
        /// Manipulates a component via its 0-based index
        /// </summary>
        /// <remarks>The operator manipulates the CLR memory in which the vector is stored
        /// and has no direct impact on the CPU registers.
        /// </remarks>
        public T this[int idx]
        {
            [MethodImpl(Inline)]
            get => Component(this, idx);

            [MethodImpl(Inline)]
            set => Component(this, idx, value);
        }

        /// <summary>
        /// Presents the currect current vector[T] as vector[U] where U is a primal type. 
        /// Non-allocating
        /// </summary>
        /// <typeparam name="U">The target primal type</typeparam>
        [MethodImpl(Inline)]
        public Vec128<U> As<U>() 
            where U : struct
                => Unsafe.As<Vector128<T>, Vec128<U>>(ref Unsafe.AsRef(in data));         

        [MethodImpl(Inline)]
        public bool Equals(Vec128<T> rhs)
             => data.Equals(rhs.data);

        public override string ToString()
            => data.ToString();

        public override int GetHashCode()
            => data.GetHashCode();

        public override bool Equals(object obj)
            => obj is Vec128<T> v ? Equals(v) : false;

        [MethodImpl(Inline)]
        static T Component(Vec128<T> src, int index)
        {
            ref T e0 = ref Unsafe.As<Vec128<T>, T>(ref src);
            return Unsafe.Add(ref e0, index);
        }

        [MethodImpl(Inline)]
        static void Component(Vec128<T> src, int index, T value)
        {
            ref T e0 = ref Unsafe.As<Vec128<T>, T>(ref src);
            Unsafe.Add(ref e0, index) = value;
        }       
    }     
}