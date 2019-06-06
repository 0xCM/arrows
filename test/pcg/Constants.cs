//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    public static partial class PCG
    {

        public const byte PCG_DEFAULT_MULTIPLIER_8  = 141;
        
        public const ushort PCG_DEFAULT_MULTIPLIER_16  = 12829;
        
        public const uint PCG_DEFAULT_MULTIPLIER_32 = 747796405;
        
        public const ulong PCG_DEFAULT_MULTIPLIER_64 = 6364136223846793005;

        public const byte PCG_DEFAULT_INCREMENT_8 = 77;
        
        public const ushort PCG_DEFAULT_INCREMENT_16 = 47989;
        
        public const uint PCG_DEFAULT_INCREMENT_32 = 2891336453;
        
        public const ulong PCG_DEFAULT_INCREMENT_64 = 1442695040888963407;

        static class GenericConstants
        {
            public static T multiplier<T>()
                where T : struct
                => GenericConstant<T>.TheOnly.Multiplier;

            public static T increment<T>()
                where T : struct
                => GenericConstant<T>.TheOnly.Increment;
        }

        class GenericConstant<T>
            where T : struct
        {
            public static readonly GenericConstant<T> TheOnly = new GenericConstant<T>();

            GenericConstant()
            {

            }

            public T Multiplier {get;}
                = GetMultiplier();

            public T Increment {get;}
                = GetIncrement();
                
            static T GetIncrement()
            {
                if(typeof(T) == typeof(byte))
                    return literal<T>((byte)77);
                else if(typeof(T) == typeof(ushort))
                    return literal<T>((ushort)47989);
                else if(typeof(T) == typeof(uint))
                    return literal<T>(2891336453u);
                else if(typeof(T) == typeof(ulong))
                    return literal<T>(1442695040888963407ul);               
                else throw unsupported<T>();
            }

            static T GetMultiplier()
            {
                if(typeof(T) == typeof(byte))
                    return literal<T>((byte)141);
                else if(typeof(T) == typeof(ushort))
                    return literal<T>((ushort)12829);
                else if(typeof(T) == typeof(uint))
                    return literal<T>(747796405u);
                else if(typeof(T) == typeof(ulong))
                    return literal<T>(6364136223846793005ul);               
                else throw unsupported<T>();
            }
        }

        class Engine<T>
            where T : struct
        {
            public Engine(T state)
            {
                this.state_ = state;
            
            }

            T state_;

        }

    }
}
