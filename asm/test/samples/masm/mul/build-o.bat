del bin /q

ml64 /c /Fo bin/mul.asm.obj mul.asm

cl /c /GL /O2 /Fo:bin/mul.obj /Fe:bin/mul.exe mul.c
link /ltcg:pgi "bin/mul.asm.obj" "bin/mul.obj" /out:"bin/mul.exe"

"bin/mul.exe" %random% > nul


link /ltcg:pgo "bin/mul.asm.obj" "bin/mul.obj" /out:"bin/mul.exe"