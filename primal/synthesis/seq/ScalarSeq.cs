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
    /// Defines a data structure for sparse/partial sequence representation
    /// </summary>
    public readonly ref struct ScalarSeq<T>
        where T : unmanaged
    {            
        readonly Span<SeqTerm<T>> terms;

        public static ScalarSeq<T> Empty => new ScalarSeq<T>(SeqTerm<T>.Empty);

        internal ScalarSeq(params T[] terms)
        {
            if(terms.Length != 0)
            {
                this.terms = new SeqTerm<T>[terms.Length];
                for(var i=0; i<terms.Length; i++)
                    this.terms[i] = (i,terms[i]);
            }
            else
                this.terms = Empty.terms;
        }

        [MethodImpl(Inline)]
        internal ScalarSeq(params SeqTerm<T>[] terms)
        {
            if(terms.Length != 0)
                this.terms = terms;
            else
                this.terms = Empty.terms;
        }

        internal ScalarSeq(Span<T> terms)
        {
            if(terms.Length != 0)
            {
                this.terms = new SeqTerm<T>[terms.Length];
                for(var i=0; i<terms.Length; i++)
                    this.terms[i] = (i,terms[i]);
            }
            else
                this.terms = Empty.terms;
        }

        /// <summary>
        /// Specifies the sequence terms
        /// </summary>
        /// <value></value>
        public ReadOnlySpan<SeqTerm<T>> Terms
        {
            [MethodImpl(Inline)]
            get => terms;
        }

        public ref readonly SeqTerm<T> this[int idx]
        {
            [MethodImpl(Inline)]
            get => ref terms[idx];
        }

        public ref readonly SeqTerm<T> First
            => ref terms[0];

        public ref readonly SeqTerm<T> Last
            => ref terms[terms.Length - 1];

        public string Format(char? delimiter = null)
        {
            var fmt = sbuild();
            fmt.Append(AsciSym.LBrace);
            for(var i=0; i<terms.Length; i++)
            {
                fmt.Append(terms[i].Format());
                if(i != terms.Length - 1)
                {
                    fmt.Append(delimiter ?? AsciSym.Comma);
                    fmt.Append(AsciSym.Space);
                }                
            }
            fmt.Append(AsciSym.RBrace);
            return fmt.ToString();
        }        
    }
}