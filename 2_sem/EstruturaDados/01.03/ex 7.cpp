#include <iostream>
#include <cstdlib>

using namespace std;

int fatorial (int fator){
	int aux, prod=1;
	
	for(aux = 1; aux <= fator; aux++){
		prod *=aux;
	}
	
	return prod;
}

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	float fator;
	
	cout << "Informe o valor a ser fatorado: \n";
	
	cin >> fator;
	
	cout << "O valor fatorado e igual a "<<fatorial(fator)<<".";
	
	return 0;
}
