//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.PCG
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    public static class Constants
    {
        public static T multiplier<T>()
            where T : struct
            => Constants<T>.TheOnly.Multiplier;

        public static T increment<T>()
            where T : struct
            => Constants<T>.TheOnly.Increment;
    }

    public class Constants<T>
        where T : struct
    {
        public static readonly Constants<T> TheOnly = new Constants<T>();

        Constants()
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

    public class Engine<T>
        where T : struct
    {
        public Engine(T state)
        {
            this.state_ = state;
        
        }

        T state_;

    }

}
