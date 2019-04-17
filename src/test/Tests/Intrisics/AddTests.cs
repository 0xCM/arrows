//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public abstract class AddTest<S,T> : InXTest<S,T>
        where S : AddTest<S,T>
        where T : struct, IEquatable<T>
    {        
        protected static readonly InXAdd<T> InXOp = InXG.add<T>();
        
        protected AddTest(Interval<T>? domain = null, int? streamlen = null)
            : base(P.add, domain, streamlen)        
        {

        }

        protected IEnumerable<Vec128<T>> Results()
            => Results(InXOp.add);

        public virtual void Verify()
            => Verify(InXOp.add, PrimOps.add);        
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
        public class AddInt64 : AddTest<AddInt64,ulong>
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
        public class AddFloat64 : AddTest<AddFloat64,double>
        {
            public const string Path = BasePath + P.float64;

            public override void Verify()
                => base.Verify();
        }

    }

}