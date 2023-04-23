/* 2.ª) Faça um programa que leia uma temperatura em graus Centígrados e apresente-a
convertida em graus Fahrenheit. A fórmula de conversão é: 
F = (9 * C + 160) / 5, onde F é a temperatura em Fahrenheit e C em graus Centígrados */

#include <iostream>
#include <stdlib.h>

using namespace std; 

int main(){
	float c, f;
	
	cout << "Insira a temperatura em Celsius:";
	cin >> c;
	
	f=(9 * c + 160)/5;
	
	cout << "\nA temperatura inserida, em Fahrenheit, e de " << f << endl;	
	
	
	
	
	return 0;
}
