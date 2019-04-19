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

    public abstract class AndTest<S,T> : InXBinOpTest<S,T>
        where S : AndTest<S,T>
        where T : struct, IEquatable<T>
    {        
        protected AndTest(Interval<T>? domain = null, int? sampleSize = null)
            : base("and", domain, sampleSize)        
        {

        }

        static Vec128<T> and(Vec128<T> lhs, Vec128<T> rhs)
            => InXG.and(lhs,rhs);
        
        protected override Vec128BinOp<T> VecOp {get;} 
            = and;

        protected override ListBinOp<T> ListOp {get;} 
            = PrimOps.and;
        
    }

    public class AndTests
    {
        const string BasePath = P.InX128 + P.bits + P.and;

        [DisplayName(Path)]
        public class AndInt8 : AndTest<AndInt8, sbyte>
        {
            public const string Path = BasePath + P.int8;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AndUInt8 : AndTest<AndUInt8, byte>
        {
            public const string Path = BasePath + P.uint8;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AndInt16 : AndTest<AndInt16, short>
        {
            public const string Path = BasePath + P.int16;

            public override void Verify()
                => base.Verify();
        }


        [DisplayName(Path)]
        public class AndUInt16 : AndTest<AndUInt16, ushort>
        {
            public const string Path = BasePath + P.uint16;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AndInt32 : AndTest<AndInt32, int>
        {
            public const string Path = BasePath + P.int32;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AndUInt32 : AndTest<AndUInt32, uint>
        {
            public const string Path = BasePath + P.uint32;

            public override void Verify()
                => base.Verify();
        }


        [DisplayName(Path)]
        public class AndInt64 : AndTest<AndInt64, long>
        {
            public const string Path = BasePath + P.int64;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AndUInt64 : AndTest<AndUInt64, long>
        {
            public const string Path = BasePath + P.uint64;

  
            public override void Verify()
                => base.Verify();
            
        } 
    } 
}