//2.�) Dado um n�mero real X e um n�mero natural K, calcular a pot�ncia X elevado a K 
//atrav�s de produtos sucessivos.
//x
//k = x.x.x.x. ...... x
//Obs: independente do valor de k, para x=0 ou 1 o resultado � imediato, isto �, 0 e 1.

#include <iostream>
using namespace std;

int main (){
	
	float x, X, res=0;
	int k, i=0;
	
	cout << "Informe a base: ";
	cin >> x;
	X=x;
	
	cout << "Informe a potencia: ";
	cin >> k;
	
	if (k==0){
		cout << "O resultado de " << x << " elevado a potencia de 0 = 1";
		return 0;
	}
else if (x==0){
		cout << "O resultado de 0 elevado a potencia de " << k << " = 0";
		return 0;
	}
else if (x==1){
		cout << "O resultado de 1 elevado a potencia de " << k << " = 1";
		return 0;
	} 
else {
	res = x;
	for (i=1; i<k; i++)
	res=res*x;
	}
	
	
	cout << "O resultado de " << X << " elevado a potencia de " << k << " = " << res;
	
	return 0;
}
