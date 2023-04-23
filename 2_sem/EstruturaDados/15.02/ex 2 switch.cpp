//3.ª) Efetuar o cálculo da quantidade de litros de combustível gastos em uma viagem, 
//utilizando-se um automóvel que faz “x” km/l. Para obter o cálculo, o usuário deverá 
//fornecer o tempo gasto na viagem e a velocidade média durante a mesma. Desta forma será 
//possível obter a distância percorrida com a fórmula: DISTÂNCIA= TEMPO * 
//VELOCIDADE (utilizar uma função). Tendo o valor da distância, basta calcular a 
//quantidade de litros de combustível utilizada na viagem com a fórmula: 
//LITROS_USADOS=DISTÂNCIA / “x” (através de função). O programa deverá apresentar 
//os valores da velocidade média, tempo gasto na viagem, a distância percorrida e a 
//quantidade de litros utilizada na viagem

#include <iostream>
using namespace std;

int main (){
	
	int x, X, res=0;
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
switch (x)
	{
	case 0:
		cout << "O resultado de 0 elevado a potencia de " << k << " = 0";
		break;
	case 1:
		cout << "O resultado de 1 elevado a potencia de " << k << " = 1";
		break;
 
	default:
	res = x;
	for (i=1; i<k; i++)
	res=res*x;
	
	
	
	cout << "O resultado de " << X << " elevado a potencia de " << k << " = " << res;
	
	break;
}}
