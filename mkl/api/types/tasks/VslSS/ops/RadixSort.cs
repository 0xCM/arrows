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

    using static VslSSTaskParameter;
    using static VslSSComputeRoutine;
    using static VslSSComputeMethod;


    public static partial class VssOps
    {
        /// <summary>
        /// Applies the radix sort method to order the components in each observation vector
        /// </summary>
        /// <param name="samples">The observation vectors in row-major format</param>
        /// <param name="dim">The common dimension of each vector</param>
        /// <param name="dst">The buffer that will receive the sorted vectors</param>
        [MethodImpl(Inline)]
        public static Sample<float> RadixSort(this Sample<float> samples, Sample<float> dst)        
            => samples.ApplyRadixSort(dst);

        /// <summary>
        /// Applies the radix sort method to order the components in each observation vector
        /// </summary>
        /// <param name="samples">The observation vectors in row-major format</param>
        /// <param name="dim">The common dimension of each vector</param>
        /// <param name="dst">The buffer that will receive the sorted vectors</param>
        [MethodImpl(Inline)]
        public static Sample<double> RadixSort(this Sample<double> samples, Sample<double> dst)        
            => samples.ApplyRadixSort(dst);

        /// <summary>
        /// Applies the radix sort method to order the components in each observation vector
        /// </summary>
        /// <param name="samples">The observation vectors in row-major format</param>
        /// <param name="dim">The common dimension of each vector</param>
        [MethodImpl(Inline)]
        public static Sample<float> RadixSort(this Sample<float> samples)        
            => samples.ApplyRadixSort(Sample.Alloc<float>(samples.Dimension, samples.Count));

        /// <summary>
        /// Applies the radix sort method to order the components in each observation vector
        /// </summary>
        /// <param name="samples">The observation vectors in row-major format</param>
        /// <param name="dim">The common dimension of each vector</param>
        [MethodImpl(Inline)]
        public static Span<double> RadixSort(this Sample<double> samples)        
            => samples.ApplyRadixSort(Sample.Alloc<double>(samples.Dimension, samples.Count));


         static unsafe Sample<T> ApplyRadixSort<T>(this Sample<T> samples, Sample<T> dst)        
            where T : struct
        {
            var dim = samples.Dimension;
            var sampleCount = samples.Count;
            var iStorage = (int)VslSSMatrixStorage.VSL_SS_MATRIX_STORAGE_ROWS;
            var mformat = VslSSMatrixStorage.VSL_SS_MATRIX_STORAGE_ROWS;
            var taskPtr = IntPtr.Zero;

            if(typeof(T) == typeof(float))
                VSL.vslsSSNewTask(ref taskPtr, ref dim, ref sampleCount, ref mformat, 
                    ref MemoryMarshal.Cast<T,float>(samples)[0]).AutoThrow();
            else if(typeof(T) == typeof(double))
                VSL.vsldSSNewTask(ref taskPtr, ref dim, ref sampleCount, ref mformat, 
                    ref MemoryMarshal.Cast<T,double>(samples)[0]).AutoThrow();
            else
                throw unsupported<T>();
            
            using var handle = VslSSTaskHandle.Wrap<T>(taskPtr);
            handle.Set(VSL_SS_ED_OBSERV_STORAGE, ref iStorage);
            handle.Set(VSL_SS_ED_SORTED_OBSERV, ref dst[0]);
            handle.Set(VSL_SS_ED_SORTED_OBSERV_STORAGE, ref iStorage);
            handle.Compute(VSL_SS_SORTED_OBSERV, VSL_SS_METHOD_RADIX);
            return dst;
        }


    }

}