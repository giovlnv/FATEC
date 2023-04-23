//2.ª) Dado um número real X e um número natural K, calcular a potência X elevado a K 
//através de produtos sucessivos.
//x
//k = x.x.x.x. ...... x
//Obs: independente do valor de k, para x=0 ou 1 o resultado é imediato, isto é, 0 e 1.

#include <iostream>
using namespace std;

int main (){
	float x, lit, tem, dis, vel;

	cout << "Informe quantos km/l seu automovel faz: ";
	cin >> x;
	
	cout << "\nInforme o tempo gasto ate o destino, em horas: ";
	cin >> tem;
	
	cout << "\nInforme a velocidade media durante o trajeto, em km: ";
	cin >> vel;
	
	dis=tem*vel;
	lit=dis/x;
	
	cout << "\nA velocidade media do trajeto foi de " << vel << "km/h.";
	cout << "\nO tempo gasto na viagem foi de " << tem << " horas.";
	cout << "\nA distancia percorrida foi de " << dis << "km.";
	cout << "\nForam usados " << lit << " litros de combustivel nesse trajeto.";


}
