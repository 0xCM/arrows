//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
namespace  Z0
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;
    using System.Linq.Expressions;
    
    using static zfunc;

    /// <summary>
    /// Generates a dynamic method that pins a pointer before delegate invocation and unpins it after
    /// </summary>
    /// <remarks>
    /// Harvested from https://stackoverflow.com/questions/4994277/memory-address-of-an-object-in-c-sharp
    /// </remarks>
    static class PinnedPointers
    {
        public static readonly Action<object, Action<IntPtr>> Pin;

        static PinnedPointers()
        {
            var getPP = new DynamicMethod("GetPinnedPtr", 
                typeof(void), 
                new[] {typeof(object), typeof(Action<IntPtr>)}, 
                typeof(PinnedPointers).Module);
                
            var il = getPP.GetILGenerator();
            il.DeclareLocal(typeof(object), true);
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Stloc_0);
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Ldloc_0);
            il.Emit(OpCodes.Conv_I);
            il.Emit(OpCodes.Call, typeof(Action<IntPtr>).GetMethod("Invoke"));
            il.Emit(OpCodes.Ret);
            
            Pin = (Action<object, Action<IntPtr>>)getPP.CreateDelegate(typeof(Action<object, Action<IntPtr>>));
        }

        static void Example()
        {
            object o = new object();
            PinnedPointers.Pin(o, 
                //the first pointer in the managed object header in .NET points to its run-time type info 
                ptr => Console.WriteLine(Marshal.ReadIntPtr(ptr) == typeof(object).TypeHandle.Value));            
        }
    }
}


partial class zfunc
{
    public static void pin<T>(ref T x, Action<IntPtr> worker)
    {
        Z0.PinnedPointers.Pin(x, ptr => worker(ptr));
    }
}