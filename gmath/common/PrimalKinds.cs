//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static mfunc;

    public static class PrimalKinds
    {
        static readonly Type[] Kinds = 
            new Type[]{
                typeof(void),       
                typeof(sbyte),      
                typeof(byte),       
                typeof(short),      
                typeof(ushort),     
                typeof(int),        
                typeof(uint),       
                typeof(long),       
                typeof(ulong),      
                typeof(float),      
                typeof(double),     
                typeof(decimal),    
                typeof(System.Numerics.BigInteger),
                };

        [MethodImpl(Inline)]
        public static PrimalIndex index<T>(
            T @sbyte = default(T), 
            T @byte = default(T), 
            T @short = default(T), 
            T @ushort = default(T), 
            T @int = default(T), 
            T @uint = default(T), 
            T @long = default(T), 
            T @ulong = default(T), 
            T @float = default(T), 
            T @double = default(T),
            T @decimal = default(T),
            T @bigint = default(T)
            )
                => new PrimalIndex(new object[]{default(T), 
                @sbyte, @byte, @short, @ushort, @int, 
                @uint, @long, @ulong, @float, @double,
                @decimal, @bigint
                });

        [MethodImpl(Inline)]
        public static PrimalIndex index<I8,U8,I16,U16,I32,U32,I64,U64,F32,F64>(
            I8 @sbyte = default(I8), 
            U8 @byte = default(U8), 
            I16 @short = default(I16), 
            U16 @ushort = default(U16), 
            I32 @int = default(I32), 
            U32  @uint = default(U32), 
            I64 @long = default(I64), 
            U64 @ulong = default(U64), 
            F32 @float = default(F32), 
            F64 @double = default(F64)
            )
                => new PrimalIndex(new object[]{typeof(void), 
                @sbyte, @byte, @short, @ushort, @int, 
                @uint, @long, @ulong, @float, @double,
                typeof(decimal), typeof(System.Numerics.BigInteger)}
                );

        [MethodImpl(Inline)]
        public static Type type(PrimalKind key)
            => Kinds[(int)key];

        [MethodImpl(Inline)]
        public static Type type(int key)
            => Kinds[key];            

        [MethodImpl(Inline)]
        public static PrimalKind kind(Type t)
        {
            for(var i =1; i<= (int)PrimalKind.last; i++)
            {
                if(Kinds[i] == t)
                    return (PrimalKind)i;
            }
            return PrimalKind.none;
        }

        [MethodImpl(Inline)]
        public static PrimalKind kind<T>()
            => PrimalKind<T>.Kind;

        [MethodImpl(Inline)]
        public static int key<T>()
            => (int)PrimalKind<T>.Kind;
    }

}