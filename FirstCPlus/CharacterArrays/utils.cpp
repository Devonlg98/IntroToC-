#include <iostream>
#include "utils.h"
#include <cmath>

char Green[15] = "Green";
char green[15] = "green";
char yellow[15] = "yellow";
char Yellow[15] = "Yellow";
char orange[15] = "orange";
char Orange[15] = "Orange";
char red[15] = "red";
char Red[15] = "Red";
char purple[15] = "purple";
char Purple[15] = "Purple";
char blue[15] = "blue";
char Blue[15] = "Blue";

void favoriteColorCheck(char * userColor)
{
	if ((strcmp(userColor, green) == 0) || (strcmp(userColor, Green) == 0))
	{
		std::cout << "Green is the best color!";
	}
	else if ((strcmp(userColor, yellow) == 0) || (strcmp(userColor, Yellow) == 0))
	{
		std::cout << "Yellow, just like the submarine!";
	}
	else if ((strcmp(userColor, orange) == 0) || (strcmp(userColor, Orange) == 0))
	{
		std::cout << "Pretty lame color honestly, who likes orange?! green is better";
	}
	else if ((strcmp(userColor, red) == 0) || (strcmp(userColor, Red) == 0))
	{
		std::cout << "Typical lame color, red is boring, green is better";
	}
	else if ((strcmp(userColor, purple) == 0) || (strcmp(userColor, Purple) == 0))
	{
		std::cout << "Ah yes, Purple, the color of royalty!";
	}
	else if ((strcmp(userColor, blue) == 0) || (strcmp(userColor, Blue) == 0))
	{
		std::cout << "Blue is a good color, almost as good as green!";
	}
	else
	{
		std::cout << userColor << " is a really weird color...";
	}

}

void toUpperFunc(char userInput[])
{

	for (int i = 0; i< strlen(userInput); i++)
	{
		userInput[i] = toupper(userInput[i]);
	}
}

void removeEmptySpaces(char userInput[])
{
	int temp = strlen(userInput);
	for (int i = 0; i < strlen(userInput); i++)
	{
		if (userInput[i] == ' ')
		{			
		}
		else
		{
			std::cout << userInput[i];
		}			
	}
}

void stringTrimming(char string[], size_t size)
{
	char trimmedString[50] = {};

	for (int i = 0; i < size; i++)
	{
		if (string[i] != 52 || string[i] != 32)
		{

		}
	}

	string = trimmedString;
	std::cout << trimmedString;
}

void substringStartStop(char userInput[], int start, int stop)
{
	for (int i = start; i < stop; i++)
	{
		std::cout << userInput[i];
	}
}

void stringReversal(char string[], size_t size)
{
	char reverseString[50] = {};

 	for (int i = 0; i < size; i++)
	{
		if (string[size -i -1] != 52)
		{
			reverseString[i] = string[size -i -1];
		}
	}
	string = reverseString;
	std::cout << reverseString;
}

bool palindromeTest(char string[], size_t size)
{
	char reverseString[50] = {};
	bool check = true;
	for (int i = 0; i < size; i++)
	{
		if (string[size - i - 1] != 52)
		{
			reverseString[i] = string[size - i - 1];
		}
	}
	for (int i = 0; i < size; i++)
	{
		if (reverseString[i] != string[i])
		{
			check = false;
			break;
		}
	}
	if (check == true)
	{
		return true;
	}
	else
	{
		return false;
	}


}

int stringLength(char userInput[])
{
	int length = 0;
	for (int i = 0; i < strlen(userInput); i++)
	{
		if (userInput[i] != 52)
		{
			length++;
		}
	}
	return length;
}