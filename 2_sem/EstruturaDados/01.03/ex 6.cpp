#include <cstdlib>
#include <iostream>

using namespace std;


void mes (int a){
	switch(a)
	{
		case 1:
			cout << "Janeiro";
			break;
			
		case 2:
			cout << "Fevereiro";
			break;
			
		case 3:
			cout << "Marco";
			break;
			
		default:
			cout << "Valor invalido. Fora do intervalo.";
			break;
	}
}

int main (){
	int a;
	
	cout << "Informe o mes: ";
	cin >> a;
	
	mes(a);
	
	return 0;
}
