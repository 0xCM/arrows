//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Diagnostics
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
        
    using static zfunc;

    using static ErrorMessages;
    using Member = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Span256;
    using static Span128;

    public static class Require
    {

        public static void RequireEq<T>(this Span128<T> lhs, Span128<T> rhs,  [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        public static void RequireEq<T>(this Span256<T> lhs, Span256<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        public static void RequireEq<T>(this Span<T> lhs, Span<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(num<T> lhs, num<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs == rhs ? true : 
                    throw Errors.NotEqual(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => gmath.neq(lhs,rhs) ? true : 
                    throw Errors.Equal(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        public static bool nonzero<T>(T x, [Member] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : struct 
                => gmath.nonzero(x) ? true 
                : throw Errors.NotNonzero(caller,file,line);

        [MethodImpl(Inline)]
        public static bool numeq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => gmath.eq(lhs,rhs) ? true 
                : throw Errors.Equal(lhs,rhs);

        public static void numeq<T>(T[] lhs, T[] rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {            
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

    }

}