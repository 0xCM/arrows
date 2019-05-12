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
    
    
    using static mfunc;
    using static As;

    partial class atoms
    {

        [MethodImpl(Inline)]
        public static T sinF32<T>(T src)
            => generic<T>(MathF.Sin(float32(src)));

        [MethodImpl(Inline)]
        public static T sinF64<T>(T src)
            => generic<T>(Math.Sin(float64(src)));

        [MethodImpl(Inline)]
        public static T cosF32<T>(T src)
            => generic<T>(MathF.Cos(float32(src)));

        [MethodImpl(Inline)]
        public static T cosF64<T>(T src)
            => generic<T>(Math.Cos(float64(src)));

        [MethodImpl(Inline)]
        public static T tanF32<T>(T src)
            => generic<T>(MathF.Tan(float32(src)));

        [MethodImpl(Inline)]
        public static T tanF64<T>(T src)
            => generic<T>(Math.Cos(float64(src)));


        [MethodImpl(Inline)]
        public static T asinF32<T>(T src)
            => generic<T>(MathF.Asin(float32(src)));

        [MethodImpl(Inline)]
        public static T asinF64<T>(T src)
            => generic<T>(Math.Asin(float64(src)));

        [MethodImpl(Inline)]
        public static T acosF32<T>(T src)
            => generic<T>(MathF.Acos(float32(src)));

        [MethodImpl(Inline)]
        public static T acosF64<T>(T src)
            => generic<T>(Math.Acos(float64(src)));

        [MethodImpl(Inline)]
        public static T atanF32<T>(T src)
            => generic<T>(MathF.Atan(float32(src)));

        [MethodImpl(Inline)]
        public static T atanF64<T>(T src)
            => generic<T>(Math.Acos(float64(src)));

 
        [MethodImpl(Inline)]
        public static T ceilingF32<T>(T src)
            => generic<T>(MathF.Ceiling(float32(src)));

        [MethodImpl(Inline)]
        public static T ceilingF64<T>(T src)
            => generic<T>(Math.Ceiling(float64(src)));
    }

}