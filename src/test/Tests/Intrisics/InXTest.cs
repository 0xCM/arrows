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

    public abstract class InXTest<S> : UnitTest<S>
        where S : InXTest<S>
    {


        protected InXTest(int? sampleSize = null)
            : base(sampleSize)    
        {
        }

        protected IEnumerable<T> Partition<T>(Interval<T> domain, T? step = null)
            where T : struct, IEquatable<T>
            => domain.Discretize(step);

        protected IEnumerable<T> Random<T>(T min, T max)
            where T : struct, IEquatable<T>
                => Context.Random<T>().stream(min,max);

        protected IEnumerable<T> Random<T>(Interval<T> domain)
            where T : struct, IEquatable<T>
                => Random(domain.left,domain.right);

        protected T[] RandomArray<T>(T min, T max, int len)
            where T : struct, IEquatable<T>
                => Random(min,max).TakeArray(len);

        protected T[] RandomArray<T>(T min, T max, uint len)
            where T : struct, IEquatable<T>
                => Random(min,max).TakeArray((int)len);

        protected T[] RandomArray<T>(Interval<T> domain, int len)
            where T : struct, IEquatable<T>
                => Random(domain).TakeArray(len);

        protected T[] RandomArray<T>(Interval<T> domain, uint len)
            where T : struct, IEquatable<T>
                => Random(domain).TakeArray((int)len);

        protected IEnumerable<T[]> RandomArrays<T>(T min, T max, int len)
            where T : struct, IEquatable<T>
        {
            while(true)
                yield return RandomArray(min,max,len);
        }

        protected IEnumerable<T[]> RandomArrays<T>(Interval<T> domain, int len)
            where T : struct, IEquatable<T>
        {
            while(true)
                yield return RandomArray(domain,len);
        }

        protected IReadOnlyList<T> RandomList<T>(T min, T max, int len)
            where T : struct, IEquatable<T>
                => Random(min,max).Freeze(len);

        protected IReadOnlyList<T> RandomList<T>(T min, T max, uint len)
            where T : struct, IEquatable<T>
                => RandomList<T>(min,max,(int)len);

        protected IReadOnlyList<T> RandomList<T>(Interval<T> domain, int len)
            where T : struct, IEquatable<T>
                => Random(domain).Freeze(len);

    }

    public abstract class InXTest<S,T> : InXTest<S>
        where S : InXTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly int PrimSize = Vec128<T>.PrimSize;

        protected static readonly int VecLength = Vec128<T>.Length;

        protected override string OpName {get;}

        protected int VecCount
            => SampleSize / VecLength;

        protected InXTest(string opname, Interval<T>? domain = null, int? sampleSize = null)
            :base(sampleSize)
        {
            this.OpName = opname;
            this.Domain = domain ?? Defaults.get<T>().Domain;            
        }

        protected Interval<T> Domain {get;}

        protected IEnumerable<T> Random(T min, T max)
            => Random<T>(min,max);

        protected IEnumerable<T> Random(Interval<T> domain)
            => Random(domain.left,domain.right);

        protected IEnumerable<T> Random()
            => Random(Domain);

        protected IEnumerable<T> Random(int count)
            => Random(Domain).Take(count);

        protected T[] RandomArray(int? len = null)
            => RandomArray(Domain,len ?? SampleSize);

        protected IReadOnlyList<T> RandomList(int? len = null)
            => RandomList<T>(Domain,len ?? SampleSize);
        protected IReadOnlyList<T> RandomList(uint? len = null)
            => RandomList<T>(Domain, (int) (len ?? (uint)SampleSize));

        protected IEnumerable<T> Partition(T? step = null)
            => Partition(Domain,step);

        protected string OpInfo<X,Y,Z>(X lhs, Y rhs, Z result)
            => $"{lhs} {OpName} {rhs} = {result}";

        protected IReadOnlyList<T> RandList128()
            => RandomList(VecLength);

        protected T[] RandArray128()
            => RandomArray(VecLength);

        protected Vec128<T> RandVec128()        
            => Vec128.define(RandomArray(VecLength));

        protected IEnumerable<T[]> RandArrays128(int? count = null)
        {
            for(var i = 0; i< (count ?? SampleSize); i++)
                 yield return RandArray128();
        }

        protected IEnumerable<IReadOnlyList<T>> RandLists128(int? count = null)
        {
            for(var i = 0; i< (count ?? SampleSize); i++)
                 yield return RandList128();
        }
            
        protected IEnumerable<Vec128<T>> RandVecs128(int? count = null)        
        {
            for(var i = 0; i< (count ?? SampleSize); i++)
                 yield return RandVec128();
        }        


    }    


}