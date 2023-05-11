#include <iostream>
#include <stdlib.h>

using namespace std;

int divi(int x, int y){
	if(x<0||y<0){
		return -1;
	}else if(x==y){
		return 1;
	}else if(x<y){
		return 0;
	}else{
		return (1 + divi(x-y, y));
	}
}

int main(){
	
	int x,y;
	
	cout << "Insira Dividendo:\n";
	cin >> x;
	
	cout << "Insira Divisor:\n";
	cin >> y;
	
	cout << "DIV(" << x << ", " << y << ") eh: " << divi(x,y);
	
	return 0;
	
}
