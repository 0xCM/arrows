//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Text;

    using static zfunc;    

    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct Perm8
    {
        public static readonly Perm8 Identity = new Perm8(
            Perm8Symbol.A, Perm8Symbol.B, Perm8Symbol.C, Perm8Symbol.D, 
            Perm8Symbol.E, Perm8Symbol.F, Perm8Symbol.G, Perm8Symbol.H);

        Perm8Symbol[] terms;

        Perm8(params Perm8Symbol[] terms)
            => this.terms = terms;

        public Perm8Symbol this[Perm8Symbol index]
        {
            [MethodImpl(Inline)]
            get => terms[(int)index];
            [MethodImpl(Inline)]
            set => terms[(int)index] = value;
        }

        [MethodImpl(Inline)]
        public Perm8 Replicate()
        {
            var dst = new Perm8Symbol[8];
            terms.CopyTo(dst);
            return new Perm8(dst);
        }

        public string Format(int? colwidth = null)
            => Perm.Format<Perm8Symbol>(terms,colwidth);

        [MethodImpl(Inline)]        
        public Span<T> ToSpan<T>()
            where T : unmanaged
                => terms.AsSpan().As<Perm8Symbol, T>();

    }

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 8 symbols
    /// </summary>
    [Flags]
    public enum Perm8Symbol : uint
    {
        /// <summary>
        /// Identifies the first permutation symbol
        /// </summary>
        A = 0,

        /// <summary>
        /// Identifies the second permutation symbol
        /// </summary>
        B = 1,

        /// <summary>
        /// Identifies the third permutation symbol
        /// </summary>
        C = 2,

        /// <summary>
        /// Identifies the fourth permutation symbol
        /// </summary>
        D = 3, 

        /// <summary>
        /// Identifies the fifth permutation symbol
        /// </summary>
        E = 4, 

        /// <summary>
        /// Identifies the sixth permutation symbol
        /// </summary>
        F = 5,

        /// <summary>
        /// Identifies the seventh permutation symbol
        /// </summary>
        G = 6, 

        /// <summary>
        /// Identifies the eighth permutation symbol
        /// </summary>
        H = 7, 

        /// <summary>
        /// Represents the 8 symbol identity permutation
        /// </summary>
        Identity = A | B << 3 | C << 6 | D << 9 | E << 12 | F << 15 | G << 18 | H << 21,

        /// <summary>
        /// Represents the reversed identity permutation
        /// </summary>
        Reverse =  H | G << 3 | F << 6 | E << 9 | D << 12 | C << 15 | B << 18 | A << 21,
    }


}