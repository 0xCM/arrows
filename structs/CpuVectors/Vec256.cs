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
    using System.Runtime.Intrinsics.X86;


    using static zfunc;    
    
    /// <summary>
    /// Represents a 256-bit cpu vector for use with intrinsic operations
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = ByteCount)]
    public readonly struct Vec256<T> : IEquatable<Vec256<T>>
        where T : struct
    {
        /// <summary>
        /// The backing data
        /// </summary>
        readonly Vector256<T> data;        

        /// <summary>
        /// The number of components in the vector
        /// </summary>
        public static readonly int Length = Vector256<T>.Count;

        /// <summary>
        /// The number of bytes occupied by a vector - which is invariant with respect to the primal component type
        /// </summary>
        public const int ByteCount = 32;

        /// <summary>
        /// The canonical zero vector
        /// </summary>
        public static readonly Vec256<T> Zero = default;

        [MethodImpl(Inline)]
        public static bool operator ==(in Vec256<T> lhs, in Vec256<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in Vec256<T> lhs, in Vec256<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator Vec256<T>(in Vector256<T> src)
            => new Vec256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<T>(in Vec256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public Vec256(in Vector256<T> src)
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
            get => component(this,idx);
            [MethodImpl(Inline)]
            set => component(this,idx, value);
        }

        /// <summary>
        /// Presents the currect current vector[T] as vector[U] where U is a primal type.
        /// Non-allocating
        /// </summary>
        /// <typeparam name="U">The target primal type</typeparam>
        [MethodImpl(Inline)]
        public Vec256<U> As<U>() 
            where U : struct                
        {
            return Unsafe.As<Vector256<T>, Vec256<U>>(ref Unsafe.AsRef(in data));
        }
             
        [MethodImpl(Inline)]
        public ref Vec256<U> As<U>(out Vec256<U> dst) 
            where U : struct                
        {
            dst = Unsafe.As<Vector256<T>, Vec256<U>>(ref Unsafe.AsRef(in data));
            return ref dst;
        }
        

        [MethodImpl(Inline)]
        public bool Equals(Vec256<T> rhs)
            => data.Equals(rhs.data);

        public override string ToString()
            => data.ToString();
        
        public override int GetHashCode()
            => data.GetHashCode();

        public override bool Equals(object obj)
            => obj is Vec256<T> v ? Equals(v) : false;

        [MethodImpl(Inline)]
        static T component(Vec256<T> src, int index)
        {
            ref T e0 = ref Unsafe.As<Vec256<T>, T>(ref src);
            return Unsafe.Add(ref e0, index);
        }

        [MethodImpl(Inline)]
        static void component(Vec256<T> src, int index, T value)
        {
            ref T e0 = ref Unsafe.As<Vec256<T>, T>(ref src);
            Unsafe.Add(ref e0, index) = value;
        }

    }    


    public static class VecX
    {
        [MethodImpl(Inline)]
        public static ref Vec256<U> AsRef<T,U>(this in Vec256<T> src) 
            where T : struct
            where U : struct                
                => ref Unsafe.As<Vec256<T>, Vec256<U>>(ref Unsafe.AsRef(in src));


    }     
}