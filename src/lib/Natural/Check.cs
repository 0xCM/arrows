namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using static zcore;

    public static class Check
    {
        static bool failure<N>(string name, uint value, bool raise)
            where N : TypeNat, new()
            => raise 
               ? throw new NatConstraintException("eq", value, natval<N>()) 
               : false;

        static bool failure<M,N>(string name, bool raise)
            where M : TypeNat, new()
            where N : TypeNat, new()
            => raise 
               ? throw new NatConstraintException("successor", natvals<M,N>()) 
               : false;

        public static bool eq<N>(uint test, bool raise = true)
            where N : TypeNat, new() 
                =>  natval<N>() == test ? true : failure<N>("eq", test, raise);

        public static bool lt<N>(uint test, bool raise = true)
            where N : TypeNat, new() 
                =>  natval<N>() < test ? true : failure<N>("lt", test, raise);

        public static bool lteq<N>(uint test, bool raise = true)
            where N : TypeNat, new() 
                =>  natval<N>() <= test ? true : failure<N>("lteq", test, raise);

        public static bool gt<N>(uint test, bool raise = true)
            where N : TypeNat, new() 
                =>  natval<N>() > test ? true : failure<N>("gt", test, raise);

        public static bool gteq<N>(uint test, bool raise = true)
            where N : TypeNat, new() 
                =>  natval<N>() >= test ? true : failure<N>("gteq", test, raise);

        public static bool successor<M,N>(bool raise = true)
            where M : TypeNat, new() 
            where N : TypeNat, new()
                =>  natval<M>() + 1u == natval<N>() ? true : failure<M,N>("successor", raise);

        
    }
}