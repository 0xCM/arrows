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
        
    using static zfunc;

    /// <summary>
    /// Captures a sample from an unspecified distribution
    /// </summary>
    public readonly struct Sample<T>
        where T : unmanaged
    {
        public readonly MemorySpan<T> Data {get;}

        /// <summary>
        /// The number of observations that comprise the sample
        /// </summary>
        public readonly int Count;

        /// <summary>
        /// The sample dimensionality
        /// </summary>
        public readonly int Dim;

        [MethodImpl(Inline)]
        public static Sample<T> Alloc(int dim, int count)
            => new Sample<T>(new T[count * dim], dim);
    
        [MethodImpl(Inline)]
        public static Sample<T> Load(MemorySpan<T> src, int dim)
            => new Sample<T>(src,dim);

        [MethodImpl(Inline)]
        public static Sample<T> Load(T[] src, int dim)
            => new Sample<T>(src,dim);

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Sample<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (Sample<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static bool operator == (Sample<T> lhs, Sample<T> rhs)
            => lhs.Data.Span == rhs.Data.Span;

        [MethodImpl(Inline)]
        public static bool operator != (Sample<T> lhs, Sample<T> rhs)
            => lhs.Data.Span != rhs.Data.Span;
        

        [MethodImpl(Inline)]
        Sample(T[] src, int dim)
        {
            this.Dim = dim;            
            this.Count = Math.DivRem(src.Length, dim, out int remainder);    
            require(remainder == 0);
            Data = src;
        }
                
        [MethodImpl(Inline)]
        Sample(MemorySpan<T> src, int dim)
        {
            this.Dim = dim;            
            this.Count = Math.DivRem(src.Length, dim, out int remainder);    
            require(remainder == 0);
            Data = src;
        }

        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Data.Span[ix];
        }

        [MethodImpl(Inline)]
        public ref T Block(int vecix)
            => ref this[vecix*Dim];

        /// <summary>
        /// Retrieves a single index-identified observation vector
        /// </summary>
        /// <param name="vecix">The vector index</param>
        [MethodImpl(Inline)]
        public Sample<T> Observation(int vecix)
        {
            var slice = Data.Slice(vecix * Dim, Dim); 
            return new Sample<T>(slice, Dim);
        }

        /// <summary>
        /// Retrives a contiguous sequence of observation vectors begining at 
        /// a specified vector index
        /// </summary>
        /// <param name="vecix">The index of the first vector</param>
        /// <param name="count">The number of observations to retrieve</param>
        [MethodImpl(Inline)]
        public Sample<T> Observations(int vecix, int count)
            => new Sample<T>(Data.Slice(vecix * Dim, count * Dim), Dim);
            
        /// <summary>
        /// The data length
        /// </summary>
        public int Length 
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public string Format()
        {
            var fmt = sbuild();
            for(var i=0; i<Count; i++)
            {
                var v = Observation(i);
                fmt.Append(AsciSym.Lt);                
                for(var j = 0; j< Dim; j++)
                {
                    fmt.Append($"{v[j]}");
                    if(j != Dim - 1)
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