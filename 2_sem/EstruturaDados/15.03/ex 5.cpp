#include <iostream>
#include <pilha.h>
#include <stdlib.h>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	
	struct Pilha P1; // Criando a pilha
	
	IniPilha(&P1); // Iniciando uma nova pilha
	
	char palavra[15]; // Criando as variaveis
	char x;
	int t, i;
	
	cout << "Digite uma palavra:\n"; // Solicitando o dado
	//gets(palavra); lê com espaço
	cin >> palavra;
	t = strlen(palavra); // Lendo o tamanho da string
	
	for(i =0; i<t; i++){ // Empilhando
		Push(&P1, palavra[i]);
	}
	while(!pilhavazia(&P1)){ // Desimpilhando
		x = Pop(&P1);
		cout << x; // Retornando o valor reverso
	}
	
	
	return 0;
}
