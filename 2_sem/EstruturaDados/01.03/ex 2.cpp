#include <cstdlib>
#include <iostream>

using namespace std;

float media (float a, float b, float c, float d){
	float m;
	return ((a+b+c+d)/4);
}

int main ()
{
	float a, b, c, d;
	
	cout << "Informe as 4 notas: ";
	cin >> a >> b >> c >> d;
	
	
	cout << "\nA media aritmetica das notas e " << media(a,b,c,d);
}
