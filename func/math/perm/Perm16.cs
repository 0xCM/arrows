namespace Z0
{
    using System;

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    [Flags]
    public enum Perm16 : ulong
    {
        X0 = 0b0000,
        
        X1 = 0b0001,
        
        X2 = 0b0010,

        X3 = 0b0011,

        X4 = 0b0100,

        X5 = 0b0101,

        X6 = 0b0110,

        X7 = 0b0111,

        X8 = X1 << 3,

        X9 = X8 | X1,

        XA = X8 | X2,

        XB = X8 | X3,

        XC = X8 | X4,

        XD = X8 | X5,

        XE = X8 | X6,

        XF = X8 | X7,

        /// <summary>
        /// Represents the 16 symbol identity permutation
        /// </summary>
        Identity = X0       | X1 << 4  | X2 << 8  | X3 << 12 | X4 << 16 | X5 << 20 | X6 << 24 | X7 << 28 
                 | X8 << 32 | X9 << 36 | XA << 40 | XB << 44 | XC << 48 | XD << 52 | XE << 56 | XF << 60,
            
        /// <summary>
        /// Represents the reversed identity permutation
        /// </summary>
        Reverse =  XF       | XE << 4  | XD << 8  | XC << 12 | XB << 16 | XA << 20 | X9 << 24 | X8 << 28 
                 | X7 << 32 | X6 << 36 | X5 << 40 | X4 << 44 | X3 << 48 | X2 << 52 | X1 << 56 | X0 << 60

    }


}