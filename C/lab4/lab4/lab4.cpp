#include "stdafx.h"
#include "conio.h"
#include "locale.h"

void ExerciseOne();
void ExerciseTwo();
void Instruction();
void InstructionEx1();
void InstructionEx2();

int main() {
	int n;
	setlocale(LC_ALL, "RUS");
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
	int num, ft=1, i;
	printf("Введите число: ");
	if (scanf_s("%d", &num)) {
		if (num >= 1){
			for (i = 2;i <= num;i++) {
				ft = ft*i;
			}
			printf("Факториал [%d] равен: %d", num, ft);
		}
		else if (num == 0) {
			printf("Факториал [%d] равен: 1", num);
		}
		else {
			printf("Ошибка: Факториала отрицательного числа не существует.");
		}
	}
	else {
		printf("Ошибка: Требуется ввести число.");
	}
	InstructionEx1();
	printf("\n");
	_getch();
}

void ExerciseTwo() {
	int numb, i = 1, min;
	printf("Введите %d-ое: ", i);
	if (scanf_s("%d", &numb)) {
		min = numb;
		i++;
	}
	else {
		printf("Ошибка: Введите число.\n\n");
		rewind(stdin);
		ExerciseTwo();
	}
	do{
		printf("Введите %d-ое: ",i);
		if (scanf_s("%d", &numb)) {
			if (numb < min) {
				min = numb;
			}
			i++;
		}
		else {
			printf("Ошибка: Введите число.\n\n");
			rewind(stdin);
			ExerciseTwo();
		}
	}while (i <= 5);
	printf("\nМинимальное: %d", min);
	InstructionEx2();
	printf("\n");
}

void Instruction() {
	printf("\tЛабораторная работа №4\n"
		"1)Вычислить факториал числа\n"
		"2)Определение минимального числа из 5-ти\n"
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


