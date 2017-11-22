#include <iostream>
#include <ctime>
#include "perem.h"
using namespace std;
double zapMas(int N, double *Mas)
{
	cout << "Массив заполняется автоматически, можете взглянуть на него " << endl;
	for (int i = 0; i < N; i++)
	{
		Mas[i] = rand();
		cout << Mas[i] << "\n";
	}
	//cout <<  "\n";
	return *Mas;
}
void Quicksort(double *Mas, int left, int right, int K, int l)
{

	int i = left;
	int j = right;

	int opporn = Mas[left + (right - left) / 2];
	do
	{
		while (Mas[i] < opporn)
		{
			i++;
		}

		while (Mas[j] > opporn)
		{
			j--;
		}

		if (i <= j)
		{
			int temp = Mas[i];
			Mas[i] = Mas[j];
			Mas[j] = temp;
			i++;
			j--;
		}

	} while (i <= j);

	/*cout << "Преобразованный массив " << endl;
	for (int k = 0; k < N; k++)
	{
	cout << Mas[k] << endl;
	}*/
	if (left < j)
	{
		Quicksort(Mas, left, j, K, l);
	}

	if (i < right)
	{
		Quicksort(Mas, i, right, K, l);
	}


}
double Rezultat(double *Mas, int N)
{
	cout << "Преобразованный массив " << endl;
	for (int i = 0; i < N; i++)
	{
		cout << Mas[i + 1] << endl;
	}
	return *Mas;
}
int main()
{
	setlocale(LC_ALL, "Rus");			//Русский буквы в консоли
	bool A = false;
	do
	{
		cout << "Введите количество элементов массива" << endl;
		cin >> N;
		if (N >0)
		{
			A = true;
		}
		else if (N < 0)
		{
			cout << "Как ты себе представляешь такой массив? " << endl;;
			A = false;
		}
	} while (A == false);
	/*cout << "Введите количество итераций " << endl;
	cin >> K;*/
	double *Mas = new double[N];			// сортируемый массив данных

	zapMas(N, Mas);
	int left = 0;						// левая часть массива
	int right = N;						//правая часть массива
	start_time = clock();
	Quicksort(Mas, left, right, K, l);
	end_time = clock();

	Rezultat(Mas, N);
	cout << "runtime = " << clock() / 1000.0 << endl;											//Конечное время программы
	cout << "Время выполнения программы: " << (end_time - start_time) / 1000.0 << endl;			//Конечное время выполнения сортировки методом пузырька
	return 0;

}