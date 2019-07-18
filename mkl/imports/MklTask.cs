//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public abstract class MklTask<T> : IDisposable
        where T : MklTask<T>, new()
    {
        /// <summary>
        /// Implicitly constructs a task from a pointer
        /// </summary>
        /// <param name="src">The source pointer</param>
        /// <typeparam name="T">The concrete subtype</typeparam>
        public static implicit operator MklTask<T>(IntPtr src)
        {
            var task = new T();
            task.Pointer = src;
            return task;
        }
            
        public static implicit operator IntPtr(MklTask<T> src)
            => src.Pointer;
    
        protected IntPtr Pointer;

        protected MklTask(IntPtr Pointer)
            => this.Pointer = Pointer;

        protected MklTask()
        {
            Pointer = IntPtr.Zero;
        }
        public abstract void Dispose();

        public IntPtr Raw()
            => Pointer;
    }



}