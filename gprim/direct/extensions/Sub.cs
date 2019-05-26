//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    
    using static zfunc;    
    


    partial class MathX
    {

        [MethodImpl(Inline)]
        public static ref sbyte Sub(this ref sbyte lhs, sbyte rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte Sub(this ref byte lhs, byte rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short Sub(this ref short lhs, short rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort Sub(this ref ushort lhs, ushort rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int Sub(this ref int lhs, int rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint Sub(this ref uint lhs, uint rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long Sub(this ref long lhs, long rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong Sub(this ref ulong lhs, ulong rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float Sub(this ref float lhs, float rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double Sub(this ref double lhs, float rhs)
        {
            lhs -= rhs;
            return ref lhs;
        }
    }
}