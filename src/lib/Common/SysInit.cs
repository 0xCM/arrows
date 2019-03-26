//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Linq;

    using static zcore;

    /// <summary>
    /// Characterizes a system initializer, i.e. a component whose initialization
    /// routine is executed exactly once per application domain load
    /// </summary>
    public interface ISysInit
    {
        void Initialize();
    }

    /// <summary>
    /// Identifies a system initializer
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SysInitAttribute : Attribute
    {
    }

    [SysInit]
    public abstract class SysInit<T> : ISysInit
        where T : SysInit<T>, new()
    {
        protected abstract void ExecInit();
        public void Initialize()
        {
            print($"Executing  {GetType().Name} initializer");
            try
            {
                ExecInit();
            }
            catch(Exception e)
            {
                print($"{GetType().Name} initializer failed: {e}");
                throw;
            }
        }
    }

    public static class SysInit
    {
        /// <summary>
        /// Initializes a specified assembly
        /// </summary>
        /// <typeparam name="T">A type defined in the assembly to initialize</typeparam>
        public static void initialize<T>()
        {
            iter(initializers<T>(), init => init.Initialize());
        }

        /// <summary>
        /// Yields the initializers defined in the assembly of the parametrized type
        /// </summary>
        /// <typeparam name="T">A type to identify the assembly for which initializers are found</typeparam>
        /// <returns></returns>
        public static IEnumerable<ISysInit> initializers<T>()
        {
            var types = assembly<T>().GetTypeAttributions<SysInitAttribute>(t => !t.IsAbstract).Select(x => x.Key); 
            foreach(var t in types)
                yield return instance<ISysInit>(t);
        }
        
    }
}