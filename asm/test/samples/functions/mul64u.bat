del bin /q 
set name="mul64u"

ml64 /c /Fo bin/%name%.asm.obj %name%.asm
cl /O2 /GL /Fo:bin/%name%.obj /Fe:bin/%name%.exe %name%.c  /link bin/%name%.asm.obj 
call "bin/%name%.exe"

