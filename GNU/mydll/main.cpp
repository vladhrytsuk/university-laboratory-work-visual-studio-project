#include "main.h"
#include <iostream>
#include <cstdlib>
#include <cstdio>
#include <cstring>

using namespace std;

void DLL_EXPORT Dec2Bin(){
    int translate = 0;
    char binStr;
    string decStr;
    cout << "Enter variant to translate(1 - decimal, 2 - binary): ";
    cin >> translate;

    switch(translate){
        case 1:
            int number;
            cout << "Enter a decimal string: ";
            cin >> number;
            itoa(number, &binStr, 2);
            cout << "The equivalent decimal for binary " << number << " is " << &binStr << endl;
            break;
        case 2:
            cout << "Enter a binary string: ";
            cin >> decStr;
            cout << "The equivalent binary for decimal " << decStr << " is " << strtol(decStr.c_str(), NULL, 2) << endl;
            break;
        default:
            cout << "ERROR" << endl; break;
    }
}

extern "C" DLL_EXPORT BOOL APIENTRY DllMain(HINSTANCE hinstDLL, DWORD fdwReason, LPVOID lpvReserved){
    switch (fdwReason) {
        case DLL_PROCESS_ATTACH:
            break;
        case DLL_PROCESS_DETACH:
            break;
        case DLL_THREAD_ATTACH:
            break;
        case DLL_THREAD_DETACH:
            break;
    }
    return TRUE;
}
