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

        /// <summary>
        /// Fails unconditionally
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        [MethodImpl(Inline)]
        public static void fail(string msg, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimOpKind.Fail, AppMsg.Error(msg, caller, file,line));

        /// <summary>
        /// Asserts the equality of two enum values
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        [MethodImpl(Inline)]
        public static bool eq(Enum lhs, Enum rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true
                : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two strings
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        [MethodImpl(Inline)]
        public static bool eq(string lhs, string rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true
                : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two values via whatever equals operator is implemented
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of the content of two arrays
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        [MethodImpl(Inline)]
        public static bool eq<T>(T[] lhs, T[] rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Eq(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts the equality of two boolean arrays
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
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
        public static bool neq(long lhs, long rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ClaimOpKind.NEq, Equal(lhs, rhs, caller, file, line));

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
        public static bool numeq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => gmath.eq(lhs,rhs) ? true : throw Errors.Equal(lhs,rhs);

        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.ClaimEqual(rhs, caller,file,line);

        [MethodImpl(Inline)]
        public static void eq<T>(Span<T> lhs, Span<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.ClaimEqual(rhs, caller,file,line);
 
        [MethodImpl(Inline)]
        public static void eq<T>(Span128<T> lhs, Span128<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.ClaimEqual(rhs, caller,file,line);

        [MethodImpl(Inline)]
        public static void eq<T>(Span256<T> lhs, Span256<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.ClaimEqual(rhs, caller,file,line);

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, Equal(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool within<T>(T x, Interval<T> range, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
                => range.Contains(x) ? true : throw failed(ClaimOpKind.Between, NotBetween(x,range.Left, range.Right, caller, file, line));

        [MethodImpl(Inline)]
        public static bool within<T>(T x, T lower, T upper, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
        {
            var range = closed(lower,upper);
            return range.Contains(x) 
                ? true 
                : throw failed(ClaimOpKind.Between, NotBetween(x,range.Left, range.Right, caller, file, line));
        }

        [MethodImpl(Inline)]
        public static bool between<T>(T x, T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
                => gmath.between(x,lhs,rhs) ? true : throw failed(ClaimOpKind.Between, NotBetween(x, lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool between<T>(BitSize x, T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
                => gmath.between(x.Bits.Convert<T>(),lhs,rhs) ? true : throw failed(ClaimOpKind.Between, NotBetween(x.Bits.Convert<T>(),lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool between<T>(BitSize x, Interval<T> range, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
                => range.Contains(x.Bits.Convert<T>()) ? true : throw failed(ClaimOpKind.Between, NotBetween(x.Bits.Convert<T>(), range.Left, range.Right, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
                => gmath.gt(lhs,rhs) ? true : throw failed(ClaimOpKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
                => gmath.gteq(lhs,rhs) ? true : throw failed(ClaimOpKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
                => gmath.lt(lhs,rhs) ? true : throw failed(ClaimOpKind.Lt, NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct
                => gmath.lteq(lhs,rhs) ? true : throw failed(ClaimOpKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool nonzero<T>(T x, [Member] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : struct 
                => gmath.nonzero(x) ? true : throw Errors.NotNonzero(caller,file,line);

        [MethodImpl(Inline)]
        public static bool yea(bool src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => src ? true 
                : throw ClaimException.Define(NotTrue(msg, caller, file,line));

        /// <summary>
        /// Asserts that the operand is false
        /// </summary>
        /// <param name="src">The value claimed to be false</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        [MethodImpl(Inline)]
        public static bool nea(bool src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !src ? true : throw ClaimException.Define(NotFalse(msg, caller, file,line));

        [MethodImpl(Inline)]
        public static unsafe bool notnull(void* p, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => (p != null) ? true : throw new ArgumentNullException(AppMsg.Define($"Pointer was null", SeverityLevel.Error, caller,file,line).ToString());

        [MethodImpl(Inline)]
        public static bool notnull<T>(T src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !(src is null) ? true : throw new ArgumentNullException(AppMsg.Define($"Argument was null", SeverityLevel.Error, caller,file,line).ToString());

    }
}