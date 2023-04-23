#include <iostream>
#include <pilha.h>
#include <stdlib.h>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop 

2.ª)  Codifique  umprograma  em  C++  que  reverta  uma  série  de  números  até  que  999  
seja digitado. Teste o seu programa com a série 1,3,5,7,9,2,4,6,8. 

*/

int main(int argc, char** argv) {
	
	struct Pilha P1;
	
	IniPilha(&P1);
	
	int num, numero, x;
	
	cout << "\nInforme um numero:";
	cin >> num;	
	
	while(num != 999){
		
		if(num == 999){
			break;			
		}else{
			numero=num;
			cout << "\nInforme um numero:";
			cin >> num;	
			Push(&P1, numero);
		}		
		
	}
	
	while(! pilhavazia(&P1)){
		x = Pop(&P1);
		cout << x << " ";
	}
	
	return 0;
}
