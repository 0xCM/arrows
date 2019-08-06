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
        public static Sample<float> Mean(this Sample<float> src)        
            => src.CalcMean(Sample.Alloc<float>(src.Dim,1));

        /// <summary>
        /// Finds the mean for each dimension
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<double> Mean(this Sample<double> src)        
            => src.CalcMean(Sample.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the sum
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<float> Sum(this Sample<float> src)        
            => src.CalcSum(Sample.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the sum
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<double> Sum(this Sample<double> src)        
            => src.CalcSum(Sample.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<float> Min(this Sample<float> src)        
            => src.CalcMin(Sample.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<double> Min(this Sample<double> src)        
            => src.CalcMin(Sample.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the maximum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<float> Max(this Sample<float> src)        
            => src.CalcMax(Sample.Alloc<float>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the maximum sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<double> Max(this Sample<double> src)        
            => src.CalcMax(Sample.Alloc<double>(src.Dim,1));

        /// <summary>
        /// For each dimension, finds the minimum and maxim sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<float> Extrema(this Sample<float> src)        
            => src.CalcExtrema(Sample.Alloc<float>(src.Dim,2));

        /// <summary>
        /// For each dimension, finds the minimum and maxim sample value
        /// </summary>
        /// <param name="src">The sample</param>
        [MethodImpl(Inline)]
        public static Sample<double> Extrema(this Sample<double> src)        
            => src.CalcExtrema(Sample.Alloc<double>(src.Dim,2));

        static unsafe Sample<T> CalcMin<T>(this Sample<T> samples, Sample<T> dst)        
            where T : struct
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MIN, ref dst[0]);
            h2.Compute(VSL_SS_MIN, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Sample<T> CalcMax<T>(this Sample<T> samples, Sample<T> dst)        
            where T : struct
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MAX, ref dst[0]);
            h2.Compute(VSL_SS_MAX, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Sample<T> CalcSum<T>(this Sample<T> samples, Sample<T> dst)        
            where T : struct
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_SUM, ref dst[0]);
            h2.Compute(VSL_SS_SUM, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Sample<T> CalcExtrema<T>(this Sample<T> samples, Sample<T> dst)        
            where T : struct
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MIN, ref dst[0]);
            h2.Set(VSL_SS_ED_MAX, ref dst[1]);
            h2.Compute(VSL_SS_MAX | VSL_SS_MIN, VSL_SS_METHOD_FAST);
            return dst;
        }

        static unsafe Sample<T> CalcMean<T>(this Sample<T> samples, Sample<T> dst)        
            where T : struct
        {
            using var h2 = VslSSTaskHandle.Create(samples);
            h2.Set(VSL_SS_ED_MEAN, ref dst[0]);
            h2.Compute(VSL_SS_MEAN, VSL_SS_METHOD_FAST);
            return dst;
        }

    }

}