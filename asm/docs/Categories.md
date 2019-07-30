# MMX Data Transfer Instructions

The data transfer instructions move doubleword and quadword operands between MMX registers and between MMX
registers and memory.

-- MOVD Move doubleword.
-- MOVQ Move quadword.

## MMX Conversion Instructions

The conversion instructions pack and unpack bytes, words, and doublewords

-- PACKSSWB Pack words into bytes with signed saturation.
-- PACKSSDW Pack doublewords into words with signed saturation.
-- PACKUSWB Pack words into bytes with unsigned saturation.
-- PUNPCKHBW Unpack high-order bytes.
-- PUNPCKHWD Unpack high-order words.
-- PUNPCKHDQ Unpack high-order doublewords.
-- PUNPCKLBW Unpack low-order bytes.
-- PUNPCKLWD Unpack low-order words.
-- PUNPCKLDQ Unpack low-order doublewords.

## MMX Packed Arithmetic Instructions

The packed arithmetic instructions perform packed integer arithmetic on packed byte, word, and doubleword integers.

-- PADDB Add packed byte integers.
-- PADDW Add packed word integers.
-- PADDD Add packed doubleword integers.
-- PADDSB Add packed signed byte integers with signed saturation.
-- PADDSW Add packed signed word integers with signed saturation.
-- PADDUSB Add packed unsigned byte integers with unsigned saturation.
-- PADDUSW Add packed unsigned word integers with unsigned saturation.
-- PSUBB Subtract packed byte integers.
-- PSUBW Subtract packed word integers.
-- PSUBD Subtract packed doubleword integers.
-- PSUBSB Subtract packed signed byte integers with signed saturation.
-- PSUBSW Subtract packed signed word integers with signed saturation.
-- PSUBUSB Subtract packed unsigned byte integers with unsigned saturation.
-- PSUBUSW Subtract packed unsigned word integers with unsigned saturation.
-- PMULHW Multiply packed signed word integers and store high result.
-- PMULLW Multiply packed signed word integers and store low result.
-- PMADDWD Multiply and add packed word integers.

## MMX Comparison Instructions

The compare instructions compare packed bytes, words, or doublewords.

-- PCMPEQB Compare packed bytes for equal.
-- PCMPEQW Compare packed words for equal.
-- PCMPEQD Compare packed doublewords for equal.
-- PCMPGTB Compare packed signed byte integers for greater than.
-- PCMPGTW Compare packed signed word integers for greater than.
-- PCMPGTD Compare packed signed doubleword integers for greater than

## MMX Logical Instructions

The logical instructions perform AND, AND NOT, OR, and XOR operations on quadword operands.

-- PAND Bitwise logical AND.
-- PANDN Bitwise logical AND NOT.
-- POR Bitwise logical OR.
-- PXOR Bitwise logical exclusive OR.

## MMX Shift and Rotate Instructions

The shift and rotate instructions shift and rotate packed bytes, words, or doublewords, or quadwords in 64-bit
operands.

-- PSLLW Shift packed words left logical.
-- PSLLD Shift packed doublewords left logical.
-- PSLLQ Shift packed quadword left logical.
-- PSRLW Shift packed words right logical.
-- PSRLD Shift packed doublewords right logical.
-- PSRLQ Shift packed quadword right logical.
-- PSRAW Shift packed words right arithmetic.
-- PSRAD Shift packed doublewords right arithmetic.

## SSE Data Transfer Instructions

SSE data transfer instructions move packed and scalar single-precision floating-point operands between XMM
registers and between XMM registers and memory.

-- MOVAPS Move four aligned packed single-precision floating-point values between XMM registers or between and XMM register and memory.
-- MOVUPS Move four unaligned packed single-precision floating-point values between XMM registers or between and XMM register and memory.
-- MOVHPS Move two packed single-precision floating-point values to an from the high quadword of an XMM register and memory.
-- MOVHLPS Move two packed single-precision floating-point values from the high quadword of an XMM register to the low quadword of another XMM register.
-- MOVLPS Move two packed single-precision floating-point values to an from the low quadword of an XMM register and memory.
-- MOVLHPS Move two packed single-precision floating-point values from the low quadword of an XMM register to the high quadword of another XMM register.
-- MOVMSKPS Extract sign mask from four packed single-precision floating-point values
-- MOVSS Move scalar single-precision floating-point value between XMM registers or between an XMM register and memory.

## SSE Packed Arithmetic Instructions

