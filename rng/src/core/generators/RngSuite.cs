//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static As;

    /// <summary>
    /// Defines a suite of random number generators
    /// </summary>
    /// <typeparam name="N">The number of generators in the suite</typeparam>
    class RngSuite<N> : IRngSuite<N>
        where N : ITypeNat, new()
    {
        readonly IPolyrand[] members;

        static readonly int n = (int)new N().value;        

        public RngSuite(IPolyrand[] members)
        {
            this.members = members.ToArray();
            require(this.members.Length == n);
        }

        public RngSuite(IEnumerable<IPolyrand> members)
        {
            this.members = members.ToArray();
            require(this.members.Length == n);
        }

        public BlockVector<N, T> Next<T>() 
            where T : struct
        {
            var dst = BlockVector.Alloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>();
            return dst;
        }

        public BlockVector<N, T> Next<T>(T min) 
            where T : struct
        {
            var dst = BlockVector.Alloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(min);
            return dst;
        }

        public BlockVector<N, T> Next<T>(T min, T max) 
            where T : struct
        {
            var dst = BlockVector.Alloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(min,max);
            return dst;
        }

        public BlockVector<N, T> Next<T>(Interval<T> domain)
             where T : struct
        {
            var dst = BlockVector.Alloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(domain);
            return dst;
        }

        public IPolyrand Select(int index)
            => members[index];
    }

}