//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;


   public enum BitPattern : byte
    {
        B000 = 0b00000000,        
        
        B00000000 = B000,

        B001 = 0b00000001,
        
        B00000001 = B001, 

        B002 = 0b00000010,
        
        B00000010 = B002, 

        B003 = 0b00000011,
        
        B00000011 = B003,

        B004 = 0b00000100,
        
        B00000100 = B004,

        B005 = 0b00000101,
        
        B00000101 = B005,

        B006 = 0b00000110,
        
        B00000110 = B006,

        B007 = 0b00000111,
        
        B00000111 = B007,

        B008 = 0b00001000,
        
        B00001000 = B008,

        B009 = 0b00001001,
        
        B00001001 = B009,

        B010 = 0b00001010,
        
        B00001010 = B010,

        B011 = B008 | B003,
        
        B00001011 = B011,

        B012 = B008 | B004,
        
        B00001100 = B012,

        B013 = B008 | B005,
        
        B00001101 = B013,

        B014 = B008 | B006,
        
        B00001110 = B014,

        B015 = B008 | B007,
        
        B00001111 = B015,

        B016 = 0b00010000,
        
        B00010000 = B016,

        B017 = 0b00010001,

        B00010001 = B017,

        B018 = 0b00010010,

        B019 = 0b00010011,

        B020 = B016 | B004,

        B021 = B016 | B005,

        B022 = B016 | B006,

        B023 = B016 | B007,

        B024 = B016 | B008,

        B025 = B016 | B009,
        
        B026 = B016 | B010,
        
        B027 = B016 | B011,
        
        B028 = B016 | B012,
        
        B029 = B016 | B013,
        
        B030 = B016 | B014,
        
        B031 = B016 | B015,

        B032 = 0b00100000,

        B033 = 0b00100001,

        B034 = 0b00100010,

        B035 = 0b00100011,

        B036 = 0b00100100,

        B037 = 0b00100101,

        B038 = 0b00100110,

        B039 = 0b00100111,

        B040 = 0b00101000,

        B041 = 0b00101001,
        
        B042 = 0b00101010,
        
        B043 = 0b00101011,
        
        B044 = B032 | B012,
        
        B045 = B032 | B013,
        
        B046 = B032 | B014,
        
        B047 = B032 | B015,

        B048 = B032 | B016,

        B049 = B032 | B017,

        B050 = B032 | B018,

        B051 = B032 | B019,

        B052 = B032 | B020,

        B053 = B032 | B021,

        B054 = B032 | B022,

        B055 = B032 | B023,

        B056 = B032 | B024,
        
        B057 = B032 | B025,
        
        B058 = B032 | B026,
        
        B059 = B032 | B027,
        
        B060 = B032 | B028,
        
        B061 = B032 | B029,
        
        B062 = B032 | B030,
        
        B063 = B032 | B031,

        B064 = 0b01000000,
        
        B065 = 0b01000001,

        B066 = 0b01000010,

        B067 = 0b01000011,

        B068 = 0b01000100,

        B069 = 0b01000101,

        B070 = 0b01000110,

        B071 = 0b01000111,

        B072 = 0b01001000,

        B073,

        B074,

        B075,

        B076,
        
        B077,
 
        B078,

        B079,
         
 
    }



}