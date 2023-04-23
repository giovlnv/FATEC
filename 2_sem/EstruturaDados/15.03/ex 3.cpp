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

	z = x % 8;
	w = x / 8;
	Push(&P1,z);
		
		while (w != 0)
		{
		x = w;
		z = x % 8;
		w = x / 8;
		Push(&P1, z);
		}


		while (! pilhavazia(&P1))
		{
		x = Pop(&P1);
		
		cout << x;

		}
		
		cout << endl;
    	return 0;
		}
