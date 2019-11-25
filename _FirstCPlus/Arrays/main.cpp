#include <iostream>
#include "utils.h"

int main()
{

	int anything;
	int choice;
	int arr[5]{ 5,3,2,7,1 };
	double arrArr[5][5]{ { 5,3,2,7,1 }, { 5,3,2,7,1 }, { 5,3,2,7,1 }, { 5,3,2,7,1 }, { 5,3,2,7,1 } };
	bool gameOn = true;
	while (gameOn == true)
	{
		system("cls");
		std::cout << "Welcome to arrays, type the number of the exercise you'd like to view!\r\nPrintArray[1]\r\n";
		std::cin >> choice;

		switch (choice)
		{
		case 1:
			printNumbers(arr, 5);
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 2:
			std::cout << "\r\nThe Sum of the array is " << sumNumbers(arr, 5) << std::endl;
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 3:
			std::cout << "\r\nThe largest value of the array is " << largestValue(arr, 5) << std::endl;
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 4:
			int indexValue;
			int indexStart;
			std::cout << "\r\n\Where do you want to start in the array?\r\n";
			std::cin >> indexStart;
			std::cout << "\r\n\What value in the array would you like to look for?\r\n";
			std::cin >> indexValue;
			std::cout << "\r\nIt's position in the array is " << findIndex(arr, 5, indexValue, indexStart) << "\n";
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 5:
			int countValue;
			int countStart;
			std::cout << "\r\n\Where do you want to start in the array?\r\n";
			std::cin >> countStart;
			std::cout << "\r\n\What value in the array would you like to look for?\r\n";
			std::cin >> countValue;
			std::cout << "\r\nThere are " << countElement(arr, 5, countValue, countStart) << " of those values in the array";

			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 6:
			if (arrayUniqueness(arr, 5) == true)
			{
				std::cout << "\r\nIt is true that, the given value is in the array";
			}
			else
			{
				std::cout << "\r\nIt is false that, the given value is in the array";
			}
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 7:
			reverseArray(arr, 5);
			printNumbers(arr, 5);
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 8:
			//getAllUniqueElements(arrArr, 25);

			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;


		//case 99:
		//	std::cin.clear();
		//	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		//	std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
		//	std::cin >> anything;
		//	gameOn = false;
		//	continue;

		//default:
		//	system("cls");
		//	std::cin.clear();
		//	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		//	std::cout << "\r\nIncorrect Input, try again!\r\n";
		//	continue;


		}
	}

	return 0;
}

