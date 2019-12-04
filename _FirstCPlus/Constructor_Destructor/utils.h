#pragma once
#include <iostream>
#include <cmath>
#ifndef  _UTILS_H_
#define _UTILS_H_
class myHero
{
public:
	// generally, we'll put our ctors and dtors first
	myHero();                     // default constructor
	myHero(const char * name);    // parameterized constructor

	~myHero();                    // default destructor (well, the only kind)

	// other public member functions here
	void status();

private:
	char myName[16];
};

class randomizedDefaults
{
public:

	randomizedDefaults();
	randomizedDefaults(const char * name);
	randomizedDefaults(const char * name, size_t HP, size_t ATK, size_t DEF);

	~randomizedDefaults();


	void status();
private:
	char myName[16];
	int HP = 10;
	int ATK = 5;
	int DEF = 2;

};


#endif // ! _UTILS_H_