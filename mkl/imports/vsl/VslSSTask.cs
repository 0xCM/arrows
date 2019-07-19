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
        public static extern VslSSStatus vslsSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref float observations, ref float weights, ref int indices);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static unsafe extern VslSSStatus vslsSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref float observations, ref float weights, int* pIndices = null);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static unsafe extern VslSSStatus vslsSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref float observations, float* pWeights, ref int indices);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static unsafe extern VslSSStatus vslsSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref float observations, float* pWeights = null, int* pIndices = null);

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
        public static extern VslSSStatus vsldSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref double observations, ref double weights, ref int indices);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static unsafe extern VslSSStatus vsldSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref double observations, ref double weights, int* pIndices = null);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static unsafe extern VslSSStatus vsldSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref double observations, double* pWeights, ref int indices);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static unsafe extern VslSSStatus vsldSSNewTask(ref IntPtr task, ref int dim, ref int obsCount, ref VslSSMatrixStorage obsStorage, 
            ref double observations, double* pWeights = null, int* pIndices = null);

        /// <summary>
        /// Deletes a summary statistics task
        /// </summary>
        /// <param name="task">A reference to the task pointer that the routine will deallocate</param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslSSStatus vslSSDeleteTask(ref IntPtr task);


         [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
         public static extern VslSSStatus vsliSSEditTask(IntPtr task, VslSSTaskParameter param, ref int value);

         [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
         public static extern VslSSStatus vslsSSEditTask(IntPtr task, VslSSTaskParameter param, ref float value);

         [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
         public static extern VslSSStatus vsldSSEditTask(IntPtr task, VslSSTaskParameter param, ref double value);


        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslSSStatus vslsSSCompute(IntPtr task, VslSSComputeRoutine routines, VslSSComputeMethod methods);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslSSStatus vsldSSCompute(IntPtr task, VslSSComputeRoutine routines, VslSSComputeMethod methods);

    }
    
}