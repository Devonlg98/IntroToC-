#include <iostream>
#include "Utils.h"

//Declare and define sum
int sum(int a, int b)
{
	return a + b;
}
//Declare sub
int sub(int a, int b);

int main()
{
	//Call sum
	std::cout << sum(5, 7) << std::endl;

	std::cout << mul(5, 7) << std::endl;

	std::cout << division(5, 7) << std::endl;

	while (true)
	{

	}
	return 0;
}

//Declare and define sub
int sub(int a, int b)
{
	return a - b;
}