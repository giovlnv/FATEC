/*
4.a.)Elaborar um programa recursivo que dado um número natural K, 
calcular a potência X elevado a K através de produtos sucessivos.
Obs.:
xk=  x *x k-1
Se k > 1xk   =  x
Se k=1xk   =  1
Se k=0
Independente do valor de k, para X=0 ou 1 o resultado é imediato, isto é, 0 e 1.
*/

#include <iostream>
#include <stdlib.h>

using namespace std;

int Potencia(int x, int k){
	if(k==0){
		return 1;
	}else{
		return x*Potencia(x, k-1);
	}
}

int main(){
	try{
	
	int base, exp;
	
	cout << "Insira a Base: ";
	cin >> base;
	
	cout << "Insira a Expoente: ";
	cin >> exp;
	
	if(exp<0){
			throw (exp);
		}else{
			cout << base << " elevado a " << exp << " eh: " << Potencia(base,exp);
		}
			
	}catch(int exp){
		cout << "Informe somente expoentes Positivos";
	}
	
}

