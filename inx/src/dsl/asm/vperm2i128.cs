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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static Reg;
    using static Perm2x128Step;
    
    partial class Asm
    {
        /// <summary>
        /// VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// Blends the source vectors as directed by the control value
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="control"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/vperm2i128</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vperm2i128(YMM a, YMM b, byte control)        
            => Permute2x128(vload<ulong>(ref a), vload<ulong>(ref b), control);

        [MethodImpl(Inline)]
        public static Vector256<ulong> vperm2i128(Vector256<ulong> a, Vector256<ulong> b, byte control)        
            => Permute2x128(a, b, control);

        /// <summary>
        /// VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// Blends the source vectors as directed by the control value
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="control"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/vperm2f128</remarks>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm2f128(YMM a, YMM b, byte control)        
            => Permute2x128(vload<double>(ref a), vload<double>(ref b), control);

        /// <summary>
        /// VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// Construct a target from the source vectors as directed by the control value
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="control">Specifies how to form the target fromthe sources</param>
        [MethodImpl(Inline)]
        public static YMM vperm2i128(YMM a, YMM b, Perm2x128 control)        
            => YMM.From(vperm2i128(a,b, (byte)control));

        /// <summary>
        /// VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// Blends the source vectors as directed by the control value
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="control">Specifies how to form the target fromthe sources</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vperm2f128(YMM a, YMM b, Perm2x128 control)        
            => Permute2x128(vload<byte>(ref a), vload<byte>(ref  b), (byte)control);
    }

    /// <summary>
    /// Defines 2x128 permutation classifiers
    /// </summary>
    [Flags]
    public enum Perm2x128 : byte
    {            
        /// <summary>
        /// Assemble the target vector from the lo part of the first source vector and the lo part of the second source vector
        /// [AB] [CD] => [AC]
        /// </summary>
        AC = AB_LO_LO | CD_LO_HI,
        
        /// <summary>
        /// Assemble the target vector from the lo part of the first source vector and the hi part of the second source vector
        /// [AB] [CD] => [AD]
        /// </summary>
        AD = AB_LO_LO | CD_HI_HI,

        /// <summary>
        /// Assemble the target vector from the hi part of the first source vector and the lo part of the second source vector
        /// [AB] [CD] => [BC]
        /// </summary>
        BC = AB_HI_LO | CD_LO_HI,

        /// <summary>
        /// Assemble the target vector from the hi part of the first source vector and the hi part of the second source vector
        /// [AB] [CD] => [BD]
        /// </summary>
        BD = AB_HI_LO | CD_HI_HI,

        /// <summary>
        /// Assemble the target vector from the lo part of the second source vector and the lo part of the first source vector and the 
        /// [AB] [CD] => [CA]
        /// </summary>
        CA = CD_LO_LO | AB_LO_HI,

        /// <summary>
        /// Assemble the target vector from lo part of the second source vector and the hi part of the first source vector
        /// [AB] [CD] => [CB]
        /// </summary>
        CB = CD_LO_LO | AB_HI_HI ,

        /// <summary>
        /// Assemble the target vector from hi part of the second source vector and the lo part of the first source vector
        /// [AB] [CD] => [DA]
        /// </summary>
        DA = CD_HI_LO | AB_LO_HI,
        
        /// <summary>
        /// Assemble the target vector from the hi part of the second source vector and the hi part of the first source vector
        /// [AB] [CD] => [DB]
        /// </summary>
        DB = CD_HI_LO | AB_HI_HI ,
    }

    [Flags]
    internal enum Perm2x128Step : byte
    {
        /// <summary>
        /// DEST[127:0]←SRC1[127:0] 
        /// Map the lo part of the first source vector to the lo part of the target vector
        /// </summary>
        AB_LO_LO = 0b00,

        /// <summary>
        /// DEST[127:0]←SRC1[255:128]
        /// Map the hi part of the first source vector to the lo part of the target vector
        /// </summary>
        AB_HI_LO = 0b01,

        /// <summary>
        /// DEST[127:0]←SRC2[127:0]
        /// Map the lo part of the second source vector to the lo part of the target vector
        /// </summary>
        CD_LO_LO = 0b10,

        /// <summary>
        /// DEST[127:0]←SRC2[255:128]
        /// Map the hi part of the second source vector to the lo part of the target vector
        /// </summary>
        CD_HI_LO = 0b11,

        /// <summary>
        /// IMM8[5:4] = 0 => DEST[255:128]←SRC1[127:0]
        /// Map the lo part of the first source vector to the hi part of the target vector
        /// </summary>
        AB_LO_HI = 0b00_0000,

        /// <summary>
        /// IMM8[5:4] = 1 => DEST[255:128]←SRC1[255:128]
        /// Map the hi part of the first source vector to the hi part of the target vector
        /// </summary>
        AB_HI_HI = 0b01_0000,

        /// <summary>
        /// IMM8[5:4] = 2 => DEST[255:128]←SRC2[127:0]
        /// Map the lo part of the second source vector to the hi part of the target vector
        /// </summary>
        CD_LO_HI = 0b10_0000,

        /// <summary>
        /// IMM8[5:4] = 3 => DEST[255:128]←SRC2[255:128]
        /// Map the hi part of the second source vector to the hi part of the target vector
        /// </summary>
        CD_HI_HI = 0b11_0000,

    }

}