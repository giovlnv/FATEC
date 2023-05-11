#include <iostream>
#include <stdlib.h>

using namespace std;

int MDC(int x, int y){
	if(x<y){
		return MDC(y,x);
	}else if(y==0){
		return x;
	}else{
		return MDC(y, x%y);
	}
}

int main(){
	
	try{
	
	int x, y;
	
	cout << "Insira X: ";
	cin >> x;
	
	cout << "Insira Y: ";
	cin >> y;
	
	if(x<0||y<0){
			throw (x);
		}else{
			cout << "O MDC(" << x << ", " << y <<") eh: " << MDC(x,y);
		}
			
	}catch(int x){
		cout << "Informe somente Numeros Positivos";
	}
	
}
