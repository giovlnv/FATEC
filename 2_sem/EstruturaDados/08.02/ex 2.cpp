/* 2.�) Fa�a um programa que leia uma temperatura em graus Cent�grados e apresente-a
convertida em graus Fahrenheit. A f�rmula de convers�o �: 
F = (9 * C + 160) / 5, onde F � a temperatura em Fahrenheit e C em graus Cent�grados */

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
