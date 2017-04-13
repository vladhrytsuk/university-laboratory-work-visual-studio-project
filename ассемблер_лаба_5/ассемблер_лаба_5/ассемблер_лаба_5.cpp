#include "stdafx.h"
#include <iostream>
#include <windows.h>

using namespace std;

extern "C" void macro_procedure_delete(char *string, char *temp, char string_symbol, int length_of_string);

int main() {
	char *string = new char[256];
	char tmpstring[256];
	char temp[256] = "";
	char string_symbol;
	int counter = 0;

	cout << "Enter the string: ";
	gets_s(tmpstring);
	for (int i = 0; i < strlen(tmpstring); i++)
	{
		if (tmpstring[i] != '\n')
		{
			string[i] = tmpstring[i];
			counter++;
		}
		else
			break;
	}
	string[counter] = '\0';

	cout << "Enter the symbol for delete: ";
	cin >> string_symbol;
	cout << endl;

	int length_of_string = strlen(string);

	macro_procedure_delete(string, temp, string_symbol, length_of_string);

	cout << "Rezult string: " << endl;
	for (int i = 0; i < strlen(temp); i++) cout << temp[i];
	cout << endl;
	system("pause");
	return 0;
}

