//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;


    public static partial class Reg
    {


        /// <summary>
        /// Presents a source register as a 128-bit cpu vector
        /// </summary>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vec<T>(in XMM src)
            where T : unmanaged
                => XMM.AsVec<T>(in src);

        /// <summary>
        /// Presents a source register as a 256-bit cpu vector
        /// </summary>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vec<T>(in YMM src)
            where T : unmanaged
                => YMM.Vec256<T>(in src);

        /// <summary>
        /// Moves source vector content to a 128-bit register target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMM transfer<T>(Vector128<T> src, ref XMM dst)
            where T : unmanaged
                => ref XMM.Assign(src, ref dst);

        /// <summary>
        /// Moves source vector content to a 128-bit register/memory target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMEM transfer<T>(Vector128<T> src, ref XMEM dst)
            where T : unmanaged
                => ref XMEM.Assign(src, ref dst);

        /// <summary>
        /// Moves source vector content to a 256-bit register target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref YMM transfer<T>(Vector256<T> src, ref YMM dst)
            where T : unmanaged
                => ref YMM.Assign(src, ref dst);

        /// <summary>
        /// Moves source vector content to a 256-bit register/memory target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref YMEM transfer<T>(Vector256<T> src, ref YMEM dst)
            where T : unmanaged
                => ref YMEM.Assign(src, ref dst);


        /// <summary>
        /// Selects the xmm register at slot 0
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm0(ref Cpu src)
            => ref src.Ymm.xmm0;         

        /// <summary>
        /// Selects the xmm register at slot 1
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm1(ref Cpu src)
            => ref src.Ymm.xmm1;         

        /// <summary>
        /// Selects the xmm register at slot 2
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm2(ref Cpu src)
            => ref src.Ymm.xmm2;         

        /// <summary>
        /// Selects the xmm register at slot 3
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm3(ref Cpu src)
            => ref src.Ymm.xmm3;         

        /// <summary>
        /// Selects the xmm register at slot 4
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm4(ref Cpu src)
            => ref src.Ymm.xmm4;         

        /// <summary>
        /// Selects the xmm register at slot 5
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm5(ref Cpu src)
            => ref src.Ymm.xmm5;         

        /// <summary>
        /// Selects the xmm register at slot 6
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm6(ref Cpu src)
            => ref src.Ymm.xmm6;         

        /// <summary>
        /// Selects the xmm register at slot 7
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm7(ref Cpu src)
            => ref src.Ymm.xmm7;         

        /// <summary>
        /// Selects the xmm register at slot 8
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm8(ref Cpu src)
            => ref src.Ymm.xmm8;         

        /// <summary>
        /// Selects the xmm register at slot 9
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm9(ref Cpu src)
            => ref src.Ymm.xmm9;         

        /// <summary>
        /// Selects the xmm register at slot 10
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm10(ref Cpu src)
            => ref src.Ymm.xmm10;         

        /// <summary>
        /// Selects the xmm register at slot 11
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm11(ref Cpu src)
            => ref src.Ymm.xmm11;         

        /// <summary>
        /// Selects the xmm register at slot 12
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm12(ref Cpu src)
            => ref src.Ymm.xmm12;         

        /// <summary>
        /// Selects the xmm register at slot 13
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm13(ref Cpu src)
            => ref src.Ymm.xmm13;         

        /// <summary>
        /// Selects the xmm register at slot 14
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm14(ref Cpu src)
            => ref src.Ymm.xmm14;         

        /// <summary>
        /// Selects the xmm register at slot 15
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm15(ref Cpu src)
            => ref src.Ymm.xmm15;         

        [MethodImpl(Inline)]
        public static ref XMM xmm(ref Cpu cpu, int slot)
            => ref cpu.Ymm.XmmSlot(slot);

        /// <summary>
        /// Selects an index-identified ymm register
        /// </summary>
        /// <param name="slot">The zero-based index of the register</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm(ref Cpu src, int slot)
            => ref src.Ymm.YmmSlot(slot);

        /// <summary>
        /// Selects the ymm register at slot 0
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm0(ref Cpu src)
            => ref src.Ymm.ymm0;         

        /// <summary>
        /// Selects the ymm register at slot 1
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm1(ref Cpu src)
            => ref src.Ymm.ymm1;         

        /// <summary>
        /// Selects the ymm register at slot 2
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm2(ref Cpu src)
            => ref src.Ymm.ymm2;         

        /// <summary>
        /// Selects the ymm register at slot 3
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm3(ref Cpu src)
            => ref src.Ymm.ymm3;         

        /// <summary>
        /// Selects the ymm register at slot 4
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm4(ref Cpu src)
            => ref src.Ymm.ymm4;         

        /// <summary>
        /// Selects the ymm register at slot 5
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm5(ref Cpu src)
            => ref src.Ymm.ymm5;         

        /// <summary>
        /// Selects the ymm register at slot 6
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm6(ref Cpu src)
            => ref src.Ymm.ymm6;         

        /// <summary>
        /// Selects the ymm register at slot 7
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm7(ref Cpu src)
            => ref src.Ymm.ymm7;         

        /// <summary>
        /// Selects the ymm register at slot 8
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm8(ref Cpu src)
            => ref src.Ymm.ymm8;         

        /// <summary>
        /// Selects the ymm register at slot 9
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm9(ref Cpu src)
            => ref src.Ymm.ymm9;         

        /// <summary>
        /// Selects the ymm register at slot 10
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm10(ref Cpu src)
            => ref src.Ymm.ymm10;         

        /// <summary>
        /// Selects the ymm register at slot 11
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm11(ref Cpu src)
            => ref src.Ymm.ymm11;         

        /// <summary>
        /// Selects the ymm register at slot 12
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm12(ref Cpu src)
            => ref src.Ymm.ymm12;         

        /// <summary>
        /// Selects the ymm register at slot 13
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm13(ref Cpu src)
            => ref src.Ymm.ymm13;         

        /// <summary>
        /// Selects the ymm register at slot 14
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm14(ref Cpu src)
            => ref src.Ymm.ymm14;         

        /// <summary>
        /// Selects the ymm register at slot 15
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm15(ref Cpu src)
            => ref src.Ymm.ymm15;         
    }

}