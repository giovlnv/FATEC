/* 7.�) Fa�a um programa que apresente a s�rie de Fibonacci at� o d�cimo quinto termo.
A s�rie � formada pela seq��ncia: 1,1,2,3,5,8,13,21,34,....,etc. */

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
