#include <iostream>
#include "utils.h"
int main()
{

	int anything;
	int choice;
	bool gameOn = true;
	while (gameOn == true)
	{
		system("cls");
		std::cout << "Welcome, type the number of the exercise you'd like to view!\r\nPair Printing[1]\r\nSum of 3[2]\r\nMin 2 Numbers[3]\r\nMax 2 Numbers[4]\r\nClamp[5]\r\nDistance[6]\r\nEstimated Time of Arrival[7]\r\nQuit[8]\r\n";
		std::cin >> choice;

		switch (choice)
		{
		case 1:
			commaNumber();
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			continue;

		case 2:
			int num1;
			int num2;
			int num3;
			std::cout << "\r\nType a number loser\r\n";
			std::cin >> num1;
			std::cout << "\r\nType another number loser\r\n";
			std::cin >> num2;
			std::cout << "\r\nType another number loser\r\n";
			std::cin >> num3;
			std::cout << "The sum of those 3 numbers is " << sumOf3(num1, num2, num3) << "\r\n";
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			continue;

		case 3:
			int minNum1;
			int minNum2;
			std::cout << "\r\nType a number loser\r\n";
			std::cin >> minNum1;
			std::cout << "\r\nType another number loser\r\n";
			std::cin >> minNum2;
			std::cout << "The smallest number you typed is " << min2(minNum1, minNum2);
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			continue;

		case 4:
			int maxNum1;
			int maxNum2;
			std::cout << "\r\nType a number loser\r\n";
			std::cin >> maxNum1;
			std::cout << "\r\nType another number loser\r\n";
			std::cin >> maxNum2;
			std::cout << "The biggest number you typed is " << max2(maxNum1, maxNum2) << "\r\n";
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			continue;

		case 5:
			int clamp1;
			int clamp2;
			int clampedNum;

			std::cout << "\r\nType a number for a clamp\r\n";
			std::cin >> clamp1;
			std::cout << "\r\nType another number for your clamp\r\n";
			std::cin >> clamp2;
			std::cout << "\r\nType the possibly clamped number\r\n";
			std::cin >> clampedNum;
			std::cout << "Your number is " << clamp(clamp1, clamp2, clampedNum) << std::endl;
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			continue;

		case 6:
			float x1;
			float y1;
			float x2;
			float y2;

			std::cout << "\r\nLets find the distance between two points!\r\nType the x cord of your first point!\r\n";
			std::cin >> x1;
			std::cout << "\r\nType the y cord of your first point!\r\n";
			std::cin >> y1;
			std::cout << "\r\nType the x cord of your second point!\r\n";
			std::cin >> x2;
			std::cout << "\r\nType the y cord of your second point!\r\n";
			std::cin >> y2;
			std::cout << "The disance between your two points is" << distanceBetween2Points(x1, y1, x2, y2) << " units.\r\n";
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			continue;

		case 7:
			float timex1;
			float timey1;
			float timex2;
			float timey2;
			float speed;

			std::cout << "\r\nLets see how long it takes you to travel between two points!\r\nType the x cord of your first point!\r\n";
			std::cin >> timex1;
			std::cout << "\r\nType the y cord of your first point!\r\n";
			std::cin >> timey1;
			std::cout << "\r\nType the x cord of your second point!\r\n";
			std::cin >> timex2;
			std::cout << "\r\nType the y cord of your second point!\r\n";
			std::cin >> timey2;
			std::cout << "\r\nType the speed in units per second you want to travel!\r\n";
			std::cin >> speed;
			std::cout << "Your estimated time of arrival from point a to b is " << estimatedArrival(timex1, timey1, timex2, timey2, speed) << " seconds.\r\n";
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			continue;

		case 8:
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			gameOn = false;
			continue;

		default:
			system("cls");
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			std::cout << "\r\nIncorrect Input, try again!\r\n";
			continue;


		}
	}


	//hello();
	//std::cout << sqInt(2) << std::endl;
	//std::cout << decFormFraction(11, 5) << std::endl;
	//
	////Pair Printing
	//commaNumber();

	////Sum of Three Integers
	//int num1;
	//int num2;
	//int num3;
	//std::cout << "\r\nType a number loser\r\n";
	//std::cin >> num1;
	//std::cout << "\r\nType another number loser\r\n";
	//std::cin >> num2;
	//std::cout << "\r\nType another number loser\r\n";
	//std::cin >> num3;
	//std::cout << sumOf3(num1, num2, num3) << "\r\n";


	////Min 2 numbers
	//int minNum1;
	//int minNum2;
	//std::cout << "\r\nType a number loser\r\n";
	//std::cin >> minNum1;
	//std::cout << "\r\nType another number loser\r\n";
	//std::cin >> minNum2;
	//std::cout << min2(minNum1, minNum2);

	////Max 2 numbers
	//int maxNum1;
	//int maxNum2;
	//std::cout << "\r\nType a number loser\r\n";
	//std::cin >> maxNum1;
	//std::cout << "\r\nType another number loser\r\n";
	//std::cin >> maxNum2;
	//std::cout << max2(maxNum1, maxNum2);

	////Clamp
	//int clamp1;
	//int clamp2;
	//int clampedNum;

	//std::cout << "\r\nType a number for a clamp\r\n";
	//std::cin >> clamp1;
	//std::cout << "\r\nType another number for your clamp\r\n";
	//std::cin >> clamp2;
	//std::cout << "\r\nType the possibly clamped number\r\n";
	//std::cin >> clampedNum;
	//std::cout << "Your number is " << clamp(clamp1, clamp2, clampedNum) << std::endl;

	////Distance
	//float x1;
	//float y1;
	//float x2;
	//float y2;

	//std::cout << "\r\nLets find the distance between two points!\r\nType the x cord of your first point!";
	//std::cin >> x1;
	//std::cout << "\r\nType the y cord of your first point!";
	//std::cin >> y1;
	//std::cout << "\r\nType the x cord of your second point!";
	//std::cin >> x2;
	//std::cout << "\r\nType the y cord of your second point!";
	//std::cin >> y2;
	//std::cout << "The disance between your two points is" <<  distanceBetween2Points(x1, y1, x2, y2) << "\r\n";

	////Estimated Time of Arrival

	//float timex1;
	//float timey1;
	//float timex2;
	//float timey2;
	//float speed;

	//std::cout << "\r\nLets see how long it takes you to travel between two points!\r\nType the x cord of your first point!";
	//std::cin >> timex1;
	//std::cout << "\r\nType the y cord of your first point!";
	//std::cin >> timey1;
	//std::cout << "\r\nType the x cord of your second point!";
	//std::cin >> timex2;
	//std::cout << "\r\nType the y cord of your second point!";
	//std::cin >> timey2;
	//std::cout << "\r\nType the speed in units per second you want to travel!";
	//std::cin >> speed;
	//std::cout << "Your estimated time of arrival from point a to b is " <<  estimatedArrival(timex1, timey1, timex2, timey2, speed) << "\r\n";




	//

	//	hello();
	//std::cout << sqInt(2) << std::endl;
	//std::cout << decFormFraction(11, 5) << std::endl;
	//
	////Pair Printing
	//commaNumber();

	////Sum of Three Integers
	//int num1;
	//int num2;
	//int num3;
	//std::cout << "\r\nType a number loser\r\n";
	//std::cin >> num1;
	//std::cout << "\r\nType another number loser\r\n";
	//std::cin >> num2;
	//std::cout << "\r\nType another number loser\r\n";
	//std::cin >> num3;
	//std::cout << sumOf3(num1, num2, num3) << "\r\n";


	////Min 2 numbers
	//int minNum1;
	//int minNum2;
	//std::cout << "\r\nType a number loser\r\n";
	//std::cin >> minNum1;
	//std::cout << "\r\nType another number loser\r\n";
	//std::cin >> minNum2;
	//std::cout << min2(minNum1, minNum2);

	////Max 2 numbers
	//int maxNum1;
	//int maxNum2;
	//std::cout << "\r\nType a number loser\r\n";
	//std::cin >> maxNum1;
	//std::cout << "\r\nType another number loser\r\n";
	//std::cin >> maxNum2;
	//std::cout << max2(maxNum1, maxNum2);

	////Clamp
	//int clamp1;
	//int clamp2;
	//int clampedNum;

	//std::cout << "\r\nType a number for a clamp\r\n";
	//std::cin >> clamp1;
	//std::cout << "\r\nType another number for your clamp\r\n";
	//std::cin >> clamp2;
	//std::cout << "\r\nType the possibly clamped number\r\n";
	//std::cin >> clampedNum;
	//std::cout << "Your number is " << clamp(clamp1, clamp2, clampedNum) << std::endl;

	////Distance
	//float x1;
	//float y1;
	//float x2;
	//float y2;

	//std::cout << "\r\nLets find the distance between two points!\r\nType the x cord of your first point!";
	//std::cin >> x1;
	//std::cout << "\r\nType the y cord of your first point!";
	//std::cin >> y1;
	//std::cout << "\r\nType the x cord of your second point!";
	//std::cin >> x2;
	//std::cout << "\r\nType the y cord of your second point!";
	//std::cin >> y2;
	//std::cout << "The disance between your two points is" <<  distanceBetween2Points(x1, y1, x2, y2) << "\r\n";

	////Estimated Time of Arrival

	//float timex1;
	//float timey1;
	//float timex2;
	//float timey2;
	//float speed;

	//std::cout << "\r\nLets see how long it takes you to travel between two points!\r\nType the x cord of your first point!";
	//std::cin >> timex1;
	//std::cout << "\r\nType the y cord of your first point!";
	//std::cin >> timey1;
	//std::cout << "\r\nType the x cord of your second point!";
	//std::cin >> timex2;
	//std::cout << "\r\nType the y cord of your second point!";
	//std::cin >> timey2;
	//std::cout << "\r\nType the speed in units per second you want to travel!";
	//std::cin >> speed;
	//std::cout << "Your estimated time of arrival from point a to b is " <<  estimatedArrival(timex1, timey1, timex2, timey2, speed) << "\r\n";




	//


	//while (true)
	//{

	//}
	return 0;
}

