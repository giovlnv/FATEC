#include <iostream>
#include <cstdlib>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

float produto (float a, float b){
	return (a*b);
}

int main(int argc, char** argv) {
	
	float a,b;
	
	cout << "\nInforme o primeiro valor:\n";
	cin >> a;
	
	cout << "\nInforme o segundo valor:\n";
	cin >> b;
	
	cout << "\nO valor do produto e igual a "<<produto(a,b);
	
	
	return 0;
}
