//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zcore;
    using static zfunc;


    public readonly struct Rule<A, B> : IRuled<Rule<A, B>, A, B>
    {
        static readonly string Description = $"{typename<A>()} -> {typename<B>()}";

        readonly Func<A,B> f;
        
        public Rule(Func<A,B> f, string name = null)
        {
            this.f = f;
            this.RuleName =  name ?? Description;
        }
        
        public string RuleName {get;}

        public uint Arity
            => 1;

        public B apply(A src)
            => f(src);

        public string format()
            => RuleName;            

        public override string ToString()
            => format();
    }

    public readonly struct Rule<A, B, C> : IRuled<Rule<A, B, C>, A, B, C>
    {
        static readonly string Description = $"{typename<A>()} -> {typename<B>()} -> {typename<C>()}";
        readonly Func<A,B,C> f;


        public Rule(Func<A,B,C> f, string name = null)
        {
            this.f = f;
            this.RuleName =  name ?? Description;
        }


        public string RuleName {get;}

        public uint Arity
            => 2;

        public C apply(A a, B b)
            => f(a,b);

        public string format()
            => RuleName;            

        public override string ToString()
            => format();
    }
}