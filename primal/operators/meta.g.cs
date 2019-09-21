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
        
    using static zfunc;    
    using static As;
    using static Constants;
    
    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(ref asRef((sbyte)0));
            else if(typeof(T) == typeof(byte))
                return generic<T>(ref asRef((byte)0));
            else if(typeof(T) == typeof(short))
                return generic<T>(ref asRef((short)0));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ref asRef((ushort)0));
            else if(typeof(T) == typeof(int))
                return generic<T>(ref asRef(0));
            else if(typeof(T) == typeof(uint))
                return generic<T>(ref asRef(0u));
            else if(typeof(T) == typeof(long))
                return generic<T>(ref asRef(0L));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ref asRef(0ul));
            else if(typeof(T) == typeof(float))
                return generic<T>(ref asRef(0f));
            else if(typeof(T) == typeof(double))
                return generic<T>(ref asRef(0.0));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T one<T>()
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(ref asRef((sbyte)1));
            else if(typeof(T) == typeof(byte))
                return generic<T>(ref asRef((byte)1));
            else if(typeof(T) == typeof(short))
                return generic<T>(ref asRef((short)1));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ref asRef((ushort)1));
            else if(typeof(T) == typeof(int))
                return generic<T>(ref asRef(1));
            else if(typeof(T) == typeof(uint))
                return generic<T>(ref asRef(1u));
            else if(typeof(T) == typeof(long))
                return generic<T>(ref asRef(1L));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ref asRef(1ul));
            else if(typeof(T) == typeof(float))
                return generic<T>(ref asRef(1f));
            else if(typeof(T) == typeof(double))
                return generic<T>(ref asRef(1.0));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(sbyte.MinValue);
            else if(typeof(T) == typeof(byte))
                return generic<T>(byte.MinValue);
            else if(typeof(T) == typeof(short))
                return generic<T>(short.MinValue);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ushort.MinValue);
            else if(typeof(T) == typeof(int))
                return generic<T>(int.MinValue);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint.MinValue);
            else if(typeof(T) == typeof(long))
                return generic<T>(long.MinValue);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ulong.MinValue);
            else if(typeof(T) == typeof(float))
                return generic<T>(float.MinValue);
            else if(typeof(T) == typeof(double))
                return generic<T>(double.MinValue);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(sbyte.MaxValue);
            else if(typeof(T) == typeof(byte))
                return generic<T>(byte.MaxValue);
            else if(typeof(T) == typeof(short))
                return generic<T>(short.MaxValue);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ushort.MaxValue);
            else if(typeof(T) == typeof(int))
                return generic<T>(int.MaxValue);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint.MaxValue);
            else if(typeof(T) == typeof(long))
                return generic<T>(long.MaxValue);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ulong.MaxValue);
            else if(typeof(T) == typeof(float))
                return generic<T>(float.MaxValue);
            else if(typeof(T) == typeof(double))
                return generic<T>(double.MaxValue);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool signed<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return true;
            else if(typeof(T) == typeof(byte))
                return false;
            else if(typeof(T) == typeof(short))
                return true;
            else if(typeof(T) == typeof(ushort))
                return false;
            else if(typeof(T) == typeof(int))
                return true;
            else if(typeof(T) == typeof(uint))
                return false;
            else if(typeof(T) == typeof(long))
                return true;
            else if(typeof(T) == typeof(ulong))
                return false;
            else if(typeof(T) == typeof(float))
                return true;
            else if(typeof(T) == typeof(double))
                return true;
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool unsigned<T>()
            where T : struct
                => !signed<T>();

        [MethodImpl(Inline)]
        public static bool floating<T>()
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return true;
            else if(typeof(T) == typeof(double))
                return true;
            else
                return false;
        }

        [MethodImpl(Inline)]
        public static bool integral<T>()
            where T : struct
                => !floating<T>();

        [MethodImpl(Inline)]
        public static ByteSize size<T>()
            where T : struct
                => SizeOf<T>.Size;

        [MethodImpl(Inline)]
        public static BitSize bitsize<T>()
            where T : struct
                => Unsafe.SizeOf<T>()* 8;

    }
}