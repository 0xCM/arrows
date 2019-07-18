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
    using static MklImports;

    /// <summary>
    /// Represents a summary statistics task
    /// </summary>
    public sealed class VslSSTask<T> : MklTask<VslSSTask<T>>
    {

        public VslSSTask()
        {

        }

        public VslSSTask(int Dim,  T[] Observations)
        {
            this.Dim = Dim;
            this.OservationCount = Observations.Length / Dim;
            this.Observations = Observations;


        }

        public readonly int Dim;

        public readonly int OservationCount;

        public readonly T[] Observations;
             

        public override void Dispose()
        {
            if(Pointer != IntPtr.Zero)
                VSL.vslSSDeleteTask(ref Pointer);
        }
    }

    partial class VSL
    {        

        /// <summary>
        /// Creates a new single-precisiion summary statistics task
        /// </summary>
        /// <param name="task">A reference to task pointer that the routine will allocate</param>
        /// <param name="dim">The number of variables, i.e. the dimension of the observation vectors</param>
        /// <param name="obsCount">The number of observation vectors</param>
        /// <param name="obsStorage">The observation storage format</param>
        /// <param name="observations">The matrix of observations</param>
        /// <param name="weights">A weight vector of length obsCount. If NULL, implies each observation has a weight of 1 </param>
        /// <param name="indices">Array of vector components of length dim indicating the components that sould be processed. If null, all components are procesed</param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern SSStatus vsldSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref float observations, ref float weights, ref int indices);

        /// <summary>
        /// Creates a new double-precisiion summary statistics task
        /// </summary>
        /// <param name="task">A reference to task pointer that the routine will allocate</param>
        /// <param name="dim">The number of variables, i.e. the dimension of the observation vectors</param>
        /// <param name="obsCount">The number of observation vectors</param>
        /// <param name="obsStorage">The observation storage format</param>
        /// <param name="observations">The matrix of observations</param>
        /// <param name="weights">A weight vector of length obsCount. If NULL, implies each observation has a weight of 1 </param>
        /// <param name="indices">Array of vector components of length dim indicating the components that sould be processed. If null, all components are procesed</param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern SSStatus vsldSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref double observations, ref double weights, ref int indices);

        /// <summary>
        /// Deletes a summary statistics task
        /// </summary>
        /// <param name="task">A reference to the task pointer that the routine will deallocate</param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern SSStatus vslSSDeleteTask(ref IntPtr task);


         [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
         public static extern SSStatus vsldSSEditTask(IntPtr task, int param, ref int value);

         [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
         public static extern SSStatus vsldSSEditTask(IntPtr task, SSTaskParameter param, ref float value);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern SSStatus vsldSSEditTask(IntPtr task, SSTaskParameter param, ref double value);


        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern SSStatus vslsSSCompute(IntPtr task, SSComputeRoutine routines, SSComputeMethod methods);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern SSStatus vsldSSCompute(IntPtr task, SSComputeRoutine routines, SSComputeMethod methods);

    }
    
}