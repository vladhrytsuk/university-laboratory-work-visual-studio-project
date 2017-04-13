#include "stdafx.h"
#include <cmath>
#include <iostream>
#include <iomanip>

using namespace std;

double f(double x)
{
	double h = 3.89, g = 8.433, f1, f2, f3, y;
			f1 = fabs(pow((x - h), 2) * sin(x - g) - 0.59) * 15.5;
			f2 = sqrt(2 + log10(1 + pow(x, 2) + exp(x + 1)));
			f3 = sqrt(1 + log10(1 + pow((2 * x), 2)));
			y = (f1 / f2) * f3;
	return y;
}

double goldenSectionSearch_MAX(double a, double b) {
	double fi, x1, x2, f1, f2, eps = 0.000001, x = 0;
	fi = (1 + sqrt(5)) / 2; /* пропорция золотого сечения */

	/*разделили отрезок двумя симметричными относительно его центра точками */
	x1 = b - (b - a) / fi;
	x2 = a + (b - a) / fi;

	f1 = f(x1);
	f2 = f(x2);

	/* отбрасываем тот из концов отрезка,
	к которому из двух вновь поставленных точек ближе оказалась та,
	значение в которой максимальнo */
	while (abs(b - a) > eps) {
		if (f1 > f2) {
			a = x1;
			x1 = x2;
			f1 = f2;
			x2 = a + (b - a) * fi;
			f2 = f(x2);
		}
		else {
			b = x2;
			x2 = x1;
			f2 = f1;
			x1 = b - (b - a) * fi;
			f1 = f(x1);
		}
		x = (a + b) / 2;
	}
	return x;
}

double goldenSectionSearch_MIN(double a, double b) {
	double fi, x1, x2, f1, f2, eps = 0.000001, x = 0;
	fi = (1 + sqrt(5)) / 2; /* пропорция золотого сечения */

	/*разделили отрезок двумя симметричными относительно его центра точками */
	x1 = b - (b - a) / fi;
	x2 = a + (b - a) / fi;

	f1 = f(x1);
	f2 = f(x2);

	/* отбрасываем тот из концов отрезка,
	к которому из двух вновь поставленных точек ближе оказалась та,
	значение в которой максимальнo */
	while (abs(b - a) > eps) {
		if (f1 < f2) {
			a = x1;
			x1 = x2;
			f1 = f2;
			x2 = a + (b - a) * fi;
			f2 = f(x2);
		}
		else {
			b = x2;
			x2 = x1;
			f2 = f1;
			x1 = b - (b - a) * fi;
			f1 = f(x1);
		}
		x = (a + b) / 2;
	}
	return x;
}

int main()
{
	setlocale(LC_ALL, "RUS");
	cout << "\t\t\t\tЛабораторная работа №13" << endl;
	int j;
	double a = 1.2, b = 3.8, x = a, fx[21],t = ((b - a) / 20), xmin, xmax;
	//cout.width(5);
	cout << setw(5) << "x" << " | " << setw(5) << "F(x)\n";
		for (j = 0; j < 21; j++) {
			if (x <= b) {
			fx[j] = f(x);
			cout << setw(5) << x << " | "<< setprecision(4) << setw(5) << fx[j] << endl;
			x += t;
		}

	} 



		for (j = 0, x = a; j < 18; j++, x += t) {

			if (fx[j] <= fx[j + 1] && fx[j + 1] >= fx[j + 2]) {
				xmax = goldenSectionSearch_MAX(x, (x + 2 * t));
				cout << "На отрезке [" << setprecision(4) << x << ";" << setprecision(4) << x + 2 * t << "] - max " << endl;
				cout << " | x* = " << setprecision(4) << setw(7) << xmax << "| F(x*) = " << setw(6) << setprecision(4) << f(xmax) << endl;

			} 
			
			if (fx[j] >= fx[j + 1] && fx[j + 1] <= fx[j + 2]) {
				xmin = goldenSectionSearch_MIN(x, (x + 2 * t));
				cout << "На отрезке [" << setprecision(4) << x << ";" << setprecision(4) << x + 2 * t << "] - min " << " | x* = " << setprecision(4) << setw(6) << xmin << "| F(x*) = " << setw(6) << setprecision(4) << f(xmin) <<  endl;
				double Z = f(2.5);
				cout << Z << endl;
			}
		}
		
	system("pause");
    return 0;
}

