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

    using Calcs = VslSSComputeRoutine;

    partial class VssOps
    {
        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<float> Mean(this Dataset<float> src)        
            => src.CalcMean(Dataset.Alloc<float>(src.Dim,1));

        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<double> Mean(this Dataset<double> src)        
            => src.CalcMean(Dataset.Alloc<double>(src.Dim,1));

        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<double> Variance(this Dataset<double> src)        
            => src.CalcVariance(Dataset.Alloc<double>(src.Dim,1));

        /// <summary>
        /// Calculates the mean
        /// </summary>
        [MethodImpl(Inline)]
        public static ref double Mean(this Dataset<double> src, ref double dst)        
            => ref src.CalcMean(ref dst);

        /// <summary>
        /// For each dimension, finds the sum
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<float> Sum(this Dataset<float> src)        
            => src.CalcSum(Dataset.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the sum
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<double> Sum(this Dataset<double> src)        
            => src.CalcSum(Dataset.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<float> Min(this Dataset<float> src)        
            => src.CalcMin(Dataset.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<double> Min(this Dataset<double> src)        
            => src.CalcMin(Dataset.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the maximum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<float> Max(this Dataset<float> src)        
            => src.CalcMax(Dataset.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the maximum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<double> Max(this Dataset<double> src)        
            => src.CalcMax(Dataset.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum and maxim sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<float> Extrema(this Dataset<float> src)        
            => src.CalcExtrema(Dataset.Alloc<float>(src.Dim,2));

        /// <summary>
        /// For each dimension, finds the minimum and maxim sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Dataset<double> Extrema(this Dataset<double> src)        
            => src.CalcExtrema(Dataset.Alloc<double>(src.Dim,2));

        static unsafe Dataset<T> CalcMin<T>(this Dataset<T> samples, Dataset<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MIN, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_MIN, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Dataset<T> CalcMax<T>(this Dataset<T> samples, Dataset<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MAX, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_MAX, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Dataset<T> CalcSum<T>(this Dataset<T> samples, Dataset<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_SUM, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_SUM, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Dataset<T> CalcExtrema<T>(this Dataset<T> samples, Dataset<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MIN, ref dst[0]);
            h2.Set(VSL_SS_ED_MAX, ref dst[1]);
            h2.Compute(Calcs.VSL_SS_MAX | Calcs.VSL_SS_MIN, VSL_SS_METHOD_FAST);
            return dst;
        }


        static unsafe ref T CalcMean<T>(this Dataset<T> samples, ref T dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MEAN, ref dst);
            h2.Compute(Calcs.VSL_SS_MEAN, VSL_SS_METHOD_FAST);
            return ref dst;
        }

        static unsafe Dataset<T> CalcMean<T>(this Dataset<T> samples, Dataset<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MEAN, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_MEAN, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Dataset<T> CalcVariance<T>(this Dataset<T> samples, Dataset<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_2R_MOM, ref dst[0]);
            h2.Compute(Calcs.VSL_SS_2R_MOM, VSL_SS_METHOD_FAST);
            return dst;
        }

    }

}