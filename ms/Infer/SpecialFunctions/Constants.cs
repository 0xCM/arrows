// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace MsInfer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    partial class MMath
    {

        private const double TOLERANCE = 1.0e-7;

        /// <summary>
        /// Math.Sqrt(2*Math.PI)
        /// </summary>
        public const double Sqrt2PI = 2.5066282746310005;

        /// <summary>
        /// 1.0/Math.Sqrt(2*Math.PI)
        /// </summary>
        public const double InvSqrt2PI = 0.398942280401432677939946;

        /// <summary>
        /// Math.Log(Math.Sqrt(2*Math.PI)).
        /// </summary>
        public const double LnSqrt2PI = 0.91893853320467274178;

        /// <summary>
        /// Math.Log(Math.PI)
        /// </summary>
        public const double LnPI = 1.14472988584940;

        /// <summary>
        /// Math.Log(2)
        /// </summary>
        public const double Ln2 = 0.6931471805599453094172321214581765680;

        /// <summary>
        /// Math.Sqrt(2)
        /// </summary>
        public const double Sqrt2 = 1.41421356237309504880;

        /// <summary>
        /// Math.Sqrt(0.5)
        /// </summary>
        public const double SqrtHalf = 0.70710678118654752440084436210485;

        /// <summary>
        /// Zeta(2) = Trigamma(1) = pi^2/6.
        /// </summary>
        public const double Zeta2 = 1.644934066848226436472415;

        /// <summary>
        /// Tetragamma(1) = -2 Zeta(3)
        /// </summary>
        private const double M2Zeta3 = -2.404113806319188570799476;

        /// <summary>
        /// Zeta4 = pi^4/90 = polygamma(3,1)/6
        /// </summary>
        private const double Zeta4 = 1.0823232337111381915;

        /// <summary>
        /// Coefficients of the asymptotic expansion of NormalCdfLn.
        /// </summary>
        private static readonly double[] c_normcdfln_series =
            {
                -1, 5.0/2, -37.0/3, 353.0/4, -4081.0/5, 55205.0/6, -854197.0/7
            };

        /// <summary>
        /// NormCdf(x)/NormPdf(x) for x = 0, -1, -2, -3, ..., -16
        /// </summary>
        private static readonly double[] c_normcdf_table = 
            {
                Sqrt2PI/2, 0.655679542418798471543871, .421369229288054473, 0.30459029871010329573361254651, .236652382913560671,
                0.1928081047153157648774657, .162377660896867462, 0.140104183453050241599534, .123131963257932296, 0.109787282578308291230, .0990285964717319214,
                0.09017567550106468227978, .0827662865013691773, 0.076475761016248502993495, .0710695805388521071, 0.0663742358232501735, .0622586659950261958
            };

        private const double Ln2SqrtPi = 1.265512123484645396488945797;

        private static readonly double[] c_erfc_table =
            // Taylor series (not as good as Chebyshev)
            // Maple command for Taylor series: asympt(subs(x=2*y-2,log(erfc(x)*(1+x/2))+x*x),y);
            //{ - Ln2SqrtPi, 1, 3.0 / 8, 1.0 / 12, -11.0 / 128, -23.0 / 160, -47.0 / 512, 53.0 / 1792, 2177.0/16384, 2249.0/18432 };
            // Chebyshev series
            // Maple command: chebyshev( subs(x=2/y-2,log(erfc(x)*(1+x/2))+x*x), y=0..1, 1e-6);
            //{ -1.26551220, 1.000023566, 0.3740932172, 0.0967773480, -0.1862670280, 0.2788294034, -1.135160988, 1.488487954, -0.8221427183, 0.1708715269 };
            // from Ralf (better than above)
            { -1.26551223, 1.00002368, 0.37409196, 0.09678418, -0.18628806, 0.27886807, -1.13520398, 1.48851587, -0.82215223, 0.17087277 };

        // Maple command: chebyshev( subs(x=2/y-2,log(erfc(x)*(1+x/2))+x*x), y=0..1, 1e-8);
        // more accurate, but more expensive
        //{ -1.265512122, 0.9999999460, 0.3750003113, 0.08331553737, -0.0857441378, -0.142407635, -0.1269326291, 0.295066080, -0.9476268748, 2.769131338, -3.938783592, 2.943051024, -1.142311460, 0.1837542133 };

 

    }


}