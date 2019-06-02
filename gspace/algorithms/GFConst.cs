//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
// Thie this is a deriviative work based on
// GF-Complete: A Comprehensive Open Source Library for Galois Field Arithmetic
// James S. Plank, Ethan L. Miller, Kevin M. Greenan,
// Benjamin A. Arnold, John A. Burnum, Adam W. Disney, Allen C. McBride.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static As;
    using static zfunc;


    partial class GF
    {
        /// <summary>
        /// These are the different ways to perform multiplication. Not all are implemented for all values of w. 
        /// See the paper for an explanation of how they work.
        /// </summary>
        public enum gf_mult_type_t 
        {
            GF_MULT_DEFAULT,
            GF_MULT_SHIFT,
            GF_MULT_CARRY_FREE,
            GF_MULT_CARRY_FREE_GK,
            GF_MULT_GROUP,
            GF_MULT_BYTWO_p,
            GF_MULT_BYTWO_b,
            GF_MULT_TABLE,
            GF_MULT_LOG_TABLE,
            GF_MULT_LOG_ZERO,
            GF_MULT_LOG_ZERO_EXT,
            GF_MULT_SPLIT_TABLE,
            GF_MULT_COMPOSITE 
        } 

    
        [Flags]
        public enum gf_region_type_t : uint
        {
            GF_REGION_DEFAULT = 0x0,
            GF_REGION_DOUBLE_TABLE = 0x1,
            GF_REGION_QUAD_TABLE   = 0x2,
            GF_REGION_LAZY = 0x4,
            GF_REGION_SIMD = 0x8,
            GF_REGION_SSE = 0x8,
            GF_REGION_NOSIMD = 0x10,
            GF_REGION_NOSSE = 0x10,
            GF_REGION_ALTMAP = 0x20,
            GF_REGION_CAUCHY = 0x40,
        }
    
        /// <summary>
        /// These are different ways to implement division. Once again, it's best to use "DEFAULT".  
        /// However, there are times when you may want to experiment with the others. 
        /// </summary>
        public enum gf_division_type_t
        { 
            GF_DIVIDE_DEFAULT,
            GF_DIVIDE_MATRIX,
            GF_DIVIDE_EUCLID 
        }

        public enum gf_error_type_t
        {
            GF_E_MDEFDIV, /* Dev != Default && Mult == Default */
            GF_E_MDEFREG, /* Reg != Default && Mult == Default */
            GF_E_MDEFARG, /* Args != Default && Mult == Default */
            GF_E_DIVCOMP, /* Mult == Composite && Div != Default */
            GF_E_CAUCOMP, /* Mult == Composite && Reg == CAUCHY */
            GF_E_DOUQUAD, /* Reg == DOUBLE && Reg == QUAD */
            GF_E_SIMD_NO, /* Reg == SIMD && Reg == NOSIMD */
            GF_E_CAUCHYB, /* Reg == CAUCHY && Other Reg */
            GF_E_CAUGT32, /* Reg == CAUCHY && w > 32*/
            GF_E_ARG1SET, /* Arg1 != 0 && Mult \notin COMPOSITE/SPLIT/GROUP */
            GF_E_ARG2SET, /* Arg2 != 0 && Mult \notin SPLIT/GROUP */
            GF_E_MATRIXW, /* Div == MATRIX && w > 32 */
            GF_E_BAD___W, /* Illegal w */
            GF_E_DOUBLET, /* Reg == DOUBLE && Mult != TABLE */
            GF_E_DOUBLEW, /* Reg == DOUBLE && w \notin {4,8} */
            GF_E_DOUBLEJ, /* Reg == DOUBLE && other Reg */
            GF_E_DOUBLEL, /* Reg == DOUBLE & LAZY but w = 4 */
            GF_E_QUAD__T, /* Reg == QUAD && Mult != TABLE */
            GF_E_QUAD__W, /* Reg == QUAD && w != 4 */
            GF_E_QUAD__J, /* Reg == QUAD && other Reg */
            GF_E_LAZY__X, /* Reg == LAZY && not DOUBLE or QUAD*/
            GF_E_ALTSHIF, /* Mult == Shift && Reg == ALTMAP */
            GF_E_SSESHIF, /* Mult == Shift && Reg == SIMD|NOSIMD */
            GF_E_ALT_CFM, /* Mult == CARRY_FREE && Reg == ALTMAP */
            GF_E_SSE_CFM, /* Mult == CARRY_FREE && Reg == SIMD|NOSIMD */
            GF_E_PCLMULX, /* Mult == Carry_Free && No PCLMUL */
            GF_E_ALT_BY2, /* Mult == Bytwo_x && Reg == ALTMAP */
            GF_E_BY2_SSE, /* Mult == Bytwo_x && Reg == SSE && No SSE2 */
            GF_E_LOGBADW, /* Mult == LOGx, w too big*/
            GF_E_LOG___J, /* Mult == LOGx, && Reg == SSE|ALTMAP|NOSSE */
            GF_E_ZERBADW, /* Mult == LOG_ZERO, w \notin {8,16} */
            GF_E_ZEXBADW, /* Mult == LOG_ZERO_EXT, w != 8 */
            GF_E_LOGPOLY, /* Mult == LOG & poly not primitive */
            GF_E_GR_ARGX, /* Mult == GROUP, Bad arg1/2 */
            GF_E_GR_W_48, /* Mult == GROUP, w \in { 4, 8 } */
            GF_E_GR_W_16, /* Mult == GROUP, w == 16, arg1 != 4 || arg2 != 4 */
            GF_E_GR_128A, /* Mult == GROUP, w == 128, bad args */
            GF_E_GR_A_27, /* Mult == GROUP, either arg > 27 */
            GF_E_GR_AR_W, /* Mult == GROUP, either arg > w  */
            GF_E_GR____J, /* Mult == GROUP, Reg == SSE|ALTMAP|NOSSE */
            GF_E_TABLE_W, /* Mult == TABLE, w too big */
            GF_E_TAB_SSE, /* Mult == TABLE, SIMD|NOSIMD only apply to w == 4 */
            GF_E_TABSSE3, /* Mult == TABLE, Need SSSE3 for SSE */
            GF_E_TAB_ALT, /* Mult == TABLE, Reg == ALTMAP */
            GF_E_SP128AR, /* Mult == SPLIT, w=128, Bad arg1/arg2 */
            GF_E_SP128AL, /* Mult == SPLIT, w=128, SSE requires ALTMAP */
            GF_E_SP128AS, /* Mult == SPLIT, w=128, ALTMAP requires SSE */
            GF_E_SP128_A, /* Mult == SPLIT, w=128, ALTMAP only with 4/128 */
            GF_E_SP128_S, /* Mult == SPLIT, w=128, SSE only with 4/128 */
            GF_E_SPLIT_W, /* Mult == SPLIT, Bad w (8, 16, 32, 64, 128)  */
            GF_E_SP_16AR, /* Mult == SPLIT, w=16, Bad arg1/arg2 */
            GF_E_SP_16_A, /* Mult == SPLIT, w=16, ALTMAP only with 4/16 */
            GF_E_SP_16_S, /* Mult == SPLIT, w=16, SSE only with 4/16 */
            GF_E_SP_32AR, /* Mult == SPLIT, w=32, Bad arg1/arg2 */
            GF_E_SP_32AS, /* Mult == SPLIT, w=32, ALTMAP requires SSE */
            GF_E_SP_32_A, /* Mult == SPLIT, w=32, ALTMAP only with 4/32 */
            GF_E_SP_32_S, /* Mult == SPLIT, w=32, SSE only with 4/32 */
            GF_E_SP_64AR, /* Mult == SPLIT, w=64, Bad arg1/arg2 */
            GF_E_SP_64AS, /* Mult == SPLIT, w=64, ALTMAP requires SSE */
            GF_E_SP_64_A, /* Mult == SPLIT, w=64, ALTMAP only with 4/64 */
            GF_E_SP_64_S, /* Mult == SPLIT, w=64, SSE only with 4/64 */
            GF_E_SP_8_AR, /* Mult == SPLIT, w=8, Bad arg1/arg2 */
            GF_E_SP_8__A, /* Mult == SPLIT, w=8, no ALTMAP */
            GF_E_SP_SSE3, /* Mult == SPLIT, Need SSSE3 for SSE */
            GF_E_COMP_A2, /* Mult == COMP, arg1 must be = 2 */
            GF_E_COMP_SS, /* Mult == COMP, SIMD|NOSIMD */
            GF_E_COMP__W, /* Mult == COMP, Bad w. */
            GF_E_UNKFLAG, /* Unknown flag in create_from.... */
            GF_E_UNKNOWN, /* Unknown mult_type. */
            GF_E_UNK_REG, /* Unknown region_type. */
            GF_E_UNK_DIV, /* Unknown divide_type. */
            GF_E_CFM___W, /* Mult == CFM,  Bad w. */
            GF_E_CFM4POL, /* Mult == CFM & Prim Poly has high bits set. */
            GF_E_CFM8POL, /* Mult == CFM & Prim Poly has high bits set. */
            GF_E_CF16POL, /* Mult == CFM & Prim Poly has high bits set. */
            GF_E_CF32POL, /* Mult == CFM & Prim Poly has high bits set. */
            GF_E_CF64POL, /* Mult == CFM & Prim Poly has high bits set. */
            GF_E_FEWARGS, /* Too few args in argc/argv. */
            GF_E_BADPOLY, /* Bad primitive polynomial -- too many bits set. */
            GF_E_COMP_PP, /* Bad primitive polynomial -- bigger than sub-field. */
            GF_E_COMPXPP, /* Can't derive a default pp for composite field. */
            GF_E_BASE__W, /* Composite -- Base field is the wrong size. */
            GF_E_TWOMULT, /* In create_from... two -m's. */
            GF_E_TWO_DIV, /* In create_from... two -d's. */
            GF_E_POLYSPC, /* Bad numbera after -p. */
            GF_E_SPLITAR, /* Ran out of arguments in SPLIT */
            GF_E_SPLITNU, /* Arguments not integers in SPLIT. */
            GF_E_GROUPAR, /* Ran out of arguments in GROUP */
            GF_E_GROUPNU, /* Arguments not integers in GROUP. */
            GF_E_DEFAULT
        }
        

    }
}