// Помощь Вите.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <windows.h>
#include <iostream>

void gotoxy(int xpos, int ypos)
{
	COORD scrn;

	HANDLE hOuput = GetStdHandle(STD_OUTPUT_HANDLE);

	scrn.X = xpos; scrn.Y = ypos;

	SetConsoleCursorPosition(hOuput, scrn);
}

void main()
{
	int q, p;
	window(1, 1, 50, 50);
	textbackground(BLACK);
	textcolor(YELLOW);
	system("cls");
	textbackground(WHITE);
	gotoxy(2, 2);
	cputs("Help");
	gotoxy(4, 4);
	textcolor(BLACK);
	cputs("laba1...");
	gotoxy(6, 6);
	cputs("laba2...");
	gotoxy(8, 8);
	cputs("laba3...");
	gotoxy(10, 10);
	cputs("laba4...");
	gotoxy(12, 12);
	cputs("laba5...");
	gotoxy(14, 14);
	cputs("laba6...");

	if (!(q = getch()))
	{
		q == 0;
		q == getch();
		switch (q)
		{
		case77: printf("!%d!");
			p = 0;
			gotoxy(2, 2);
			textcolor(BLACK);
			cputs("Help");

			p = 1;
			gotoxy(4, 4);
			textcolor(YELLOW);
			cputs("Laba1...");
		}
	}

}