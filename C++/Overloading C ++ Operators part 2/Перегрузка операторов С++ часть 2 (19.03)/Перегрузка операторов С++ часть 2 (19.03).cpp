#include "stdafx.h"
#include <iostream>
using namespace std;

class MyArray
{
	int *numbers;
	int sizeOfArray;
public:
	MyArray() //конструктор без параметров
	{
		sizeOfArray = 0;
		numbers = 0;
	}
	//-----------------------------------------------
	MyArray(int size)  //конструктор с параметрами
	{
		sizeOfArray = size;
		numbers = new int[sizeOfArray];
		for (int i = 0; i < sizeOfArray; i++)
		{
			numbers[i] = 0;
		}
	}
	//-----------------------------------------------
	~MyArray() //деструктор
	{
		delete[] numbers;
	}
	//-----------------------------------------------
	void showData() //вывод данных массива на экран
	{
		for (int i = 0; i < sizeOfArray; i++)
		{
			cout << numbers[i] << " | ";
		}
		cout << endl << endl;
	}
	//-----------------------------------------------
	// на место вызова [] вернется по ссылке сам объект
	int operator[](int j) //перегрузка []     
	{
		return numbers[j];
	}
	//-----------------------------------------------

	MyArray& operator=(MyArray &arrInt2) //перегрузка оператора присваивания
	{
		delete[] numbers;

		sizeOfArray = arrInt2.sizeOfArray;

		numbers = new int[sizeOfArray];
		for (int i = 0; i < sizeOfArray; i++)
		{
			numbers[i] = arrInt2.numbers[i];
		}

		return *this;
	}
	//-----------------------------------------------
	friend bool operator ==(MyArray &arrInt, MyArray &arrInt2); //перегрузка ==
};

bool operator == (MyArray &arrInt, MyArray &arrInt2)
{
	if (arrInt.sizeOfArray != arrInt2.sizeOfArray) //сравниваем размеры массивов объектов
	{
		cout << "В массивах разное количество элементов\n";
		return 0;
	}
	else //проверяем равны ли данныев в ячейках массивов
	{
		for (int i = 0; i < arrInt.sizeOfArray; i++)
		{
			if (arrInt.numbers[i] != arrInt2.numbers[i])
			{
				cout << "Значения массивов не равны\n";
				return 0;
			}
		}
	}
	return 1;
}

int main()
{
	setlocale(LC_ALL, "rus");

	MyArray ArrayInt(5);  //создаем объект класса и записываем в него данные
	ArrayInt[0] = 1; //перегруженный []
	ArrayInt[1] = 2;
	ArrayInt[2] = 3;
	ArrayInt[3] = 4;
	ArrayInt[4] = 5;
	cout << "Массив ArrayInt:  ";
	ArrayInt.showData();  //вывод данных массива на экран

	MyArray ArrayInt2(5); //создаем второй объект класса
	ArrayInt2[0] = 11; //перегруженный []
	ArrayInt2[1] = 22;
	ArrayInt2[2] = 33;
	ArrayInt2[3] = 44;
	ArrayInt2[4] = 55;
	cout << "Массив ArrayInt2: ";
	ArrayInt2.showData();  //вывод данных массива на экран

	if (ArrayInt == ArrayInt2) { //сравнение двух объектов класса (перегруженный ==)
		cout << "Массив ArrayInt равен массиву ArrayInt2\n";
	}
	else {
		ArrayInt = ArrayInt2;
	}
	cout << "Массив ArrayInt после копирования:  ";
	ArrayInt.showData();

	MyArray ArrayInt3(10); // третий объект класса с массивом из 10 элементов
	cout << "Массив ArrayInt3: ";
	ArrayInt3.showData();
	ArrayInt3 = ArrayInt; // копируем массив из ArrayInt в ArrayInt3
	cout << "Массив ArrayInt3 после копирования: \n";
	ArrayInt3.showData();

	return 0;
}