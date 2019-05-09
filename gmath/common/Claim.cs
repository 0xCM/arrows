//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    using static global::mfunc;

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

    public static class Errors
    {
        public static Exception NotEqual(object lhs, object rhs, string file, int? line)
            => new Exception($"{file} line {line}: {lhs} != {rhs}") ;

        public static Exception NotLessThan(object lhs, object rhs, string file, int? line)
            => new Exception($"{file} line {line}: !({lhs} < {rhs})") ;

        public static Exception ItemsNotEqual(int index, object lhs, object rhs, string file, int? line)
            => new Exception($"{file} line {line}: lhs[{index}] = {lhs} != rhs[{index}] = {rhs}");

        public static Exception NotNonzero(string file, int? line)
            => new Exception($"{file} line {line}: The input value is required to be nonzero, and yet, it is");
        
        public static Exception NotTrue(string msg, string file, int? line)
            => new Exception($"{file} line {line}: {msg ?? "The source value is required to be true and yet it is false"}");

        public static Exception NotFalse(string msg, string file, int? line)
            => new Exception($"{file} line {line}: {msg ?? "The source value is required to be false and yet it is true"}");
    }

    public static class Claim
    {

        static Claim<T> define<T>(T lhs, T rhs, string name, Func<T,T,bool> predicate)
            => new Claim<T>(lhs,rhs,name,predicate);

        public static void fail(string msg)
            => throw new Exception(msg);

        public static T fail<T>(string msg)
            => throw new Exception(msg);

        public static void eq(Enum lhs, Enum rhs)
            => @true(lhs.Equals(rhs), $"{lhs} != {rhs}");

        public static void eq(string lhs, string rhs)
            => @true(lhs.Equals(rhs), $"{lhs} != {rhs}");

        [MethodImpl(Inline)]
        public static void eq<T>(T lhs, T rhs, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T> 
        {
            if(!lhs.Equals(rhs))
                throw new Exception($"{file} line {line}: lhs = {lhs} != {rhs} = rhs");
        }

        [MethodImpl(Inline)]
        public static void eq<T>(T lhs, T rhs, AppMsg msg)
            where T : struct, IEquatable<T> 
        {
            if(!lhs.Equals(rhs))
                throw new Exception(msg.ToString());
        }

        public static void eq<T>(Span128<T> lhs, Span128<T> rhs, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T> 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    throw Errors.ItemsNotEqual(i,lhs[i],rhs[i], file, line);
            }
        }

        public static void eq<T>(Span256<T> lhs, Span256<T> rhs,  [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T> 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    throw Errors.ItemsNotEqual(i,lhs[i],rhs[i], file, line);
            }
        }

        public static void eq<T>(Span<T> lhs, Span<T> rhs,  [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T> 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    throw Errors.ItemsNotEqual(i,lhs[i],rhs[i], file, line);
            }
        }

        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T> 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!lhs[i].Equals(rhs[i]))
                    throw Errors.ItemsNotEqual(i,lhs[i],rhs[i], file, line);
        }

        public static void eq<T>(T[] lhs, T[] rhs,  [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T> 
        {            
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!lhs[i].Equals(rhs[i]))
                    throw Errors.ItemsNotEqual(i,lhs[i],rhs[i], file, line);
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(num<T> lhs, num<T> rhs,  [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T> 
                => lhs == rhs ? true : throw Errors.NotEqual(lhs, rhs, file, line);

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs != rhs ? throw Errors.NotEqual(lhs, rhs, file, line) : true;        

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs != rhs ? throw Errors.NotEqual(lhs, rhs, file, line) : true;        

        [MethodImpl(Inline)]
        public static bool eq(bool lhs, bool rhs, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs != rhs ? throw Errors.NotEqual(lhs, rhs, file, line) : true;        

        [MethodImpl(Inline)]
        public static bool lt(int x, int y, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => !(x < y) ? throw Errors.NotLessThan(x,y,file,line) : true;

        [MethodImpl(Inline)]
        public static bool lt(ulong x, ulong y, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => !(x < y) ? throw Errors.NotLessThan(x,y,file,line) : true;

        [MethodImpl(Inline)]
        public static bool enumeq<T>(T lhs, T rhs, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : Enum
                => lhs.Equals(rhs) ? true : throw Errors.NotEqual(lhs, rhs, file, line);

        [MethodImpl(Inline)]
        public static string neq<T>(T x, T y, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct, IEquatable<T> 
                => define(x,y,"!=", (a,b) => a.Equals(b)).demand();

        [MethodImpl(Inline)]
        public static bool nonzero(int x, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => x != 0 ? true : throw Errors.NotNonzero(file,line);

        [MethodImpl(Inline)]
        public static bool nonzero(long x, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => x != 0 ? true : throw Errors.NotNonzero(file,line);

        [MethodImpl(Inline)]
        public static bool @true(bool src, string msg = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => src ? true : throw Errors.NotTrue(msg,file,line);

        [MethodImpl(Inline)]
        public static bool @false(bool x, string msg = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => !x ? true : throw Errors.NotFalse(msg,file,line);
    }
}