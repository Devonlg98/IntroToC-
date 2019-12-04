#include <iostream>
#include "utils.h"
#include <cmath>
#include <string>
#include <algorithm> 

int instanceCounting(std::string string, std::string check)
{
	int total = 0;
	for (int i = string.find(check, 0); i != std::string::npos; i = string.find(check, i)) {
		total++;
		i++; // Move past the last discovered instance to avoid finding same string
	}
	return total;
}

int characterFrequency(std::string userString, char check)
{
	int total = 0;
	for (int i = 0; i < userString.length(); i++)
	{
		if (userString[i] == check)
		{
			total++;
		}
	}
	return total;
}