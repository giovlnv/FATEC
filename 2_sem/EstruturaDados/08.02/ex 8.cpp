/* 8.) . Faça um programa que leia 15 valores e informe o valor da diferença entre a média e o maior valor. */


#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	int i=0;
	float media, soma=0, num, maior=0;
	
	for (i=0; i<15; i++)
	{
		cout << "\nInsira o valor numero " << i+1 << ": ";
		cin >> num;
		
	soma+=num;
	if(num>maior){
	maior=num;
	}
}
	media=soma/15;
		
	cout << "A diferenca da media para o maior valor e de: " << maior-media << endl;
	return 0;
	}
	
