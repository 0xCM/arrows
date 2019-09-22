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
        /// Moves source vector content to a 128-bit register target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMM move<T>(Vector128<T> src, ref XMM dst)
            where T : unmanaged
        {
            dst = XMM.From(src);
            return ref dst;
        }

        /// <summary>
        /// Moves source vector content to a 128-bit register/memory target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMEM move<T>(Vector128<T> src, ref XMEM dst)
            where T : unmanaged
        {
            dst = XMEM.From(src);
            return ref dst;
        }

        /// <summary>
        /// Moves source vector content to a 256-bit register target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref YMM move<T>(Vector256<T> src, ref YMM dst)
            where T : unmanaged
        {
            dst = YMM.From(src);
            return ref dst;
        }

        /// <summary>
        /// Moves source vector content to a 256-bit register/memory target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref YMEM move<T>(Vector256<T> src, ref YMEM dst)
            where T : unmanaged
        {
            dst = YMEM.From(src);
            return ref dst;
        }

        /// <summary>
        /// Selects the xmm register at slot 0
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm0(ref Cpu src)
            => ref src.Ymm.XmmSlot(0);

        /// <summary>
        /// Selects the xmm register at slot 1
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm1(ref Cpu src)
            => ref src.Ymm.XmmSlot(1);

        /// <summary>
        /// Selects the xmm register at slot 2
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm2(ref Cpu src)
            => ref src.Ymm.XmmSlot(2);

        /// <summary>
        /// Selects the xmm register at slot 3
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm3(ref Cpu src)
            => ref src.Ymm.XmmSlot(3);

        /// <summary>
        /// Selects the xmm register at slot 4
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm4(ref Cpu src)
            => ref src.Ymm.XmmSlot(4);

        /// <summary>
        /// Selects the xmm register at slot 5
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm5(ref Cpu src)
            => ref src.Ymm.XmmSlot(5);

        /// <summary>
        /// Selects the xmm register at slot 6
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm6(ref Cpu src)
            => ref src.Ymm.XmmSlot(6);

        /// <summary>
        /// Selects the xmm register at slot 7
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm7(ref Cpu src)
            => ref src.Ymm.XmmSlot(7);

        /// <summary>
        /// Selects the xmm register at slot 8
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm8(ref Cpu src)
            => ref src.Ymm.XmmSlot(8);

        /// <summary>
        /// Selects the xmm register at slot 9
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm9(ref Cpu src)
            => ref src.Ymm.XmmSlot(9);

        /// <summary>
        /// Selects the xmm register at slot 10
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm10(ref Cpu src)
            => ref src.Ymm.XmmSlot(10);

        /// <summary>
        /// Selects the xmm register at slot 11
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm11(ref Cpu src)
            => ref src.Ymm.XmmSlot(11);

        /// <summary>
        /// Selects the xmm register at slot 12
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm12(ref Cpu src)
            => ref src.Ymm.XmmSlot(12);

        /// <summary>
        /// Selects the xmm register at slot 13
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm13(ref Cpu src)
            => ref src.Ymm.XmmSlot(13);

        /// <summary>
        /// Selects the xmm register at slot 14
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm14(ref Cpu src)
            => ref src.Ymm.XmmSlot(16);

        /// <summary>
        /// Selects the xmm register at slot 15
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm15(ref Cpu src)
            => ref src.Ymm.XmmSlot(15);

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
            => ref src.Ymm.YmmSlot(0);

        /// <summary>
        /// Selects the ymm register at slot 1
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm1(ref Cpu src)
            => ref src.Ymm.YmmSlot(1);

        /// <summary>
        /// Selects the ymm register at slot 2
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm2(ref Cpu src)
            => ref src.Ymm.YmmSlot(2);

        /// <summary>
        /// Selects the ymm register at slot 3
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm3(ref Cpu src)
            => ref src.Ymm.YmmSlot(3);

        /// <summary>
        /// Selects the ymm register at slot 4
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm4(ref Cpu src)
            => ref src.Ymm.YmmSlot(4);

        /// <summary>
        /// Selects the ymm register at slot 5
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm5(ref Cpu src)
            => ref src.Ymm.YmmSlot(5);

        /// <summary>
        /// Selects the ymm register at slot 6
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm6(ref Cpu src)
            => ref src.Ymm.YmmSlot(6);

        /// <summary>
        /// Selects the ymm register at slot 7
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm7(ref Cpu src)
            => ref src.Ymm.YmmSlot(7);

        /// <summary>
        /// Selects the ymm register at slot 8
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm8(ref Cpu src)
            => ref src.Ymm.YmmSlot(8);

        /// <summary>
        /// Selects the ymm register at slot 9
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm9(ref Cpu src)
            => ref src.Ymm.YmmSlot(9);

        /// <summary>
        /// Selects the ymm register at slot 10
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm10(ref Cpu src)
            => ref src.Ymm.YmmSlot(10);

        /// <summary>
        /// Selects the ymm register at slot 11
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm11(ref Cpu src)
            => ref src.Ymm.YmmSlot(11);            

        /// <summary>
        /// Selects the ymm register at slot 12
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm12(ref Cpu src)
            => ref src.Ymm.YmmSlot(12);

        /// <summary>
        /// Selects the ymm register at slot 13
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm13(ref Cpu src)
            => ref src.Ymm.YmmSlot(13);

        /// <summary>
        /// Selects the ymm register at slot 14
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm14(ref Cpu src)
            => ref src.Ymm.YmmSlot(14);

        /// <summary>
        /// Selects the ymm register at slot 15
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm15(ref Cpu src)
            => ref src.Ymm.YmmSlot(15);
    }

}