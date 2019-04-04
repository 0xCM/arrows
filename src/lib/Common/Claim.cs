//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;


    public readonly struct Claim<T>
    {
        public Claim(T lhs, T rhs, string name,  Func<T,T,bool> predicate)
        {
            this.name = name;
            this.lhs = lhs;            
            this.rhs = rhs;
            this.predicate = predicate;
        }

        Func<T,T,bool> predicate {get;}
        
        public string name {get;}
        public T lhs {get;}

        public T rhs {get;}

        public string demand()
        {
            if(!predicate(lhs,rhs))
                throw new Exception($"The claim {lhs} {name} {rhs} does not hold");
            else
                return $"The claim {lhs} {name} {rhs} is satisfied";
        }

    }

    public static class Claim
    {

        static Claim<T> define<T>(T lhs, T rhs, string name, Func<T,T,bool> predicate)
            => new Claim<T>(lhs,rhs,name,predicate);

        public static void fail(string msg)
            => throw new Exception(msg);

        public static string eq<T>(T x, T y)
            where T : Equatable<T>, new()        
                => define(x,y,"==",  (a,b) => a.eq(b)).demand();
                    
        public static string neq<T>(T x, T y)
            where T : Equatable<T>, new()
                => define(x,y,"!=", (a,b) => a.neq(b)).demand();

        public static string lt<T>(T x, T y)
            where T : Operative.Ordered<T>, new()
                => define(x,y,"<", new T().lt).demand();

        public static string lteq<T>(T x, T y)
            where T : Operative.Ordered<T>, new()
                => define(x,y,"<=", new T().lteq).demand();

        public static void gt<T>(T x, T y)
            where T : Operative.Ordered<T>, new()
                => define(x,y,">", new T().gt).demand();

        public static void gteq<T>(T x, T y)
            where T : Operative.Ordered<T>, new()
                => define(x,y,">=", new T().gteq).demand();    
    }
}