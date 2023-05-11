#include <iostream>
#include <stdlib.h>

using namespace std;

int mod(int x, int y){
	if(x<0||y<0){
		return -1;
	}else if(x==y){
		return 0;
	}else if(x<y){
		return x;
	}else{
		return mod(x-y,y);
	}
}

int main(){
	
	int x,y;
	
	cout << "Insira Dividendo:\n";
	cin >> x;
	
	cout << "Insira Divisor:\n";
	cin >> y;
	
	cout << "MOD(" << x << ", " << y << ") eh: " << mod(x,y);
	
	return 0;
	
}
