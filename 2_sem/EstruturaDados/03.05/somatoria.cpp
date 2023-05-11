#include <iostream>
#include <stdlib.h>

using namespace std;

int soma(int n){
	if(n<0){
		return -1;
	}else if(n==0){
		return 0;
	}else{
		return n+soma(n-1);
	}
}

int main(){
	
	int n;
	
	cout << "Insira um numero para a somatoria:\n";
	cin >> n;
	
	cout << "Soma(" << n << ") eh: " << soma(n);
	
	return 0;
	
}
