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

    public readonly struct SeqTerm<T> : IEquatable<SeqTerm<T>>
        where T : unmanaged
    {
        public readonly int Index;

        public readonly T Value;

        public static readonly SeqTerm<T> Empty = new SeqTerm<T>(-1, default(T));
        
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
        
        public bool IsEmpty
            => Index == -1 && !gmath.nonzero(Value);

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