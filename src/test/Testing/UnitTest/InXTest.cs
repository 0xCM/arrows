//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    public abstract class InXTest<S,T> : UnitTest<S>
        where S : InXTest<S,T>
        where T : struct, IEquatable<T>
    {

        protected abstract int VecLen {get;}

        protected abstract int VecBitCount {get;}

        protected override string OpName {get;}

        protected InXTest(string opname, Interval<T>? domain = null)    
        {
            this.OpName = opname;
            this.Domain = domain ?? Defaults.get<T>().Domain;
            
        }

        protected Interval<T> Domain {get;}

        protected IEnumerable<T> Random(T min, T max)
            => Context.Random<T>().stream(min,max);

        protected IEnumerable<T> Random(Interval<T> domain)
            => Random(domain.left,domain.right);

        protected IEnumerable<T> Random()
            => Random(Domain);

        protected IReadOnlyList<T> RandomList(int len)
            => Random(Domain).Freeze(len);

        protected IEnumerable<T> Partition(T? step = null)
            => Domain.Discretize(step);

        protected string OpInfo<X,Y,Z>(X lhs, Y rhs, Z result)
            => $"{lhs} {OpName} {rhs} = {result}";
        

    }    

    public abstract class InX128Test<S,T> : InXTest<S,T>
        where S : InX128Test<S,T>
        where T : struct, IEquatable<T>
    {
        protected override int VecLen {get;}

        protected override int VecBitCount {get;}
        
        protected InX128Test(string opname, Interval<T>? domain = null)
            : base(opname,domain)
        {
            this.VecLen = Vec128<T>.Length;
            this.VecBitCount = Vec128<T>.BitCount;
        }

        protected IReadOnlyList<T> RandomList()
            => RandomList(VecLen);

        protected Vec128<T> RandomVector()        
            => Vec128.define(RandomList());

        protected IEnumerable<IReadOnlyList<T>> RandomLists(int? count = null)
        {
            for(var i = 0; i< (count ?? StreamLength); i++)
                 yield return RandomList();
        }
            
        protected IEnumerable<Vec128<T>> RandomVectors(int? count = null)        
        {
            for(var i = 0; i< (count ?? StreamLength); i++)
                 yield return RandomVector();
        }        
    }    

    public abstract class InX256Test<S,T> : InXTest<S,T>
        where S : InX256Test<S,T>
        where T : struct, IEquatable<T>
    {
        protected override int VecLen {get;}

        protected override int VecBitCount {get;}


        protected InX256Test(string opname, Interval<T> bounds)
            : base(opname,bounds)
        {
            this.VecLen = Vec256<T>.Length;
            this.VecBitCount = Vec256<T>.BitCount;

        }
        
        protected IEnumerable<Vec256<T>> RandomVectors(int count)        
        {
            for(var i = 0; i< count; i++)
                 yield return Vec256.define(Random().Freeze(VecLen));
        }
    }    
}