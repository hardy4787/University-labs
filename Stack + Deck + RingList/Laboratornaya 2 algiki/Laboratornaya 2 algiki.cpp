#include "stdafx.h"
#include "stdlib.h"
#include "locale.h"
#include "stdio.h"
#include "conio.h"
#include "Windows.h"
//#include "time.h"

#define STACK_OVERFLOW  -100
#define STACK_UNDERFLOW -101
#define OUT_OF_MEMORY   -102
#define _clear clear()

typedef struct Node_tag {
	int value;
	struct Node_tag *next;
} Node_t;

struct node {
	struct node *prev;
	int n;
	struct node *next;
}*h, *temp, *temp1, *temp2;
int count = 0;

void push(Node_t **head, int value);
Node_t* pop1(Node_t **head);
int peek(const Node_t* head);
size_t getSize(const Node_t *head);
size_t getSizeDek(const struct node *h);
void InstructionsStek(void);
void InstructionDek(void);
void InstructionRingList(void);
void PrimeInstruction(void);
void StekMenu();
void DekMenu();
void RingListMenu();
void insert1();
void insert2();
void traversebeg();
void traverseend(int);
void create();
void delete();
void ShowDek();
void GenCreate(int data);
void DekGeneration(int count);

void clear() {
	system("cls");
}

int main() {
	int i;
	setlocale(LC_ALL, "RUS");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	//srand(time(NULL));
	PrimeInstruction();
	printf("\nВыберите действие: ");
	scanf_s("%d", &i);
	switch (i) {
	case 1:
		_clear;
		StekMenu();
		break;
	case 2:
		_clear;
		DekMenu();
		break;
	case 3:
		_clear;
		RingListMenu();
		break;
	default:
		_clear;
		main();
	}
	return 0;
}

/*************StackZone************/

void push(Node_t **head, int value) {
	Node_t *tmp = malloc(sizeof(Node_t));
	if (tmp == NULL) {
		exit(STACK_OVERFLOW);
	}
	tmp->next = *head;
	tmp->value = value;
	*head = tmp;
}

Node_t* pop1(Node_t **head) {
	Node_t *out;
	if ((*head) == NULL) {
		printf("\nСтек пуст.");
		_getch();
		_clear;
		main();
	}
	out = *head;
	*head = (*head)->next;
	return out;
}

int peek(const Node_t* head) {
	if (head == NULL) {
		printf("\nСтек пуст.");
		_getch();
		_clear;
		main();
	}
	return head->value;
}

size_t getSize(const Node_t *head) {
	size_t size = 0;
	while (head) {
		size++;
		head = head->next;
	}
	return size;
}

/*************DeckZone************/

void create() {
	int data;
	temp = (struct node *)malloc(1 * sizeof(struct node));
	temp->prev = NULL;
	temp->next = NULL;
	printf("\nВведите значение элемента : ");
	scanf_s("%d", &data);
	temp->n = data;
	count++;
}

/*void GenCreate(int data) {
	temp = (struct node *)malloc(1 * sizeof(struct node));
	temp->prev = NULL;
	temp->next = NULL;
	temp->n = data;
	count++;
}

void DekGeneration(int count) {
	int i; Счётчик цикла
	for (i = 0; i < count; i++) {
		GenCreate(rand() % count + 1);
	}
}
*/
void insert1() {
	if (h == NULL) {
		create();
		h = temp;
		temp1 = h;
	}
	else {
		create();
		temp->next = h;
		h->prev = temp;
		h = temp;
	}
	ShowDek();
}

/* To insert at end */
void insert2() {

	if (h == NULL) {
		create();
		h = temp;
		temp1 = h;
	}
	else {
		create();
		temp1->next = temp;
		temp->prev = temp1;
		temp1 = temp;
	}
	ShowDek();
}
/* Traverse from beginning */
void traversebeg()
{
	temp2 = h;

	if (temp2 == NULL) {
		printf("Элемент не был введен. \n");
		return;
	}
	printf("\nПервый элемент : ");
	printf(" %d ", temp2->n);

	printf("\n");
}

/* To traverse from end recursively */
void traverseend(int i) {

	if (temp2 != NULL) {
		i = temp2->n;
		temp2 = temp2->next;
		traverseend(i);
	}
	else {
		printf(" %d", i);
	}
}

size_t getSizeDek(const struct node *h) {
	size_t size = 0;
	while (h) {
		size++;
		h = h->next;
	}
	printf("Размер дека = %d", size);
	return 0;
}

void delete() {
	int i = 1, pos;
	printf("\n1 С верху\n"
		"2 С низу\n");
	printf("\nВыберите позицию: : ");
	scanf_s("%d", &pos);
	temp2 = h;
	if (pos != 1 && pos != 2) {
		printf("Ошибка: Существует лишь два варианта выбора.\n");
		return;
	}
	if (pos == 2) {
		pos = count;
	}
	if (h == NULL) {
		printf("\nОшибка : Дек пуст.\n");
		return;
	} else {
		while (i < pos) {
			temp2 = temp2->next;
			i++;
		}
		if (temp2->next == NULL) {
			temp2->prev->next = NULL;
			free(temp2);
			printf("\nВерхний элемент удален");
			count--;
			printf("\n");
			ShowDek();
			return;
		}
		temp2->next->prev = temp2->prev;
		if (i != 1)
			temp2->prev->next = temp2->next;
		if (i == 1)
			h = temp2->next;
		printf("\nНижний элемент удален");
		printf("\n");
		free(temp2);
	}
	count--;
	ShowDek();
}

