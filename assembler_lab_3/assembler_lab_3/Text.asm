.686
.model flat, C
.code

macro_procedure_changeSym proc C string: ptr byte, oldSym: byte, newSym: byte
	
start:

	mov dh, newSym
	mov dl, oldSym
	mov esi, dword ptr[string]
	
	lop1 :
		mov bl, byte ptr[esi]

		cmp bl, '0'
		je endLop1
		
		cmp bl, dl
		jne increse

		mov byte ptr[esi], dh

	increse:
		inc esi
		jmp lop1
		
	endLop1 :

exit:
	
ret
macro_procedure_changeSym endp
end
