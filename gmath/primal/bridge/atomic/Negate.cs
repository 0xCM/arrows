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

    public static partial class bridge
    {

        [MethodImpl(Inline)]
        public static T negateI8<T>(T src)        
            => generic<T>(math.negate(ref int8(ref src)));            
        
        [MethodImpl(Inline)]
        public static T negateI16<T>(T src)        
            => generic<T>(math.negate(ref int16(ref src)));            

        [MethodImpl(Inline)]
        public static T negateI32<T>(T src)        
            => generic<T>(math.negate(ref int32(ref src)));            
        
        [MethodImpl(Inline)]
        public static T negateI64<T>(T src)        
            => generic<T>(math.negate(ref int64(ref src)));            

        [MethodImpl(Inline)]
        public static T negateF32<T>(T src)        
            => generic<T>(math.negate(ref float32(ref src)));            
        
        [MethodImpl(Inline)]
        public static T negateF64<T>(T src)        
            => generic<T>(math.negate(ref float64(ref src)));            


        [MethodImpl(Inline)]
        public static ref T negateI8<T>(ref T io)
        {
            math.negate(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateI16<T>(ref T io)
        {
            math.negate(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateI32<T>(ref T io)
        {
            math.negate(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateI64<T>(ref T io)
        {
            math.negate(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateF32<T>(ref T io)
        {
            math.negate(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        public static ref T negateF64<T>(ref T io)
        {
            math.negate(ref float64(ref io));
            return ref io;
        }
    }
}