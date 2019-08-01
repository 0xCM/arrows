del bin /q
ml64 /c /Fo bin/mul.asm.obj mul.asm
cl /GL /Fo:bin/mul.obj /Fe:bin/mul.exe mul.c  /link bin/mul.asm.obj 