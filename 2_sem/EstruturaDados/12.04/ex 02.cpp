#include <iostream>
#include <stdlib.h>
#include <pilha.h>
#include "Fila.h"

using namespace std;


/* 

Considerar o programa de exemplo sobre Filas (menu.cpp) e adicionar:
a) uma opção no menu que permita inverter o conteúdo da fila.
b) uma opção que retorne o número de elementos existentes na fila circular.
c) O primeiro elemento da fila
d) O último elemento da fila

 */


int menu()
{	
	system("cls");
	
	cout << "FILA CIRCULAR \n\n";
	cout << "[1] INSERIR UM ELEMENTO NA FILA\n";
	cout << "[2] REMOVER UM ELEMENTO DA FILA\n";
	cout << "[3] IMPRIMIR A FILA\n";
	cout << "[4] INVERTER A FILA\n";
	cout << "[5] TAMANHO DA FILA\n";
	cout << "[6] PRIMEIRO ELEMENTO DA FILA\n";
	cout << "[7] ULTIMO ELEMENTO DA FILA\n";
	cout << "[8] SAIR\n";	
	return(0);
}

int main(int argc, char** argv) {
	
	int elem, op, x, i, y, cont = 0;
	
	struct Pilha P;
	IniPilha (&P);
	
	struct queue F;
	struct queue G;
	
	inicFila(&F);
	inicFila(&G);
	
	op = 0;
	
	while(op != 8){
		op = 0;
		menu();
		cin >> op;
		
		while(op < 1 || op > 8){
			menu();
			cin >> op;
		}		
		
		switch(op){
			case 1:
				if (filaCheia(&F) == 1){
					
					cout << "A FILA ESTA CHEIA";
					
				}else{
					
					cout << "INSIRA UM VALOR:\n";
					cin >> elem;
					
					insFila(&F, elem);
					cont++;
					
					cout << "ELEMENTO INSERIDO COM SUCESSO!\n";					
					system("pause");
					
					break;
				}
			case 2:
				
				if (filaVazia(&F) == 1){					
					
					cout << "A FILA ESTA VAZIA\n";
					system("pause");
					break;					
					
				}else{
					
					x = remFila(&F);
					
					cout << "VALOR REMOVIDO COM SUCESSO!\n";
					system("pause");
					cont--;
					
					break;
				}
			case 3:
				
				if (filaVazia(&F) == 1){
								
					cout << "A FILA ESTA VAZIA\n";
					system("pause");					
					
				}else{
										
					y = guardainicio(&F);
					
					G = F;
					
					cout << "[ ";
					
					while(!filaVazia(&G)){
						cout << remFila(&G)<<" ";
					}
					
					cout << "]\n";					
					
					system("pause");
										
					break;
				}
			case 4:
				
				if(filaVazia(&F) == 1){
										
					cout << "A FILA ESTA VAZIA\n";
					system("pause");					
					
				}else{				
					
					
					G = F;
					
					while(!filaVazia(&G)){
						Push(&P, remFila(&G));
					}					
					cout << "[ ";
					while(!pilhavazia(&P)){
						cout << Pop(&P) << " ";
					}			
					cout << "]\n";					
						
					system("pause");										
					break;
				}
			
			case 5:
								
				cout << "TAMANHO DA FILA = " << cont <<"\n";
				system("pause");
				break;
				
			case 6:
				
				if(filaVazia(&F) == 1){					
					
					cout << "A FILA ESTA VAZIA\n";
					system("pause");					
					
				}else{
					
					G = F;
				
					cout << "PRIMEIRO ELEMENTO DA FILA = [" << remFila(&G) << "].\n";
					system("pause");
					
					break;					
				}
				
			case 7:
				
					if(filaVazia(&F) == 1){					
					
					cout << "A FILA ESTA VAZIA\n";
					system("pause");					
					
					}else{
						
						G = F;
						
						while(!filaVazia(&G)){
							Push(&P, remFila(&G));
						}
						
						cout << "ULTIMO ELEMENTO DA VILA  = [" << Top(&P)<< "].\n";
						system("pause");
						break;
					}
			case 8:
				system("exit");
		}
	}
	
}