SSE packed arithmetic instructions perform packed and scalar arithmetic operations on packed and scalar singleprecision
floating-point operands.

-- ADDPS Add packed single-precision floating-point values.
-- ADDSS Add scalar single-precision floating-point values.
-- SUBPS Subtract packed single-precision floating-point values.
-- SUBSS Subtract scalar single-precision floating-point values.
-- MULPS Multiply packed single-precision floating-point values.
-- MULSS Multiply scalar single-precision floating-point values.
-- DIVPS Divide packed single-precision floating-point values.
-- DIVSS Divide scalar single-precision floating-point values.
-- RCPPS Compute reciprocals of packed single-precision floating-point values.
-- RCPSS Compute reciprocal of scalar single-precision floating-point values.
-- SQRTPS Compute square roots of packed single-precision floating-point values.
-- SQRTSS Compute square root of scalar single-precision floating-point values.
-- RSQRTPS Compute reciprocals of square roots of packed single-precision floating-point values.
-- RSQRTSS Compute reciprocal of square root of scalar single-precision floating-point values.
-- MAXPS Return maximum packed single-precision floating-point values.
-- MAXSS Return maximum scalar single-precision floating-point values.
-- MINPS Return minimum packed single-precision floating-point values.
-- MINSS Return minimum scalar single-precision floating-point values.

## SSE Comparison Instructions

SSE compare instructions compare packed and scalar single-precision floating-point operands.

-- CMPPS Compare packed single-precision floating-point values.
-- CMPSS Compare scalar single-precision floating-point values.
-- COMISS Perform ordered comparison of scalar single-precision floating-point values and set flags in EFLAGS register.
-- UCOMISS Perform unordered comparison of scalar single-precision floating-point values and set flags in EFLAGS register.

## SSE Logical Instructions

SSE logical instructions perform bitwise AND, AND NOT, OR, and XOR operations on packed single-precision
floating-point operands.

-- ANDPS Perform bitwise logical AND of packed single-precision floating-point values.
-- ANDNPS Perform bitwise logical AND NOT of packed single-precision floating-point values.
-- ORPS Perform bitwise logical OR of packed single-precision floating-point values.
-- XORPS Perform bitwise logical XOR of packed single-precision floating-point values.

## SSE Shuffle and Unpack Instructions

SSE shuffle and unpack instructions shuffle or interleave single-precision floating-point values in packed singleprecision
floating-point operands.

-- SHUFPS Shuffles values in packed single-precision floating-point operands.
-- UNPCKHPS Unpacks and interleaves the two high-order values from two single-precision floating-point operands.
-- UNPCKLPS Unpacks and interleaves the two low-order values from two single-precision floating-point operands.

## SSE Conversion Instructions

SSE conversion instructions convert packed and individual doubleword integers into packed and scalar single-precision
floating-point values and vice versa.

-- CVTPI2PS Convert packed doubleword integers to packed single-precision floating-point values.
-- CVTSI2SS Convert doubleword integer to scalar single-precision floating-point value.
-- CVTPS2PI Convert packed single-precision floating-point values to packed doubleword integers.
-- CVTTPS2PI Convert with truncation packed single-precision floating-point values to packed doubleword integers.
-- CVTSS2SI Convert a scalar single-precision floating-point value to a doubleword integer.
-- CVTTSS2SI Convert with truncation a scalar single-precision floating-point value to a scalar doubleword integer.

## SSE 64-Bit SIMD Integer Instructions

These SSE 64-bit SIMD integer instructions perform additional operations on packed bytes, words, or doublewords
contained in MMX registers. They represent enhancements to the MMX instruction set.

-- PAVGB Compute average of packed unsigned byte integers.
-- PAVGW Compute average of packed unsigned word integers.
-- PEXTRW Extract word.
-- PINSRW Insert word.
-- PMAXUB Maximum of packed unsigned byte integers.
-- PMAXSW Maximum of packed signed word integers.
-- PMINUB Minimum of packed unsigned byte integers.
-- PMINSW Minimum of packed signed word integers.
-- PMOVMSKB Move byte mask.
-- PMULHUW Multiply packed unsigned integers and store high result.
-- PSADBW Compute sum of absolute differences.
-- PSHUFW Shuffle packed integer word in MMX register.

## SSE2 Data Movement Instructions

SSE2 data movement instructions move double-precision floating-point data between XMM registers and between
XMM registers and memory.

