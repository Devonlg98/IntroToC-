#include <iostream>
#include "utils.h"
#include <cmath>


int sum(int * numbers, size_t length)
{
	int total = 0;

	for (size_t i = 0; i < length; i++)
	{
		total += numbers[i];
	}
	return total;
}



void printFloats(float * arr, size_t size)
{
	for (size_t i = 0; i < size; i++)
	{
		std::cout << arr[i] << std::endl;
	}
}

void printInts(int * arr, size_t size)
{
	for (size_t i = 0; i < size; i++)
	{
		if (arr[i] != NULL)
		{
		std::cout << arr[i] << std::endl;
		}
	}
}

void printChars(char * arr, size_t size)
{
	for (size_t i = 0; i < size; i++)
	{
		if (arr[i] != NULL)
		{
			std::cout << arr[i] << std::endl;
		}
	}
}

int arraySum(int * arr, size_t size)
{
	int total = 0;
	for (size_t i = 0; i < size; i++)
	{
		total += arr[i];
	}
	return total;
}

void initBools(bool * arr, size_t size, bool defaultValue)
{
	for(size_t i = 0; i < size;i++)
	{
		arr[i] = defaultValue;
	}
}

int * zeroArray(size_t length)
{
	int * arr = new int[length];
	for (size_t i = 0; i < length; i++)
	{
		arr[i] = 0;
	}
	return arr;
}

void iLoveNumbers()
{

	int numberTotal;
	std::cout << "\r\nHowdy! How many numbers do you have?\r\n";
	std::cin >> numberTotal;
	int * favoriteNumbers = new int[numberTotal];
	for (size_t i = 0; i < numberTotal; i++)
	{
		std::cout << "Okay, what's number " << i + 1 << "?\r\n";
		std::cin >> favoriteNumbers[i];
	}
	std::cout << "Okay, you have the numbers: ";
	for (size_t i = 0; i < numberTotal-1; i++)
	{
		std::cout << favoriteNumbers[i] << ", ";
	}
	std::cout << "and " << favoriteNumbers[numberTotal-1] << ".\r\n";
	delete favoriteNumbers;
}

int * duplicateArray(int * origArray, size_t size)
{

	int * dupedArray = new int[size];
	for (size_t i = 0; i < size; i++)
	{
		dupedArray[i] = origArray[i];
	}
	return dupedArray;
}

int * duplicateSubArray(int * origArray, size_t size, int start, int stop)
{
	int idx = 0;
	int * dupedSubArray = new int[size];
	for (size_t i = start; i < stop+1; i++)
	{
		dupedSubArray[idx] = origArray[i];
		idx++;
	}
	for (;idx < size; idx++)
	{
		dupedSubArray[idx] = NULL;
	}
	return dupedSubArray;
}

int pointerToElement(char * arr, size_t size, char searchedChar, bool caseSenitive)
{
	int charFound = 0;

	if (caseSenitive == false)
	{
		searchedChar = tolower(searchedChar);
		for (size_t i = 0; i < size; i++)
		{
			arr[i] = tolower(arr[i]);
		}
	}
	for (size_t i = 0; i < size; i++)
	{
		if (arr[i] == searchedChar)
		{
			charFound = i;
		}
	}
	return charFound; 
}


//Learned this from this source
//tutorialspoint.com/returning-multiple-values-from-a-cplusplus-function#:~:targetText=In%20C%20or%20C%2B%2B,or%20“call%20by%20reference”. 
void swappingPointers(int swapa, int swapb, int *tempa, int *tempb)
{
	*tempa = swapb;
	*tempb = swapa;

}