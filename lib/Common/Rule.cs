//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zcore;

    partial class Traits
    {

        public interface Rule : Formattable
        {
            string name {get;}

            uint arity {get;}
        }

        /// <summary>
        /// Characterizes a rule / function A->B
        /// </summary>
        /// <typeparam name="A">The function domain</typeparam>
        /// <typeparam name="B">The function codomain</typeparam>
        /// <remarks>The only difference between a rule and a function is 
        /// that a rule is presented as structure</remarks>
        public interface Rule<in A, out B> : Rule
        {
            /// <summary>
            /// Carries an element of the domain to an element of the codomain as
            /// specified by the function definition
            /// </summary>
            /// <param name="src">An element in the domain</param>
            B apply(A src); 

        }

        /// <summary>
        /// Characterizes a rule / function (A,B) -> C
        /// </summary>
        /// <typeparam name="A">The left function domain</typeparam>
        /// <typeparam name="B">The right function domain</typeparam>
        /// <typeparam name="C">The function codomain</typeparam>
        /// <remarks>The only difference between a rule and a function is 
        /// that a rule is presented as structure</remarks>
        public interface Rule<in A, in B, out C> : Rule
        {
            /// <summary>
            /// Carries an element of the domain to an element of the codomain as
            /// specified by the function definition
            /// </summary>
            /// <param name="src">An element in the domain</param>
            C apply(A a, B b); 

        }


        /// <summary>
        /// Characterizes a function realization
        /// </summary>
        /// <typeparam name="A">The function domain</typeparam>
        /// <typeparam name="B">The function codomain</typeparam>
        public interface Ruled<F,in A, out B> : Rule<A,B>
            where F : Ruled<F,A,B>, new()
        {

        }   

        /// <summary>
        /// Characterizes a function realization
        /// </summary>
        /// <typeparam name="A">The left function domain</typeparam>
        /// <typeparam name="B">The right function domain</typeparam>
        /// <typeparam name="C">The function codomain</typeparam>
        public interface Ruled<F, in A, in B, out C> : Rule<A,B,C>
            where F : Ruled<F,A,B,C>, new()
        {

        }         
        
    }

    public readonly struct Rule<A, B> : Traits.Ruled<Rule<A, B>, A, B>
    {
        static readonly string Description = $"{typename<A>()} -> {typename<B>()}";

        readonly Func<A,B> f;
        
        public Rule(Func<A,B> f, string name = null)
        {
            this.f = f;
            this.name =  name ?? Description;
        }
        
        public string name {get;}

        public uint arity
            => 1;

        public B apply(A src)
            => f(src);

        public string format()
            => name;            

        public override string ToString()
            => format();
    }

    public readonly struct Rule<A, B, C> : Traits.Ruled<Rule<A, B, C>, A, B, C>
    {
        static readonly string Description = $"{typename<A>()} -> {typename<B>()} -> {typename<C>()}";
        readonly Func<A,B,C> f;


        public Rule(Func<A,B,C> f, string name = null)
        {
            this.f = f;
            this.name =  name ?? Description;
        }


        public string name {get;}

        public uint arity
            => 2;

        public C apply(A a, B b)
            => f(a,b);

        public string format()
            => name;            

        public override string ToString()
            => format();
    }
}