-- MOVAPD Move two aligned packed double-precision floating-point values between XMM registers or between and XMM register and memory.
-- MOVUPD Move two unaligned packed double-precision floating-point values between XMM registers or between and XMM register and memory.
-- MOVHPD Move high packed double-precision floating-point value to an from the high quadword of an XMM register and memory.
-- MOVLPD Move low packed single-precision floating-point value to an from the low quadword of an XMM register and memory.
-- MOVMSKPD Extract sign mask from two packed double-precision floating-point values.
-- MOVSD Move scalar double-precision floating-point value between XMM registers or between an XMM register and memory.

## SSE2 Packed Arithmetic Instructions

The arithmetic instructions perform addition, subtraction, multiply, divide, square root, and maximum/minimum
operations on packed and scalar double-precision floating-point operands.

-- ADDPD Add packed double-precision floating-point values.
-- ADDSD Add scalar double precision floating-point values.
-- SUBPD Subtract packed double-precision floating-point values.
-- SUBSD Subtract scalar double-precision floating-point values.
-- MULPD Multiply packed double-precision floating-point values.
-- MULSD Multiply scalar double-precision floating-point values.
-- DIVPD Divide packed double-precision floating-point values.
-- DIVSD Divide scalar double-precision floating-point values.
-- SQRTPD Compute packed square roots of packed double-precision floating-point values.
-- SQRTSD Compute scalar square root of scalar double-precision floating-point values.
-- MAXPD Return maximum packed double-precision floating-point values.
-- MAXSD Return maximum scalar double-precision floating-point values.
-- MINPD Return minimum packed double-precision floating-point values.
-- MINSD Return minimum scalar double-precision floating-point values.

## SSE2 Logical Instructions

SSE2 logical instructions preform AND, AND NOT, OR, and XOR operations on packed double-precision floating-point
values.

-- ANDPD Perform bitwise logical AND of packed double-precision floating-point values.
-- ANDNPD Perform bitwise logical AND NOT of packed double-precision floating-point values.
-- ORPD Perform bitwise logical OR of packed double-precision floating-point values.
-- XORPD Perform bitwise logical XOR of packed double-precision floating-point values.

## SSE2 Compare Instructions

SSE2 compare instructions compare packed and scalar double-precision floating-point values and return the
results of the comparison either to the destination operand or to the EFLAGS register.

-- CMPPD Compare packed double-precision floating-point values.
-- CMPSD Compare scalar double-precision floating-point values.
-- COMISD Perform ordered comparison of scalar double-precision floating-point values and set flags in EFLAGS register.
-- UCOMISD Perform unordered comparison of scalar double-precision floating-point values and set flags in EFLAGS register.

## SSE2 Shuffle and Unpack Instructions

SSE2 shuffle and unpack instructions shuffle or interleave double-precision floating-point values in packed doubleprecision
floating-point operands.

-- SHUFPD Shuffles values in packed double-precision floating-point operands.
-- UNPCKHPD Unpacks and interleaves the high values from two packed double-precision floating-point operands.
-- UNPCKLPD Unpacks and interleaves the low values from two packed double-precision floating-point operands.

## SSE2 Conversion Instructions

SSE2 conversion instructions convert packed and individual doubleword integers into packed and scalar double-precision
floating-point values and vice versa. They also convert between packed and scalar single-precision and
double-precision floating-point values.

-- CVTPD2PI Convert packed double-precision floating-point values to packed doubleword integers.
-- CVTTPD2PI Convert with truncation packed double-precision floating-point values to packed doubleword integers.
-- CVTPI2PD Convert packed doubleword integers to packed double-precision floating-point values.
-- CVTPD2DQ Convert packed double-precision floating-point values to packed doubleword integers.
-- CVTTPD2DQ Convert with truncation packed double-precision floating-point values to packed doubleword integers.
-- CVTDQ2PD Convert packed doubleword integers to packed double-precision floating-point values.
-- CVTPS2PD Convert packed single-precision floating-point values to packed double-precision floating-point values.
-- CVTPD2PS Convert packed double-precision floating-point values to packed single-precision floating-point values.
-- CVTSS2SD Convert scalar single-precision floating-point values to scalar double-precision floating-point values.
-- CVTSD2SS Convert scalar double-precision floating-point values to scalar single-precision floating-point values.
-- CVTSD2SI Convert scalar double-precision floating-point values to a doubleword integer.
-- CVTTSD2SI Convert with truncation scalar double-precision floating-point values to scalar doubleword integers.
-- CVTSI2SD Convert doubleword integer to scalar double-precision floating-point value.

