//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public abstract class AddTest<S,T> : InXBinOpTest<S,T>
        where S : AddTest<S,T>
        where T : struct, IEquatable<T>
    {                
        protected AddTest(Interval<T>? domain = null, int? streamlen = null)
            : base(P.add, domain, streamlen)        
        {

        }

        protected override Vec128BinOp<T> VecOp {get;} 
            = InXG.add<T>;

        protected override ListBinOp<T> ListOp {get;} 
            = PrimOps.add;
    }

    public class AddTests
    {
        const string BasePath = P.InX128 + P.add;        

        [DisplayName(Path)]
        public class AddInt8 : AddTest<AddInt8,sbyte>
        {
            public const string Path = BasePath + P.int8;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AddUInt8 : AddTest<AddUInt8,byte>
        {
            public const string Path = BasePath + P.uint8;
                
            public override void Verify()
                => base.Verify();                
        }

        [DisplayName(Path)]
        public class AddInt16 : AddTest<AddInt16,short>
        {
            public const string Path = BasePath + P.int16;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AddUInt16 : AddTest<AddUInt16,ushort>
        {
            public const string Path = BasePath + P.uint16;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AddInt32 : AddTest<AddInt32,uint>
        {
            public const string Path = BasePath + P.int32;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AddUInt32 : AddTest<AddUInt32,uint>
        {
            public const string Path = BasePath + P.uint32;

            public override void Verify()
                => base.Verify();
        }


        [DisplayName(Path)]
        public class AddInt64 : AddTest<AddInt64,long>
        {
            public const string Path = BasePath + P.int64;
                
            public override void Verify()
                => base.Verify();
                
        }

        [DisplayName(Path)]
        public class AddUInt64 : AddTest<AddUInt64,ulong>
        {
            public const string Path = BasePath + P.uint64;
                
            public override void Verify()
                => base.Verify();
        }        

        [DisplayName(Path)]
        public class AddFloat32 : AddTest<AddFloat32,float>
        {
            public const string Path = BasePath + P.float64;

            public override void Verify()
                => base.Verify();
        }

        [DisplayName(Path)]
        public class AddFloat64 : AddTest<AddFloat64,double>
        {
            public const string Path = BasePath + P.float64;

            public override void Verify()
                => base.Verify();
        }

    }

}