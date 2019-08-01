includelib kernel32.lib
includelib user32.lib
includelib libcmt.lib
includelib libvcruntime.lib
includelib libucrt.lib

extrn ExitProcess:PROC
extrn MessageBoxA:PROC
extrn WriteConsoleA:PROC
extrn GetStdHandle:PROC                            
extrn WriteFile:PROC  
extrn printf:proc
extrn puts:proc
extrn system:proc

.data
  caption db '64-bit hello!', 0
  message db 'Hello World!', 0
  msg1 db 'Howdy', 0
  string_title_x64_printf db "title x64 printf",0
  string_color_0F db "color 0F",0
  string_pause db "pause",0
  string db "string",0
  string_pd_newline db "%d",10,0

.code
  _main PROC  
    sub    rsp, 28h      ; shadow space, aligns stack  
    mov    rcx, 0       ; hWnd = HWND_DESKTOP
    lea    rdx, message ; LPCSTR lpText
    lea    r8,  caption ; LPCSTR lpCaption
    mov    r9d, 0       ; uType = MB_OK
    call   MessageBoxA  ; call MessageBox API function
    mov    ecx, eax     ; uExitCode = MessageBox(...)
    call ExitProcess
  _main ENDP

  output proc
      ;push              rbp
      mov               rbp,rsp
      lea               rcx,[string_title_x64_printf]
      call              system
      lea               rcx,[string_color_0F]
      call              system
      lea               rcx,[string]
      call              puts
      lea               rcx,[string_pd_newline]
      mov               rdx,3
      call              printf
      lea               rcx,[string_pause]
      call              system
      ret 
  output endp
END

