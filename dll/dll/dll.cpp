// dll.cpp: определяет экспортированные функции для приложения DLL.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

extern "C" __declspec(dllexport)void func()
{
	setlocale(LC_ALL, "Rus");

	cout << "It is function ПРИВЕТ!!! "<<"\n";
}