## 5.6.2 SSE2 Packed Single-Precision Floating-Point Instructions

SSE2 packed single-precision floating-point instructions perform conversion operations on single-precision
floating-point and integer operands. These instructions represent enhancements to the SSE single-precision
floating-point instructions.

-- CVTDQ2PS Convert packed doubleword integers to packed single-precision floating-point values.
-- CVTPS2DQ Convert packed single-precision floating-point values to packed doubleword integers.
-- CVTTPS2DQ Convert with truncation packed single-precision floating-point values to packed doubleword integers.

## SSE2 128-Bit SIMD Integer Instructions

SSE2 SIMD integer instructions perform additional operations on packed words, doublewords, and quadwords
contained in XMM and MMX registers.

-- MOVDQA Move aligned double quadword.
-- MOVDQU Move unaligned double quadword.
-- MOVQ2DQ Move quadword integer from MMX to XMM registers.
-- MOVDQ2Q Move quadword integer from XMM to MMX registers.
-- PMULUDQ Multiply packed unsigned doubleword integers.
-- PADDQ Add packed quadword integers.
-- PSUBQ Subtract packed quadword integers.
-- PSHUFLW Shuffle packed low words.
-- PSHUFHW Shuffle packed high words.
-- PSHUFD Shuffle packed doublewords.
-- PSLLDQ Shift double quadword left logical.
-- PSRLDQ Shift double quadword right logical.
-- PUNPCKHQDQ Unpack high quadwords.
-- PUNPCKLQDQ Unpack low quadwords.

## SSE2 Cacheability Control and Ordering Instructions

SSE2 cacheability control instructions provide additional operations for caching of non-temporal data when storing
data from XMM registers to memory. LFENCE and MFENCE provide additional control of instruction ordering on
store operations.

-- CLFLUSH See Section 5.1.13.
-- LFENCE Serializes load operations.
-- MFENCE Serializes load and store operations.
-- PAUSE Improves the performance of “spin-wait loops”.
-- MASKMOVDQU Non-temporal store of selected bytes from an XMM register into memory.
-- MOVNTPD Non-temporal store of two packed double-precision floating-point values from an XMM register into memory.
-- MOVNTDQ Non-temporal store of double quadword from an XMM register into memory.
-- MOVNTI Non-temporal store of a doubleword from a general-purpose register into memory.

## SSE3 x87-FP Integer Conversion Instruction

-- FISTTP Behaves like the FISTP instruction but uses truncation, irrespective of the rounding mode specified in the floating-point control word (FCW)

## SSE3 Specialized 128-bit Unaligned Data Load Instruction

-- LDDQU Special 128-bit unaligned load designed to avoid cache line splits

## SSE3 SIMD Floating-Point Packed ADD/SUB Instructions

-- ADDSUBPS Performs single-precision addition on the second and fourth pairs of 32-bit data elements within the operands; single-precision subtraction on the first and third pairs.
-- ADDSUBPD Performs double-precision addition on the second pair of quadwords, and double-precision subtraction on the first pair.

## SSE3 SIMD Floating-Point Horizontal ADD/SUB Instructions

-- HADDPS Performs a single-precision addition on contiguous data elements. The first data element of the result is obtained by adding the first and second elements of the first operand; the second element by adding the third and fourth elements of the first operand; the third by adding the first and second elements of the second operand; and the fourth by adding the third and fourth elements of the second operand.
-- HSUBPS Performs a single-precision subtraction on contiguous data elements. The first data element of the result is obtained by subtracting the second element of the first operand from the first element of the first operand; the second element by subtracting the fourth element of the first operand from the third element of the first operand; the third by subtracting the second element of the second operand from the first element of the second operand; and the fourth by subtracting the fourth element of the second operand from the third element of the second operand.
-- HADDPD Performs a double-precision addition on contiguous data elements. The first data element of the result is obtained by adding the first and second elements of the first operand; the second element by adding the first and second elements of the second operand.
-- HSUBPD Performs a double-precision subtraction on contiguous data elements. The first data element of the result is obtained by subtracting the second element of the first operand from the first element of the first operand; the second element by subtracting the second element of the second operand from the first element of the second operand.

## SSE3 SIMD Floating-Point LOAD/MOVE/DUPLICATE Instructions

