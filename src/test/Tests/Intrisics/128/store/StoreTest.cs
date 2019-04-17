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


    public abstract class StoreTest<S,T> : InXTest<S, T>
        where S : StoreTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly InXStore<T> InXOp = InXG.store<T>();

        public const string BasePath = P.InX128 + P.store;


        public StoreTest()
            : base(P.store)
        {

        }

        public virtual void StoreVector()
        {   
            var dst = alloc<T>(VecLength);
            foreach(var v0 in SrcVectors)
            {                
                InXOp.store(v0,dst);
                var v1 = Vec128.define(dst);
                Claim.eq(v0,v1);
                
            }

        }

        public virtual void StoreVectors()
        {   
            var dst = alloc<T>(VecLength*VecCount);
            var src = SrcVectors.ToReadOnlyList();
            InXOp.store(src,dst);
            IterOffsets((c,i) => Claim.eq(src[c],Vec128.define(dst,i)));

        }


    }

    public class StoreTests
    {

        [DisplayName(Path)]
        public sealed class StoreInt64 : StoreTest<StoreInt64, long>
        {
            public const string Path = StoreInt64.BasePath + P.int64;
                
            public override void StoreVector()
                => base.StoreVector();

            public override void StoreVectors()
                => base.StoreVectors();
        }


        [DisplayName(Path)]
        public sealed class StoreUInt64 : StoreTest<StoreUInt64, ulong>
        {
            public const string Path = StoreUInt64.BasePath + P.uint64;
                
            public override void StoreVector()
                => base.StoreVector();

            public override void StoreVectors()
                => base.StoreVectors();
        }

        [DisplayName(Path)]
        public sealed class StoreFloat32 : StoreTest<StoreFloat32, float>
        {
            public const string Path = StoreFloat32.BasePath + P.float32;
                
            public override void StoreVector()
                => base.StoreVector();

            public override void StoreVectors()
                => base.StoreVectors();
        }

        [DisplayName(Path)]
        public sealed class StoreFloat64 : StoreTest<StoreFloat64, double>
        {
            public const string Path = StoreFloat64.BasePath + P.float64;
                
            public override void StoreVector()
                => base.StoreVector();

            public override void StoreVectors()
                => base.StoreVectors();
        }

    }
}