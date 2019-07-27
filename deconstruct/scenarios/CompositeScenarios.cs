//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using static zfunc;


    [DisplayName("scenarios-composite")]
    class CompositScenarios
    {
        static ReadOnlySpan<byte> U8Data => new byte[]
        {
            0x20, 0xda, 0x1f, 0x32, 0x4b, 0xca, 0x42, 0x5b,
            0x06, 0xbd, 0xac, 0xdb, 0x28, 0x87, 0x7a, 0xd4,
            0x0c, 0xd9, 0x1e, 0xde, 0x5d, 0x17, 0xd6, 0x7c,
            0x08, 0xcf, 0x94, 0x93, 0xf4, 0x5c, 0x4f, 0x6b,
            0x7a, 0x02, 0x62, 0x31, 0x37, 0xed, 0x21, 0x03,
            0xef, 0xe4, 0x4c, 0x0a, 0xbd, 0x8d, 0x48, 0x21,
            0xaf, 0x50, 0x9b, 0x7a, 0x75, 0x7d, 0xc0, 0xa7,
            0x4b, 0x70, 0x86, 0x84, 0x64, 0xee, 0x2b, 0x04
        };

        static ReadOnlySpan<uint> U32Data => new uint[]
        {
            0x20da1f32, 0x4bca425b,
            0x06bdacdb, 0x28877ad4,
            0x0cd91ede, 0x5d17d67c,
            0x08cf9493, 0xf45c4f6b,
            0x7a026231, 0x37ed2103,
            0xefe44c0a, 0xbd8d4821,
            0xaf509b7a, 0x757dc0a7,
            0x4b708684, 0x64ee2b04
        };

        [MethodImpl(Inline)]
        public static int AddI32LoopInline()
        {
            var sum = 0;
            for(var i=0; i<100; i++)
                sum += i;
            return sum;
        }

        [MethodImpl(NotInline)]
        public static int AddI32Loop()
        {
            var sum = 0;
            for(var i=0; i<100; i++)
                sum += i;
            return sum;
        }

        public static int AddI32LoopInlineCall()
            => AddI32LoopInline();

        public static int AddI32LoopCall()
            => AddI32Loop();

        [MethodImpl(Inline)]
        public static uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
            => x0 | x1 | x2 | x3 | x4 | x5 | x6 | x7;

        [MethodImpl(Inline)]
        public static uint RotLU32Inline(uint x, int offset)
            => (x << (int)offset) | (x >> (32 - offset));

        [MethodImpl(Inline)]
        public int ChoiceSwitchInline(int x)
        {
            switch(x)
            {
                case 1: return 1;
                case 2: return 4;
                case 3: return 8;
                case 4: return 16;
                case 5: return 32;
                default: return 0;
            }
        }

        [MethodImpl(Inline)]
        public int ChoiceIfElse5Inline(int x)
        {
            if(x == 1) return 1;
            else if(x == 2) return 4;
            else if(x == 3) return 8;
            else if(x == 4) return 16;
            else if(x == 5) return 32;
            else return 0;
        }

        [MethodImpl(Inline)]
        public int ChoiceIfElse10Inline(int x)
        {
            if(x == 1) return 1;
            else if(x == 2) return 4;
            else if(x == 3) return 8;
            else if(x == 4) return 16;
            else if(x == 5) return 32;
            else if(x == 6) return 64;
            else if(x == 7) return 128;
            else if(x == 8) return 256;
            else if(x == 9) return 512;
            else if(x == 10) return 1024;
            else return 0;
        }

        public int CallChoiceSwitchInline(int x)
        {
            return ChoiceSwitchInline(x);
        }

        public int CallChoiceIfElse5Inline(int x)
        {
            return ChoiceIfElse5Inline(x);
        }

        public int CallChoiceIfElse10Inline(int x)
        {
            return ChoiceIfElse10Inline(x);
        }

        public uint CallRotLU32Inline(uint x, int offset)
            => RotLU32Inline(x,offset);
        
        public uint CallOr8InlineConst()
            => Or8Inline(2, 4, 8, 12, 16, 32, 68, 64);

        public uint CallOr8InlineVar(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
            => Or8Inline(x0, x1, x2, x3, x4, x5, x6, x7);

         public ReadOnlySpan<byte> ReadU8Data(int count)
            => U8Data.Slice(0,count);

        public ReadOnlySpan<uint> ReadU32Data(int count)
            => U32Data.Slice(0,count);

        [MethodImpl(NotInline)]
        public void VoidReturn()
            => Console.Write("");
    
        public int SizeTest()
        {
            var a = 0;
            var b = 1;
            var c = 2;

            int d = 1, e = 2, f = 2;

            var x = d * e * f;
            var y = a + b + c;

            return x + y;
        }

        public void VoidCalls1()
        {
            VoidReturn();
        }

        public void VoidCalls2()
        {
            VoidReturn();
            VoidReturn();
        }

        public void VoidCalls3()
        {
            VoidReturn();
            VoidReturn();
            VoidReturn();
        }

        public void VoidCalls4()
        {
            VoidReturn();
            VoidReturn();
            VoidReturn();
            VoidReturn();
        }

        [MethodImpl(Inline)]
        public int InvokeBinOp(Func<int,int,int> f, int x, int y)
            => f(x,y);

        [MethodImpl(Inline)]
        static int AddMulInline(int x, int y)
            => (x + y) *x + (x + y)*y;

        public int CallInvokeBinOp(int x, int y)
            => InvokeBinOp(AddMulInline, x, y);

        [MethodImpl(NotInline)]
        public int JumpTarget1()
            => 1;

        [MethodImpl(NotInline)]
        public int JumpTarget2()
            => 2;

        [MethodImpl(NotInline)]
        public int JumpTarget3()
            => 3;

        [MethodImpl(NotInline)]
        public int JumpTarget4()
            => 4;

        public int Jump(int target)
            => target == 1 ? JumpTarget1() 
             : target == 2 ? JumpTarget2() 
             : target == 3 ? JumpTarget3()
             : JumpTarget4();

    }

}