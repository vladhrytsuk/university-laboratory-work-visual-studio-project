.686
.model flat
.code

changement macro temp, length_of_temp, count
	mov esi, temp
	mov ecx, length_of_temp
	mov al, ' '
	mov edi, count

start:
	mov ah, [esi]	
	cmp al, ah
	je count_word

labl:
	inc esi 
	loop start
	jmp exit

count_word:
	inc edi
	jmp labl

exit:
	endm

public macro_procedure_count_word
macro_procedure_count_word proc C temp:dword, length_of_temp:dword, count:dword
changement temp, length_of_temp, count
	
ret
macro_procedure_count_word endp
end
