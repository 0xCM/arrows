//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    public abstract class ZMod
    {
    }

    public abstract class ZMod<T> : ZMod
        where T : ZMod<T>
    {
        public static readonly Assembly DefiningAssembly  = typeof(T).Assembly;

        public Assembly Host
            => typeof(T).Assembly;

    }

    public abstract class ZLib<T> : ZMod<T> 
        where T : ZLib<T>
    {


    }

    public abstract class ZApp<T> : ZMod<T> 
        where T : ZApp<T>
    {


    }

    public abstract class ZTest<T> : ZMod<T> 
        where T : ZTest<T>
    {


    }

    public sealed class ZCore : ZLib<ZCore>
    {

    }
}