-- MOVSHDUP Loads/moves 128 bits; duplicating the second and fourth 32-bit data elements.
-- MOVSLDUP Loads/moves 128 bits; duplicating the first and third 32-bit data elements.
-- MOVDDUP Loads/moves 64 bits (bits[63:0] if the source is a register) and returns the same 64 bits in both the lower and upper halves of the 128-bit result register; duplicates the 64 bits from the source.

## Horizontal Addition/Subtraction

-- PHADDW Adds two adjacent, signed 16-bit integers horizontally from the source and destination operands and packs the signed 16-bit results to the destination operand.
-- PHADDSW Adds two adjacent, signed 16-bit integers horizontally from the source and destination operands and packs the signed, saturated 16-bit results to the destination operand.
-- PHADDD Adds two adjacent, signed 32-bit integers horizontally from the source and destination operands and packs the signed 32-bit results to the destination operand.
-- PHSUBW Performs horizontal subtraction on each adjacent pair of 16-bit signed integers by subtracting the most significant word from the least significant word of each pair in the source and destination operands. The signed 16-bit results are packed and written to the destination operand.
-- PHSUBSW Performs horizontal subtraction on each adjacent pair of 16-bit signed integers by subtracting the most significant word from the least significant word of each pair in the source and destination operands. The signed, saturated 16-bit results are packed and written to the destination operand.
-- PHSUBD Performs horizontal subtraction on each adjacent pair of 32-bit signed integers by subtracting the most significant doubleword from the least significant double word of each pair in the source and destination operands. The signed 32-bit results are packed and written to the destination operand.

## Packed Absolute Values

-- PABSB Computes the absolute value of each signed byte data element.
-- PABSW Computes the absolute value of each signed 16-bit data element.
-- PABSD Computes the absolute value of each signed 32-bit data element.

## Multiply and Add Packed Signed and Unsigned Bytes

-- PMADDUBSW Multiplies each unsigned byte value with the corresponding signed byte value to produce an intermediate, 16-bit signed integer. Each adjacent pair of 16-bit signed values are added horizontally. The signed, saturated 16-bit results are packed to the destination operand.

## Packed Multiply High with Round and Scale

-- PMULHRSW Multiplies vertically each signed 16-bit integer from the destination operand with the corresponding signed 16-bit integer of the source operand, producing intermediate, signed 32-bit integers. Each intermediate 32-bit integer is truncated to the 18 most significant bits. Rounding is always performed by adding 1 to the least significant bit of the 18-bit intermediate result. The final result is obtained by selecting the 16 bits immediately to the right of the most significant bit of each 18-bit intermediate result and packed to the destination operand

## Packed Shuffle Bytes

-- PSHUFB Permutes each byte in place, according to a shuffle control mask. The least significant three or four bits of each shuffle control byte of the control mask form the shuffle index. The shuffle mask is unaffected. If the most significant bit (bit 7) of a shuffle control byte is set, the constant zero is written in the result byte.

## Packed Sign

-- PSIGNB/W/D Negates each signed integer element of the destination operand if the sign of the corresponding data element in the source operand is less than zero.

## Packed Align Right

-- PALIGNR Source operand is appended after the destination operand forming an intermediate value of twice the width of an operand. The result is extracted from the intermediate value into the destination operand by selecting the 128 bit or 64 bit value that are right-aligned to the byte offset specified by the immediate value.

## Dword Multiply Instructions

-- PMULLD Returns four lower 32-bits of the 64-bit results of signed 32-bit integer multiplies.
-- PMULDQ Returns two 64-bit signed result of signed 32-bit integer multiplies.

## Floating-Point Dot Product Instructions

-- DPPD Perform double-precision dot product for up to 2 elements and broadcast.
-- DPPS Perform single-precision dot products for up to 4 elements and broadcast.

## Streaming Load Hint Instruction

-- MOVNTDQA Provides a non-temporal hint that can cause adjacent 16-byte items within an aligned 64- byte region (a streaming line) to be fetched and held in a small set of temporary buffers (“streaming load buffers”). Subsequent streaming loads to other aligned 16-byte items in the same streaming line may be supplied from the streaming load buffer and can improve
throughput.

## Packed Blending Instructions

-- BLENDPD Conditionally copies specified double-precision floating-point data elements in the source operand to the corresponding data elements in the destination, using an immediate byte control.
-- BLENDPS Conditionally copies specified single-precision floating-point data elements in the source operand to the corresponding data elements in the destination, using an immediate byte control.
-- BLENDVPD Conditionally copies specified double-precision floating-point data elements in the source operand to the corresponding data elements in the destination, using an implied mask.
-- BLENDVPS Conditionally copies specified single-precision floating-point data elements in the source operand to the corresponding data elements in the destination, using an implied mask.
-- PBLENDVB Conditionally copies specified byte elements in the source operand to the corresponding elements in the destination, using an implied mask.
-- PBLENDW Conditionally copies specified word elements in the source operand to the corresponding elements in the destination, using an immediate byte control.

