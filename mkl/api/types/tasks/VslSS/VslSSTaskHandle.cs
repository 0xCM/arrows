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


    unsafe struct VslSSTaskHandle<T> : IDisposable
        where T : struct
    {
        public static VslSSTaskHandle<T> Create(Span<T> samples, int dim)
            => new VslSSTaskHandle<T>(samples, dim);

        public static VslSSTaskHandle<T> Wrap(IntPtr ptr)
            => new VslSSTaskHandle<T>(ptr);

        public static unsafe VslSSTaskHandle<T> Create(Sample<T> samples)
            => new VslSSTaskHandle<T>(samples, samples.Dimension);

        public static implicit operator IntPtr(VslSSTaskHandle<T> handle)
            => handle.TaskPtr;

        VslSSTaskHandle(IntPtr taskPtr)
        {
            this.TaskPtr = taskPtr;
            this.Dim = 0;
            this.MatrixFormat = 0;
            this.SampleCount = 0;
        }
        
        VslSSTaskHandle(Span<T> samples, int dim)
        {
            this.Dim = dim;
            this.SampleCount = samples.Length/dim;
            this.MatrixFormat = VslSSMatrixStorage.VSL_SS_MATRIX_STORAGE_ROWS;
            this.TaskPtr = IntPtr.Zero;

            if(typeof(T) == typeof(float))
                VSL.vslsSSNewTask(ref TaskPtr, ref Dim, ref SampleCount, ref MatrixFormat, 
                    ref MemoryMarshal.Cast<T,float>(samples)[0]).AutoThrow();
            else if(typeof(T) == typeof(double))
                VSL.vsldSSNewTask(ref TaskPtr, ref Dim, ref SampleCount, ref MatrixFormat, 
                    ref MemoryMarshal.Cast<T,double>(samples)[0]).AutoThrow();
            else
                throw unsupported<T>();
        }


        IntPtr TaskPtr;

        int Dim;

        int SampleCount;

        VslSSMatrixStorage MatrixFormat;
        
        public void Dispose()
            => VSL.vslSSDeleteTask(ref As.asRef( in TaskPtr)).AutoThrow();
    }

    static class VslSSTaskHandle
    {
        public static unsafe VslSSTaskHandle<T> Create<T>(Span<T> samples, int dim)
            where T : struct
                => VslSSTaskHandle<T>.Create(samples,dim);

        public static unsafe VslSSTaskHandle<T> Create<T>(Sample<T> samples)
            where T : struct
                => VslSSTaskHandle<T>.Create(samples);

        public static VslSSTaskHandle<T> Wrap<T>(IntPtr ptr)
            where T : struct
            => VslSSTaskHandle<T>.Wrap(ptr);
    }

}