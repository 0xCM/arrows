
#include "main.h"

int TestOps()
{
    uint32_t rcase1 = rotate1(34,2);
    printf("Rotate Version 1: 0x%08x\n", rcase1);
    uint32_t rcase2 = rotate2(34,2);
    printf("Roate Version 2: 0x%08x\n", rcase2);

    uint16_t tcase1 = threshold1(27);
    printf("Threshold Version 1: 0x%08x\n", tcase1);

    uint16_t tcase2 = threshold2(27);
    printf("Threshold Version 2: 0x%08x\n", tcase2);

    uint16_t ocase1 = output1(27ull);
    printf("Output Version 1: %d\n", ocase1);

    uint16_t ocase2 = output2(27ull);
    printf("Output Version 2: %d\n", ocase2);

    uint64_t x64 = 128;
    uint64_t y64 = -x64;
    printf("-128u64 = %" PRIu64 "\n", y64);

    uint32_t x32 = 128;
    uint32_t y32 = -x32;
    printf("-128u32 = %" PRIu32 "\n", y32);

    uint16_t x16 = 128;
    uint16_t y16 = -x16;
    printf("-128u16 = %" PRIu16 "\n", y16);

    uint8_t x8 = 128;
    uint8_t y8 = -x8;
    printf("-128u8 = %" PRIu8 "\n", y8);

    return 0;
}

int main(int argc, char** argv)
{


}