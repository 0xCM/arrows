//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;

    using static Pow2;
    using static GpRegIdBase;
    using static RegIdOffset;

    
    [Flags,Info(Desc.RegIdInfo, BitWidth.Bw16)]
    public enum GpRegId16 : ulong
    {
        
        /// <summary>
        /// accumulator
        /// </summary>
        ax =  gpb16,

        /// <summary>
        /// base pointer
        /// </summary>
        bx = gpb16 | offset1,

        /// <summary>
        /// counter
        /// </summary>        
        cx = gpb16 | offset2,

        /// <summary>
        /// data
        /// </summary>
        dx = gpb16 | offset3,
        
        /// <summary>
        /// source index
        /// </summary>
        si  = gpb16 | offset4,

        /// <summary>
        /// destination index
        /// </summary>
        di = gpb16 | offset5,

        /// <summary>
        /// stack-based pointer
        /// </summary>
        bp = gpb16 | offset6,

        /// <summary>
        /// stack pointer
        /// </summary>
        sp = gpb16 | offset7,

        r8w = gpb16 | offset8,

        r9w = gpb16 | offset19,

        r10w = gpb16 | offset10,

        r11w = gpb16 | offset11,

        r12w= gpb16 | offset12,

        r13w = gpb16 | offset13,

        r14w = gpb16 | offset14,
 
        r15w = gpb16 | offset15,
    }

}