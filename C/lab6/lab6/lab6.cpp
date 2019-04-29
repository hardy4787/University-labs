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
	char *str=NULL;
	int i,j;
	rewind(stdin);
	str = (char*)malloc(sizeof(char) * 80);
	printf("Исходная строка: ");
	fgets(str,80,stdin);
	printf("Выходная строка: ");
	for (i = 0;i <= strlen(str) - 2;i++) {
		if (str[i] == '.') {
			str[i + 1] = toupper(str[i + 1]);
			j = i;
			while (str[j + 1] == ' ') {
				str[j + 2] = toupper(str[j + 2]);
				j++;
			}
		}
		printf("%c", str[i]);
	}
	free(str);
	InstructionEx1();
	printf("\n");
	_getch();
}

void ExerciseTwo() {
	char *str,
		**s,
		*nun;
	int SIZE = 200,
		count,
		i=1;
	rewind(stdin);
	if (!(str = (char*)malloc(sizeof(char)*SIZE))) {
		printf("\nОшибка: Нехватка памяти\n");
	}
	if (!(s = (char**)malloc(sizeof(char)*SIZE))) {
		printf("\nОшибка: Нехватка памяти\n");
	}
	printf("Введите строку со словами:\n");
	fgets(str, 200, stdin);
	s[0] = strtok_s(str, " ,.!", &nun);
	while (s[i-1] != NULL) {
		s[i] = strtok_s(NULL, " ,.!", &nun);
		i++;
	}
	printf("Введите номер слова: ");
	if (!scanf_s("%d", &count)) {
		printf("\nОшибка. Введите цифру\n");
	}
	printf("Искоемое слова - %s", s[count - 1]);
	free(str);
	InstructionEx2();
	printf("\n");
}

void Instruction() {
	printf("\tЛабораторная работа №3\n"
		"1)Перевод символа после точки в верхний регистр\n"
		"2)Нахождение слова под заданым номером\n"
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


