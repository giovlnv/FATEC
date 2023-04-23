/* 5.ª) Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 20. */

#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	int i=0, sobra;
	
	for (i=0; i<20; i++)
	{ 
	sobra=i%2;
	if(sobra==1){
	cout << i << " ";
	};	
	}
	
	return 0;	
}
