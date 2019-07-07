//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Characterizes a Gamma distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Gamma_distribution</remarks>
    public class GammaSpec : IDistributionSpec
    {
        public static GammaSpec FromShapeAndScale(double Shape, double Scale)
            => new GammaSpec
            {
                Shape = Shape,
                Scale = Scale,
                Rate = 1.0/Scale,
            };
        
        public static GammaSpec FromShapeAndRate(double Shape, double Rate)
            => new GammaSpec
            {
                Shape = Shape,
                Scale = 1.0/Rate,
                Rate = Rate,
            };

        GammaSpec()
        {

        }

        [Symbol(Greek.alpha)]
        public double Shape {get; private set;}

        [Symbol(Greek.theta)]
        public double Scale {get; private set;}

        [Symbol(Greek.beta)]
        public double Rate {get; private set;}
    }
}
