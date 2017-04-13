#include "stdafx.h"
#include <iostream>
#include <math.h>
using namespace std;
int l9m = 1539, x = 25, l9mx = l9m*x, x1 = 0;
float modul(float a) {
	if (a>0)
		return a;
	else
		return -a;

}
int multiplnorm(int l9m, int x, int a)
{
	float mat = 0, arr[30000], dis = 0, r = 0, sig, mx, arr2[6000], u4 = 0;
	int k = 0;
	if (a % 6 != 0)
		a = a - a % 6;
	for (int j = 0; j<a; j++)
	{
		for (int i = 0; i<10; i++)
		{
			x1 = x1 + l9mx % 2 * pow(2, i);
			l9mx = (l9mx - l9mx % 2) / 2;
		}

		l9mx = l9m*x1;
		arr[j] = x1 / pow(2, 10);
		mat = mat + arr[j];
		x1 = 0;
	}
	mx = mat / a;

	for (int j = 0; j<a; j++)
	{
		dis = dis + pow((arr[j] - mat), 2);
	}

	sig = pow(dis / (a - 1) / a, 0.5);
	mat = 0;
	dis = 0;
	for (int j = 0; j<a; j = j + 6)
	{
		for (int i = 0; i<6; i++)
			r = r + arr[j + i];
		arr2[k] = mx + sig*pow(2, 0.5)*(r - 3);
		cout << k << "." << arr2[k] << endl;
		mat = mat + arr2[k];
		k++;
		r = 0;
	}
	a = k;
	mat = mat / a;
	cout << "Mat.ojidanie= " << mat << endl;
	for (int j = 0; j<a; j++)
	{
		dis = dis + pow((arr2[j] - mat), 2);
	}
	for (int j = 0; j<a; j++)
	{
		u4 = u4 + pow((arr[j] - mat), 4);
	}
	cout << "Dispersi9= " << dis / (a - 1) << endl;
	cout << "otklonenie= " << pow(dis / (a - 1) / a, 0.5) << endl;
	cout << "centralniy moment 4 por9dka=" << u4 << endl;
	cout << "srednekv.otklon= " << pow(u4 / a - (a - 3) / a / (a - 1)*pow(dis / (a - 1), 2), 0.5) << endl;
	return 0;
};

int main()
{
	int n;
	cout << "Enter size: ";
	cin >> n;
	multiplnorm(l9m, x, n);
	system("pause");
	return 0;
}
