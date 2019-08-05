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
            this.Dim = new int[]{0};
            this.MatrixFormat = new VslSSMatrixStorage[]{0};
            this.SampleCount = new int[]{0};
        }
        
        VslSSTaskHandle(Span<T> samples, int dim)
        {
            this.Dim = new int[]{dim};
            this.SampleCount = new int[]{samples.Length/dim};
            this.MatrixFormat = new VslSSMatrixStorage[]{VslSSMatrixStorage.VSL_SS_MATRIX_STORAGE_ROWS};
            this.TaskPtr = IntPtr.Zero;

            if(typeof(T) == typeof(float))
                VSL.vslsSSNewTask(ref TaskPtr, ref Dim[0], ref SampleCount[0], ref MatrixFormat[0], 
                    ref MemoryMarshal.Cast<T,float>(samples)[0]).AutoThrow();
            else if(typeof(T) == typeof(double))
                VSL.vsldSSNewTask(ref TaskPtr, ref Dim[0], ref SampleCount[0], ref MatrixFormat[0], 
                    ref MemoryMarshal.Cast<T,double>(samples)[0]).AutoThrow();
            else
                throw unsupported<T>();

            
        }

        IntPtr TaskPtr;

        int[] Dim;

        int[] SampleCount;

        VslSSMatrixStorage[] MatrixFormat;

        
        public void Dispose()
            => VSL.vslSSDeleteTask(ref As.asRef( in TaskPtr)).AutoThrow();
    }




}