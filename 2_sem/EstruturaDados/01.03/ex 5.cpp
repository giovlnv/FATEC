#include <iostream>
#include <cstdlib>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

void maior (float a, float b){
	if (a < b){
		cout << "\nA ordem dos valores informados é: "<<a<<" e "<<b<<".";
	}else{
		cout << "\nA ordem dos valores informados é: "<<b<<" e "<<a<<".";
	}
	
	system ("PAUSE");
}

int main(int argc, char** argv) {
	float a, b;
	
	cout << "Informe os dois valores:\n";
	cin >> a >> b;
	
	maior(a,b);
	
	return 0;
}
