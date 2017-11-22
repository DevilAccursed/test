#include <iostream>
#include <ctime>
#include "perem.h"
#include <windows.h>
#include <conio.h>
using namespace std;
double zapMas(int N, double *Mas)
{
	cout << "������ ����������� �������������, ������ ��������� �� ���� " << endl;
	for (int i = 0; i < N; i++)
	{
		Mas[i] = rand();
		cout << Mas[i] << "\n";
	}
	return *Mas;
}
double SortMas(double *Mas, int N, int K, double flag, double C, double end_time, double start_time)
{
	do
	{
		for (int i = 0; i < N - 1; i++)
		{
			C = 0;
			if (Mas[i + 1] < Mas[i])
			{
				C = Mas[i];
				Mas[i] = Mas[i + 1];
				Mas[i + 1] = C;
			}
		}
		flag++;
	} while (flag != K);
	return *Mas;
}
double Rezultat(double *Mas, int N)
{
	cout << "��������������� ������ " << endl;
	for (int i = 0; i < N; i++)
	{
		cout << Mas[i] << endl;
	}
	return *Mas;
}
int main()
{
	setlocale(LC_ALL, "Rus");
	typedef void(*funcclass)();
	HMODULE hlib = LoadLibrary(TEXT("dll.dll"));
	if (hlib == NULL) cout << "Library ERROR!!!"<<"\n";
	

	funcclass func =(funcclass)GetProcAddress(hlib, "func");
	if (hlib == NULL) cout << "Library ERROR!!!";
	if (hlib != NULL) func();
	
	bool A = false;
	do
	{
		cout << "������� ���������� ��������� �������" << endl;
		cin >> N;
		if (N >0)
		{
			A = true;
		}
		else if (N < 0)
		{
			cout << "��� �� ���� ������������� ����� ������? " << endl;;
			A = false;
		}
	} while (A == false);

	double *Mas = new double[N];			// ����������� ������ ������

	zapMas(N, Mas);
	cout << "������� ���������� ��������(��������)" << endl;
	cin >> K;

	start_time = clock();
	SortMas(Mas, N, K, flag, C, end_time, start_time);
	end_time = clock();

	Rezultat(Mas, N);
	cout << "runtime = " << clock() / 1000.0 << endl;											//�������� ����� ���������
	cout << "����� ���������� ���������: " << (end_time - start_time) / 1000.0 << endl;			//�������� ����� ���������� ���������� ������� ��������
	FreeLibrary(hlib);
	return 0;
}