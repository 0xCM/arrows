//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class ValueComparison<T>
    {
        public ValueComparison(string ValName, T LeftValue, T RightValue, bool AreEqual)
        {   
            this.ValName = ValName;
            this.LeftVal = LeftValue;
            this.RightVal = RightValue;
            this.AreEqual = AreEqual;

        }
        
        public string ValName {get;}

        public T LeftVal {get;}

        public T RightVal {get;}

        public bool AreEqual {get;}
    }
    
    public static class ValueComparison
    {
        public static IReadOnlyDictionary<string, ValueComparison<object>> ComparePropertyValues<X,Y>(X x, Y y)
        {
            var delta = new Dictionary<string, ValueComparison<object>>();
            var xprops = x.GetType().GetProperties();
            var yprops = y.GetType().GetProperties();
            foreach (var xprop in xprops)
            {
                var yprop = yprops.FirstOrDefault(z => z.Name == xprop.Name);
                if (yprop != null)
                {
                    var xval = xprop.GetValue(x);
                    var yval = yprop.GetValue(y);
                    delta[xprop.Name] = ValueComparison.Define(
                        xprop.Name, 
                        xval, 
                        yval, 
                        Object.Equals(xval, yval)
                        );
                }
            }

            return delta;
        }

        public static ValueComparison<T> Define<T>(string ValName, T LeftVal, T RightVal, bool AreEqual)
            => new ValueComparison<T>(ValName, LeftVal, RightVal, AreEqual);
    }

}