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
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    /// <summary>
    /// Defines a vector over cells of unmanaged type
    /// </summary>
    public struct Vector<T>
        where T : unmanaged
    {
        T[] data;

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

        /// <summary>
        /// Deems vectors are equal if they have the same number of components
        /// and corresponding components have identical content
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">Teh right vector</param>
        [MethodImpl(Inline)]
        public static bool operator == (Vector<T> lhs, Vector<T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Vector<T> lhs, Vector<T> rhs) 
            => !lhs.Equals(rhs);

        /// <summary>
        /// Initializes a vector from array content
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public Vector(T[] src)
            => this.data = src;

        /// <summary>
        /// Queries/manipulates component values
        /// </summary>
        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref data[i];            
        }

        /// <summary>
        /// The data wrapped by the vector
        /// </summary>
        public T[] Data
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
        /// Formats components as a list
        /// </summary>
        /// <param name="delimiter">The component delimiter</param>
        [MethodImpl(Inline)]
        public string Format(char? delimiter = null)
            => data.FormatList(delimiter ?? AsciSym.Comma);    

        /// <summary>
        /// Copies vector content into a caller-provided span
        /// </summary>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void CopyTo(Span<T> dst)
        {
            if(dst.Length < data.Length)
                Errors.ThrowTooShort(dst.Length);
             data.CopyTo(dst);
        }

        /// <summary>
        /// Loads the data from the source into a block vector, allocating as necessary to ensure alignment
        /// </summary>
        [MethodImpl(Inline)]
        public BlockVector<T> Block()
            => Span256.Load(data);

        [MethodImpl(Inline)]
        public Vector<U> Convert<U>()
            where U : unmanaged
               => new Vector<U>(convert<T,U>(data));

        [MethodImpl(Inline)]
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
            => rhs is Vector<T> x && Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();
    }

}