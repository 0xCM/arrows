//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    public abstract class AssemblyDesignator
    {
        public abstract Assembly Host {get;}
    }

    public abstract class AssemblyDesignator<T> : AssemblyDesignator
        where T : AssemblyDesignator<T>
    {
        public static readonly Assembly DefiningAssembly = typeof(T).Assembly;

        public override sealed Assembly Host
            => typeof(T).Assembly;

    }

    /// <summary>
    /// Identifies a libary component
    /// </summary>
    /// <typeparam name="T">The derived subtype that lives in a library</typeparam>
    public abstract class ZLib<T> : AssemblyDesignator<T> 
        where T : ZLib<T>, new()
    {


    }

    public abstract class ZApp<T> : AssemblyDesignator<T> 
        where T : ZApp<T>, new()
    {


    }

    public abstract class ZTest<T> : AssemblyDesignator<T> 
        where T : ZTest<T>, new()
    {


    }

    public abstract class ZBench<T> : AssemblyDesignator<T> 
        where T : ZBench<T>, new()
    {


    }
}

