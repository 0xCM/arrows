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

    partial class VssOps
    {
        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<float> Mean(this DataSet<float> src)        
            => src.CalcMean(Sample.Alloc<float>(src.Dim,1));

        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<double> Mean(this DataSet<double> src)        
            => src.CalcMean(Sample.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the sum
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<float> Sum(this DataSet<float> src)        
            => src.CalcSum(Sample.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the sum
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<double> Sum(this DataSet<double> src)        
            => src.CalcSum(Sample.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<float> Min(this DataSet<float> src)        
            => src.CalcMin(Sample.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<double> Min(this DataSet<double> src)        
            => src.CalcMin(Sample.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the maximum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<float> Max(this DataSet<float> src)        
            => src.CalcMax(Sample.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the maximum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<double> Max(this DataSet<double> src)        
            => src.CalcMax(Sample.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum and maxim sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<float> Extrema(this DataSet<float> src)        
            => src.CalcExtrema(Sample.Alloc<float>(src.Dim,2));

        /// <summary>
        /// For each dimension, finds the minimum and maxim sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static DataSet<double> Extrema(this DataSet<double> src)        
            => src.CalcExtrema(Sample.Alloc<double>(src.Dim,2));

        static unsafe DataSet<T> CalcMin<T>(this DataSet<T> samples, DataSet<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MIN, ref dst[0]);
            h2.Compute(VSL_SS_MIN, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe DataSet<T> CalcMax<T>(this DataSet<T> samples, DataSet<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MAX, ref dst[0]);
            h2.Compute(VSL_SS_MAX, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe DataSet<T> CalcSum<T>(this DataSet<T> samples, DataSet<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_SUM, ref dst[0]);
            h2.Compute(VSL_SS_SUM, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe DataSet<T> CalcExtrema<T>(this DataSet<T> samples, DataSet<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MIN, ref dst[0]);
            h2.Set(VSL_SS_ED_MAX, ref dst[1]);
            h2.Compute(VSL_SS_MAX | VSL_SS_MIN, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe DataSet<T> CalcMean<T>(this DataSet<T> samples, DataSet<T> dst)        
            where T : unmanaged
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MEAN, ref dst[0]);
            h2.Compute(VSL_SS_MEAN, VSL_SS_METHOD_FAST);
            return dst;
        }

    }

}