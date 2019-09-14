//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Fatory for RNG's
    /// </summary>
    public static class Rng
    {
        [MethodImpl(Inline)]
        static T TypeMin<T>()
            where T : struct
                => gmath.minval<T>();
        
        static T TypeMax<T>()
            where T : struct
                => gmath.maxval<T>();

        public static Interval<T> TypeDomain<T>()
            where T : struct
        {
            var min = gmath.signed<T>() && !gmath.floating<T>()
                ? gmath.negate(gbits.sar(TypeMax<T>(), 1)) 
                : gmath.zero<T>();
            
            var max = 
                gmath.signed<T>() && !gmath.floating<T>()
                ? gbits.sar(TypeMax<T>(), 1)
                : gmath.maxval<T>();
            
            return leftclosed(min,max);
        }

        /// <summary>
        /// Retrieves a non-deterministic seed
        /// </summary>
        /// <typeparam name="T">The seed type</typeparam>
        [MethodImpl(Inline)]
        public static T EntropicSeed<T>()            
            where T : struct
                => Entropy.Value<T>();
        
        /// <summary>
        /// Retrieves a seeed from embedded application resources that, for a given
        /// index, remanins fixed
        /// </summary>
        /// <typeparam name="T">The seed type</typeparam>
        [MethodImpl(Inline)]
        public static T FixedSeed<T>(T index)
            where T : struct
                => RngSeed.TakeSingle<T>(convert<T,int>(index));

        /// <summary>
        /// Retrieves descriptive information for fixed seed data
        /// </summary>
        /// <param name="ByteCount">The total number of bytes available</param>
        /// <param name="MaxIndex">The maximum index for one value of the parametric type</param>
        /// <typeparam name="T">The type relative to which the maximum index is computed</typeparam>
        [MethodImpl(Inline)]
        public static (ByteSize ByteCount, int MaxIndex) FixedSeedStats<T>()
            where T : struct
                => (RngSeed.SourceLength, RngSeed.MaxOffset<T>());

        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        [MethodImpl(Inline)]
        public static IPolyrand WyHash64(ulong? seed = null)
            => new WyHash64(seed ?? Seed64.Seed00).ToPolyrand();        

        /// <summary>
        /// Creates a 128-bit xorshift rng initialezed with a specified seed
        /// </summary>
        /// <param name="s0">The first seed value</param>
        /// <param name="s1">The second seed value</param>
        /// <param name="s2">The third seed value</param>
        /// <param name="s3">The fourth seed value</param>
        [MethodImpl(Inline)]
        public static IPointSource<uint> XOr128(uint? s0 = null, uint? s1 = null, uint? s2 = null, uint? s3 = null)
            => new XOrShift128(s0 ?? Seed32.Seed00,s1 ?? Seed32.Seed01, s2 ?? Seed32.Seed02, s3 ?? Seed32.Seed03);

        [MethodImpl(Inline)]
        public static IPointSource<uint> XOr128(ReadOnlySpan<uint> state, int offset = 0)
            => new XOrShift128(state.Slice(offset));

        /// <summary>
        /// Creates an XOrShift 1024 rng
        /// </summary>
        /// <param name="seed">The initial state</param>
        [MethodImpl(Inline)]
        public static IPolyrand XOrShift1024(ulong[] seed = null)
            => new XOrShift1024(seed ?? Seed1024.Default).ToPolyrand();

        static Vector<N6,uint> Seed6x32 = new uint[]{0xFA243, 0xAD941, 0xBC883, 0xDB193, 0xAA137, 0xB1B39};

        [MethodImpl(Inline)]
        public static IPointSource<uint> Mrg32k3a(Vector<N6,uint>? seed = null)
            => new Mrg32K3A(seed ?? Seed6x32);

        /// <summary>
        /// Creates an XOrShift 1024 rng
        /// </summary>
        /// <param name="seed">The initial state</param>
        [MethodImpl(Inline)]
        public static IPolyrand XOrStarStar256(ulong[] seed = null)
            => XOrShift256.Define(seed ?? Seed256.Default).ToPolyrand();
 
        /// <summary>
        /// Creates a splitmix 64-bit generator
        /// </summary>
        /// <param name="seed">The initial state of the generator, if specified; 
        /// otherwise, the seed is obtained from an entropy source</param>
        [MethodImpl(Inline)]
        public static IPolyrand SplitMix(ulong? seed = null)
            => SplitMix64.Define(seed ?? Seed64.Seed00).ToPolyrand();

        /// <summary>
        /// Creates a 32-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The inital rng state</param>
        /// <param name="index">The stream index, if any</param>
        public static IStepwiseSource<uint> Pcg32(ulong? seed = null, ulong? index = null)
            => Z0.Pcg32.Define(seed ?? Seed64.Seed00, index);        

        /// <summary>
        /// Creates a 64-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The inital rng state</param>
        /// <param name="index">The stream index, if any</param>
        public static IPolyrand Pcg64(ulong? seed = null, ulong? index = null)
            => Z0.Pcg64.Define(seed ?? Seed64.Seed00, index).ToPolyrand();     

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on an array of seed and stream indices
        /// </summary>
        /// <param name="seed">The initial state of a generator</param>
        /// <param name="index">The stream index</param>
        public static IRngSuite<N> Pcg64Suite<N>(N n, params (ulong seed, ulong index)[] specs)
            where N : ITypeNat, new()
        {
            var suite = new IPolyrand[specs.Length];
            for(var i=0; i < suite.Length; i++)
            {
                (var seed, var index) = specs[i];
                suite[i] = Pcg64(seed, index);
            }
            return new RngSuite<N>(suite);
        }

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on spans of seeds and stream indices
        /// </summary>
        /// <param name="seed">The initial rng states</param>
        /// <param name="indices">A span of index values</param>
        public static IRngSuite<N> Pcg64Suite<N>(Span<ulong> seeds, Span<ulong> indices)        
            where N : ITypeNat, new()

        {
            var count = length(seeds,indices);
            var members = new IPolyrand[count];
            for(var i=0; i<count; i++)
                members[i] = Pcg64(seeds[i], indices[i]);
            return new RngSuite<N>(members);
        }    

        /// <summary>
        /// Creates a WyHash64 generator suite
        /// </summary>
        /// <param name="n">The number of suite generators</param>
        /// <param name="seed">The optional seed which, if of nonzero length, must have matching natural length</param>
        /// <typeparam name="N">The natural length type</typeparam>
        public static IRngSuite<N> WyHash64Suite<N>(N n = default, params ulong[] seed)
            where N : ITypeNat, new()
        {
            Span<N,ulong> _seed;
            if(seed.Length == 0)
                _seed = Entropy.Values<N,ulong>();
            else if(seed.Length == (int)n.value)
                _seed = NatSpan.Load<N,ulong>(ref seed[0]);
            else
                throw Errors.LengthMismatch((int)n.value, seed.Length);

            var members = new IPolyrand[n.value];
            for(var i=0; i<members.Length; i++)
                members[i] = WyHash64(_seed[i]);

            return new RngSuite<N>(members);
        }

        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        /// <param name="increment">The generator step size</param>
        public static IBoundPointSource<ushort> WyHash16(ushort? seed = null, ushort? increment = null)
            => new WyHash16(seed ?? BitConverter.ToUInt16(Entropy.Bytes(2)),increment);

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on an array of seed and stream indices
        /// </summary>
        /// <param name="seed">The initial state of a generator</param>
        /// <param name="index">The stream index</param>
        public static IStepwiseSource<uint>[] Pcg32Suite(params (ulong seed, ulong index)[] specs)
        {
            var suite = new IStepwiseSource<uint>[specs.Length];
            for(var i=0; i < suite.Length; i++)
            {
                (var seed, var index) = specs[i];
                suite[i] = Pcg32(seed, index);
            }
            return suite;
        }

        /// <summary>
        /// Creates a 32-bit Pcg RNG suite predicated on spans of seeds and stream indices
        /// </summary>
        /// <param name="seeds">A span of seed values</param>
        /// <param name="indices">A span of index values</param>
        public static Span<IStepwiseSource<uint>> Pcg32Suite(Span<ulong> seeds, Span<ulong> indices)        
        {
            var count = length(seeds,indices);
            var g = span<IStepwiseSource<uint>>(count);
            for(var i=0; i<count; i++)
                g[i] = Pcg32(seeds[i], indices[i]);
            return g;
        }  
    }
}