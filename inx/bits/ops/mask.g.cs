//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static ref T enable<T>(ref T src, in int pos)
            where T : struct
                => ref BitMaskG.enable(ref src, in pos);

        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static T enable<T>(T src, in int pos)
            where T : struct
                => BitMaskG.enable(ref src, in pos);

        /// <summary>
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static ref T disable<T>(ref T src, byte pos)
            where T : struct
                => ref BitMaskG.disable(ref src, (byte)pos);

        /// <summary>
        /// Determines whether a position-identified bit in value is enabled
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static bool test<T>(in T src,in int pos)
            where T : struct
                => BitMaskG.test(in src, (byte)pos);

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        public static bool test<T>(in T src, byte pos)
            where T : struct
                => BitMaskG.test(in src, pos);

    }
}