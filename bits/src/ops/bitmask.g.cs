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
        /// Calculates the bitsize of the source type
        /// </summary>
        /// <typeparam name="T">The soruce type</typeparam>
        public static BitSize width<T>()
            where T : struct
                => Unsafe.SizeOf<T>()*8;

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

        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref T set<T>(ref T src, byte pos, in Bit value)            
            where T : struct
                => ref BitMaskG.set(ref src, pos, value);

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref T setif<T>(in T src, int srcpos, ref T dst, int dstpos)
            where T : struct
                => ref BitMaskG.setif(in src, srcpos, ref dst, dstpos);

    }
}