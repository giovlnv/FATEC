#include <iostream>
#include <stdlib.h>

using namespace std;

int fibo(int x){	
	if(x == 1){
		return 1;
	}else if(x == 2){
		return 1;
	}else{
		return fibo(x-1)+fibo(x-2);
	}		
}

int main(){
		
	try{
		
		int imp;
		
		cout << "Qual o indice da sequencia Fibonacci que deseja saber? \n";
		cin >> imp;
		
		system("cls");
		
		if(imp<1){
			throw (imp);
		}else{
			cout << "O indice " << imp << " e: " << fibo(imp);
		}
			
	}catch(int imp){
		cout << "Informe somente números maiores que 0!";
	}
}

