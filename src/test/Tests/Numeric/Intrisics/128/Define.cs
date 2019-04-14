//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    [DisplayName(Path)]
    public class InX128Define : UnitTest<InX128Define>
    {
        public const string Path = P.InX128 + P.define;

        public void DefineInt8Vec()
        {
            var data = list<sbyte>(
                    20, -50, -20, 30, 
                    80, 70, -25, -2, 
                    1, -2, 3, -4, 
                    5, -6, 7, -8);
            var v1 = Vec128.define(data);
            
            var idx = 0;
            var v2 = Vec128.define(
                data[idx++], data[idx++], data[idx++], data[idx++],
                data[idx++], data[idx++], data[idx++], data[idx++],
                data[idx++], data[idx++], data[idx++], data[idx++],
                data[idx++], data[idx++], data[idx++], data[idx++]
                );

            Claim.eq(v1,v2, $"{v1} == {v2}",false);
        }

        public void DefineUInt8Vec()
        {
            var data = list<byte>(
                    20, 50, 20, 30, 
                    80, 70, 25, 2, 
                    1, 2, 3, 4, 
                    5, 6, 7, 8);
            var v1 = Vec128.define(data);
            
            var idx = 0;
            var v2 = Vec128.define(
                data[idx++], data[idx++], data[idx++], data[idx++],
                data[idx++], data[idx++], data[idx++], data[idx++],
                data[idx++], data[idx++], data[idx++], data[idx++],
                data[idx++], data[idx++], data[idx++], data[idx++]
                );

            Claim.eq(v1,v2, $"{v1} == {v2}",false);
        }

        public void DefineInt16Vec()
        {
            var data = list<short>(20, -50, -20, 30, 80, 70, -250, -500);
            var v1 = Vec128.define(data);
            
            var idx = 0;
            var v2 = Vec128.define(
                data[idx++], data[idx++], data[idx++], data[idx++],
                data[idx++], data[idx++], data[idx++], data[idx++]
                );

            Claim.eq(v1,v2, $"{v1} == {v2}",false);
        }

        public void DefineInt32Vec()
        {
            var data = list(20, -50, -20, 30);
            var v1 = Vec128.define(data);
            var v2 = Vec128.define(data[0], data[1], data[2], data[3]);
            Claim.eq(v1,v2, $"{v1} == {v2}", false);
        }

    }

}