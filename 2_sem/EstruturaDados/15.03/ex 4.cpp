#include <iostream>
#include <stdlib.h>
#include <pilha.h>

using namespace std;

int main()
{
	struct Pilha P1;
	IniPilha(&P1); 
	
	int x,z,w;
	cout << "Digite um numero inteiro decimal: " << endl;
	cin >> x;

	z = x % 16;
	w = x / 16;
	Push(&P1,z);
		
		while (w != 0)
		{
		x = w;
		z = x % 16;
		w = x / 16;
		Push(&P1, z);
		}


		while (! pilhavazia(&P1))
		{
		x = Pop(&P1);
		
			switch(x){
			case 10: cout << "A";
					break;
			case 11: cout << "B";
					break;
			case 12: cout << "C";
					break;
			case 13: cout << "D";
					break;
			case 14: cout << "E";
					break;
			case 15: cout << "F";
					break;
			default: cout << x ;
			}

		}
		
		cout << endl;
    	return 0;
		}
