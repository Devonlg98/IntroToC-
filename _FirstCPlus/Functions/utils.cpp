#include <iostream>
#include "utils.h"
#include <cmath>

void hello()
{
	std::cout << "Hello Functions\r\n";
}

int sqInt(int a)
{
	return a * a;
}

int decFormFraction(int a, int b)
{
	return (float)a / (float)b;
}

void commaNumber()
{
	int num1;
	int num2;
	std::cout << "\r\nType a number loser\r\n";
	std::cin >> num1;
	std::cout << "\r\nType another number loser\r\n";
	std::cin >> num2;
	std::cout << num1 << "," << num2 << std::endl;
}

int sumOf3(int a, int b, int c)
{
	return a + b + c;
}

int min2(int a, int b)
{
	if (a < b)
	{
		return a;
	}
	if (b < a)
	{
		return b;
	}
}

int max2(int a, int b)
{
	if (a > b)
	{
		return a;
	}
	if (b > a)
	{
		return b;
	}
}

int clamp(int a, int b, int c)
{
	int smallClamp =min2(a, b);
	int bigClamp = max2(a, b);

	if (c < smallClamp)
	{
		return smallClamp;
	}
	if (c > bigClamp)
	{
		return bigClamp;
	}

}

float distanceBetween2Points(float x1, float y1, float x2, float y2)
{
	float x = x2 - x1;
	float y = y2 - y1;
	return sqrt((x*x) + (y*y));
}

float estimatedArrival(float x1, float y1, float x2, float y2, float speed)
{
	int distance = distanceBetween2Points(x1, y1, x2, y2);
	return distance / speed;

}