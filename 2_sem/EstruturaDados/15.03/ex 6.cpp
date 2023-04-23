#include <iostream>
#include <pilha.h>
#include <stdlib.h>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	
	struct Pilha P1;
	struct Pilha P2;
	
	
	IniPilha(&P1);	
	
	bool palindromo;
	
	char entrada[50];
	char x;
	
	int t, i;
	
	
	cout << "Escreva uma palavra e descobriremos se ela e palindroma:\n";
	gets(entrada);
	
	t = strlen(entrada);
	
	for(i=0; i<t; i++) {
		Push(&P1, entrada[i]);		
	}
	for(i=0; i<t; i++) {
		Push(&P1, entrada[i]);		
	}
	
	while(!pilhavazia(&P1)){
		for(i=0; i<t; i++){
			
			x = Pop(&P1);
			
			if(entrada[i] == x){	
				palindromo = true;
			}else{
				palindromo = false;
			}
	
		}
	}
	
	
	if(palindromo){		
		cout << "Palindromo";	
	}else{
		cout << "Nao Palindromo";	
	}	
	
}
