#include "stdafx.h"
#include "iostream"
#include "iomanip"

using namespace std;

void allocArray(int* &p, int n) {
	p = new int[n];
}

void freeArray(int* &p) {
	if (p)
		delete[] p, p = 0;
}

void iniArray(int *ptr, int n) {
	for (int i = 0;i < n;i++) {
		ptr[i] = rand() % 100 + 1;
	}
}

void ShowArray(int *ptr, int n) {
	for (int i = 0; i < n; i++) {
		cout << setw(7) << ptr[i];
	}
}
int main()
{
	int amount;
	int *ptr = 0;
	cin >> amount;
	allocArray(ptr, amount);
	iniArray(ptr,amount);
	ShowArray(ptr, amount);
	freeArray(ptr);
	cout << endl;
	return 0;
}


