//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    using static As;


    public static partial class RngX
    {
        /// <summary>
        /// Creates a polyrand rng from a point source
        /// </summary>
        /// <param name="rng">The source rng</param>
        public static IPolyrand ToPolyrand(this IBoundPointSource<ulong> source)        
            => new Polyrand(source);

        /// <summary>
        /// Creates a System.Random rng from a random source
        /// </summary>
        /// <param name="rng"></param>
        [MethodImpl(Inline)]
        public static System.Random ToSysRand(this IPolyrand rng)
            => SysRand.Derive(rng);

        /// <summary>
        /// Creates a polyrand based on a specified source
        /// </summary>
        /// <param name="src">The random source</param>
        [MethodImpl(Inline)]
        public static IPolyrand ToPolyrand(this IStepwiseSource<ulong> src)
            => new Polyrand(src);

        /// <summary>
        /// Presents the polysource as a point source
        /// </summary>
        /// <param name="src">The randon source</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static IPointSource<T> PointSource<T>(this IPolyrand src)
            where T : unmanaged
                => src as IPointSource<T>;

        /// <summary>
        /// Samples a subsequence from a point source determined by successive sequence widths
        /// </summary>
        /// <param name="src">The point source</param>
        /// <param name="batchsize">The number of samples per batch</param>
        /// <param name="widths">The subsequence width markers</param>
        public static Span<(ulong count, T value)> SubSeq<T>(this IPointSource<T> src, int batchsize, ReadOnlySpan<ulong> widths)
            where T : unmanaged
        {
            var bufferlen = batchsize;

            var subseq = new (ulong,T)[widths.Length];
            Span<T> buffer = new T[bufferlen];

            for(var i=0; i< subseq.Length; i++)
            {
                var count = 0ul;
                while(count < widths[i])
                {
                    src.StreamTo(bufferlen, ref head(buffer));
                    count += Math.Min(widths[i],(ulong)bufferlen);
                }
                subseq[i] = (count, buffer.Last());                
            }
            return subseq;

        }

        public static Span<(ulong count, T value)> SubSeq<T>(this IPointSource<T> src, int batchsize, params ulong[] widths)        
            where T : unmanaged
                => src.SubSeq(batchsize, widths.ToSpan());
              
        public static Span<(ulong count, T value)> SubSeq<T>(this IPointSource<T> src, int batchsize, ulong width, int count)        
            where T : unmanaged
        {
            Span<ulong> widths = new ulong[count];
            widths.Fill(width);
            return src.SubSeq(batchsize, widths);

        }

    }


}