#include <iostream>
#include <cstring>
#include "utils.h"
using std::cout;
using std::endl;

void showScope();

int main() {
	showScope();
	myHero george = { "George" };
	myHero* chief = new myHero;
	delete chief;


	while (true)
	{

	}
	return 0;
}

void showScope() {
	randomizedDefaults empoleon = { "Empoleon", 15, 5, 10 };

	myHero terry;

	myHero ironMan = { "Superfreak" };
}