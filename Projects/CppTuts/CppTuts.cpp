// CppTuts.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <sstream>

using namespace std;

void method( int *x, int *y)
{
	*x *= 10;
	*y *= 20;
}

int main()
{
	int x(10) , y(20);
	cout << "Before passing to a method: " << "\n";
	cout << x << " : " << y << "\n";
	

	cout << "After passing to a method: " << "\n";
	
	method( &x, &y);

	cout << x << " : " << y << "\n";

	cout << "Address values: " << "\n";
	cout << &x << " : " << &y << "\n";
	string name = "Hello world!";

	cout << name << endl;

    return 0;
}

