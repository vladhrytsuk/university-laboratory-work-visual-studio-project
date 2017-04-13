#include <iostream>
#include <ctime>

using namespace std;

void FUNC_C(char *str1, char *str2, char *str3, char *str4) {
	char *a, *b;

	a = str1;
	str1 = str3;
	str3 = a;

	b = str2;
	str2 = str4;
	str4 = b;

	cout << endl << "Реализация программы  С++:" << endl << "Строки после изменения:" << endl << str1 << str2 << str3 << str4 << endl;
}

void FUNC_ASM(char *str1, char *str2, char *str3, char *str4) {
	cout << endl << "Реализация программы ASM:" << endl << "Строки после изменения:" << endl;
	int c, d;

	__asm {

		mov eax, str1
			mov ebx, str2
			mov ecx, str3
			mov edx, str4

			mov c, eax
			mov eax, ebx
			mov ebx, c

			mov d, ecx
			mov ecx, edx
			mov edx, d

			push eax
			push ebx
			push ecx
			push edx

			call printf
			pop edx
			call printf
			pop ecx
			call printf
			pop ebx
			call printf
			pop eax
	};
}

int main() {
	setlocale(LC_ALL, "RUS");

	char *str1 = "Строка 1\n";
	char *str2 = "Строка 2\n";
	char *str3 = "Строка 3\n";
	char *str4 = "Строка 4\n";

	cout << "Исходные строки:" << endl << str1 << str2 << str3 << str4;

	int start = clock();
	FUNC_C(str1, str2, str3, str4);
	int end = clock();
	cout.precision(20);
	cout << "C++ func time is:" << double(end - start) / CLOCKS_PER_SEC << endl;

	start = clock();
	FUNC_ASM(str1, str2, str3, str4);
	end = clock();
	cout.precision(20);

	cout << "ASM func time is:" << double(end - start) / CLOCKS_PER_SEC << endl;

	system("pause");
	return 0;
}