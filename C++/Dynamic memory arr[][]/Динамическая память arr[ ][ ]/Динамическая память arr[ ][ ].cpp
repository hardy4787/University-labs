#include "stdafx.h"
#include "iostream"
#include "iomanip"

using namespace std;

void allocArray(int** &p, int row, int col) {
	p = new int*[row];
	for (int i = 0;i < row;i++)
		p[i] = new int[col];
}

void freeArray(int** &p, int row) {
	for (int i = 0;i < row;i++)
		delete[] p[i];
	delete[] p;
}

void iniArray(int **ptr, int row,int col) {
	for (int i = 0;i < row;i++) {
		for (int j = 0;j < col;j++) {
			ptr[i][j] = rand() % 100 + 1;
		}
	}
}

void ShowArray(int **ptr, int row, int col) {
	for (int i = 0;i < row;i++) {
		for (int j = 0;j < col;j++) {
			cout << ptr[i][j] << "\t";
		}
		cout << endl;
	}
}

int main(){
	int mrow, mcol;
	int **ptr = 0;
	cin >> mrow;
	cin >> mcol;
	allocArray(ptr, mrow, mcol);
	iniArray(ptr, mrow, mcol);
	ShowArray(ptr, mrow, mcol);
	freeArray(ptr, mrow);
	return 0;
}


