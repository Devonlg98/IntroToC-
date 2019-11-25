#include <iostream>


int main() 
{
	std::cout << "Pizza Pizza" << " " <<  0 << " " << 5 << std::endl << 5 << "\r\n" << 5<< std::endl;

	int age = -1;
	std::cout << "What is your age?" << std::endl;
	std::cin >> age;
	std::cout << "Wow, you're old boomer at the age of " << age << std::endl;

	// Celsius to Fahrenheit)
	std::cout << "How hot is it in Celsius?" << std::endl;
	float degCelsius = 0.0f;
	std::cin >> degCelsius;
	float degFahrenheit = (degCelsius * 9 / 5) + 32;

	std::cout << "Celsius to Fahrenheit)" << std::endl;
	std::cout << "Celsius:    " << degCelsius << std::endl;
	std::cout << "Fahrenheit: " << degFahrenheit << std::endl;

	//Area W*H

	std::cout << "\r\nLets make a rectangle, Please type the width you'd like!\r\n";
	float rectWidth = 0;
	std::cin >> rectWidth;
	std::cout << "\r\nPlease type the Height you'd like!\r\n";
	float rectHeight = 0;
	std::cin >> rectHeight;
	float rectArea = rectWidth * rectHeight;
	std::cout << "Area of a Rectangle)" << std::endl;
	std::cout << "H: " << rectHeight << " , W: " << rectWidth << std::endl;
	std::cout << "Area: " << rectArea << std::endl;

	//Average of Five
	float a, b, c, d, e;    // Modify these variables below.
	std::cout << "\r\nLets get the average of 5 numbers you choose, type a number then hit enter 5 times!\r\n";
	std::cin >> a;
	std::cout << "\r\nSecond Number Please!\r\n";
	std::cin >> b;
	std::cout << "\r\nThird Number Please!\r\n";
	std::cin >> c;
	std::cout << "\r\nFourth Number Please!\r\n";
	std::cin >> d;
	std::cout << "\r\nFifth Number Please!\r\n";
	std::cin >> e;

	float avg = (a + b + c + d + e)/5;

	std::cout << "Average of Five)" << std::endl;
	std::cout << a << "," << b << "," << c << "," << d << "," << e << std::endl;
	std::cout << "avg: " << avg << std::endl;

	// Number Swap)
	std::cout << "\r\nLets swap two numbers, type your first number for x!\r\n";
	int x = 0;
	std::cin >> x;
	std::cout << "\r\nType your next number for y!\r\n";
	int y = 0;
	std::cin >> y;
	int xTemp = x;
	int yTemp = y;
	x = yTemp;
	y = xTemp;


	std::cout << "Number Swap)" << std::endl;
	std::cout << "x was " << xTemp << " and now is " << x << std::endl;
	std::cout << "y was " << yTemp << " and now is " << y << std::endl;

	//Fun Facts Age

	std::cout << "\r\nPlease type your age\r\n";
	float funAge = 0;
	std::cin >> funAge;
	float monthsToYears = funAge * 12;
	float lifeExpectancyJapan = 84 - funAge;
	std::cout << "\r\nYou've been alive for " << monthsToYears << " Months" <<"\r\nAnd you are expected to live for another " << lifeExpectancyJapan << " years, if you are from Japan";


	//Challenge Handling errors
	bool realNumberCheck = true;
	float favNum = -1.0f;
	while (realNumberCheck == true)
	{

		std::cout << "\r\nWhat's your favorite number?";
		std::cin >> favNum;
		if (std::cin.fail()) 
		{
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			std::cout << "\r\nIncorrect Input!\r\n";
		}
		else
		{
			std::cout << "\r\nYour favorite number is " << favNum;
			realNumberCheck = false;
		}

	}



	while (true) {}

	return 0;
}