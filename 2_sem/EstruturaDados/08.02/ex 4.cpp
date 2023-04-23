/* 4.ª) Faça um programa que leia 5 valores e informe o valor do maior */


#include <iostream>
#include <stdlib.h>

using namespace std; 

int main(){
	int i=0;
	float maior=0, n;
	
	for(i=0; i<5; i++){
	cout << "Insira um numero: ";
	cin >> n;
	
	if(n>maior)	{
	maior=n;
	}
}

	cout << "O maior numero informado foi: " << maior;
	return 0;
}
