#include "stdafx.h"
#include "conio.h"
#include "locale.h"
#include "string.h"
#include "stdlib.h"
#include "Windows.h"
#include "stdio.h"
#include "time.h"

void ExerciseOne();
void Instruction();
void InstructionEx1();
void error();

int main() {
	int n;
	setlocale(LC_ALL, "RUS");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	Instruction();
	scanf_s("%d", &n);
	switch (n) {
	case 1:
		system("cls");
		ExerciseOne();
		break;
	default:
		system("cls");
		printf("Ошибка: Данного пункта меню нет. Нажмите 1 или 2.\n");
		main();
	}
}

void ExerciseOne() {
	int i,//число строк
		j,//число столбцов
		n,//текущее число строк в массиве
		m,//текущее число столбцов в массиве
		**arr,//указатель на двумерный массив
		*swap,//обмен значениями
		a,//вспомагательная для прохода по столбцам
		l;//вспомагательная для проверки на совпадение елементов в строке
	srand(time(NULL));
	printf("Введите размер двумерного массива:");
	printf("\nКоличество строк = ");
	scanf_s("%d", &n);
	printf("Количество столбцов = ");
	scanf_s("%d", &m);
	if (!(arr = (int**)malloc(n * sizeof(int*)))) {
		printf("Для такого массива не хватает памяти!\n");
		system("pause");
		return 1;
	}
	/*Заполнение массива числами */
	printf("\nЗадайте значения элементам массива: ");
	printf("\n");
	for (i = 0;i < n;i++) {
		if (!(arr[i] = (int*)malloc(m * sizeof(int)))) {
			printf("Для такого массива не хватает памяти!\n");
			system("pause");
			return 1;
		}
		for (j = 0;j < m;j++) {
		de:
			printf("arr[%d][%d]=", i, j);
			if (scanf_s("%d", &arr[i][j])) {
				for (l = i - 1; l >= 0; l--) { //Проверка на совпадение елементов в строке
					if (arr[i][j] == arr[l][j]) {
						printf("Вы ввели повторяющийся елемент!\n");
						goto de;
					}
				}
			}
			else {
				error();
				goto de;
			}
		}
	}
	printf("\n");
	/*Печать массива*/
	for (i = 0;i < m;i++) {
		for (j = 0;j < n;j++) {//печать текущей i-ой строки массива
			printf("%3d", arr[i][j]);
		}
		printf("\n");//переход к печати новой строки
	}
	//Сортировка строк двумерного массива
	for (i = 0;i < m;i++) {
		for (j = 0; j < (n - 1);) {
			if (arr[i][j] > arr[i][j + 1]) {
				for (a = 0; a < (n - 1);a++) {
					if (arr[i][a] > arr[i][a + 1]) {
						swap = arr[i][a];
						arr[i][a] = arr[i][a + 1];
						arr[i][a + 1] = swap;
					}
				}
				j = 0;
			}
			else {
				j++;
			}
		}
	}
	/*Печать массива*/
	printf("\n Отсортированный массив: \n");
	for (i = 0;i < m;++i) {
		for (j = 0; j < n; ++j) {
			printf_s("%3d", arr[i][j]);
		}
		printf("\n");
	}
	free(arr);
	InstructionEx1();
	printf("\n");
	_getch();
}

void Instruction() {
	printf("\tЛабораторная работа №7\n"
		"Используя пузырек упорядочить по возрастанию значения,\n"
		"содержащиеся в строках двумерного массива размером n x m.\n"
		"Вывести массив на экран. Массив должен состоять из целых чисел.\n"
		"Значения n x m, а также значение элементов массива вводятся пользователем с клавиатуры.\n"
		"Элементы в столбцах массива С не должны повторяться.\n"
		"1)Перейти к программе: ");
}

void InstructionEx1() {
	int n;
	printf("\n1)Повторить попытку\n"
		"2)Выход в МЕНЮ\n"
		"3)Завершить программу\n");
	do {
		scanf_s("%d", &n);
		switch (n) {
		case 1:
			system("cls");
			ExerciseOne();
			break;
		case 2:
			system("cls");
			rewind(stdin);
			main();
			break;
		case 3:
			exit(0);
		}
	} while (n != 1 || n != 2 || n != 3);
}

void error() {
	printf_s("Ошибка ввода!\n");
	rewind(stdin);
}
