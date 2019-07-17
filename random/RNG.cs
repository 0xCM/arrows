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
    public static class RNG
    {
        static IRandomSource Entropic = new XOrShift1024(Seed1024.Entropic);

        internal static Interval<T> TypeDomain<T>()
            where T : struct
        {
            var min = gmath.signed<T>() && !gmath.floating<T>()
                ? gmath.negate(gbits.shiftr(gmath.maxval<T>(), 1)) 
                : gmath.zero<T>();
            
            var max = 
                gmath.signed<T>() && !gmath.floating<T>()
                ? gbits.shiftr(gmath.maxval<T>(), 1)
                : gmath.maxval<T>();
            
            return leftclosed(min,max);

        }

        public static IRandomSource Default
            => Entropic;
            
        public static IRandomSource XOrShift1024(ulong[] seed = null)
            => new XOrShift1024(seed ?? Seed1024.Default);

        public static IRandomSource XOrStarStar256(ulong[] seed = null)
            => new XOrShift256(seed ?? Seed256.Default);
 
        public static Pcg32 Pcg32(ulong s0, ulong? index = null)
            => Z0.Pcg32.Define(s0, index);        

        public static Pcg64 Pcg64(ulong s0, ulong? index = null)
            => Z0.Pcg64.Define(s0, index);     

        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        public static IRandomSource<ulong> WyHash64(ulong? seed = null)
            => new WyHash64(seed ?? BitConverter.ToUInt64(Entropy.Bytes(8)));        

        /// <summary>
        /// Creates a WyHash64 generator suite
        /// </summary>
        /// <param name="n">The number of suite generators</param>
        /// <param name="seed">The optional seed which, if of nonzero length, must have matching natural length</param>
        /// <typeparam name="N">The natural length type</typeparam>
        public static IRandomSource<N,ulong> WyHash64Suite<N>(N n = default, params ulong[] seed)
            where N : ITypeNat, new()
        {
            Span<N,ulong> _seed;
            if(seed.Length == 0)
                _seed = Entropy.Values<N,ulong>();
            else if(seed.Length == (int)n.value)
                _seed = NatSpan.load<N,ulong>(ref seed[0]);
            else
                throw Errors.LengthMismatch((int)n.value, seed.Length);
            return new WyHash64Suite<N>(_seed);
        }

        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        /// <param name="increment">The generator step size</param>
        public static IRandomSource<ushort> WyHash16(ushort? seed = null, ushort? increment = null)
            => new WyHash16(seed ?? BitConverter.ToUInt16(Entropy.Bytes(2)),increment);

        /// <summary>
        /// Creates a polyrand based on a specified source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <returns></returns>
        public static Polyrand Polyrand(IRandomSource random)
            => new Polyrand((IRandomSource<ulong>)random);

    }

}