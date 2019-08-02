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
    using static As;

    /// <summary>
    /// Provides a random source implementation predicated on <see cref'System.Random'/>
    /// </summary>
    public sealed class SysRandSource : IRandomSource
    {
        public static IRandomSource Create()
            => new SysRandSource(new System.Random());

        public static IRandomSource FromSysRand(System.Random src)
            => new SysRandSource(src);

        readonly System.Random Random;
        
        SysRandSource(System.Random src)
            => this.Random = src;

        [MethodImpl(Inline)]
        public double NextDouble()
            => Random.NextDouble();

        [MethodImpl(Inline)]
        public int NextInt32(int max)
            => Random.Next(max);

        [MethodImpl(Inline)]
        public ulong NextUInt64()
            => (ulong)BitConverter.DoubleToInt64Bits(Random.NextDouble());

        [MethodImpl(Inline)]
        public ulong NextUInt64(ulong max)
            => NextUInt64().Contract(max);
    }



}