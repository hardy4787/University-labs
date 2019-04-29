#include "stdafx.h"
#include "iostream" 

using namespace std;

int sum(int, int);
int adress(int &, int &);
int prt(int *ap, int *bp);
int funk4(int *pa1, int *pb1);
int funk5(int* &pa2, int* &pb2);

int main() {
	for (int i = 0;i < 3;) {
		i++;
		cout << i;
	}
	
	/*int a = 7;
	int b = 9;
	int *pa = &a;
	int *pb = &b;
	funk4(pa, pb);
	funk5(pa, pb);
	sum(a, b);
	adress(a, b);
	prt(&a, &b);*/
	system("pause");
	return 0;
}

// Передача по значению ( int az = a; int bz = b; )
int sum(int az, int bz) {
	cout << az + bz << endl;
	return 0;
}

// Передача по ссылке ( int &ad = adress a; int &bd = adress b; )
int adress(int &ad, int &bd) {
	cout << ad + bd << endl;
	return 0;
}

// Передача по указателю ( int *ap=adress a; int *bp=adress b; )
int prt(int *ap, int *bp) {
	cout << *ap + *bp << endl;
	return 0;
}

// Передача указателя по значению
int funk4(int *pa1, int *pb1) {
	cout << *pa1 + *pb1 << endl;
	return 0;
}
// Передача указателя по ссылке
int funk5(int* &pa2, int* &pb2) {
	cout << *pa2 + *pb2 << endl;
	return 0;
}
