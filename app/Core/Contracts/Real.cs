//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    using C = Core.Contracts;
    using Root;

    using static corefunc;


    public readonly struct Infinity
    {
        readonly Copair<double,double> data;

        public Infinity(double src)   
        {
            if(src == Double.NegativeInfinity)
                data = copair<double,double>(left: src);
            else
                data = copair<double,double>(right: Double.PositiveInfinity);            
        }

        public bool negative => data.IsLeft();
        
        public bool positive => data.IsRight();        
    }

    public readonly struct ExtendedReal
    {
        readonly double data;        

        public ExtendedReal(double x)
            => this.data = x;

        public bool infinite 
            => data == double.PositiveInfinity 
            || data == double.NegativeInfinity;
        
        public bool neginfinity 
            => data == double.NegativeInfinity;

        public bool posinfinity 
            => data == double.PositiveInfinity;

        public bool undefined 
            => data == double.NaN;

    }


}