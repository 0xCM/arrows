//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using static zcore;

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

        public static void eq(Enum x, Enum y)
            => @true(x.Equals(y), $"{x} != {y}");

        public static string eq<T>(T x, T y)
            where T : struct, IEquatable<T> 
                => define(x,y,"==",  (a,b) => a.Equals(b)).demand();

        public static void eq<T>(T[] lhs, T[] rhs)
            where T : struct, IEquatable<T> 
        {
            
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    fail($"lhs[{i}] = {lhs[i]} != rhs[{i}] = {rhs[i]}");
            }
        }
        public static void eq<T>(T x, T y, string msg)
            where T : struct, IEquatable<T> 
        {
            if(not(x.Equals(y)))
                fail($"{x} != {y}: {msg}");
        }

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

        public static void nonzero(int x)
        {
            if(x == 0)
                fail("The input value is required to be nonzero, and yet, it is 0");
        }
            
        public static bool @true(bool x, string msg = null)
            => x ? true : fail<bool>(msg  ?? "Claim is not true");

        public static bool @false(bool x, string msg = null)
            => !x ? true : fail<bool>(msg  ?? "Claim is not false");
    }
}