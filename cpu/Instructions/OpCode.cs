//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public readonly struct VEX2
    {

    }

    public readonly struct VEX3
    {

    }

    //1, 2 or 3 bytes
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct OpCode
    {
        [FieldOffset(0)]
        readonly byte Part1;

        [FieldOffset(1)]
        readonly byte Part2;

        [FieldOffset(2)]
        readonly byte Part3;

    }
    public readonly struct OpCodeSegment
    {


    }




}