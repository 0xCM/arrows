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

    partial class bridge
    {
        [MethodImpl(Inline)]
        public static ref T absI8<T>(ref T src)
        {
            ref var result = ref math.abs(ref int8(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T absI16<T>(ref T src)
        {
            ref var result = ref math.abs(ref int16(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T absI32<T>(ref T src)
        {
            ref var result = ref math.abs(ref int32(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T absI64<T>(ref T src)
        {
            ref var result = ref math.abs(ref int64(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T absF32<T>(ref T src)
        {
            ref var result = ref math.abs(ref float32(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static ref T absF64<T>(ref T src)
        {
            ref var result = ref math.abs(ref float64(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        public static T absI8<T>(T src)
            => generic<T>(Math.Abs(int8(src)));

        [MethodImpl(Inline)]
        public static T absI16<T>(T src)
            => generic<T>(Math.Abs(int16(src)));

        [MethodImpl(Inline)]
        public static T absI32<T>(T src)
            => generic<T>(Math.Abs(int32(src)));
        
        [MethodImpl(Inline)]
        public static T absI64<T>(T src)
            => generic<T>(Math.Abs(int64(src)));

        [MethodImpl(Inline)]
        public static T absF32<T>(T src)
            => generic<T>(MathF.Abs(float32(src)));

        [MethodImpl(Inline)]
        public static T absF64<T>(T src)
            => generic<T>(Math.Abs(float64(src)));
    }

}