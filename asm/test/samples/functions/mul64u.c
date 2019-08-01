#include <stdio.h>
#include <stdint.h>

uint64_t mul64u(uint64_t x, uint64_t y);

int main(void)
{
	uint64_t x = 4;
	uint64_t y = 5;
	uint64_t z = mul64u(x,y);
	printf("%I64u * %I64u = %I64u\n", x, y, z);
	return 1;
}