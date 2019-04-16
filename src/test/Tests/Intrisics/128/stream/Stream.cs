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
            this.Src = RandomArray(Domain, SampleSize);
        }
        
        protected T[] Src {get;}

        protected IEnumerable<Vec128<T>> DefineStream()
            => InX128G.stream<T>(Src);

        protected void IterateStream()
        {
            var i = 0;
            iter(DefineStream(), _ => i++);            
            trace($"Interated a stream of {i} vectors");
        }

        protected void ValidateStream()
        {
            var vectors = DefineStream().ToReadOnlyList();
            Claim.eq(VecCount, vectors.Count);                    

            for(int i = 0, pos = 0; i< VecCount; i++, pos += VecLength)
            {
                var v0 = Vec128.define(Src, pos);
                var v1 = vectors[i];
                Claim.eq(v0,v1);
            }            
        }

    }


}