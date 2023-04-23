/* 6.ª) Faça um programa que apresente o total da soma obtido dos cem primeiros números inteiros. (1+2+3+4+......+100) */

#include <iostream>
#include <stdlib.h>

using namespace std; 

int main(){
	int soma=0, cont=0;
	
	while (cont<100){
		cont++;
		soma+=cont;
	}
	
	cout << soma << endl;
	
	return 0;
}
