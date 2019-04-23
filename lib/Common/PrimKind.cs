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

    public readonly struct PrimalIndex
    {
        readonly Index<object> index;

        public PrimalIndex(Index<object> src)
            => index = src;
        public V lookup<K,V>()
            where K : struct, IEquatable<K>
            => (V)index[PrimKinds.key<K>()];
    }


    public readonly struct PrimalIndex<T>
    {
        readonly Index<object> index;

        public PrimalIndex(Index<object> src)
            => index = src;

        public T lookup<P>()
            where P : struct, IEquatable<P>
            => (T)index[PrimKinds.key<P>()];

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

        decimal128 = 12,

        bigint = 13,
        
        last = bigint      
    }

    public readonly struct PrimKind<T>
    {
        public static readonly PrimKind Kind = PrimKinds.kind(typeof(T));
    }

    public static class PrimKinds
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
                => new PrimalIndex(array<object>(default(T), 
                @sbyte, @byte, @short, @ushort, @int, 
                @uint, @long, @ulong, @float, @double,
                @decimal, @bigint
                ));

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
                => new PrimalIndex(array<object>(typeof(void), 
                @sbyte, @byte, @short, @ushort, @int, 
                @uint, @long, @ulong, @float, @double,
                typeof(decimal), typeof(System.Numerics.BigInteger)
                ));

        [MethodImpl(Inline)]
        public static Type type(PrimKind key)
            => Kinds[(int)key];

        [MethodImpl(Inline)]
        public static Type type(int key)
            => Kinds[key];            

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
        public static int key<T>()
            => (int)PrimKind<T>.Kind;

    }



}