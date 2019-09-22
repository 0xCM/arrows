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
    using static Reg;
    using static Asm;

    public class t_cpu_vperm2i128 : t_cpu<t_cpu_vperm2i128>
    {
        public void vperm_2x128()
        {            
            YMM ymm0 = YMM.FromCells(1ul, 2u, 3ul, 4ul);
            YMM ymm1 = YMM.FromCells(5ul, 6ul, 7ul, 8ul);
            YMM ymm2 = default, ymm2e = default;

            ymm2e = YMM.FromCells(1ul, 2ul, 5ul, 6ul); 
            ymm2 = vperm2i128(ymm0, ymm1, Perm2x128.AC);
            Claim.eq(ymm2e, ymm2);

            ymm2e = YMM.FromCells(3ul, 4ul, 7ul, 8ul); 
            ymm2 = vperm2i128(ymm0,ymm1,Perm2x128.BD);
            Claim.eq(ymm2e, ymm2);
            
            ymm2e = YMM.FromCells(3ul, 4ul, 5ul, 6ul); 
            ymm2 = vperm2i128(ymm0,ymm1,Perm2x128.BC);
            Claim.eq(ymm2e, ymm2);

            ymm2e = YMM.FromCells(3ul, 4ul, 7ul, 8ul); 
            ymm2 = vperm2i128(ymm0,ymm1,Perm2x128.BD);
            Claim.eq(ymm2e, ymm2);

            ymm2e = YMM.FromCells(7ul, 8ul, 3ul, 4ul); 
            ymm2 = vperm2i128(ymm0,ymm1,Perm2x128.DB);
            Claim.eq(ymm2e, ymm2);

            ymm2e = YMM.FromCells(5ul, 6ul, 1ul, 2ul); 
            ymm2 = vperm2i128(ymm0,ymm1,Perm2x128.CA);
            Claim.eq(ymm2e, ymm2);

            ymm2e = YMM.FromCells(7ul, 8ul, 1ul, 2ul); 
            ymm2 = vperm2i128(ymm0,ymm1,Perm2x128.DA);
            Claim.eq(ymm2e, ymm2);

            ymm2e = YMM.FromCells(5ul, 6ul, 3ul, 4ul); 
            ymm2 = vperm2i128(ymm0, ymm1,Perm2x128.CB);
            Claim.eq(ymm2e, ymm2);
        
        }

        void perm_report(YMM ymm0, YMM ymm1, Perm2x128 spec)
        {
            YMM ymm2 = vperm2i128(ymm0, ymm1, spec);
            Trace("ymm0", ymm0.Format<ulong>());
            Trace("ymm1", ymm1.Format<ulong>());
            Trace($"{spec} {EnumValues.ToGeneric(spec).Scalar<byte>().FormatBits()}", ymm2.Format<ulong>());
        }
    }

}