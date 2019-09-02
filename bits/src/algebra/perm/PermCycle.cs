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
    using System.Text;

    using static zfunc;    


    /// <summary>
    /// Describes cycle in a perutation
    /// </summary>
    public readonly struct PermCycleG<T>
        where T : unmanaged
    {
        public PermCycleG(params PermTerm<T>[] src)
        {
            var len = src.Length;
            if(len > 1)
                require(gmath.eq(src[0].Source, src[len - 1].Target));
            
            this.Terms = src;
        }

        [MethodImpl(Inline)]
        public PermCycleG(Span<PermTerm<T>> src)
        {
            Terms = src.ToArray();
        }
        
        /// <summary>
        /// The terms that define the cycle
        /// </summary>
        public readonly PermTerm<T>[] Terms;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Terms.Length;
        }
        public string Format()
        {
            var sb = sbuild();
            sb.Append(AsciSym.LParen);
            for(var i=0; i< Terms.Length; i++)            
            {
                sb.Append(Terms[i].Source);
                if(i != Terms.Length - 1)                
                    sb.Append(AsciSym.Space);
            }

            sb.Append(AsciSym.RParen);
            return sb.ToString();
        }

        public override string ToString()
            => Format();
    }

}