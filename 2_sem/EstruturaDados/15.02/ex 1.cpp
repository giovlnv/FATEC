//1.�) Dados dois n�meros naturais A e B, calcular o MDC entre A e B atrav�s do processo e 
//exemplo: 
//� Para A=80 e B=112:
//1. Dividir o n�mero maior pelo menor: 
//112 dividido por 80 -> quociente 1 e resto 32;
//2. N�o dando resto zero, dividir o divisor pelo resto da divis�o anterior:
//80 dividido por 32 -> quociente 2 e resto 16;
//3. Prosseguir com as divis�es at� obter resto zero.
//32 dividido por 16 ->quociente 2 e resto 0.
//Portanto, o MDC(80,112) = 16.

#include <iostream>

using namespace std;

int main () {
	
	int a, A, b, B, mdc, res, rest;
	
	cout << "\nInforme o valor de A: "; 
	cin >> a;
	A = a;
	
	cout << "\nInforme o valor de B: ";
	cin >> b;
	B = b;
	
	if (a>b){
	res=a%b;
	}
	else {
	res=b%a;
	}
	while (res!=0){
			a=b;
			b=res;
			res=a%b;
		};	
	
	cout << "\nMDC(" << A << "," << B << ") = " << b;
	
	
}
