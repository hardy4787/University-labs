#include "stdafx.h"
#include "conio.h"
#include "locale.h"

void ExerciseOne();
void ExerciseTwo();
void Instruction();
void InstructionEx1();
void InstructionEx2();

int main(){
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
	int num;
	printf("Введите число диапазон которого выхотите узнать: ");
	if (scanf_s("%d", &num)) {
		if (num >= -3 && 0 >= num) {
			printf("Число [%d] входит в диапазон от -3 до 0", num);
		}
		else if (num >= 3 && 6 >= num) {
			printf("Число [%d] входит в диапазон от 3 до 6", num);
		}
		else {
			printf("Число [%d] не входит ни в один из диапазонов, а именно\n\tот -3 до 0\n\tи\n\tот 3 до 6", num);
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
	int mon;
	printf("Введите номер месяца: ");
	scanf_s("%d", &mon);
	switch (mon) {
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
		printf("Данного месяца не существует.\nПовторите попытку пожалуйста.");
		_getch();
		InstructionEx2();
		break;
	}
	if (mon == 1 || mon == 2 || mon == 12) {
		printf(" - Зима");
	}
	else if(mon == 3 || mon == 4 || mon == 5) {
		printf(" - Весна");
	}
	else if (mon == 6 || mon == 7 || mon == 8) {
		printf(" - Лето");
	}
	else{
		printf(" - Осень");
	}
	InstructionEx2();
	printf("\n");
}

void Instruction(){
	printf("\tЛабораторная работа №3\n"
		"1)Проверка попадания числа в диапазон\n"
		"2)Определение времени года по числу месяца\n"
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


