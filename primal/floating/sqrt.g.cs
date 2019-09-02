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
        
    using static As;
    using static zfunc;

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static ref T sqrt<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.sqrt(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.sqrt(ref float64(ref src));
            else 
                throw unsupported<T>();
            return ref src;
        }           

        [MethodImpl(Inline)]
        public static ref Span<T> sqrt<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                float32(io).Sqrt();
            else if(typeof(T) == typeof(double))
                float64(io).Sqrt();
            else
                 throw unsupported<T>();                           
            return ref io;
        }


        [MethodImpl(Inline)]
        public static T sqrt<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.sqrt(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.sqrt(float64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        static ref T sqrtF32<T>(ref T src)
        {
            fmath.sqrt(ref float32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T sqrtF64<T>(ref T src)
        {
            fmath.sqrt(ref float64(ref src));            
            return ref src;
        }

    }

}
