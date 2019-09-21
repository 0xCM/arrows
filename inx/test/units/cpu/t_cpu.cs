//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    using static IMM;

    public abstract class t_cpu<T> : UnitTest<T>
        where T : t_cpu<T>, new()
    {

        protected Cpu cpu;

        protected t_cpu()
        {
            cpu = Cpu.Init();
        }

        /// <summary>
        /// Returns a slot-identified XMM cpu register refererence
        /// </summary>
        /// <param name="slot">The slot index of the register, an integer betwee 0 and 15</param>
        [MethodImpl(Inline)]
        protected ref XMM xmm(int slot)                
            => ref cpu.xmm(slot);

        /// <summary>
        /// Returns a slot-identified YMM cpu register refererence
        /// </summary>
        /// <param name="slot">The slot index of the register, an integer betwee 0 and 15</param>
        [MethodImpl(Inline)]
        protected ref YMM ymm(int slot)                
            => ref cpu.ymm(slot);

        [MethodImpl(Inline)]
        protected Imm8 imm8(Bit? b0 = null, Bit? b1 = null, Bit? b2 = null, Bit? b3 = null,Bit? b4 = null, Bit? b5 = null, Bit? b6 = null, Bit? b7 = null)
            => Imm8.From(b0 ?? 0, b1 ?? 0, b2 ?? 0, b3 ?? 0, b4 ?? 0, b5 ?? 0, b6 ?? 0, b7 ?? 0);

        /// <summary>
        /// Formats a slot-identified XMM register as cells of specified type
        /// </summary>
        /// <param name="i">The slot index</param>
        /// <typeparam name="X">The cell type</typeparam>
        protected string FormatXmm<X>(int i)
            where X : unmanaged
                => cpu.XmmFormat<X>(i);

        /// <summary>
        /// Formats a slot-identified XMM register as cells of specified type
        /// </summary>
        /// <param name="i">The slot index</param>
        /// <typeparam name="X">The cell type</typeparam>
        protected string FormatYmm<X>(int i)
            where X : unmanaged
                => cpu.YmmFormat<X>(i);

        /// <summary>
        /// Block-formats an immediate
        /// </summary>
        /// <param name="i">The slot index</param>
        /// <typeparam name="X">The cell type</typeparam>
        protected string FormatImm<X>(Imm8 imm)
            where X : unmanaged
                => imm.FormatBlocked<X>();

    }

}