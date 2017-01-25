#include "stdafx.h"
#include "conio.h"
#include "locale.h"
#include "string.h"
#include "stdlib.h"
#include "Windows.h"
#include "stdio.h"

void ExerciseOne();
void ExerciseTwo();
void Instruction();
void InstructionEx1();
void InstructionEx2();

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
	case 2:
		system("cls");
		ExerciseTwo();
		break;
	default:
		system("cls");
		printf("Ошибка: Данного пункта меню нет. Нажмите 1 или 2.\n");
		main();
	}
}

void ExerciseOne() {
	int num; /*Число месяца*/
	printf	("Введите число месяца: ");
	if (scanf_s("%d", &num)) {
		printf("Выбраный месяц: ");
		switch (num)
		{
		case 1:
			printf("Январь");
			break;
		case 2:
			printf("Февраль");
			break;
		case 3:
			printf("Март");
			break;
		case 4:
			printf("Апрель");
			break;
		case 5:
			printf("Май");
			break;
		case 6:
			printf("Июнь");
			break;
		case 7:
			printf("Июль");
			break;
		case 8:
			printf("Август");
			break;
		case 9:
			printf("Сентябрь");
			break;
		case 10:
			printf("Октябрь");
			break;
		case 11:
			printf("Ноябрь");
			break;
		case 12:
			printf("Декабрь");
			break;
		default:
			printf("Не коректное число месяца.");
			break;
		}
	}
	else {
		printf("Ошибка: Введите число");
	}
	InstructionEx1();
	printf("\n");
	_getch();
}

void ExerciseTwo() {
	char *chr; /*Слово*/
	int err = 0, /* если 1 то не полиндром*/
		lengh; /*Длинна слова*/
	rewind(stdin);
	chr = (char*)malloc(sizeof(chr));
	printf("Введите слово: ");
	fgets(chr, 100, stdin);
	lengh = strlen(chr);
	for (int i = 0; i <= lengh - 2 && err == 0; i++) {
		if (toupper(chr[i]) != toupper(chr[lengh - i - 2])) {
			err = 1;
		}
	}
	if (err == 0) {
		printf("YES");
	}
	else { 
		printf("NO"); 
	}
	InstructionEx2();
	printf("\n");
}

void Instruction() {
	printf("\tЛабораторная работа №8\n"
		"1)Вывод месяца по номеру\n"
		"2)Палиндром или нет\n"
		"Выберите программу: ");
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

void InstructionEx2() {
	int n;
	printf("\n1)Повторить попытку\n"
		"2)Выход в МЕНЮ\n"
		"3)Завершить программу\n");
	do {
		scanf_s("%d", &n);
		switch (n) {
		case 1:
			system("cls");
			ExerciseTwo();
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


