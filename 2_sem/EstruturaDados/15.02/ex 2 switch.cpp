//3.�) Efetuar o c�lculo da quantidade de litros de combust�vel gastos em uma viagem, 
//utilizando-se um autom�vel que faz �x� km/l. Para obter o c�lculo, o usu�rio dever� 
//fornecer o tempo gasto na viagem e a velocidade m�dia durante a mesma. Desta forma ser� 
//poss�vel obter a dist�ncia percorrida com a f�rmula: DIST�NCIA= TEMPO * 
//VELOCIDADE (utilizar uma fun��o). Tendo o valor da dist�ncia, basta calcular a 
//quantidade de litros de combust�vel utilizada na viagem com a f�rmula: 
//LITROS_USADOS=DIST�NCIA / �x� (atrav�s de fun��o). O programa dever� apresentar 
//os valores da velocidade m�dia, tempo gasto na viagem, a dist�ncia percorrida e a 
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
