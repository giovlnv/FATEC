/* 3.ª) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: 
VOLUME = 3.14159 * R2 * ALTURA.  */

#include <iostream>
#include <stdlib.h>
#define PI 3.14159

using namespace std;

int main(){

	float raio=0, alt=0, vol=0 ;
	
	cout << "\nInsira a altura da lata: ";
	cin >> alt;
	cout << "\nInsira o raio da lata: ";
	cin >> raio;
	
	vol= PI*(raio*raio)*alt;
	
	cout << vol;
	
	return 0;
}
