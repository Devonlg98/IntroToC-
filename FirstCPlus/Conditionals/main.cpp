#include <iostream>
void clearCinConsole()
{
	system("cls");
	std::cin.clear();
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
}

int main()
{
	//int num = 0;

	//while (num < 5)
	//{
	//	std::cout << num << std::endl;
	//	num++;
	//}
	//for (int i = 0; i < 5; ++i)
	//{
	//	std::cout << i << std::endl;
	//}
	//for (int i = 1; i < 10; ++i)
	//{
	//	if (i % 5 == 0)
	//	{
	//		continue;
	//	}

	//	std::cout << i << std::endl;
	//}

	//// From 1 to 100
	//for (int i = 1; i < 101; i++)
	//{
	//	std::cout << i << std::endl;

	//}
	////From 100 to 1
	//for (int i = 100; i > 0; i--)
	//{
	//	std::cout << i << std::endl;

	//}

	////Age Gate

	//std::cout << "\r\nHow old are you?\r\n";
	//int age;
	//std::cin >> age;

	//if (age < 18)
	//{
	//	std::cout << "\r\nYou are a minor\r\n";
	//}
	//if (age >= 18 && age < 50)
	//{
	//	std::cout << "\r\nYou are and adult\r\n";
	//}
	//if (age >= 50 && age < 65)
	//{
	//	std::cout << "\r\nYou are eligible for AARP\r\n";
	//}
	//if (age >= 65)
	//{
	//	std::cout << "\r\nYou are eligible for retirement benefits\r\n";
	//}

	////Smallest of any number of numbers

	//std::cout << "\r\nHow many numbers would you like to type?\r\n";
	//int maxNumbers;
	//int numberOut;
	//int lowestNumber = INT_MAX;
	//std::cin >> maxNumbers;


	//for (int i = 0; i < maxNumbers; i++)
	//{
	//	std::cout << "\r\nPlease enter a number\r\n";
	//	std::cin >> numberOut;
	//	if (numberOut < lowestNumber)
	//	{
	//		lowestNumber = numberOut;
	//	}
	//}
	//std::cout << "\r\nThe lowest number you typed is " << lowestNumber;

	//// Even or odd
	//int oddOrEven;
	//std::cout << "\r\nType a number and I'll tell you whether it is odd or even\r\n";
	//std::cin >> oddOrEven;

	//if (oddOrEven % 2 == 0)
	//{
	//	std::cout << "That's a mighty fine EVEN numba";
	//}
	//else
	//{
	//	std::cout << "That's a mighty fine ODD numba";
	//}

	////All leap years

	//for (int i = 0; i < 3001; i++)
	//{
	//	if (!(i % 4 == 0)) 
	//	{

	//	}
	//	else if (!(i % 100 == 0)) 
	//	{
	//		std::cout << i << std::endl;
	//	}
	//	else if (!(i % 400 == 0))
	//	{

	//	}
	//	else
	//	{
	//		std::cout << i << std::endl;
	//	}


	//}
	////from 1995 to 2019

	//std::cout << "\r\n";
	//for (int i = 1995; i < 2020; i++) 
	//{
	//	std::cout << i << "\r\n";
	//}

	////Printing multiples of five
	//int first5;
	//int second5;
	//std::cout << "\r\nWhat multiple of 5 would you like to start on?\r\n";
	//std::cin >> first5;
	//std::cout << "\r\nWhat multiple of 5 would you like to end on?\r\n";
	//std::cin >> second5;


	//for (int i = first5*5; i <= second5*5; i++)
	//{
	//	if (i % 5 == 0) 
	//	{
	//	std::cout << i << "\r\n";

	//	}
	//}

	////clamp the number
	//int clamp;
	//std::cout << "\r\nInput a number between 15 or 30 or else\r\n";
	//std::cin >> clamp;

	//if (clamp < 15) 
	//{
	//	clamp = 15;
	//}
	//else if (clamp > 30) 
	//{
	//	clamp = 30;
	//}
	//std::cout << "\r\nYour number is " << clamp;

	//function disposable calculator
	char oper;
	float firstNum;
	float secondNum;
	float result;
	float fltMax = FLT_MAX;
	bool calculatorOn = true;
	bool freshStart = true;


	while (calculatorOn)
	{
		std::cout << "\r\nOPERATOR [+] [-] [*] [/], or [c]lear [e]xit\r\n";
		std::cin >> oper;
		if (!(oper == '+' || oper == '-' || oper == '*' || oper == '/' || oper == 'c' || oper == 'e'))
		{
			clearCinConsole();
			std::cout << "\r\nIncorrect Input, try again!\r\n";
			continue;
		}
		if(oper == 'c')
		{
			clearCinConsole();
			freshStart = true;
			std::cout << "\r\nResult Cleared!\r\n";
			continue;
		}
		if (oper == 'e')
		{
			calculatorOn = false;
			break;
		}
		std::cout << "\r\nOPERAND\r\n";
		std::cin >> firstNum;
		
		if (firstNum >= fltMax || firstNum <= -fltMax)
		{
			clearCinConsole();
			std::cout << "\r\nWoah! That number is too large!\r\n";
			continue;
		}
		if (freshStart == true)
		{
			std::cout << "\r\nOPERAND\r\n";
			std::cin >> secondNum;
			if (secondNum >= fltMax || secondNum <= -fltMax)
			{
				clearCinConsole();
				std::cout << "\r\nWoah! That number is too large!\r\n";
				continue;
			}
		}
		switch (oper)
		{
		case '+':
			if (freshStart == true)
			{
				result = secondNum;
			}
			if ((result + firstNum) > fltMax || (result + firstNum) < -fltMax)
			{
				clearCinConsole();
				std::cout << "\r\nWoah! That number is too large!\r\n";
				continue;
			}
			std::cout << (result + firstNum) << std::endl;
			result = (result + firstNum);
			freshStart = false;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			break;

		case '-':
			if (freshStart == true)
			{
				result = secondNum;
			}
			if ((result - firstNum) > fltMax || (result - firstNum) < -fltMax)
			{
				clearCinConsole();
				std::cout << "\r\nWoah! That number is too large!\r\n";
				continue;
			}
			std::cout << (result - firstNum) << std::endl;
			result = (result - firstNum);
			freshStart = false;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			break;

		case '*':
			if (freshStart == true)
			{
				result = secondNum;
			}
			if ((result * firstNum) > fltMax || (result * firstNum) < -fltMax)
			{
				clearCinConsole();
				std::cout << "\r\nWoah! That number is too large!\r\n";
				continue;
			}
			std::cout << (result * firstNum) << std::endl;
			result = (result * firstNum);
			freshStart = false;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			break;

		case '/':
			if (freshStart == true)
			{
				result = secondNum;
			}
			if (firstNum == 0 || secondNum == 0)
			{
				clearCinConsole();
				std::cout << "\r\nCan't divide by zero!\r\n";
				continue;
			}
			if ((result / firstNum) > fltMax || (result / firstNum) < -fltMax)
			{
				clearCinConsole();
				std::cout << "\r\nWoah! That number is too large!\r\n";
				continue;
			}
			std::cout << (result / firstNum) << std::endl;
			result = (result / firstNum);
			freshStart = false;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			break;

		default:
			clearCinConsole();
			std::cout << "\r\nIncorrect Input, try again!\r\n";
			continue;


		}
	}

	return 0;
}