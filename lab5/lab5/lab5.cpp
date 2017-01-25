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
	int *num, size, i, j, ct=0;
	printf("Введите размер массива: ");
	if (!scanf_s("%d", &size)) {
		printf("\nОшибка: Введите число.\n");
		rewind(stdin);
		ExerciseOne();
	}
	if (size > 0) {
		if (!(num = (int*)malloc(sizeof(int)*size))) {
			printf("\nОшибка: Нехватка памяти.\n");
		}
		for (j = 0;j <= size - 1;j++) {
			printf("Введите [%d]-ое число: ", j + 1);
			scanf_s("%d", &num[j]);
		}
		for (j = 0;j <= size - 1;j++) {
			for (i = j + 1;i <= size - 1;i++) {
				if ((num[j] == num[i])) {
					printf("В массиве присутствуют элементы с одинаковым значением.");
					InstructionEx1();
				}
			}
		}
		printf("В данном массиве нет элементов с одинаковыми значениями.");
	}
	else {
		printf("Ошибка: Введены недопустимые границы.");
	}
	InstructionEx1();
	printf("\n");
	_getch();
}

void ExerciseTwo() {
	int **mtx,*ser, n, i,j;
	printf("Введите размер квадратной матрицы: ");
	if (!scanf_s("%d", &n)) {
		printf("\nОшибка: Введите число.\n");
		rewind(stdin);
		ExerciseTwo();
	}
	printf("\n");
	if (!(mtx = (int**)malloc(sizeof(int*)*n))) {
		printf("\nОшибка: Нехватка памяти.\n");
	}
	if (!(ser = (int*)malloc(sizeof(int)*n))) {
		printf("\nОшибка: Нехватка памяти.\n");
	}
	for (i = 0;i <= (n - 1);i++) {
		if (!(mtx[i] = (int*)malloc(sizeof(int)*n))) {
			printf("\nОшибка: Нехватка памяти.\n");
		}
		for (j = 0;j <= (n - 1);j++) {
			printf("mtx[%d][%d] = ", i, j);
			scanf_s("%d", &mtx[i][j]);
		}
	}
	printf("\n\n");
	for (i = 0;i <= (n - 1);i++) {
		for (j = 0;j <= (n - 1);j++) {
			printf("%3d", mtx[i][j]);
		//	if(ser)
		//	ser[i]=ser[i]+mtx[i][j]
		}
		printf("\n");
	}
	for (i = 0;i <= (n-1);i++) {
		ser[i] = 0;
		for (j = 0;j <= (n - 1);j++) {
			ser[i] = ser[i] + mtx[j][i];
		}
		printf("\nСреднее арифметическое %d-го столбца = %d", i+1, ser[i]/n);
	}
	InstructionEx2();
	printf("\n");
}

void Instruction() {
	printf("\tЛабораторная работа №3\n"
		"1)Проверка наличия одинаковых елементов в массиве.\n"
		"2)Нахождение среднего арифметического по столбцам матрицы\n"
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


