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
    public readonly struct GammaSpec : IDistributionSpec
    {
        public static GammaSpec FromShapeAndScale(double Shape, double Scale)
            => new GammaSpec
            (
                Shape : Shape,
                Scale : Scale,
                Rate : 1.0/Scale
            );        
        public static GammaSpec FromShapeAndRate(double Shape, double Rate)
            => new GammaSpec
            (
                Shape : Shape,
                Scale : 1.0/Rate,
                Rate : Rate
            );

        GammaSpec(double Shape, double Scale, double Rate)
        {
            this.Shape = Shape;
            this.Scale = Scale;
            this.Rate = Rate;
        }

        [Symbol(Greek.alpha)]
        public readonly double Shape;

        [Symbol(Greek.theta)]
        public readonly double Scale;

        [Symbol(Greek.beta)]
        public readonly double Rate;
    }
}
