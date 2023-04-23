#include <cstdlib>
#include <iostream>
#define pi 3.1415

using namespace std;


float radian (float a){
	float r;
	return (r=(a*pi)/180);
}

int main ()
{
	float a;
	
	cout << "Informe o grau a ser convertido: ";
	cin >> a;
	
	
	cout << "\nEsse grau em radianos e " << radian(a);
}
