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
			 += userInput[i];
		}
			
	}
}