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
    using static Registers;

    [StructLayout(LayoutKind.Explicit)]
    public struct Cpu
    {
        [FieldOffset(0)]
        XmmBank Xmm;

        [FieldOffset(0)]
        YmmBank Ymm;

        [MethodImpl(Inline)]
        public static Cpu Init()
            => default;

        [MethodImpl(Inline)]
        public static ref XMM xmm(ref Cpu cpu, int slot)
            => ref cpu.Xmm.Slot<XMM>(slot);

        /// <summary>
        /// Selects the xmm register at slot 0
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm0(ref Cpu src)
            => ref src.Xmm.xmm0;         

        /// <summary>
        /// Selects the xmm register at slot 1
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm1(ref Cpu src)
            => ref src.Xmm.xmm1;         

        /// <summary>
        /// Selects the xmm register at slot 2
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm2(ref Cpu src)
            => ref src.Xmm.xmm2;         

        /// <summary>
        /// Selects the xmm register at slot 3
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm3(ref Cpu src)
            => ref src.Xmm.xmm3;         

        /// <summary>
        /// Selects the xmm register at slot 4
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm4(ref Cpu src)
            => ref src.Xmm.xmm4;         

        /// <summary>
        /// Selects the xmm register at slot 5
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm5(ref Cpu src)
            => ref src.Xmm.xmm5;         

        /// <summary>
        /// Selects the xmm register at slot 6
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm6(ref Cpu src)
            => ref src.Xmm.xmm6;         

        /// <summary>
        /// Selects the xmm register at slot 7
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm7(ref Cpu src)
            => ref src.Xmm.xmm7;         

        /// <summary>
        /// Selects the xmm register at slot 8
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm8(ref Cpu src)
            => ref src.Xmm.xmm8;         

        /// <summary>
        /// Selects the xmm register at slot 9
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm9(ref Cpu src)
            => ref src.Xmm.xmm9;         

        /// <summary>
        /// Selects the xmm register at slot 10
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm10(ref Cpu src)
            => ref src.Xmm.xmm10;         

        /// <summary>
        /// Selects the xmm register at slot 11
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm11(ref Cpu src)
            => ref src.Xmm.xmm11;         

        /// <summary>
        /// Selects the xmm register at slot 12
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm12(ref Cpu src)
            => ref src.Xmm.xmm12;         

        /// <summary>
        /// Selects the xmm register at slot 13
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm13(ref Cpu src)
            => ref src.Xmm.xmm13;         

        /// <summary>
        /// Selects the xmm register at slot 14
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm14(ref Cpu src)
            => ref src.Xmm.xmm14;         

        /// <summary>
        /// Selects the xmm register at slot 15
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public static ref XMM xmm15(ref Cpu src)
            => ref src.Xmm.xmm15;         

        /// <summary>
        /// Selects an index-identified ymm register
        /// </summary>
        /// <param name="slot">The zero-based index of the register</param>
        [MethodImpl(Inline)]
        public static ref YMM ymm(ref Cpu src, int slot)
            => ref src.Ymm.Slot<XMM>(slot);

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

        /// <summary>
        /// Presents a source ymm register as a cpu vector
        /// </summary>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vec<T>(in XMM src)
            where T : unmanaged
                => XMM.AsVec<T>(in src);

        /// <summary>
        /// Presents a source register as a cpu vector
        /// </summary>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vec<T>(in YMM src)
            where T : unmanaged
                => YMM.AsVec<T>(in src);


        [MethodImpl(Inline)]
        public XMM xmm(int slot)
            => Xmm.Slot<XMM>(slot);

        /// <summary>
        /// Selects the xmm register at slot 0
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public XMM xmm0()
            => Xmm.xmm0;         

        /// <summary>
        /// Selects the xmm register at slot 1
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public XMM xmm1()
            => Xmm.xmm1;         

        /// <summary>
        /// Selects the xmm register at slot 2
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public XMM xmm2()
            => Xmm.xmm2;         

        /// <summary>
        /// Selects the xmm register at slot 3
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public XMM xmm3()
            => Xmm.xmm3;         

        /// <summary>
        /// Selects the xmm register at slot 4
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public XMM xmm4()
            => Xmm.xmm4;         

        /// <summary>
        /// Selects the xmm register at slot 5
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public XMM xmm5()
            => Xmm.xmm5;         

        /// <summary>
        /// Selects the xmm register at slot 6
        /// </summary>
        /// <param name="src">The source bank</param>
        [MethodImpl(Inline)]
        public XMM xmm6()
            => Xmm.xmm6;         

    }

}


