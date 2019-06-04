//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{


       [MethodImpl(Inline)]
       public static T literal<T>(sbyte src)
            where T : struct
            => convert(src, out T x);

       [MethodImpl(Inline)]
       public static T literal<T>(byte src)
            where T : struct
            => convert(src, out T x);

       [MethodImpl(Inline)]
       public static T literal<T>(short src)
            where T : struct
            => convert(src, out T x);

       [MethodImpl(Inline)]
       public static T literal<T>(ushort src)
            where T : struct
            => convert(src, out T x);


       [MethodImpl(Inline)]
       public static T literal<T>(int src)
            where T : struct
            => convert(src, out T x);

       [MethodImpl(Inline)]
       public static T literal<T>(uint src)
            where T : struct
            => convert(src, out T x);

       [MethodImpl(Inline)]
       public static T literal<T>(long src)
            where T : struct
            => convert(src, out T x);

       [MethodImpl(Inline)]
       public static T literal<T>(ulong src)
            where T : struct
            => convert(src, out T x);

       [MethodImpl(Inline)]
       public static T literal<T>(float src)
            where T : struct
            => convert(src, out T x);

       [MethodImpl(Inline)]
       public static T literal<T>(double src)
            where T : struct
            => convert(src, out T x);


}