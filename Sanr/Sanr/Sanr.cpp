#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;

double F0(double x) //значение функции F(x)
{
	double F_0;
	F_0 = pow(x, 2)*sin(0.23 + 3*x);
	return F_0;
}
double F1(double x) // 1-ая производная F(x)
{
	double F_1, F_1_1, F_1_2;
	F_1_1 = 2 / pow(x, 0.5)*sin(2 * pow(x, 0.5) + 1);
	F_1_2 = cos(2 * pow(x, 0.5) + 1);
	F_1 = F_1_1 * F_1_2;
	return F_1;
}
double F2(double x) //2-ая производная F(x)
{
	double F_2, F_2_1, F_2_2;
	F_2_1 = -1 / pow(x, 1.5)*pow(sin(1), 0.5);
	F_2_2 = pow(cos(1), 0.5);
	F_2 = F_2_1*F_2_2;
	return F_2;
}

double Newton(double x0, double eps)
{
	double x;    x = x0;
	while ((F1(x) != 0) && (F2(x) > eps))
	{
		x = x - F1(x) / F2(x);
	}
	cout << setw(9) << "x(exrt)=" << x << ", " << "F(x)_(extr)=" << setw(9) << F0(x) << endl;
	return x;
}

void z1(double *A, double *F, int n) {
	cout << setw(9) << "x" << "\t\t" << "F(x)" << endl;
	cout << "_________________________________________" << endl;
	for (int i = 0; i < n; i++)
	{
		cout << setw(9) << A[i] << "\t" << "|      ";
		cout << setw(9) << F[i] << "\t" << "|" << endl;
		cout << "_________________________________________" << endl;
	}
}

void z2(double *A, double *F, int n) {
	double e = 0.0001;
	cout << "--------------------------------------" << endl;
	cout << "nachalo otrezka\t| " << "konec otrezka\t|" << "Extr" << endl;
	cout << "--------------------------------------" << endl;
	for (int i = 0; i < n - 2; i++)	{
		if (F[i] <= F[i + 1] && F[i + 1] >= F[i + 2]) {
			cout << setw(9) << A[i] << "\t| " << setw(9) << A[i + 2] << "\t|" << "max ->";
			Newton((A[i] + A[i + 2]) / 2, e);
			cout << "--------------------------------------" << endl;
			
		}

		else
			if (F[i] >= F[i + 1] && F[i + 1] <= F[i + 2]) {
				cout << setw(9) << A[i] << "\t| " << setw(9) << A[i + 2] << "\t|" << "min ->";
				Newton((A[i] + A[i + 2]) / 2, e);
				cout << "--------------------------------------" << endl;
				
			}
	}
}

int main() {
	int input, n;  double a, b, h;
	a = -0.5;  b = 3;
	cout << "Vvedite kol-vo razbiyeniy ";
	cin >> n;  cout << endl;
	h = (b - a) / (n - 1);
	double *A = new double[n]; // Выделение памяти для массива
	double *F = new double[n]; // Выделение памяти для массива
	A[0] = a;
	for (int i = 0; i < n; i++) {
		A[i + 1] = A[i] + h;
		F[i] = F0(A[i]);
	}
	cout << "1. Bloc_1\n";
	cout << "2. Bloc_2\n";
	cout << "3. Bloc_1 + Bloc_2\n";
	cout << "4. Exit\n";
	cout << "Selection: ";
	cin >> input;
	switch (input)
	{
	case 1:
		z1(A, F, n);
		break;
	case 2:
		z2(A, F, n);
		break;
	case 3:
		z1(A, F, n);
		z2(A, F, n);
		break;
	case 4:
		cout << "Exit\n";
		break;
	default:
		cout << "Error\n";
		break;
	}
	delete[] A;
	delete[] F;
	cin.get();
}
