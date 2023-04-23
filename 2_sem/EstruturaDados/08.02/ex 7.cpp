/* 7.ª) Faça um programa que apresente a série de Fibonacci até o décimo quinto termo.
A série é formada pela seqüência: 1,1,2,3,5,8,13,21,34,....,etc. */

#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	int atual=1, anterior=0, temp, i=0; 
	
	cout << atual << endl;

	for (i=0; i<14; i++)
	{
	cout << (anterior+atual) << endl;
	temp=anterior;
	anterior=atual;
	atual=atual+temp;
	}
	
	return 0;
}
