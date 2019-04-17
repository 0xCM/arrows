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
            => IterUnarySegments(LoadSpan);

        void LoadArray(int offset)
        {
            var src0 = Arr.SubArray(UnarySrc, offset, VecLength);
            var src1 = UnarySrc[offset..offset + VecLength];
            var v1 = Vec128.define(src0);
            var v2 = Vec128.define(src1);
            Claim.eq(v1,v2);

            var v3 = InXOp.load(src0,0);
            var v4 = InXOp.load(src1,0);
            Claim.eq(v3,v1);
            Claim.eq(v4,v2);

            var v5 = InXOp.load(UnarySrc, offset);
            Claim.eq(v5, v1);                
        }

        public virtual void LoadArrays()
            => IterOffsets(LoadArray);
    }

    public class LoadTests
    {
        
        const string BasePath = P.InX128 + P.load;        

        [DisplayName(Path)]
        public class LoadUInt8 : LoadTest<LoadUInt8, byte>
        {
            public const string Path = BasePath + P.uint8;

            public override void LoadSpans()
                => base.LoadSpans();
            
            public override void LoadArrays()
                => base.LoadArrays();
        }

        [DisplayName(Path)]
        public class LoadInt8 : LoadTest<LoadInt8, sbyte>
        {
            public const string Path = BasePath + P.int8;

            public override void LoadSpans()
                => base.LoadSpans();
            
            public override void LoadArrays()
                => base.LoadArrays();
        }

        
        [DisplayName(Path)]
        public class LoadInt32 : LoadTest<LoadInt32, int>
        {
            public const string Path = BasePath + P.uint32;
                
            public void Define()
            {
                var src = new int[]{-50,-25,25,50};
                var v1 = Vec128.define(src[0],src[1],src[2],src[3]);
                var v2 = Vec128.define(src);
                Claim.eq(v1,v2);
            }

            public void LoadParams()
            {
                var src = new int[4]{1,2,3,4};
                var v0 = Vec128.define(src);
                var v1 = InX.load(1,2,3,4);
                Claim.eq(v0,v1);
            }

            public override void LoadSpans()
                => base.LoadSpans();
            
            public override void LoadArrays()
                => base.LoadArrays();
        }


        [DisplayName(Path)]
        public class LoadUInt32 : LoadTest<LoadUInt32, uint>
        {
            public const string Path = BasePath + P.uint32;
                
            public void LoadParams()
            {
                var src = new uint[4]{1,2,3,4};
                var v0 = Vec128.define(src);
                var v1 = InX.load(1u,2u,3u,4u);
                Claim.eq(v0,v1);
            }

            public override void LoadSpans()
                => base.LoadSpans();
            
            public override void LoadArrays()
                => base.LoadArrays();
        }

        [DisplayName(Path)]
        public class LoadInt64 : LoadTest<LoadInt64, long>
        {
            public const string Path = BasePath + P.int64;

            public void LoadParams()
            {
                var src = new long[2]{1,2};
                var v0 = Vec128.define(src);
                var v1 = InX.load(1L,2L);
                var v2 = Vec128.define(src.ToSpan128());
                Claim.eq(v0,v1);
                Claim.eq(v0,v2);
            }

            public override void LoadSpans()
                => base.LoadSpans();
            
            public override void LoadArrays()
                => base.LoadArrays();

        }

        [DisplayName(Path)]
        public class LoadUInt64 : LoadTest<LoadUInt64, ulong>
        {
            public const string Path = BasePath + P.uint64;

            public void LoadParams()
            {
                var src = new ulong[2]{1,2};
                var v0 = Vec128.define(src);
                var v1 = InX.load(1ul,2ul);
                var v2 = Vec128.define(src.ToSpan128());
                Claim.eq(v0,v1);
                Claim.eq(v0,v2);
            }

            public override void LoadSpans()
                => base.LoadSpans();
            
            public override void LoadArrays()
                => base.LoadArrays();

        }

        [DisplayName(Path)]
        public class LoadFloat64 : LoadTest<LoadFloat64, double>
        {
            public const string Path = BasePath + P.float64;
                
            public void LoadParams()
            {
                var src = new double[2]{1.707,2.225};
                var v0 = Vec128.define(src);
                var v1 = InX.load(1.707,2.225);
                Claim.eq(v0,v1);
            }

            public override void LoadSpans()
                => base.LoadSpans();
            
            public override void LoadArrays()
                => base.LoadArrays();

        }

    }    
}