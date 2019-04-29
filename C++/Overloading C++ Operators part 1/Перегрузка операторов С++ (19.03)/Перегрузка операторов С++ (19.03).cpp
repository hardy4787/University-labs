#include "stdafx.h"
#include <iostream>
#include <string.h>

using namespace std;

class StringsWork
{
private:
	char str[256];//строка, которая доступна классу
public:
	StringsWork()//конструктор в котором очистим строку класса от мусора
	{
		for (int i = 0; i < 256; i++)  str[i] = '\0';
	}

	void operator +(char*);//прототип метода класса в котором мы перегрузим оператор +
	void operator -(char*);//прототип метода класса в котором мы перегрузим оператор -
	void getStr();//метод вывода данных на экран
};

void StringsWork::operator +(char *s) //что должен выполнить оператор +
{
	strcat(str, s);
}
void StringsWork::operator -(char *s) //что должен выполнить оператор +
{
	int ct = strlen(str) - strlen(s);
	str[ct] = '\0';
}

void StringsWork::getStr()
{
	cout << str << endl << endl;//вывод символьного массива класса на экран
}

int main()
{
	setlocale(LC_ALL, "rus");

	char *str1 = new char[strlen("У лукоморья дуб зелёный;\n") + 1]; //выделим память для строк
	char *str2 = new char[strlen("Всё ходит по цепи кругом;\n") + 1];
	char *str3 = new char[strlen("И днём и ночью кот учёный\n") + 1];
	char *str4 = new char[strlen("Златая цепь на дубе том:\n") + 1];

	strcpy(str1, "У лукоморья дуб зелёный;\n");//инициализируем
	strcpy(str2, "Всё ходит по цепи кругом;\n");
	strcpy(str3, "И днём и ночью кот учёный\n");
	strcpy(str4, "Златая цепь на дубе том:\n");

	cout << "1) " << str1;
	cout << "2) " << str2;
	cout << "3) " << str3;
	cout << "4) " << str4 << endl;

	StringsWork story;//создаем объект и добавяем в него строки с помощью перегруженного +
	story + str1;
	story + str4;
	story + str3;
	story + str2;
	story - str2;

	cout << "========================================" << endl;
	cout << "Стих, после правильного сложения строк: " << endl;
	cout << "========================================" << endl << endl;
	story.getStr();
	
	
	//Отмечу, что для числовых типов данных оператор плюс будет складывать значения, как и должен
	int a = 5;
	int b = 5;
	int c = 0;

	c = a + b;
	cout << "========================================" << endl << endl;
	cout << "a = " << a << endl << "b = " << b << endl;
	cout << "c = " << a << " + " << b << " = " << c << endl << endl;

	delete[] str4;//освободим память
	delete[] str3;
	delete[] str2;
	delete[] str1;

	return 0;
}