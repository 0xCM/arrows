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
        public static bool lt(ulong lhs, ulong rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs < rhs ? true : throw failed(ClaimOpKind.Eq, NotLessThan(lhs, rhs, caller, file, line));
        

        [MethodImpl(Inline)]
        public static bool @true(bool src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => src ? true 
                : throw ClaimException.Define(NotTrue(msg, caller, file,line));

        [MethodImpl(Inline)]
        public static bool @false(bool x, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !x ? true : throw ClaimException.Define(NotFalse(msg, caller, file,line));

        [MethodImpl(Inline)]
        public static bool notnull<T>(T src, string msg = null, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => !(src is null) ? true : throw new ArgumentNullException(AppMsg.Define($"Argument was null", SeverityLevel.Error, caller,file,line).ToString());

    }
}