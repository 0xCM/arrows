//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    public abstract class StreamTest<S,T> : InXTest<S,T>
        where S : StreamTest<S,T>
        where T : struct, IEquatable<T>
    {

        protected StreamTest(Interval<T>? domain = null, uint? VecCount = null)
            : base(P.stream, domain ?? Defaults.get<T>().Domain, 
                sampleSize: (int)(VecLength* (VecCount ?? Pow2.T16)))
        {

        }
        
        IEnumerable<Vec128<T>> DefineStream()
            => InXG.stream<T>(SrcArray);

        public virtual void TraverseStream()
        {
            var i = 0;
            iter(DefineStream(), _ => i++);            
            trace($"Iterated a stream of {i} vectors");
            Claim.eq(i, VecCount);
        }

        public virtual void ValidateStream()
        {
            var vectors = DefineStream().ToReadOnlyList();
            Claim.eq(VecCount, vectors.Count);                    


            var i = 0;
            IterOffsets(offset =>{
                var v0 = Vec128.define(SrcArray, offset);
                var v1 = vectors[i];
                Claim.eq(v0,v1);
                i++;
            });

        }

    }


}