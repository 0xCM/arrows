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

    public abstract class AvgTest<S,T> : InXTest<S,T>
        where S : AvgTest<S,T>
        where T : struct, IEquatable<T>
    {        
        
        protected AvgTest(Interval<T>? domain = null, int? streamlen = null)
            : base("avg", domain, streamlen)        
        {

        }

        protected abstract Index<T> avg(Index<T> lhs, Index<T> rhs);


        protected IEnumerable<Vec128<T>> Results()
            => items<Vec128<T>>();
        
        public virtual void Verify(){}
            
        
    }

    public class AvgTests
    {
        const string BasePath = P.InX128 + P.avg;

        [DisplayName(Path)]
        public class AvgUInt8 : AvgTest<AvgUInt8, byte>
        {
            public const string Path = BasePath + P.uint8;

            public AvgUInt8()
                : base(Interval.closed<byte>(10, 50))
                {

                }
            public override void Verify()
                => base.Verify();

            protected override Index<byte> avg(Index<byte> lhs, Index<byte> rhs)
            {
                var dst = alloc<byte>(VecLength);
                iter(VecLength, i => dst[i] = lhs[i].Add(rhs[i],1).RShift(1));
                return dst;
            }
        }

        [DisplayName(Path)]
        public class AvgUInt16 : AvgTest<AvgUInt16, ushort>
        {
            public const string Path = BasePath + P.uint8;

            public AvgUInt16()
                : base(Interval.closed<ushort>(50, 2500))
                {

                }

            public override void Verify()
                => base.Verify();

            protected override Index<ushort> avg(Index<ushort> lhs, Index<ushort> rhs)
            {
                var dst = alloc<ushort>(VecLength);
                iter(VecLength, i => dst[i] = lhs[i].Add(rhs[i],1).RShift(1));
                return dst;
            }
        }

    }
}

