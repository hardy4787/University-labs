#include "stdafx.h" 
#include "Windows.h" 
#include "stdio.h" 
#include "conio.h" 
#include "locale.h" 
#include "string.h" 

void Instruction();

typedef struct Word {
	int plum;
	char *strk;
}Word;

int main(int argc, char *argv[])
{
	Word *words = NULL;
	FILE *fp,
		*lpout,//выходной файл 
		*litf;
	char *str = NULL,//указатель на строку; 
		*lit,//указатель на строку с буквами; 
		*s = NULL,//указатель на разделитель; 
		*lol = NULL,
		ch,
		*pm = NULL,
		*nun;//вспомагательный указатель для функции "strtok_s"; 
	int SIZE = 200,//максимальный размер строки; 
		count = 0,//счетчик совпадений; 
		k,//счетчик цикла; 
		j,//счетчик цикла; 
		i = 0,//счетчик цикла;
		max = 0,
		n;//вспомагательная выбора;
	setlocale(LC_ALL, "RUS");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	do{
		Instruction();
		scanf_s("%d", &n);
		switch (n) {
		case 1:
			system("cls");
			ExerciseOne();
			break;
		}
	}while (n != 1);
	argv[1] = "text.in";
	printf("Название файла: %s\n", argv[1]);
	//argv[1] = "text.in";
	if (fopen_s(&fp, argv[1], "r+") != NULL) {
		printf_s("Не удалось открыть файл!");
	}
	if (fopen_s(&litf, "text-help.in", "r") != NULL) {
		printf_s("Не удалось открыть файл!");
	}
	if (fopen_s(&lpout, "text.out", "w+") != NULL) {
		printf_s("Не удалось открыть файл!");
	}
	printf_s("Выводить результат работы?\n\n"
		"1 ДА\n"
		"2 НЕТ\n");

	words = (Word*)malloc(SIZE * sizeof(Word));
	if (!(str = (char*)malloc(sizeof(char)*SIZE))) {
		printf("Ошибка: Нехватка памяти.");
		exit(1);
	}
	if (!(lit = (char*)malloc(sizeof(char) * 30))) {
		printf("Ошибка: Нехватка памяти.");
		exit(1);
	}
	if (!(s = (char*)malloc(sizeof(char)*SIZE))) {
		printf("Ошибка: Нехватка памяти.");
		exit(1);
	}
	if (!(lol = (char*)malloc(sizeof(char)*SIZE))) {
		printf("Ошибка: Нехватка памяти.");
		exit(1);
	}
	printf_s("\n\nТекст в файле:\n\n");
	fgets(str, 200, fp);
	printf("%s", str);
de:
	printf_s("\n\nВведите буквы, наличие которых вы будете проверять в словах:\n");
	if (!fgets(lit, 30, stdin) == NULL) {
		printf_s("Ошибка. Вы не ввели буквы");
		rewind(stdin);
		goto de;
	}
	s = strtok_s(str, " ,.!", &nun);

	while (s != NULL) {
		count = 0;
		for (k = 0; k < strlen(lit); k++) {
			for (j = 0; j < strlen(s); j++) {
				if (toupper(lit[k]) == toupper(s[j])) {
					count++;
				}
			}
		}
		fprintf(lpout, "\n[%d]%s\n", count, s);
		printf_s("\n[%d]%s\n", count, s);
		words[i].plum = count;
		words[i].strk = s;
		if (words[i].plum > max) {
			max = words[i].plum;
			lol = words[i].strk;
		}
		i++;
		s = strtok_s(NULL, " ,.!", &nun);
	}
	printf_s("\nМаксимальное количество совпадений в слове : %s - [%d]\n\n", lol, max);
	free(str);
	free(s);
	free(lit);
	free(words);
	fclose(fp);
	fclose(lpout);
	return 0;
}

void Instruction() {
	printf("\tЛабораторная работа №9\n"
		"Найти в тексте слово содержащее найбольшее количество указаных букв\n"
		"Текст и буквы находяться в файлах\n"
		"1)Перейти к программе: ");
}