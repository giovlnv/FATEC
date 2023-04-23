#include <iostream>
#include <pilha.h>
#include <stdlib.h>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop 


Criar um programa em C++  que apresente as operações básicas da estrutura de dados Pilha, da seguinte maneira:
Menu de opções

1. Inserir um número inteiro na Pilha
2. Remover um elemento da Pilha
3. Mostrar o elemento do topo da Pilha
4. Mostraros elementos da Pilha
5. Sair


*/
void menu(){
		
		cout << "\nSelecione uma opcao:";
		cout << "\n";
		cout << "\n[1]INSERIR UM NUMERO INTEIRO NA PILHA";
		cout << "\n[2]REMOVER UM ELEMENTO DA PILHA";
		cout << "\n[3]MOSTRAR O ELEMENTO DO TOPO DA PILHA";
		cout << "\n[4]MOSTRAR OS ELEMENTOS DA PILHA";
		cout << "\n[5]SAIR" << endl;		
		
}


int main(int argc, char** argv) {	
	
	struct Pilha P1;
	struct Pilha P2;
	
	IniPilha(&P1);		
	IniPilha(&P2);
	
	int opcao, n, tamanho=0, item;
	
	
	while(opcao != 5){		
		system("cls");
		menu();
		cin >> opcao;	
		
		switch(opcao){
		case 1:
			cout << "\nInforme um numero: ";
			cin >> n;
			Push(&P1, n);
			tamanho++;
			break;
			
		case 2:
			if(pilhavazia(&P1)){
				cout << "\nA pilha esta vazia!" << endl;								
				system("pause");
			}else{
				Pop(&P1);
				cout << "Item removido com sucesso!"<<endl;
				system("pause");
			}
			break;
		case 3:
			
			if(pilhavazia(&P1)){
				cout <<"\nPilha vazia!" << endl;
			}else{				
				cout << Top(&P1) << endl;				
			}	
			
			system("pause");	
			break;
			
		case 4:	
			P2=P1;
			
			
			if(pilhavazia(&P2)){
				cout <<"\nPilha vazia!" << endl;
				system("pause");
			}else{
				while(!pilhavazia(&P2)){
				cout << Pop(&P2) << endl;
				}	
			system("pause");				
			}			
			break;
			
		default:			
			break;
		}	
	}
	
	
		
}




