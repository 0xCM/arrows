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
    using System.Runtime.Serialization;
        
    using static mfunc;
    using static zfunc;

    public static class Claim
    {
        [MethodImpl(Inline)]
        public static void fail(string msg, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => throw ClaimException.Define(ClaimOpKind.Fail, $"Unconditional failure", caller, file, line);

        [MethodImpl(Inline)]
        public static bool eq(Enum lhs, Enum rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => lhs.Equals(rhs) ? true
                    : throw ClaimException.Define(ClaimOpKind.Eq, 
                        ErrorMessages.NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(string lhs, string rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => lhs.Equals(rhs) ? true
                    : throw ClaimException.Define(ClaimOpKind.Eq, 
                        ErrorMessages.NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct 
                => lhs.Equals(rhs) ? true
                    : throw ClaimException.Define(ClaimOpKind.Eq, 
                        ErrorMessages.NotEqual(lhs,rhs, caller, file, line));
        
        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs, AppMsg msg)
            where T : struct 
            => lhs.Equals(rhs) ? true
            : throw ClaimException.Define(ClaimOpKind.Eq, msg);
        
        public static void eq<T>(Span128<T> lhs, Span128<T> rhs,  [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    throw ClaimException.Define(ClaimOpKind.EqItem, 
                        ErrorMessages.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
            }
        }

        public static void eq<T>(Span256<T> lhs, Span256<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    throw ClaimException.Define(ClaimOpKind.EqItem, 
                        ErrorMessages.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
            }
        }

        public static void eq<T>(Span<T> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    throw ClaimException.Define(ClaimOpKind.EqItem, 
                        ErrorMessages.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
            }
        }

        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!lhs[i].Equals(rhs[i]))
                    throw ClaimException.Define(ClaimOpKind.EqItem, 
                        ErrorMessages.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
        }

        public static void eq<T>(T[] lhs, T[] rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct 
        {            
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!lhs[i].Equals(rhs[i]))
                    throw ClaimException.Define(ClaimOpKind.EqItem, 
                        ErrorMessages.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(num<T> lhs, num<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct 
                => lhs == rhs ? true 
                : throw ClaimException.Define(ClaimOpKind.Eq, 
                    ErrorMessages.NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs, [CallerFilePath] string file = null, 
            [CallerMemberName] string caller = null, [CallerLineNumber] int? line = null)
                => lhs == rhs ? true 
                : throw ClaimException.Define(ClaimOpKind.Eq, 
                    ErrorMessages.NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs, [CallerFilePath] string file = null, 
            [CallerMemberName] string caller = null, [CallerLineNumber] int? line = null)
                => lhs == rhs ? true 
                : throw ClaimException.Define(ClaimOpKind.Eq, 
                    ErrorMessages.NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(bool lhs, bool rhs, [CallerFilePath] string file = null, 
            [CallerMemberName] string caller = null,  [CallerLineNumber] int? line = null)
                => lhs == rhs ? true 
                    : throw ClaimException.Define(ClaimOpKind.Eq, 
                        ErrorMessages.NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lt(int lhs, int rhs, [CallerMemberName] string caller = null,  
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => lhs < rhs ? true 
                    : throw ClaimException.Define(ClaimOpKind.Eq, 
                        ErrorMessages.NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lt(ulong lhs, ulong rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => lhs < rhs ? true 
                    : throw ClaimException.Define(ClaimOpKind.Eq, 
                        ErrorMessages.NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool enumeq<T>(T lhs, T rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : Enum
                    => lhs.Equals(rhs) ? true 
                        : throw ClaimException.Define(ClaimOpKind.Eq, 
                            ErrorMessages.NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct 
                    => !lhs.Equals(rhs) ? true 
                        : throw ClaimException.Define(ClaimOpKind.Neq, 
                            ErrorMessages.Equal(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool nonzero(int x, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)        
                => x != 0 ? true 
                : throw ClaimException.Define(ClaimOpKind.Nonzero, AppMsg.Empty); 

        [MethodImpl(Inline)]
        public static bool nonzero(long x, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => x != 0 ? true 
                  : throw Errors.NotNonzero(caller, file, line);

        [MethodImpl(Inline)]
        public static bool @true(bool src, string msg = null, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => src ? true 
            : throw ClaimException.Define(ErrorMessages.NotTrue(msg, caller, file,line));

        [MethodImpl(Inline)]
        public static bool @false(bool x, string msg = null, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => !x ? true 
            : throw ClaimException.Define(ErrorMessages.NotFalse(msg, caller, file,line));
    }
}