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
        
    using static zfunc;
    using static ErrorMessages;
    using Member = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class Claim
    {
        public static ClaimException failed(ClaimOpKind op, AppMsg msg)
            => ClaimException.Define(op, msg);
        
        static ClaimException failed(ClaimOpKind op, string msg, string caller, string file, int? line)
            => ClaimException.Define(op, msg, caller, file, line);

        [MethodImpl(Inline)]
        public static void fail(string msg, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimOpKind.Fail, $"Unconditional failure", caller, file, line);

        [MethodImpl(Inline)]
        public static bool eq(Enum lhs, Enum rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true
                : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(string lhs, string rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true
                : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq<T>(T[] lhs, T[] rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Eq(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool neq<T>(T[] lhs, T[] rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !lhs.Eq(rhs) ? true : throw failed(ClaimOpKind.NEq, NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, Equal(lhs, rhs, caller, file, line));

        public static void eq(bool[] lhs, bool[] rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
        {            
            for(var i = 0; i< length(lhs,rhs); i++)
                if(lhs[i] != rhs[i])
                    throw failed(ClaimOpKind.EqItem, ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
        }

        [MethodImpl(Inline)]
        public static bool eq(bool lhs, bool rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
                => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(Bit lhs, Bit rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
                => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(byte lhs, byte rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(sbyte lhs, sbyte rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(short lhs, short rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(ushort lhs, ushort rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(int lhs, int rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(int lhs, int rhs, string msg, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, AppMsg.Define(msg, SeverityLevel.Error, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(long lhs, long rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(long lhs, long rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, msg);

        [MethodImpl(Inline)]
        public static bool eq(float lhs, float rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool eq(double lhs, double rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lt(int lhs, int rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs < rhs ? true : throw failed(ClaimOpKind.Eq, NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lt(uint lhs, uint rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs < rhs ? true : throw failed(ClaimOpKind.Eq, NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lt(ulong lhs, ulong rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs < rhs ? true : throw failed(ClaimOpKind.Eq, NotLessThan(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]
        public static bool lt(float lhs, float rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs < rhs ? true : throw failed(ClaimOpKind.Eq, NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lt(double lhs, double rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs < rhs ? true : throw failed(ClaimOpKind.Eq, NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lteq(int lhs, int rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs <= rhs ? true : throw failed(ClaimOpKind.Eq, NotLessThanOrEqual(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]
        public static bool lteq(uint lhs, uint rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs <= rhs ? true : throw failed(ClaimOpKind.LtEq, NotLessThanOrEqual(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]
        public static bool lteq(long lhs, long rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs <= rhs ? true : throw failed(ClaimOpKind.LtEq, NotLessThanOrEqual(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]
        public static bool lteq(ulong lhs, ulong rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs <= rhs ? true : throw failed(ClaimOpKind.LtEq, NotLessThanOrEqual(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]
        public static bool lteq(float lhs, float rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs <= rhs ? true : throw failed(ClaimOpKind.LtEq, NotLessThanOrEqual(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]
        public static bool lteq(double lhs, double rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs <= rhs ? true : throw failed(ClaimOpKind.LtEq, NotLessThanOrEqual(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]
        public static bool gt(long lhs, long rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs > rhs ? true : throw failed(ClaimOpKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gt(ulong lhs, ulong rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs > rhs ? true : throw failed(ClaimOpKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gt(float lhs, float rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs > rhs ? true : throw failed(ClaimOpKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gteq(float lhs, float rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs >= rhs ? true : throw failed(ClaimOpKind.Eq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gt(double lhs, double rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs > rhs ? true : throw failed(ClaimOpKind.Eq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gteq(double lhs, double rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs >= rhs ? true : throw failed(ClaimOpKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool yea(bool src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => src ? true 
                : throw ClaimException.Define(NotTrue(msg, caller, file,line));

        [MethodImpl(Inline)]
        public static bool nea(bool x, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !x ? true : throw ClaimException.Define(NotFalse(msg, caller, file,line));

        [MethodImpl(Inline)]
        public static unsafe bool notnull(void* p, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => (p != null) ? true : throw new ArgumentNullException(AppMsg.Define($"Pointer was null", SeverityLevel.Error, caller,file,line).ToString());

        [MethodImpl(Inline)]
        public static bool notnull<T>(T src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !(src is null) ? true : throw new ArgumentNullException(AppMsg.Define($"Argument was null", SeverityLevel.Error, caller,file,line).ToString());

        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(gmath.neq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        [MethodImpl(Inline)]
        public static void eq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => yea(lhs.Eq(rhs), null, caller, file, line);

        [MethodImpl(Inline)]
        public static void eq(Span<char> lhs, ReadOnlySpan<char> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => yea(lhs.Eq(rhs), null, caller, file, line);

        [MethodImpl(Inline)]
        public static void eq(Span<char> lhs, Span<char> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => yea(lhs.Eq(rhs), null, caller, file, line);

        [MethodImpl(Inline)]
        public static void eq<T>(Span<T> lhs, Span<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => eq(lhs.ReadOnly(), rhs.ReadOnly(), caller, file, line);
 
        [MethodImpl(Inline)]
        public static void eq<T>(Span128<T> lhs, Span128<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => eq(lhs.Unblock(), rhs.Unblock(), caller, file, line);

        [MethodImpl(Inline)]
        public static void eq<T>(Span256<T> lhs, Span256<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => eq(lhs.Unblocked, rhs.Unblocked, caller, file, line);
 
        /// <summary>
        /// Asserts equality for two spans of natural dimension MxN 
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void eq<M,N,T>(Span<M,N,T> lhs, Span<M,N,T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct 
                => eq(lhs.Unsized, rhs.Unsized, caller, file, line);
 
    }
}