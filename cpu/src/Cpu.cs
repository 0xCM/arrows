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
         
    [StructLayout(LayoutKind.Explicit)]
    public struct Cpu
    {
        [FieldOffset(0)]
        internal YmmBank Ymm;

        [MethodImpl(Inline)]
        public static Cpu Init()
            => default;

        /// <summary>
        /// Selects a slot-identified xmm register
        /// </summary>
        /// <param name="slot">The slot index, an integer between 0 and 15</param>
        [MethodImpl(Inline)]
        public ref XMM xmm(int slot)
            => ref Ymm.XmmSlot(slot);

        /// <summary>
        /// Selects a slot-identified ymm register
        /// </summary>
        /// <param name="slot">The slot index, an integer between 0 and 15</param>
        [MethodImpl(Inline)]
        public ref YMM ymm(int slot)
            => ref Ymm.YmmSlot(slot);

        /// <summary>
        /// Selects the xmm register at slot 0
        /// </summary>
        public ref XMM xmm0
        {
            [MethodImpl(Inline)]
            get => ref xmm(0);
        }

        /// <summary>
        /// Selects the xmm register at slot 1
        /// </summary>
        public ref XMM xmm1
        {
            [MethodImpl(Inline)]
            get => ref xmm(1);
        }

        /// <summary>
        /// Selects the xmm register at slot 2
        /// </summary>
        public ref XMM xmm2
        {
            [MethodImpl(Inline)]
            get => ref xmm(2);
        }

        /// <summary>
        /// Selects the xmm register at slot 3
        /// </summary>
        public ref XMM xmm3
        {
            [MethodImpl(Inline)]
            get => ref xmm(3);
        }

        /// <summary>
        /// Selects the xmm register at slot 4
        /// </summary>
        public ref XMM xmm4
        {
            [MethodImpl(Inline)]
            get => ref xmm(4);
        }

        /// <summary>
        /// Selects the xmm register at slot 5
        /// </summary>
        public ref XMM xmm5
        {
            [MethodImpl(Inline)]
            get => ref xmm(5);
        }

        /// <summary>
        /// Selects the xmm register at slot 6
        /// </summary>
        public ref XMM xmm6
        {
            [MethodImpl(Inline)]
            get => ref xmm(6);
        }

        /// <summary>
        /// Selects the xmm register at slot 7
        /// </summary>
        public ref XMM xmm7
        {
            [MethodImpl(Inline)]
            get => ref xmm(7);
        }

        /// <summary>
        /// Selects the xmm register at slot 8
        /// </summary>
        public ref XMM xmm8
        {
            [MethodImpl(Inline)]
            get => ref xmm(8);
        }

        /// <summary>
        /// Selects the xmm register at slot 9
        /// </summary>
        public ref XMM xmm9
        {
            [MethodImpl(Inline)]
            get => ref xmm(9);
        }

        /// <summary>
        /// Selects the xmm register at slot 10
        /// </summary>
        public ref XMM xmm10
        {
            [MethodImpl(Inline)]
            get => ref xmm(10);
        }

        /// <summary>
        /// Selects the xmm register at slot 11
        /// </summary>
        public ref XMM xmm11
        {
            [MethodImpl(Inline)]
            get => ref xmm(11);
        }

        /// <summary>
        /// Selects the xmm register at slot 12
        /// </summary>
        public ref XMM xmm12
        {
            [MethodImpl(Inline)]
            get => ref xmm(12);
        }

        /// <summary>
        /// Selects the xmm register at slot 13
        /// </summary>
        public ref XMM xmm13
        {
            [MethodImpl(Inline)]
            get => ref xmm(13);
        }

        /// <summary>
        /// Selects the xmm register at slot 14
        /// </summary>
        public ref XMM xmm14
        {
            [MethodImpl(Inline)]
            get => ref xmm(14);
        }

        /// <summary>
        /// Selects the xmm register at slot 15
        /// </summary>
        public ref XMM xmm15
        {
            [MethodImpl(Inline)]
            get => ref xmm(15);
        }

        /// <summary>
        /// Selects the ymm register at slot 0
        /// </summary>
        public ref YMM ymm0
        {
            [MethodImpl(Inline)]
            get => ref ymm(0);
        }

        /// <summary>
        /// Selects the ymm register at slot 1
        /// </summary>
        /// <param name="src">The source bank</param>
        public ref YMM ymm1
        {
            [MethodImpl(Inline)]
            get => ref ymm(1);
        }

        /// <summary>
        /// Selects the ymm register at slot 2
        /// </summary>
        /// <param name="src">The source bank</param>
        public ref YMM ymm2
        {
            [MethodImpl(Inline)]
            get => ref ymm(2);
        }

        /// <summary>
        /// Selects the ymm register at slot 3
        /// </summary>
        /// <param name="src">The source bank</param>
        public ref YMM ymm3
        {
            [MethodImpl(Inline)]
            get => ref ymm(3);
        }

        /// <summary>
        /// Selects the ymm register at slot 4
        /// </summary>
        public ref YMM ymm4
        {
            [MethodImpl(Inline)]
            get => ref ymm(4);
        }

        /// <summary>
        /// Selects the ymm register at slot 5
        /// </summary>
        public ref YMM ymm5
        {
            [MethodImpl(Inline)]
            get => ref ymm(5);
        }

        /// <summary>
        /// Selects the ymm register at slot 6
        /// </summary>
        public ref YMM ymm6
        {
            [MethodImpl(Inline)]
            get => ref ymm(6);
        }

        /// <summary>
        /// Selects the ymm register at slot 7
        /// </summary>
        public ref YMM ymm7
        {
            [MethodImpl(Inline)]
            get => ref ymm(7);
        }

        /// <summary>
        /// Selects the ymm register at slot 8
        /// </summary>
        public ref YMM ymm8
        {
            [MethodImpl(Inline)]
            get => ref ymm(8);
        }

        /// <summary>
        /// Selects the ymm register at slot 9
        /// </summary>
        public ref YMM ymm9
        {
            [MethodImpl(Inline)]
            get => ref ymm(9);
        }

        /// <summary>
        /// Selects the ymm register at slot 10
        /// </summary>
        public ref YMM ymm10
        {
            [MethodImpl(Inline)]
            get => ref ymm(10);
        }

        /// <summary>
        /// Selects the ymm register at slot 11
        /// </summary>
        public ref YMM ymm11
        {
            [MethodImpl(Inline)]
            get => ref ymm(11);
        }

        /// <summary>
        /// Selects the ymm register at slot 12
        /// </summary>
        public ref YMM ymm12
        {
            [MethodImpl(Inline)]
            get => ref ymm(12);
        }

        /// <summary>
        /// Selects the ymm register at slot 13
        /// </summary>
        public ref YMM ymm13
        {
            [MethodImpl(Inline)]
            get => ref ymm(13);
        }

        /// <summary>
        /// Selects the ymm register at slot 14
        /// </summary>
        public ref YMM ymm14
        {
            [MethodImpl(Inline)]
            get => ref ymm(14);
        }

        /// <summary>
        /// Selects the ymm register at slot 15
        /// </summary>
        public ref YMM ymm15
        {
            [MethodImpl(Inline)]
            get => ref ymm(15);
        }
    }
}