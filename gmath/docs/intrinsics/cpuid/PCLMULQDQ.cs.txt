//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BitSpecs
{
    using System;

    using static zfunc;
    using static Nats;

    public static class PCLMULQDQ
    {
        /*
        IF (imm8[0] == 0)
            TEMP1 := a[63:0]
        ELSE
            TEMP1 := a[127:64]
        FI 
        IF (imm8[4] == 0)
            TEMP2 := b[63:0]
        ELSE 
            TEMP2 := b[127:64]
        FI

        FOR i := 0 to 63
            TEMP[i] := (TEMP1[0] and TEMP2[i])
            FOR j := 1 to i
                TEMP[i] := TEMP[i] XOR (TEMP1[j] AND TEMP2[i-j])
            ENDFOR 
            dst[i] := TEMP[i]
        ENDFOR
        FOR i := 64 to 127
            TEMP[i] := 0
            FOR j := (i - 63) to 63
                TEMP[i] := TEMP[i] XOR (TEMP1[j] AND TEMP2[i-j])
            ENDFOR
            dst[i] := TEMP[i]
        ENDFOR
        dst[127] := 0
        */
        
        public static void clmulepi64(__mm128i a, __mm128i b, in _int imm8)
        {
            var dst = default(__mm128i);
            var TEMP1 = imm8[0] == 0 ? a[N63,N0] : a[N127,N64];
            var TEMP2 = imm8[4] == 0 ? b[N63,N0] : b[N127,N64];
            var TEMP = default(__mm128i);
            for(var i = 0; i<= N63; i++)
            {
                TEMP[i] = TEMP1[0] & TEMP2[i];
                for(var j = 1; j<=i; j++)
                    TEMP[i] = TEMP[i] ^  (TEMP1[j] & TEMP2[i-j]);
                dst[i] = TEMP[i];
            }
            
            for(var i = 64; i<= N127; i++)
            {
                TEMP[i] = 0;
                for(var j = (i - 63); i<= 63; j++)
                    TEMP[i] = TEMP[i] ^ (TEMP1[j] & TEMP2[i - j]);
                dst[i] = TEMP[i];
            }
            dst[127] = 0;
        }        
    }
}