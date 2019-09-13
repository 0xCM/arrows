//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
	using static zfunc;
    using static As;

    partial class mklx
    {
        /// <summary>
        /// Returns the sampler for a specified rng, data type and distribution spec
        /// </summary>
        /// <param name="rng">The random stream</param>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample point type</typeparam>
        public static ISampler<T> Sampler<T>(this MklRng rng, IDistributionSpec<T> spec)
            where T : unmanaged
        {
            var sampler = default(ISampler<T>);
            switch(spec.Kind)
            {
                case DistKind.Uniform:
                    sampler = rng.UniformSampler<T>(UniformSpec.From(spec));
                    break;
                case DistKind.UniformBits:
                    sampler = rng.UniformBitsSampler<T>(UniformBitsSpec.From(spec));
                    break;
                case DistKind.Bernoulli:
                    sampler = rng.BernoulliSampler<T>(BernoulliSpec.From(spec));                    
                    break;
                case DistKind.Gaussian:
                    sampler = rng.GaussianSampler<T>(GaussianSpec.From(spec));                    
                    break;
                default:
                    throw unsupported<T>();
            }

            return sampler;
        }

        /// <summary>
        /// Returns a uniform distribution sampler
        /// </summary>
        /// <param name="rng">The random stream</param>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample point type</typeparam>
        [MethodImpl(Inline)]
        public static ISampler<T> UniformSampler<T>(this MklRng rng, UniformSpec<T>? spec = null)
            where T : unmanaged
        {
            var _spec = spec ?? UniformSpec.Define<T>(PrimalInfo.minval<T>(), PrimalInfo.maxval<T>());
            var sampler = default(ISampler<T>);
            if(typeof(T) == typeof(int))
                sampler = samplers.uniform(rng, _spec.ToInt32()) as ISampler<T>;
            else if(typeof(T) == typeof(float))
                sampler = samplers.uniform(rng, _spec.ToFloat32()) as ISampler<T>;
            else if(typeof(T) == typeof(double))                    
                sampler = samplers.uniform(rng, _spec.ToFloat64()) as ISampler<T>;
            else
                throw unsupported<T>();                                        
            return sampler;
        }

        /// <summary>
        /// Returns a uniform bits distribution sampler
        /// </summary>
        /// <param name="rng">The random stream</param>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample point type</typeparam>
        [MethodImpl(Inline)]
        public static ISampler<T> UniformBitsSampler<T>(this MklRng rng, UniformBitsSpec<T>? spec = null)
            where T : unmanaged
        {
            var sampler = default(ISampler<T>);
            var _spec = spec ?? UniformBitsSpec.Define<T>();
            if(typeof(T) == typeof(uint))
                sampler = samplers.bits(rng, _spec.ToUInt32()) as ISampler<T>;
            else if(typeof(T) == typeof(ulong))
                sampler = samplers.bits(rng, _spec.ToUInt64()) as ISampler<T>;
            else
                throw unsupported<T>();                                        
            return sampler;
        }

        /// <summary>
        /// Returns a Bernoulli distribution sampler
        /// </summary>
        /// <param name="rng">The random stream</param>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample point type</typeparam>
        [MethodImpl(Inline)]
        public static ISampler<T> BernoulliSampler<T>(this MklRng rng, BernoulliSpec<T> spec)
            where T : unmanaged
        {
            var sampler = default(ISampler<T>);
            if(typeof(T) == typeof(int))
                sampler = samplers.bernoulli(rng,spec) as ISampler<T>;
            else
                throw unsupported<T>();                                        
            return sampler;
        }

        /// <summary>
        /// Returns a Gaussian distribution sampler
        /// </summary>
        /// <param name="rng">The random stream</param>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample point type</typeparam>
        [MethodImpl(Inline)]
        public static ISampler<T> GaussianSampler<T>(this MklRng rng, GaussianSpec<T> spec)
            where T : unmanaged
        {
            var sampler = default(ISampler<T>);
            if(typeof(T) == typeof(float))
                sampler = samplers.gaussian(rng, spec.ToFloat32()) as ISampler<T>;
            else if(typeof(T) == typeof(double))
                sampler = samplers.gaussian(rng, spec.ToFloat64()) as ISampler<T>;
            else
                throw unsupported<T>();                                        
            return sampler;
        }
    }

}