void ShowDek()
{
	temp2 = h;
	printf("\nДек : ");
	while (temp2->next != NULL) {
		printf(" %d ", temp2->n);
		temp2 = temp2->next;
	}
	printf(" %d ", temp2->n);

	printf("\n");
	_getch();
}

/*************MenuZone************/

void PrimeInstruction(void) {
	printf("\tГЛАВНОЕ МЕНЮ\n\n"
		"1 Стек\n"
		"2 Дек\n"
		"3 Кольцевой список\n");
}

void InstructionsStek(void) {
	printf("\tСТЕК:\n\n"
		//"0 Сгенирировать случайный стек\n"
		"1 Добавить элемент\n"
		"2 Удалить элемент\n"
		"3 Чтение первого элемента\n"
		"4 Получить размер стека\n"
		"5 Выход в ГЛАВНОЕ МЕНЮ\n"
		"6 Завершить программу\n");
}
void InstructionDek(void) {
	printf("\tДЕК:\n\n"
		//"9 Сгенирировать случайный дек\n"
		"1 Положить на верх\n"
		"2 Положить на низ\n"
		"3 Удаление элемента с выбраной позиции\n"
		"4 Чтение верхнего элемента\n"
		"5 Чтение нижнего элемента\n"
		"6 Получение размера деки\n"
		"7 Выход в ГЛАВНОЕ МЕНЮ\n");
}
void InstructionRingList(void) {
	printf("\tКольцевой список:\n\n"
		//"0 Сгенирировать случайный список\n"
		"1 Найти элемент с заданным свойством\n"
		"2 Определить первый элемент в линейном списке\n"
		"3 Вставить дополнительный элемент до или после указанного узла\n"
		"4 Включить определенный элемент из списка\n"
		"5 Проверку списка на пустоту\n"
		"6 Получение размера с\n");
}

void StekMenu() {
	setlocale(LC_ALL, "RUS");
	int i, choice;
	Node_t *head = NULL;
	Node_t *tmp;
	InstructionsStek();
	printf("\nВыберите действие: ");
	scanf_s("%d", &choice);
	while (TRUE) {
		switch (choice) {
		case 1://заталкивает значение в стек;
			_clear;
			printf("Введите значение элемента: ");
			scanf_s("%d", &i);
			push(&head, i);
			printf("Для возврата в меню нажмите Enter");
			break;
		case 2://выталкивает значение из стека;
			tmp = pop1(&head);
			printf("Удален элемент: %d ", tmp->value);
			free(tmp);
			break;
		case 3://чтение первого елемента;
			printf("Верхний элемент стека: %d ", peek(head));
			break;
		case 4://получение размера стека;
			printf("Размер стека = %d\n", getSize(head));
			break;
		case 5:
			_clear;
			main();
		case 6:
			exit(0);
		}
		_getch();
		_clear;
		InstructionsStek();
		printf("\nВыберите действие: ");
		scanf_s("%d", &choice);
	}
	printf("End of run.\n");
}

void DekMenu() {
	int choice, ct;
	h = NULL;
	temp = temp1 = NULL;
	InstructionDek();
	printf("\nВыберите действие: ");
	scanf_s("%d", &choice);
	while (choice) {
		switch (choice) {
		/*case 9:
			printf_s("Введите количество элементов");
			scanf_s("%d", &ct);
			DekGeneration(ct);
			ShowDek();
			break;*/
		case 1:
			insert1();
			break;
		case 2:
			insert2();
			break;
		case 3:
			delete();
			_getch();
			break;
		case 4:
			traversebeg();
			_getch();
			break;
		case 5:
			temp2 = h;
			if (temp2 == NULL)
				printf("\nОшибка: Список пуст ");
			else {
				printf("\nПоследний элемент : ");
				traverseend(temp2->n);
				printf("\n");
			}
			_getch();
			break;
		case 6:
			getSizeDek(h);
			_getch();
			break;
		case 7:
			_clear;
			main();
		case 8:
			ShowDek();
		default:
			system("cls");
			InstructionDek();
			break;
		}
		_clear;
		InstructionDek();
		printf("\nВыберите действие: ");
		scanf_s("%d", &choice);
	}
}

void RingListMenu() {
	setlocale(LC_ALL, "RUS");
	int i, choice;
	Node_t *head = NULL;
	Node_t *tmp;
	InstructionRingList();
	printf("\nВыберите действие: ");
	scanf_s("%d", &choice);
	while (choice != 5) {
		switch (choice) {
		case 1://заталкивает значение в стек;
			_clear;
			printf("Введите значение элемента, который вы хотите добавить: ");
			scanf_s("%d", &i);
			push(&head, i);
			printf("Для возврата в меню нажмите Enter");
			break;
		case 2://выталкивает значение из стека;
			tmp = pop1(&head);
			printf("Удален элемент: %d ", tmp->value);
			free(tmp);
			break;
		case 3://чтение первого елемента;
			printf("Верхний элемент стека: %d ", peek(head));
			break;
		case 4://получение размера стека;
			printf("Размер стека = %d\n", getSize(head));
			break;
		default:
			system("cls");
			InstructionsStek();
			break;
		}
		_getch();
		_clear;
		InstructionsStek();
		printf("\nВыберите действие: ");
		scanf_s("%d", &choice);
	}
	printf("End of run.\n");
}
