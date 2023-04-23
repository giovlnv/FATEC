#include <cstdlib>
#include <iostream>

using namespace std;


int primo (int a){
	int i, pri=0;
		
	for (i=2; i<=a/2; i++)
	{if (a%i==0)
		{pri++;
		break;
	}}
	
	return pri;
}


int main (){
	int a;
	
	cout << "Informe o numero: ";
	cin >> a;
	
	primo(a);
	
	if (primo(a)==0){
		cout << "O numero informado e primo."; 
		}
	else {
		cout << "O numero informado nao e primo.";  
	}
	
}
