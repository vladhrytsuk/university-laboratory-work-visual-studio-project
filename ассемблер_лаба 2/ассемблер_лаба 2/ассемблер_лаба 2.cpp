#include "stdafx.h"
#include <iostream>
#include <windows.h>

using namespace std;

char str[101];
char x2String[201];
char formatScanf[] = "%s";
char formatPrintf[] = "%s\n";
char noLatinStr[] = "������ � ����� ������ �� �������� ��������� ����\n\n";
char errorStr[] = "\n������������ ������ ������. �������� ����������� �����\n";
char correctStr[] = "\n������ ������������� �������\n����: ";
char Nachalo[] = "������� �����, ������� ���������� � ������������ ��������� ������.\n� ����� ��������� �����: ";

void ASM_function() {
	__asm {
		jmp START
			//�������� �������------
		isLatin://���� � al ���. �������� ����� ���������� � ah �������,����� 0
			cmp al, 'a'
			jl notLatin//���� ������ ���� �

			cmp al, 'z'
			jg notLatin//���� ������ ���� z

			mov ah, 1
			ret

		notLatin:
			xor ah, ah
			ret
			//1-� ��������������---------
		isRus://���� � al ��������� �������  ����� ���������� � al N mod 10 
				   //����� �������, ��� N��� ����� � ��������
			cmp al, '�'
			jl notRus//���� ������ ����� �

			cmp al, '�'
			jg notRus//���� ������ ����� �

			sub al, '�'//������� ���������� ������� ������� � ����	
			mov bl, 10
			xor ah, ah
			div bl//����� ax �� bl,� al ���������, � ah �������
			add ah, '�'//�������� ��� �������
			mov al, ah

		notRus:
			ret
		// 2-� ��������������---
		isLat://���� � al ��������� ������, ����.
				   //��������, ���������� � al N mod 10 
				   //����� �������, ��� N ��� ����� � ��������
			cmp al, 'a'
			jl notLat//���� ������ ����� �

			cmp al, 'z'
			jg notLat//���� ������ ����� z
			mov ah, 1
			ret

		notLat:
			xor ah, ah
			ret

			//���-------
		START:
			push eax
			push ebx
			push ecx

			push offset Nachalo//������ �� ����
			call printf
			pop eax

			push 255//��� ����
			push offset str
			call gets_s
			pop eax
			pop eax

			push ax//��������� ����� ������ ���������� � ��������� �����
			mov al, [str]
			call isLatin
			cmp ah, 0
			pop ax

			jz noLatins//���� ah ����� 0

			xor ecx, ecx
		begLoop_1:
			inc ecx
			cmp[str + ecx], '\0'
			jz incorString//����� �� ����� ������
						  //�� ����� �����
			cmp ecx, 100
			jz incorString//�������� ������ � 100
						  //��������
			cmp[str + ecx], '.'
			jnz begLoop_1//���� �� ������ �����
						 //������� � ������ �����
			push ax //����� �����
			mov al, [str + ecx - 1]
			call isLatin
			cmp ah, 0
			pop ax

			jz noLatins//���� ������ ����� ������
					   //�� �����, ������� �� noLatins
			push offset correctStr//������ �� ����
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

		incorString: //������� ������������ ������
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
