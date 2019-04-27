//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    public abstract class StoreTest<S,T> : InXTest<S, T>
        where S : StoreTest<S,T>
        where T : struct, IEquatable<T>
    {
        public StoreTest()
            : base(P.store)
        {

        }

        public virtual void StoreVectors()
        {   
            var vectors = map(UnarySrcVectors, v => Vec128.define(v)).ToArray();
            Claim.eq(VecCount, vectors.Length);

            var dst = alloc<T>(VecLength*VecCount);
            
            for(int i=0, offset = 0; i< VecCount; i++, offset += VecLength)            
                InXVec128Ops.store(vectors[i], dst, offset);                    


            for(int i = 0, j=0; i< dst.Length; i+= VecLength, j++)
            {
                var vDst = Vec128.define(dst, i);
                var vSrc = vectors[j];
                Claim.eq(vDst,vSrc);
            }

            for(int i=0, offset = 0; i < VecCount; i++, offset+= VecLength)
            {

                var vDst = Arr.SubArray(dst,offset,VecLength);
                var vSrc = vectors[i];
                for(var j = 0; j<VecLength; j++)
                    Claim.eq(vDst[j], vSrc[j]);
            }
        }
    }

    public class StoreTests
    {
        public const string BasePath = P.InX128 + P.store;

        [DisplayName(Path)]
        public sealed class StoreInt64 : StoreTest<StoreInt64, long>
        {
            public const string Path = BasePath + P.int64;

            public override void StoreVectors()
                => base.StoreVectors();                
        }

        [DisplayName(Path)]
        public sealed class StoreUInt64 : StoreTest<StoreUInt64, ulong>
        {
            public const string Path = BasePath + P.uint64;

            public override void StoreVectors()
                => base.StoreVectors();                
        }


        [DisplayName(Path)]
        public sealed class StoreFloat64 : StoreTest<StoreFloat64, double>
        {
            public const string Path = BasePath + P.float64;

            public override void StoreVectors()
                => base.StoreVectors();                
        }
    }
}