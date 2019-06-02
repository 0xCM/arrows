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

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(ref asRef(I8Zero));
            else if(typeof(T) == typeof(byte))
                return generic<T>(ref asRef(U8Zero));
            else if(typeof(T) == typeof(short))
                return generic<T>(ref asRef(I16Zero));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ref asRef(U16Zero));
            else if(typeof(T) == typeof(int))
                return generic<T>(ref asRef(I32Zero));
            else if(typeof(T) == typeof(uint))
                return generic<T>(ref asRef(U32Zero));
            else if(typeof(T) == typeof(long))
                return generic<T>(ref asRef(I64Zero));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ref asRef(U64Zero));
            else if(typeof(T) == typeof(float))
                return generic<T>(ref asRef(F32Zero));
            else if(typeof(T) == typeof(double))
                return generic<T>(ref asRef(F64Zero));
            else
                throw unsupported(PrimalKinds.kind<T>());        
        }

        [MethodImpl(Inline)]
        public static T one<T>()
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(ref asRef(I8One));
            else if(typeof(T) == typeof(byte))
                return generic<T>(ref asRef(U8One));
            else if(typeof(T) == typeof(short))
                return generic<T>(ref asRef(I16One));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ref asRef(U16One));
            else if(typeof(T) == typeof(int))
                return generic<T>(ref asRef(I32One));
            else if(typeof(T) == typeof(uint))
                return generic<T>(ref asRef(U32One));
            else if(typeof(T) == typeof(long))
                return generic<T>(ref asRef(I64One));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ref asRef(U64One));
            else if(typeof(T) == typeof(float))
                return generic<T>(ref asRef(F32One));
            else if(typeof(T) == typeof(double))
                return generic<T>(ref asRef(F64One));
            else
                throw unsupported(PrimalKinds.kind<T>());        
        }

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(ref asRef(I8Min));
            else if(typeof(T) == typeof(byte))
                return generic<T>(ref asRef(U8Min));
            else if(typeof(T) == typeof(short))
                return generic<T>(ref asRef(I16Min));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ref asRef(U16Min));
            else if(typeof(T) == typeof(int))
                return generic<T>(ref asRef(I32Min));
            else if(typeof(T) == typeof(uint))
                return generic<T>(ref asRef(U32Min));
            else if(typeof(T) == typeof(long))
                return generic<T>(ref asRef(I64Min));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ref asRef(U64Min));
            else if(typeof(T) == typeof(float))
                return generic<T>(ref asRef(F32Min));
            else if(typeof(T) == typeof(double))
                return generic<T>(ref asRef(F64Min));
            else
                throw unsupported(PrimalKinds.kind<T>());        
        }

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(ref asRef(I8Max));
            else if(typeof(T) == typeof(byte))
                return generic<T>(ref asRef(U8Max));
            else if(typeof(T) == typeof(short))
                return generic<T>(ref asRef(I16Max));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ref asRef(U16Max));
            else if(typeof(T) == typeof(int))
                return generic<T>(ref asRef(I32Max));
            else if(typeof(T) == typeof(uint))
                return generic<T>(ref asRef(U32Max));
            else if(typeof(T) == typeof(long))
                return generic<T>(ref asRef(I64Max));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ref asRef(U64Max));
            else if(typeof(T) == typeof(float))
                return generic<T>(ref asRef(F32Max));
            else if(typeof(T) == typeof(double))
                return generic<T>(ref asRef(F64Max));
            else
                throw unsupported(PrimalKinds.kind<T>());        
        }
    }
}