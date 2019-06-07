//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static nfunc;

    /// <summary>
    /// Reifies a nondegenerate interval of natural numbers
    /// </summary>
    public readonly struct NatInterval<K1,K2>
        where K1: ITypeNat, INatLt<K1,K2>, new()
        where K2 : ITypeNat, new()
        
    {
        public static Option<NatBetween<T,K1,K2>> contains<T>()
            where T : ITypeNat, new() => NatProve.tryBetween<T,K1,K2>();
                 
        public static IEnumerable<ulong> values()
        {
            for(var n = natu<K1>(); n <= natu<K2>(); n++)
                yield return n;
        }

        public NatInterval(K1 k1, K2 k2)
        {
            left = k1.value;
            right = k2.value;
            leftclosed = true;
            rightclosed = true;
            valid = nfunc.demand(left < right);
        }
        public Seq<ulong> members()
            => Seq.define(values());

        public bool member(uint candidate)
            => candidate >= left && candidate <= right;

        public bool member(object candidate)
            => candidate is uint 
             ? (member((uint)candidate)) 
             : false;

        public bool valid {get;}

        public ulong left {get;}

        public bool leftclosed {get;}

        public ulong right {get;}

        public bool rightclosed {get;}
            
        public bool empty 
            => false;
            
        public bool finite 
            => true;

        public bool discrete 
            => true;

        public IntervalKind kind 
            => IntervalKind.Closed;

        public Interval<ulong> canonical()
            => new Interval<ulong>(left,leftclosed,right,rightclosed);

        public string format()
            => canonical().Format();
        
        public override string ToString()
            => format();

    }
}