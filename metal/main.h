# include <stdio.h>
# include <inttypes.h>
# include <immintrin.h>


uint32_t rotate1(uint32_t value, uint32_t rotate)
{
    return (value >> rotate) | (value << (~rotate & 31 ));
}

uint32_t rotate2(uint32_t value, int rotate)
{
    return (value >> rotate) | (value << ((-rotate & 31) - 1));
}            

static uint16_t threshold1(uint16_t bound)
{
    return ((uint16_t)(-bound)) % bound;        
}

static uint16_t threshold2(uint16_t bound)
{
    return ((uint16_t)(~bound) + 1) % bound;        
}

static uint32_t output1(uint64_t state)
{
    uint64_t a = state >> 59u;
    uint64_t b = (a + 5u);
    uint64_t c = (state >> b) ^ state;
    return (c * 12605985483714917081ull) >> 32u;
}

static uint32_t output2(uint64_t state)
{
    
    int32_t a = state >> 59;
    printf("a = %d\n",a);
    
    int32_t b = a + 5;
    printf("b = %d\n",b);

    uint64_t c = state >> b;
    printf("c = %llu\n",c);

    uint64_t d = c ^ state;
    printf("d = %llu\n",d);
    
    uint64_t e = (d * 12605985483714917081ull) >> 32;
    printf("e = %llu\n",e);
    
    uint32_t f = e;
    printf("f = %d\n",f);
    
    
    return f;
}

