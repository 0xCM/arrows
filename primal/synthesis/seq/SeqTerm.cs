//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;

    /// <summary>
    /// Defines a sequence term
    /// </summary>
    public readonly struct SeqTerm<T> : IEquatable<SeqTerm<T>>
        where T : unmanaged
    {
        /// <summary>
        /// The integer that maps to the term value
        /// </summary>
        public readonly int Index;

        /// <summary>
        /// The term's value
        /// </summary>        
        public readonly T Value;

        public static readonly SeqTerm<T> Empty = new SeqTerm<T>(0, default(T));
        
        
        [MethodImpl(Inline)]
        public static implicit operator (int i, T t)(SeqTerm<T> src)
            => (src.Index, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator T(SeqTerm<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator SeqTerm<T>((int i, T t) src)
            => new SeqTerm<T>(src.i, src.t);

        [MethodImpl(Inline)]
        public SeqTerm(int index, T value)
        {
            this.Index = index;
            this.Value = value;
        }
        
        /// <summary>
        /// Specifies whether the term is empty
        /// </summary>
        public bool IsEmpty
            => Index == 0 && !gmath.nonzero(Value);

        /// <summary>
        /// Renders the term by default as 'a_i = Value' where i denotes the term index
        /// </summary>
        /// <param name="id">The sequence identifier, if specified</param>
        /// <returns></returns>
        public string Format(char? id = null)
            => IsEmpty ? "{}" : $"{id ?? 'a'}_{Index} = {Value}";
        
        [MethodImpl(Inline)]
        public bool Equals(SeqTerm<T> rhs)
            => Index == rhs.Index && gmath.eq(Value, rhs.Value);
        
        public override bool Equals(object rhs)
            => rhs is SeqTerm<T> t && Equals(t);
        
        public override int GetHashCode()
            => HashCode.Combine(Index,Value);
    }


}