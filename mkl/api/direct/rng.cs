//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class mkl
    {            
        [MethodImpl(Inline)]    
        public static VslStream stream(BRNG brng, uint seed)
        {
            IntPtr stream = IntPtr.Zero;
            VSL.vslNewStream(ref stream, brng, seed).ThrowOnError();
            return stream;
        }

        /// <summary>
        /// Gets the brng identifier associated with a stream
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        [MethodImpl(Inline)]    
        public static BRNG brng(VslStream stream)
            => VSL.vslGetStreamStateBrng(stream);

        /// <summary>
        /// Generates a discrete uniform distribution confined to a specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="buffer">The reception buffer</param>
        /// <returns></returns>
        [MethodImpl(Inline)]    
        public static UniformRangeSample<int> uniform(VslStream stream, Interval<int> range, Span<int> buffer)
        {
            VSL.viRngUniform(0,stream, buffer.Length, ref buffer[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        [MethodImpl(Inline)]    
        public static UniformRangeSample<float> uniform(VslStream stream, Interval<float> range, Span<float> buffer)
        {
            VSL.vsRngUniform(0,stream, buffer.Length, ref buffer[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        [MethodImpl(Inline)]    
        public static UniformRangeSample<double> uniform(VslStream stream, Interval<double> range, Span<double> buffer)
        {
            VSL.vdRngUniform(0,stream, buffer.Length, ref buffer[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        [MethodImpl(Inline)]    
        public static Span<float> cauchy(VslStream stream, float a, float b, Span<float> buffer)
        {
            VSL.vsRngCauchy(0, stream, buffer.Length, ref buffer[0], a, b).ThrowOnError();
            return buffer;
        }

        [MethodImpl(Inline)]    
        public static Span<double> cauchy(VslStream stream, double a, double b, Span<double> buffer)
        {
            VSL.vdRngCauchy(0, stream, buffer.Length, ref buffer[0], a, b).ThrowOnError();
            return buffer;
        }

        /// <summary>
        /// Generates uniformly distributed bits in 32-bit chunks.
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformBitsSample<uint> ubits(VslStream stream, Span<uint> buffer)
        {
            
            VSL.viRngUniformBits32(0,stream, buffer.Length, ref buffer[0]).ThrowOnError();
            return stream.Brng().UniformBitsSampled(buffer);
        }

        /// <summary>
        /// Generates uniformly distributed bits in 64-bit chunks.
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformBitsSample<ulong> ubits(VslStream stream, Span<ulong> buffer)
        {
            VSL.viRngUniformBits64(0,stream, buffer.Length, ref buffer[0]).ThrowOnError();
            return stream.Brng().UniformBitsSampled(buffer);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="p">The proability of a trial succeeding</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GeometricSample<int> geometric(VslStream stream, double p, Span<int> buffer)
        {
            VSL.viRngGeometric(0, stream, buffer.Length, ref buffer[0], p).ThrowOnError();
            return stream.Brng().GeometricSampled(p, buffer);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="p">The proability of a trial succeeding</param>
        /// <param name="buffer">The reception buffer</param>
        public static Span<Bit> bernoulli(VslStream stream, double p, Span<Bit> buffer)
        {
            Span<int> tmp = stackalloc int[buffer.Length];
            VSL.viRngBernoulli(0, stream, buffer.Length, ref tmp[0],p).ThrowOnError();
            for(var i=0; i < buffer.Length; i++)
                buffer[i] =tmp[i];
            return buffer;
        }

        [MethodImpl(Inline)]    
        public static ChiSquareSample<float> chi2(VslStream stream, int freedom, Span<float> buffer)
        {
            VSL.vsRngChiSquare(0, stream, buffer.Length, ref buffer[0], freedom).ThrowOnError();
            return stream.Brng().ChiSquareSampled(freedom,buffer);
        }

        [MethodImpl(Inline)]    
        public static ChiSquareSample<double> chi2(VslStream stream, int freedom, Span<double> buffer)
        {
            VSL.vdRngChiSquare(0, stream, buffer.Length, ref buffer[0], freedom).ThrowOnError();
            return stream.Brng().ChiSquareSampled(freedom,buffer);
        }

        /// <summary>
        /// Samples a single-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GaussianSample<float> gaussian(VslStream stream, float mu, float sigma, Span<float> buffer)
        {
            VSL.vsRngGaussian(VslGaussianMethod.BoxMuller1, stream, buffer.Length, ref buffer[0], mu, sigma).ThrowOnError();
            return stream.Brng().GaussianSample(mu,sigma,buffer);
        }

        /// <summary>
        /// Samples a single-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GaussianSample<double> gaussian(VslStream stream, double mu, double sigma, Span<double> buffer)
        {
            VSL.vdRngGaussian(VslGaussianMethod.BoxMuller1, stream, buffer.Length, ref buffer[0], mu, sigma).ThrowOnError();
            return stream.Brng().GaussianSample(mu,sigma,buffer);
        }


    }

}