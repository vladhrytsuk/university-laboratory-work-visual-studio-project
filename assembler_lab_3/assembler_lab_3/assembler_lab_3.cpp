#include "stdafx.h"
#include <iostream>
#include <stdio.h>
#include <ctype.h>
#include <cstring>

extern "C" void macro_procedure_changeSym(char *string, char oldSym, char newSym);
using namespace std;

int main() {

	char string[256];
	char oldSym;
	char newSym;

	cout << "Enter some string: ";
	cin.getline(string, 256);

	cout << "Enter symbol that you want to change: ";
	cin >> oldSym;

	cout << "Enter new symbol: ";
	cin >> newSym;

	macro_procedure_changeSym(string, oldSym, newSym);
	cout << endl << "Result: " << string << endl;
	system("pause");
}
