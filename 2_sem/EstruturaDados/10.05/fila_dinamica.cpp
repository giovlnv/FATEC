#include <iostream>

using namespace std;

class Fila {
	int info;
	Fila* next;
	Fila* end;

public:
	Fila();
	void enfileirar(int n);
	int desenfileirar();
	void imprime();
};

Fila* inicio, * fim;

Fila::Fila() {
	info = 0;
	next = NULL;
	end = NULL;
}
void Fila::enfileirar(int n) {
	this->info = n;
	if (inicio == NULL) {
		inicio = this;
		fim = this;
	}
	else {
		fim->next = this;
		fim = this;
	}
}
int Fila::desenfileirar() {
	int temp;
	if (inicio == NULL) {
		cout << endl <<"\t|==========|" << endl;
		cout << "\t|Fila vazia|" << endl;
		cout << "\t|==========|" << endl;
		return 0;
	}
	temp = inicio -> info;

	if (inicio == fim) {
		inicio = NULL;
		fim = NULL;
	}
	else {
		inicio = inicio->next;
	}

	delete this;
	return temp;
}

void Fila::imprime() {
	if (inicio == NULL) {
		cout << endl << "\t|==========|"<< endl;
		cout << "\t|Fila Vazia|" << endl;
		cout << "\t|==========|" << endl;
	}
	else {
		Fila* temp = inicio;
		while (temp != NULL) {
			cout << "\t" << temp->info << endl;
			temp = temp->next;
		}
	}
}

int main(){
	Fila* ff;
	int escolha, valor;

	inicio = NULL;
	fim = NULL;

	do {
		system("CLS");
		cout << endl << "\t|====================================|" << endl;
		cout << "\t|\tMenu Principal\t\t     |" << endl;
		cout << "\t|[1] Inserir elemento na fila\t     |" << endl;
		cout << "\t|[2] Remover elemento da fila\t     |" << endl;
		cout << "\t|[3] Imprimir fila\t\t     |" << endl;
		cout << "\t|[4] Sair\t\t\t     |" << endl;
		cout << "\t|====================================|" << endl;
		cout << "\tEscolha: ";
		cin >> escolha;
		
		switch (escolha) {
		case 1:
			system("CLS");
			ff = new Fila();
			cout << "\tEntre com um valor: ";
			cin >> valor;
			ff->enfileirar(valor);
			break;
		case 2:
			system("CLS");
			valor = inicio->desenfileirar();
			cout << "\tValor removido: " << valor << endl;
			system("PAUSE");
			break;
		case 3:
			system("CLS");
			inicio->imprime();
			system("PAUSE");
			break;
		case 4:
			exit(1);
			break;
		default:
			system("CLS");
			cout << "\t|=================================|" << endl;
			cout << "\t|Opcao invalida, leia as intrucoes|" << endl;
			cout << "\t|=================================|" << endl;
			system("PAUSE");
		}
	} while (escolha != 4);
	return 0;
}