#include <iostream>
#include "utils.h"
#include <cmath>
#include <cstring>
#include <algorithm> 
myHero::myHero() {
	// copy name into name member
	strcpy_s(myName, sizeof(myName), "DefaultName");
	status();
}
myHero::myHero(const char * name) {
	strcpy_s(myName, sizeof(myName), name);
	status();
}
myHero::~myHero() {
	std::cout << myName << " just died." << std::endl;
}
void myHero::status() {
	std::cout << myName << " was just born" << std::endl;
}

randomizedDefaults::randomizedDefaults()
{
	strcpy_s(myName, sizeof(myName), "DefaultName");
	status();
}




randomizedDefaults::randomizedDefaults(const char * name)
{
	strcpy_s(myName, sizeof(myName), name);
	status();
}

randomizedDefaults::randomizedDefaults(const char * name, size_t HP, size_t ATK, size_t DEF)
{
	strcpy_s(myName, sizeof(myName), name);
	if (HP > 10)
	{
		HP = 10;
	}
	if (ATK > 10)
	{
		ATK = 10;
	}
	if (DEF > 10)
	{
		DEF = 10;
	}
	status();
}

randomizedDefaults::~randomizedDefaults()
{
	std::cout << myName << " was released." << std::endl;
}

void randomizedDefaults::status()
{
	std::cout << myName << " was just caught." << std::endl;
	std::cout << myName << " has " << std::endl << HP << " HP." << std::endl << ATK << " Attack Power." << std::endl << DEF << " Defense Power." << std::endl;
}

