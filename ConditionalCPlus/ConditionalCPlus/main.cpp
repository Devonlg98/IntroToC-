#include <iostream>


int main()
{
	int num = 0;

	while (num < 5)
	{
		std::cout << num << std::endl;
		num++;
	}
	for (int i = 0; i < 5; ++i)
	{
		std::cout << i << std::endl;
	}
	for (int i = 1; i < 10; ++i)
	{
		if (i % 5 == 0)
		{
			continue;
		}

		std::cout << i << std::endl;
	}

	// From 1 to 100
	for (int i = 1; i < 101; i++)
	{
		std::cout << i << std::endl;

	}

	//Age Gate
	
	std::cout << "\r\nHow old are you?\r\n";
	int age;
	std::cin >> age;

	if (age < 18) 
	{
		std::cout << "\r\nYou are a minor\r\n";
	}
	if (age >= 18 && age < 50) 
	{
		std::cout << "\r\nYou are and adult\r\n";
	}
	if (age >= 50 && age < 65)
	{
		std::cout << "\r\nYou are eligible for AARP\r\n";
	}
	if (age >= 65)
	{
		std::cout << "\r\nYou are eligible for retirement benefits\r\n";
	}

	//Smallest of any number of numbers

	std::cout << "\r\nHow many numbers would you like to type?\r\n";
	int maxNumbers;
	int numberOut;
	int lowestNumber = INT_MAX;
	std::cin >> maxNumbers;

	
	for (int i = 0; i < maxNumbers; i++)
	{
		std::cout << "\r\nPlease enter a number\r\n";
		std::cin >> numberOut;
		if (numberOut < lowestNumber) 
		{
			lowestNumber = numberOut;
		}
	}
	std::cout << "\r\nThe lowest number you typed is " << lowestNumber;

	// Even or odd
	int oddOrEven;
	std::cout << "\r\nType a number and I'll tell you whether it is odd or even\r\n";
	std::cin >> oddOrEven;

	if (oddOrEven % 2 == 0)
	{
		std::cout << "That's a mighty fine EVEN numba";
	}
	else 
	{
		std::cout << "That's a mighty fine ODD numba";
	}

	while (true) {}

	return 0;
}