.code

mul64u proc
    mov     rax,rcx
    imul    rax,rdx
    ret
mul64u endp

end