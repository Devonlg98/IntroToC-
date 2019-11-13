#include <iostream>
#include "utils.h"
#include <cmath>


void printNumbers(int numbers[], size_t size)
{
	for (size_t i = 0; i < size; i++)
	{
		std::cout << numbers[i];
	}

}

int sumNumbers(int numbers[], size_t size)
{
	int sum = 0;
	for (size_t i = 0; i < size; i++)
	{
		sum += numbers[i];
	}

	return sum;
}

int largestValue(int numbers[], size_t size)
{
	int largeValue = -INT_MAX;
	for (size_t i = 0; i < size; i++)
	{
		if (numbers[i] > largeValue)
		{
			largeValue = numbers[i];
		}
	}
	return largeValue;
}

int findIndex(int numbers[], size_t size, int value, int start)
{
	int valuePosition = start-1;
	for (size_t i = start; i < size; i++)
	{
		valuePosition++;
		if (numbers[i] == value)
		{
			value = valuePosition;
			return value;
		}

	}
	return -1;
}

int countElement(int numbers[], size_t size, int value, int start)
{
	int countOfElements = 0;
	for (size_t i = start; i < size; i++)
	{
		if (numbers[i] == value)
		{
			countOfElements += 1;
		}
	}
	return countOfElements;
}

bool arrayUniqueness(int numbers[], size_t size)
{
	int uniqueTest = 0;
	for (size_t i = 0; i < size; i++)
	{
		for (size_t idx = 0; idx < size; idx++)
		{
			if (numbers[idx] == numbers[i])
			{
				uniqueTest += 1;
			}
		}
	}
	if (uniqueTest > size)
	{
		return false;
	}
	else 
	{
		return true;
	}
}

void reverseArray(int numbers[], size_t size)
{
	int arraySlider = size-1;
	int tempFakeArray;
	for (size_t i = 0; arraySlider > i; i++)
	{
		tempFakeArray = numbers[i];
		numbers[i] = numbers[arraySlider];
		numbers[arraySlider] = tempFakeArray;
		arraySlider--;
	}

}

void getAllUniqueElements(double * numbers[], size_t size)
{
	int tempArrayFiller = 0;
	int tempArray[25];
	int properArray[25];
	int properArraySlider = 0;
	int dupeCount = 0;
	for (size_t i = 0; i < size; i++)
	{
		for (size_t idx = 0; idx < size; idx++)
		{
			tempArray[tempArrayFiller] = numbers[i][idx];
			tempArrayFiller++;
		}

	}

	for (size_t i = 0; i < size; i++)
	{
		for (size_t idx = 0; idx < size; idx++)
		{
			if (tempArray[idx] == tempArray[i])
			{
				dupeCount++;
			}
		}
		if (dupeCount < 1)
		{
			properArray[properArraySlider] = tempArray[i];
		}
		dupeCount = 0;
	}
}
