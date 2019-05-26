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
    


    partial class mathx
    {

        [MethodImpl(Inline)]
        public static ref sbyte Add(this ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte) (lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte Add(this ref byte lhs, byte rhs)
        {
            lhs = (byte) (lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short Add(this ref short lhs, short rhs)
        {
            lhs = (short) (lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort Add(this ref ushort lhs, ushort rhs)
        {
            lhs = (ushort) (lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int Add(this ref int lhs, int rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint Add(this ref uint lhs, uint rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long Add(this ref long lhs, long rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong Add(this ref ulong lhs, ulong rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float Add(this ref float lhs, float rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double Add(this ref double lhs, float rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }
 


    }

}