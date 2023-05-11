#include <iostream>
#include <stdlib.h>

using namespace std;

int Binario(int d){
	if(d<2){
		return d;
	}else{
		return 10*Binario(d/2) + d%2;
	}
}

int main(){
	try{
		int decimal;
		
		cout << "Qual numero sera convertido para Binario? \n";
		cin >> decimal;
				
		system("cls");
		
	if(decimal<0){
			throw (decimal);
		}else{
			cout << "O numero decimal " << decimal << " em binario e: " << Binario(decimal);
		}
			
	}catch(int decimal){
		cout << "Informe somente números Positivos";
	}
	
}

