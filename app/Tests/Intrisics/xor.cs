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

    public abstract class XOrTest<S,T> : InXBinOpTest<S,T>
        where S : XOrTest<S,T>
        where T : struct, IEquatable<T>
    {        
        protected XOrTest(Interval<T>? domain = null, int? sampleCount = null)
            : base("xor", domain, sampleCount)        
        {

        }

        protected override Vec128BinOp<T> VecOp {get;}
              = Vec128Ops.xor<T>();

        protected override IndexBinOp<T> IndexOp {get;} 
             = PrimOps.xor;        
    }

    class XOrTests
    {
        const string BasePath = P.InX128 + P.xor;

        [DisplayName(Path)]
        public class XOrInt8 : XOrTest<XOrInt8, sbyte>
        {
            public const string Path = BasePath + P.int8;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class XOrUInt8 : XOrTest<XOrUInt8, byte>
        {
            public const string Path = BasePath + P.uint8;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class XOrInt16 : XOrTest<XOrInt16, short>
        {
            public const string Path = BasePath + P.int16;

            public override void Verify()
                => base.Verify();
        }


        [DisplayName(Path)]
        public class XOrUInt16 : XOrTest<XOrUInt16, ushort>
        {
            public const string Path = BasePath + P.uint16;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class XOrInt32 : XOrTest<XOrInt32, int>
        {
            public const string Path = BasePath + P.int32;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class XOrUInt32 : XOrTest<XOrUInt32, uint>
        {
            public const string Path = BasePath + P.uint32;

            public override void Verify()
                => base.Verify();
        }


        [DisplayName(Path)]
        public class XOrInt64 : XOrTest<XOrInt64, long>
        {
            public const string Path = BasePath + P.int64;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class XOrUInt64 : XOrTest<XOrUInt64, ulong>
        {
            public const string Path = BasePath + P.uint64;

            public override void Verify()
                => base.Verify();
        } 
    } 
}