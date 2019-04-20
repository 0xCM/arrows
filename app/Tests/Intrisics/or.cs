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

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public abstract class OrTest<S,T> : InXBinOpTest<S,T>
        where S : OrTest<S,T>
        where T : struct, IEquatable<T>
    {        
        protected OrTest(Interval<T>? domain = null, int? sampleSize = null)
            : base("or", domain, sampleSize)        
        {

        }

        protected override Vec128BinOp<T> VecOp {get;} 
            = InXG.or;

        protected override IndexBinOp<T> IndexOp {get;} 
            = PrimOps.or;
        
    }

    class OrTests
    {
        const string BasePath = P.InX128 + P.or;


        [DisplayName(Path)]
        public class OrInt8 : OrTest<OrInt8, sbyte>
        {
            public const string Path = BasePath + P.int8;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class OrUInt8 : OrTest<OrUInt8, byte>
        {
            public const string Path = BasePath + P.uint8;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class OrInt16 : OrTest<OrInt16, short>
        {
            public const string Path = BasePath + P.int16;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class OrUInt16 : OrTest<OrUInt16, ushort>
        {
            public const string Path = BasePath + P.uint16;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class OrInt32 : OrTest<OrInt32, int>
        {
            public const string Path = BasePath + P.int32;

            public override void Verify()
                => base.Verify();
        }


        [DisplayName(Path)]
        public class OrUInt32 : OrTest<OrUInt32, uint>
        {
            public const string Path = BasePath + P.uint32;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class OrInt64 : OrTest<OrInt64, long>
        {
            public const string Path = BasePath + P.int64;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class OrUInt64 : OrTest<OrUInt64, ulong>
        {
            public const string Path = BasePath + P.uint64;

            public override void Verify()
                => base.Verify();
        } 


    }
 
}