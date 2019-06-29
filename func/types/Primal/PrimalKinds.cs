//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class PrimalKinds
    {
        public static readonly PrimalKind[] All = kinds<PrimalKind>();

        public static readonly PrimalKind[] Integral 
            = array(PrimalKind.int8, PrimalKind.uint8, PrimalKind.int16, PrimalKind.uint16,
                    PrimalKind.int32, PrimalKind.uint32, PrimalKind.int64, PrimalKind.uint64);
        public static readonly PrimalKind[] Float
            = array(PrimalKind.float32, PrimalKind.float64);

        public static readonly PrimalKind[] Signed
            = array(PrimalKind.int8, PrimalKind.int16, PrimalKind.int32, PrimalKind.int64, PrimalKind.float32, PrimalKind.float64);

        public static readonly PrimalKind[] UnsignedIntegral 
            = array(PrimalKind.uint8, PrimalKind.uint16, PrimalKind.uint32, PrimalKind.uint64);

        public static readonly PrimalKind[] SignedIntegral 
            = array(PrimalKind.int8, PrimalKind.int16, PrimalKind.int32, PrimalKind.int64);

        static readonly Type[] Kinds = 
            new Type[]{
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
                };


        [MethodImpl(Inline)]
        public static Type type(PrimalKind key)
            => Kinds[(int)key];

        [MethodImpl(Inline)]
        public static Type type(int key)
            => Kinds[key];            

        [MethodImpl(Inline)]
        public static PrimalKind kind<T>()
            => PrimalKind<T>.Kind;

        [MethodImpl(Inline)]
        public static int key<T>()
            => (int)PrimalKind<T>.Kind;
    }
}