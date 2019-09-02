//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static zfunc;

    partial class fmath
    {
        /// <summary>
        /// Represents 32-bit floating point Nan
        /// </summary>
        public const float NaN32 = 0.0f/0.0f;

        /// <summary>
        /// Represents 32-bit floating-point positive infinity
        /// </summary>
        public const float PosInf32 = 1.0f/0.0f;        

        /// <summary>
        /// Represents 32-bit floating-point negative infinity
        /// </summary>
        public const float NegInf32 = -1.0f/0.0f;        

        /// <summary>
        /// Specifies the effective resolution of 32-bit floating point
        /// </summary>
        public const float Eps32 = float.Epsilon;

        /// <summary>
        /// Represents 32-bit floating point Nan
        /// </summary>
        public const double NaN64 = 0.0/0.0;

        /// <summary>
        /// Represents 64-bit floating point positive infinity
        /// </summary>
        public const double PosInf64 = 1.0/0.0;        

        /// <summary>
        /// Represents 64-bit floating point negative infinity
        /// </summary>
        public const double NegInf64 = -1.0/0.0;        

        /// <summary>
        /// Specifies the effective resolution of 64-bit floating point
        /// </summary>
        public const double Eps64 = double.Epsilon;

    }

}