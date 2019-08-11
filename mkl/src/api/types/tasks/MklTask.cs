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


    public interface IMklTask : IDisposable
    {

    }
    public interface IMklTask<T> : IMklTask
        where T : struct
    {
        
    }

    abstract class MklTask : IMklTask
    {
        protected IntPtr Pointer;

        public static implicit operator IntPtr(MklTask src)
            => src.Pointer;

        public IntPtr Handle
            => Pointer;

        protected MklTask(IntPtr Pointer)
            => this.Pointer = Pointer;

        protected MklTask()
        {
            Pointer = IntPtr.Zero;
        }

        public abstract void Dispose();

    }

    abstract class MklTask<T> : MklTask, IMklTask<T>
        where T : struct
    {
                

        protected MklTask(IntPtr Pointer)
            : base(Pointer)
        {}

        protected MklTask()
        {
            
        }
                
    }
}