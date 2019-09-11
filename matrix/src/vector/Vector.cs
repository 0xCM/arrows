//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    public struct Vector<T>
        where T : unmanaged
    {
        MemorySpan<T> data;

        [MethodImpl(Inline)]
        public static implicit operator Vector<T>(MemorySpan<T> src)
            => new Vector<T>(src);

        /// <summary>
        /// Implicitly reveals a vector's underlying memory span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator MemorySpan<T>(Vector<T> src)
            => src.data;

        /// <summary>
        /// Implicitly converts an array to a vector
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator Vector<T>(T[] src)
            => new Vector<T>(src);

        /// <summary>
        /// Implicitly reveals a vector's underlying memory span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Vector<T> src)
            =>  src.data;

        /// <summary>
        /// Implicitly provies a readonly-view of a vector's underlying data
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(Vector<T> src)
            =>  src.data;

        /// <summary>
        /// Calculates the scalar product between the operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static T operator &(Vector<T> lhs, Vector<T> rhs)
            => gmath.dot<T>(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool operator == (Vector<T> lhs, Vector<T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Vector<T> lhs, Vector<T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public Vector(T[] src)
            => this.data = src;

        [MethodImpl(Inline)]
        public Vector(MemorySpan<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public Vector(ReadOnlySpan<T> src)
            => this.data = src.ToArray();

        /// <summary>
        /// Queries/manipulates component values
        /// </summary>
        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref data[i];            
        }

        public MemorySpan<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The count of vector components, otherwise known as its dimension
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        /// <summary>
        /// Reinterpets vector content
        /// </summary>
        /// <typeparam name="U">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public Vector<U> As<U>()
            where U : unmanaged
                => data.As<U>();

        /// <summary>
        /// Formats components as a list
        /// </summary>
        /// <param name="delimiter">The component delimiter</param>
        [MethodImpl(Inline)]
        public string Format(char? delimiter = null)
            => data.Span.FormatList(delimiter ?? AsciSym.Comma);    

        /// <summary>
        /// Copies the source vector to a specified target vector
        /// </summary>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public ref Vector<T> CopyTo(ref Vector<T> dst)
        {
            data.CopyTo(dst.data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public Vector<U> Convert<U>()
            where U : unmanaged
               => new Vector<U>(convert<T,U>(data));

        public Vector<T> Replicate(bool structureOnly = false)
            => new Vector<T>(data.Replicate(structureOnly));

        
        public bool Equals(Vector<T> rhs)
        {
            if(data.Length != rhs.data.Length)
                return false;

            for(var i = 0; i<data.Length; i++)
                if(gmath.neq(data[i], rhs.data[i]))
                    return false;
            return true;
        }

        public override bool Equals(object rhs)
            => rhs is Vector<T> x  && Equals(x);

        public override int GetHashCode()
            => data.GetHashCode();

    }
}