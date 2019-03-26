//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static zcore;

    public readonly struct Interval<K1,K2> 
        : Demands.Smaller<K1,K2>, 
          Traits.DiscreteInterval<uint>, 
          Traits.ClosedInterval<uint>
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
        
    {
        public static Option<Between<T,K1,K2>> contains<T>()
            where T : TypeNat, new() => Prove.tryBetween<T,K1,K2>();
                 
        public static IEnumerable<uint> values()
        {
            for(var n = natval<K1>(); n <= natval<K2>(); n++)
                yield return n;
        }

        public Interval(K1 k1, K2 k2)
        {
            left = k1.value;
            right = k2.value;
            leftclosed = true;
            rightclosed = true;
            valid = demand(left < right);
        }
        public Seq<uint> members()
            => Seq.define(values());

        public bool member(uint candidate)
            => candidate >= left && candidate <= right;

        public bool member(object candidate)
            => candidate is uint 
             ? (member((uint)candidate)) 
             : false;

        public bool valid {get;}

        public uint left {get;}

        public bool leftclosed {get;}

        public uint right {get;}

        public bool rightclosed {get;}
            
        public bool empty 
            => false;
            
        public bool finite 
            => true;

        public bool discrete 
            => true;

        public Interval<uint> canonical()
            => new Interval<uint>(left,leftclosed,right,rightclosed);

        public string format()
            => canonical().format();
        
        public override string ToString()
            => format();

    }
}