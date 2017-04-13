.686
.model flat
.code

changement macro string, temp, string_symbol, length_of_string
	mov esi, string
	mov ecx, length_of_string
	mov al, string_symbol
	mov edi, temp

start:
	mov ah, [esi]	
	cmp al, ah
	jne found_symbol

labl:
	inc esi 
	loop start
	jmp exit

found_symbol:
	mov [esi], ah
	cmp [esi], ah
	je delete_symbol

delete_symbol:
	mov [edi], ah
	inc edi
	jmp labl

exit:
	endm

public macro_procedure_delete
macro_procedure_delete proc C string:dword, temp:dword, string_symbol:byte, length_of_string:dword
changement string, temp, string_symbol, length_of_string
	
ret
macro_procedure_delete endp
end
