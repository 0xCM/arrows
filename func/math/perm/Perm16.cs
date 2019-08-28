namespace Z0
{
    using System;

    /// <summary>
    /// Defines literals that identify the 16 elements in a permutation of length 16 such
    /// that when combined, define a cycle applied to the identity permutation
    /// </summary>
    [Flags]
    public enum Perm16 : ushort
    {
        X0 = 1,
        
        X1 =  2,
        
        X2 =  X1*2,

        X3 = X2*2,

        X4 = X3*2,

        X5 = X4*2,

        X6 = X5*2,

        X7 = X6*2,

        X8 = X7*2,

        X9 = X8*2,

        XA = X9*2,

        XB = XA*2,

        XC = XB*2,

        XD = XC*2,

        XE = XD*2,

        XF = XE*2,

        Identity = X0 | X1 | X2 | X3 | X4 | X5 | X6 | X7 | X8 | X9 | XA | XB | XC | XD | XE | XF,
        
    }


}