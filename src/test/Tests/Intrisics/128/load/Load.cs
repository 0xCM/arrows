//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    public abstract class LoadTest<S,T> : InXTest<S,T>
        where S : LoadTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly InXLoad<T> InXOp = InXG.load<T>();

        public const string BasePath = P.InX128 + P.load;

        public LoadTest()
            : base(P.load)
        {

        }

        void LoadSpan(ArraySegment<T> seg)
        {
            var v0 = Vec128.define(seg);
            var v1 = InXOp.load(seg);
            Claim.eq(v0,v1);

        }

        public virtual void LoadSpans()
            => IterSegments(LoadSpan);

        void LoadArray(int offset)
        {
            var src0 = Arr.SubArray(SrcArray, offset, VecLength);
            var src1 = SrcArray[offset..offset + VecLength];
            var v1 = Vec128.define(src0);
            var v2 = Vec128.define(src1);
            Claim.eq(v1,v2);

            var v3 = InXOp.load(src0,0);
            var v4 = InXOp.load(src1,0);
            Claim.eq(v3,v1);
            Claim.eq(v4,v2);

            var v5 = InXOp.load(SrcArray, offset);
            Claim.eq(v5, v1);                
        }

        public virtual void LoadArrays()
            => IterOffsets(LoadArray);
    }
}