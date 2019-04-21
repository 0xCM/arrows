//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zcore;

    public interface IPrimal
    {
        PrimKind PrimalKind {get;}

    }
    public interface IPrimal<T> : IPrimal
    {

    }

    public enum PrimKind : byte
    {
        none = 0,
        
        int8 = 1,

        uint8 = 2,

        int16 = 3,

        uint16 = 4,        

        int32 = 5,
        
        uint32 = 6,

        int64 = 7,

        uint64 = 8,
                            
        float32 = 9,

        float64 = 10,  

        float128 = 11,

        last = float64      
    }

    public readonly struct PrimKind<T>
    {
        public static readonly PrimKind Kind = PrimKinds.kind(typeof(T));
    }

    public static class PrimKinds
    {
        static readonly Type[] Kinds = 
            new Type[]{
                typeof(void),       // 0 = none
                typeof(sbyte),      // 1 = int8
                typeof(byte),       // 2 = uint8
                typeof(short),      // 3 = int16
                typeof(ushort),     // 4 = uint16
                typeof(int),        // 5 = int32
                typeof(uint),       // 6 = uint32
                typeof(long),       // 7 = int64
                typeof(ulong),      // 8 = uint64
                typeof(float),      // 9 = float32
                typeof(double),     // 10 = float64
                };

        [MethodImpl(Inline)]
        public static T[] index<T>(
            T @sbyte = default(T), 
            T @byte = default(T), 
            T @short = default(T), 
            T @ushort = default(T), 
            T @int = default(T), 
            T @uint = default(T), 
            T @long = default(T), 
            T @ulong = default(T), 
            T @float = default(T), 
            T @double = default(T))
                => array<T>(default(T), 
                @sbyte, @byte, @short, @ushort, @int, 
                @uint, @long, @ulong, @float, @double
                );

        [MethodImpl(Inline)]
        public static object[] index<I8,U8,I16,U16,I32,U32,I64,U64,F32,F64>(
            I8 @sbyte = default(I8), 
            U8 @byte = default(U8), 
            I16 @short = default(I16), 
            U16 @ushort = default(U16), 
            I32 @int = default(I32), 
            U32  @uint = default(U32), 
            I64 @long = default(I64), 
            U64 @ulong = default(U64), 
            F32 @float = default(F32), 
            F64 @double = default(F64))
                => array<object>(typeof(void), 
                @sbyte, @byte, @short, @ushort, @int, 
                @uint, @long, @ulong, @float, @double
                );

        [MethodImpl(Inline)]
        public static Type type(PrimKind kind)
            => Kinds[(int)kind];

        [MethodImpl(Inline)]
        public static Type type(int kind)
            => Kinds[kind];            

        [MethodImpl(Inline)]
        public static PrimKind kind(Type t)
        {
            for(var i =1; i<= (int)PrimKind.last; i++)
            {
                if(Kinds[i] == t)
                    return (PrimKind)i;
            }
            return PrimKind.none;
        }

        [MethodImpl(Inline)]
        public static PrimKind kind<T>()
            => PrimKind<T>.Kind;

        [MethodImpl(Inline)]
        public static int index<T>()
            => (int)PrimKind<T>.Kind;

    }



}