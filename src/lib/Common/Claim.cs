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

        public static T fail<T>(string msg)
            => throw new Exception(msg);

        public static void equals<T>(T expect, T actual)
        {
            if(!Object.Equals(expect,actual))
                fail($"{expect} != {actual}" );
        }

        public static string eq<T>(T x, T y)
            where T : struct, IEquatable<T> 
                => define(x,y,"==",  (a,b) => a.Equals(b)).demand();

        /// <summary>
        /// Demands that the first string is equal to the second
        /// </summary>
        /// <param name="lhs">The first string</param>
        /// <param name="rhs">The Second string</param>
        public static string eq(string lhs, string rhs)
            => define(lhs,rhs,"==",  (a,b) => a.Equals(b)).demand();

        public static string enumeq<T>(T x, T y)
            where T : Enum
                => define(x,y,"==",  (a,b) => a.Equals(b)).demand();

        public static string neq<T>(T x, T y)
            where T : struct, IEquatable<T> 
                => define(x,y,"!=", (a,b) => a.Equals(b)).demand();

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
        
        public static bool @true(bool x, string msg = null)
            => x ? true : fail<bool>(msg  ?? "Claim is not true");
            
    }
}