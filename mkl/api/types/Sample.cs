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
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;    
    using System.Diagnostics;
        
    using static zfunc;

    public static class Sample
    {
        /// <summary>
        /// Loads a sample from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dim">The sample dimension</param>
        /// <param name="offset">The offset into the source span from to begin the load</param>
        /// <typeparam name="T">The sample data type</typeparam>
        [MethodImpl(Inline)]
        public static Sample<T> Load<T>(Span<T> src, int dim = 1,  int offset = 0)
            where T : struct
                => Sample<T>.Load(src, dim, offset);

        [MethodImpl(Inline)]
        public static Sample<T> Load<T>(Memory<T> src, int dim = 1)
            where T : struct
                => Sample<T>.Load(src, dim);

        [MethodImpl(Inline)]
        public static Sample<T> Load<T>(T[] src, int dim = 1)
            where T : struct
                => Sample<T>.Load(src, dim);

        /// <summary>
        /// Allocates a sample 
        /// </summary>
        /// <param name="dim">The sample dimension</param>
        /// <param name="count">The number of observation vectors in the sample</param>
        /// <typeparam name="T">The sample data type</typeparam>
        [MethodImpl(Inline)]
        public static Sample<T> Alloc<T>(int dim, int count)
            where T : struct
            => Sample<T>.Alloc(dim, count);

    }

    public ref struct Sample<T>
        where T : struct
    {
        /// <summary>
        /// The number of observations that comprise the sample
        /// </summary>
        public readonly int Count;

        public readonly int Dimension;


        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Sample<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (Sample<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (Sample<T> lhs, Sample<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (Sample<T> lhs, Sample<T> rhs)
            => lhs.data != rhs.data;        
        
        [MethodImpl(Inline)]
        public static Sample<T> Alloc(int dim, int count)
            => new Sample<T>(new T[count * dim], dim);
    
        [MethodImpl(Inline)]
        public static Sample<T> Load(Span<T> src, int dim,  int offset = 0)
            => offset != 0 ? new Sample<T>(src.Slice(offset), dim) : new Sample<T>(src, dim);

        [MethodImpl(Inline)]
        public static Sample<T> Load(Memory<T> src, int dim)
            => new Sample<T>(src.Span,dim);

        [MethodImpl(Inline)]
        public static unsafe Sample<T> Load(int dim, void* src, int srcLen)        
            => new Sample<T>(dim, src, srcLen);        

        Span<T> data;

        [MethodImpl(Inline)]
        unsafe Sample(int dim, void* src, int length)    
        {
            this.Dimension = dim;
            this.Count = Math.DivRem(length, dim, out int remainder);    
            require(remainder == 0);
            data = new Span<T>(src, length);  
        }

        [MethodImpl(Inline)]
        Sample(T[] src, int dim)
        {
            this.Dimension = dim;            
            this.Count = Math.DivRem(src.Length, dim, out int remainder);    
            require(remainder == 0);
            data = src;
        }
                
        [MethodImpl(Inline)]
        Sample(ReadOnlySpan<T> src, int dim)
        {
            this.Dimension = dim;            
            this.Count = Math.DivRem(src.Length, dim, out int remainder);    
            require(remainder == 0);
            data = src.ToSpan();
        }

        [MethodImpl(Inline)]
        Sample(Span<T> src, int dim)
        {
            this.Dimension = dim;
            this.Count = Math.DivRem(src.Length, dim, out int remainder);    
            require(remainder == 0);
            this.data = src;
        }

        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        [MethodImpl(Inline)]
        public ref T Block(int vecix)
            => ref this[vecix*Dimension];

        /// <summary>
        /// Retrieves a single index-identified observation vector
        /// </summary>
        /// <param name="vecix">The vector index</param>
        [MethodImpl(Inline)]
        public Sample<T> Observation(int vecix)
        {
            var slice = data.Slice(vecix * Dimension, Dimension); 
            return new Sample<T>(slice, Dimension);
        }

        /// <summary>
        /// Retrives a contiguous sequence of observation vectors begining at 
        /// a specified vector index
        /// </summary>
        /// <param name="vecix">The index of the first vector</param>
        /// <param name="count">The number of observations to retrieve</param>
        [MethodImpl(Inline)]
        public Sample<T> Observations(int vecix, int count)
            => new Sample<T>(data.Slice(vecix * Dimension, count * Dimension), Dimension);
            
        [MethodImpl(Inline)]
        public Span<T> ToSpan()
            => data;

        [MethodImpl(Inline)]
        public Span<T> ToReadOnlySpan()
            => data;

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public void Fill(T value)
            => data.Fill(value);

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo (Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo (Span<T> dst)
            => data.TryCopyTo(dst);
                
        [MethodImpl(Inline)]
        public Sample<S> As<S>()                
            where S : struct
                => Sample<S>.Load(MemoryMarshal.Cast<T,S>(data),Dimension);                    

        /// <summary>
        /// The (non-blocked) data length
        /// </summary>
        public int Length 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }

        public string Format()
        {
            var fmt = sbuild();
            for(var i=0; i<Count; i++)
            {
                var v = Observation(i);
                fmt.Append(AsciSym.Lt);                
                for(var j = 0; j< Dimension; j++)
                {
                    fmt.Append($"{v[j]}");
                    if(j != Dimension - 1)
                        fmt.Append(", ");
                }
                fmt.Append(AsciSym.Gt);                
                
                if(i != Count - 1)
                    fmt.AppendLine();
            }
            return fmt.ToString();
        }

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
        
    }
}