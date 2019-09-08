namespace Z0
{
    using System;

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    [Flags]
    public enum Perm16 : ulong
    {
        X0 = 0,
        
        X1 =  1,
        
        X2 =  2,

        X3 = 3,

        X4 = 4,

        X5 = 5,

        X6 = 6,

        X7 = 7,

        X8 = 8,

        X9 = 9,

        XA = 10,

        XB = 11,

        XC = 12,

        XD = 13,

        XE = 14,

        XF = 15,

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