## Packed Integer MIN/MAX Instructions

-- PMINUW Compare packed unsigned word integers.
-- PMINUD Compare packed unsigned dword integers.
-- PMINSB Compare packed signed byte integers.
-- PMINSD Compare packed signed dword integers.
-- PMAXUW Compare packed unsigned word integers.
-- PMAXUD Compare packed unsigned dword integers.
-- PMAXSB Compare packed signed byte integers.

## Floating-Point Round Instructions with Selectable Rounding Mode

-- ROUNDPS Round packed single precision floating-point values into integer values and return rounded floating-point values.
-- ROUNDPD Round packed double precision floating-point values into integer values and return rounded floating-point values.
-- ROUNDSS Round the low packed single precision floating-point value into an integer value and return a rounded floating-point value.
-- ROUNDSD Round the low packed double precision floating-point value into an integer value and return a rounded floating-point value.

## Insertion and Extractions from XMM Registers

-- EXTRACTPS Extracts a single-precision floating-point value from a specified offset in an XMM register and stores the result to memory or a general-purpose register.
-- INSERTPS Inserts a single-precision floating-point value from either a 32-bit memory location or selected from a specified offset in an XMM register to a specified offset in the destination XMM register. In addition, INSERTPS allows zeroing out selected data elements in the destination, using a mask.
-- PINSRB Insert a byte value from a register or memory into an XMM register.
-- PINSRD Insert a dword value from 32-bit register or memory into an XMM register.
-- PINSRQ Insert a qword value from 64-bit register or memory into an XMM register.
-- PEXTRB Extract a byte from an XMM register and insert the value into a general-purpose register or memory.
-- PEXTRW Extract a word from an XMM register and insert the value into a general-purpose register or memory.
-- PEXTRD Extract a dword from an XMM register and insert the value into a general-purpose register or memory.
-- PEXTRQ Extract a qword from an XMM register and insert the value into a general-purpose register or memory.

## Packed Integer Format Conversions

-- PMOVSXBW Sign extend the lower 8-bit integer of each packed word element into packed signed word integers.
-- PMOVZXBW Zero extend the lower 8-bit integer of each packed word element into packed signed word integers.
-- PMOVSXBD Sign extend the lower 8-bit integer of each packed dword element into packed signed dword integers.
-- PMOVZXBD Zero extend the lower 8-bit integer of each packed dword element into packed signed dword integers.
-- PMOVSXWD Sign extend the lower 16-bit integer of each packed dword element into packed signed dword integers.
-- PMOVZXWD Zero extend the lower 16-bit integer of each packed dword element into packed signed dword integers.
-- PMOVSXBQ Sign extend the lower 8-bit integer of each packed qword element into packed signed qword integers.
-- PMOVZXBQ Zero extend the lower 8-bit integer of each packed qword element into packed signed qword integers.
-- PMOVSXWQ Sign extend the lower 16-bit integer of each packed qword element into packed signed qword integers.
-- PMOVZXWQ Zero extend the lower 16-bit integer of each packed qword element into packed signed qword integers.
-- PMOVSXDQ Sign extend the lower 32-bit integer of each packed qword element into packed signed qword integers.
-- PMOVZXDQ Zero extend the lower 32-bit integer of each packed qword element into packed signed qword integers.

## Improved Sums of Absolute Differences (SAD) for 4-Byte Blocks

-- MPSADBW Performs eight 4-byte wide Sum of Absolute Differences operations to produce eight word integers.

## Horizontal Search

-- PHMINPOSUW Finds the value and location of the minimum unsigned word from one of 8 horizontally packed unsigned words. The resulting value and location (offset within the source) are packed into the low dword of the destination XMM register.

## Packed Test

-- PTEST Performs a logical AND between the destination with this mask and sets the ZF flag if the result is zero. The CF flag (zero for TEST) is set if the inverted mask AND’d with the destination is all zeroes.

## Packed Qword Equality Comparisons

-- PCMPEQQ 128-bit packed qword equality test.

## Dword Packing With Unsigned Saturation

-- PACKUSDW PACKUSDW packs dword to word with unsigned saturation.
