//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
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

        }
        
        // IEnumerable<Vec128<T>> DefineStream()
        //     => UnarySrc.ToArray().Stream128();

        public virtual void TraverseStream()
        {
            // var i = 0;
            // iter(DefineStream(), _ => i++);            
            // trace($"Iterated a stream of {i} vectors");
            // Claim.eq(i, VecCount);
        }

        public virtual void ValidateStream()
        {
            // var vectors = DefineStream().ToReadOnlyList();
            // Claim.eq(VecCount, vectors.Count);                    


            // var i = 0;
            // IterOffsets(offset =>{
            //     var v0 = Vec128.define(UnarySrc.ToArray(), offset);
            //     var v1 = vectors[i];
            //     Claim.eq(v0,v1);
            //     i++;
            // });

        }

    }

    public class StreamTests
    {
        const string BasePath = P.InX128 + P.streams;

        [DisplayName(Path)]
        public class StreamUInt8 : StreamTest<StreamUInt8,byte>
        {
            public const string Path = BasePath + P.uint8;
                        
            public override void ValidateStream()
                => base.ValidateStream();

            public override void TraverseStream()
                => base.TraverseStream();
        }


        [DisplayName(Path)]
        public class StreamUFloat64 : StreamTest<StreamUFloat64,double>
        {
            public const string Path = BasePath + P.float64;
                        
            public override void ValidateStream()
                => base.ValidateStream();

            public override void TraverseStream()
                => base.TraverseStream();
        }        

        [DisplayName(Path)]
        public class StreamUInt32 : StreamTest<StreamUInt32,uint>
        {
            public const string Path = BasePath + P.uint32;
                        
            public override void ValidateStream()
                => base.ValidateStream();

            public override void TraverseStream()
                => base.TraverseStream();
        }        

        [DisplayName(Path)]
        public class StreamUInt64 : StreamTest<StreamUInt64,ulong>
        {
            public const string Path = P.InX128 + P.streams + P.uint64;
                        
            public override void ValidateStream()
                => base.ValidateStream();

            public override void TraverseStream()
                => base.TraverseStream();
        }        
    }
}