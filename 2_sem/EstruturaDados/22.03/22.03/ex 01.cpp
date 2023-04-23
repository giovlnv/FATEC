#include <iostream>
#include <pilha.h>
#include <stdlib.h>

using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop 

Armazenar “n” números inteiros em uma pilha, até que “999” seja digitado.Retornar o número de elementos da pilha que possuem valor 
ímpar e o número de elementos da pilha que possuem valor par.

*/

int main(int argc, char** argv) {
	
	struct Pilha P1;
	
	IniPilha(&P1);
	
	int numero, x, impar=0, par=0;
	
	
	while(numero != 999){
		cout << "\nInforme um numero:";
		cin >> numero;	
			
		if(numero == 999){
			break;			
		}else{						
			Push(&P1, numero);
		}		
		
	}
	
	while(!pilhavazia(&P1)){
		x = Pop(&P1);		
		if(x %2 == 0){
			par++;
		}else{
			impar++;
		}
	}
	
	cout << "\nPAR " << par;	
	cout << "\nIMPAR "<< impar;
	
	
}
