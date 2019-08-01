del bin /q 

ml64 /c /Fo bin/func.obj func.asm
cl /GL /Fo:bin/driver.obj /Fe:bin/driver.exe driver.c  /link bin/func.obj 

call "bin/driver.exe"

