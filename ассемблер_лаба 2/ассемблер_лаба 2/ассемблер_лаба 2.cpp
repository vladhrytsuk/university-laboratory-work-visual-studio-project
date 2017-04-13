#include "stdafx.h"
#include <iostream>
#include <windows.h>

using namespace std;

char str[101];
char x2String[201];
char formatScanf[] = "%s";
char formatPrintf[] = "%s\n";
char noLatinStr[] = "Начало и конец текста не содержат латинских букв\n\n";
char errorStr[] = "\nНеправильный формат текста. Возможно отсутствует точка\n";
char correctStr[] = "\nСтрока удовлетворяет условию\nИтог: ";
char Nachalo[] = "Введите текст, который начинается и оканчивается латинской буквой.\nВ конце поставьте точку: ";

void ASM_function() {
	__asm {
		jmp START
			//Проверка условия------
		isLatin://если в al лат. строчная буква записываем в ah единицу,иначе 0
			cmp al, 'a'
			jl notLatin//если меньше кода а

			cmp al, 'z'
			jg notLatin//если больше кода z

			mov ah, 1
			ret

		notLatin:
			xor ah, ah
			ret
			//1-е преобразование---------
		isRus://если в al прописная русская  буква записываем в al N mod 10 
				   //этого символа, где Nего номер в алфавите
			cmp al, 'А'
			jl notRus//если меньше буквы А

			cmp al, 'Я'
			jg notRus//если больше буквы Я

			sub al, 'А'//получам алфавитный порядок начиная с нуля	
			mov bl, 10
			xor ah, ah
			div bl//делим ax на bl,в al результат, в ah остаток
			add ah, 'А'//получаем код символа
			mov al, ah

		notRus:
			ret
		// 2-е преобразование---
		isLat://если в al латинский символ, нижн.
				   //регистра, записывает в al N mod 10 
				   //этого символа, где N его номер в алфавите
			cmp al, 'a'
			jl notLat//если меньше буквы а

			cmp al, 'z'
			jg notLat//если больше буквы z
			mov ah, 1
			ret

		notLat:
			xor ah, ah
			ret

			//Код-------
		START:
			push eax
			push ebx
			push ecx

			push offset Nachalo//Запрос на ввод
			call printf
			pop eax

			push 255//Сам ввод
			push offset str
			call gets_s
			pop eax
			pop eax

			push ax//Проверяем чтобы строка начиналась с латинской буквы
			mov al, [str]
			call isLatin
			cmp ah, 0
			pop ax

			jz noLatins//если ah равен 0

			xor ecx, ecx
		begLoop_1:
			inc ecx
			cmp[str + ecx], '\0'
			jz incorString//дошли до конца строки
						  //не найдя точку
			cmp ecx, 100
			jz incorString//превышен размер в 100
						  //символов
			cmp[str + ecx], '.'
			jnz begLoop_1//пока не найдем точку
						 //прыгаем в начало цикла
			push ax //нашли точку
			mov al, [str + ecx - 1]
			call isLatin
			cmp ah, 0
			pop ax

			jz noLatins//если символ перед точкой
					   //не цифра, прыгаем на noLatins
			push offset correctStr//Запрос на ввод
			call printf
			pop eax
			xor ecx, ecx

		begLoop_2:
			inc ecx
			cmp[str + ecx], '.'
			jz endLoop_2

			mov al, [str + ecx]
			call isRus
			mov[str + ecx], al
			jmp begLoop_2

		endLoop_2:
			push offset str
			push offset formatPrintf
			call printf
			pop eax
			pop eax
			jmp END

		noLatins:
			push offset noLatinStr
			call printf
			pop eax
			xor ecx, ecx
			xor ebx, ebx
		begLoop_3:
			mov al, [str + ecx]
			inc ecx
			cmp al, '.'
			jz endLoop_3

			call isLat
			mov[x2String + ebx], al
			inc ebx
			cmp ah, 0
			jz begLoop_3

			mov[x2String + ebx], al
			inc ebx
			jmp begLoop_3
		endLoop_3:
			mov[x2String + ebx], al
			mov[x2String + ebx + 1], '\n'
			mov[x2String + ebx + 2], '\0'

			push offset x2String
			call printf
			pop eax
			jmp END

		incorString: //Введена некорректная строка
			push offset errorStr
			call printf
			pop eax

		END:
			pop ecx
			pop ebx
			pop eax

	}
}
int main() {
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	ASM_function();
	system("pause");
	return 0;
}
