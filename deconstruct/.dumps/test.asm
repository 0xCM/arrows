# 0f 1f 44 00 00 41 0b d0 41 0b d1 0b 54 24 28 0b 54 24 30 0b 54 24 38 8b c2 0b 44 24 40 0b 44 24 48 c3 
# xed -64 -ih test.hex > test.asm
XDIS 0: WIDENOP   BASE       0F1F440000               nop dword ptr [rax+rax*1], eax
XDIS 5: LOGICAL   BASE       410BD0                   or edx, r8d
XDIS 8: LOGICAL   BASE       410BD1                   or edx, r9d
XDIS b: LOGICAL   BASE       0B542428                 or edx, dword ptr [rsp+0x28]
XDIS f: LOGICAL   BASE       0B542430                 or edx, dword ptr [rsp+0x30]
XDIS 13: LOGICAL   BASE       0B542438                 or edx, dword ptr [rsp+0x38]
XDIS 17: DATAXFER  BASE       8BC2                     mov eax, edx
XDIS 19: LOGICAL   BASE       0B442440                 or eax, dword ptr [rsp+0x40]
XDIS 1d: LOGICAL   BASE       0B442448                 or eax, dword ptr [rsp+0x48]
XDIS 21: RET       BASE       C3                       ret 
# end of text section.
# Errors: 0
#XED3 DECODE STATS
#Total DECODE cycles:        156452
#Total instructions DECODE: 10
#Total tail DECODE cycles:        156452
#Total tail instructions DECODE: 10
#Total cycles/instruction DECODE: 15645.20
#Total tail cycles/instruction DECODE: 15645.20
