#include <cstdlib>
#include <iostream>

using namespace std;

int dobro (int x)
{
 return(x*2);
}


int main()
{
 int v;
 cout << "Digite o valor: ";
 cin>> v;
 cout << "Dobro = " << dobro(v) << endl;
}


