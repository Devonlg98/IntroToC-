#include <iostream>
#include "person.h"

int main()
{
	person Bel;
	Bel.age = 18;
	Bel.cash = 200;
	Bel.killCount = 777;
	std::cout << "Bel's kill count is " << Bel.killCount << std::endl;

	std::cout << "Bel had " << Bel.cash << " GBP\r\n";

	//& = address of thing
	float withdraw = getMoney(&Bel, 1000);

	

	std::cout << "Bel has " << Bel.cash << "GBP\r\n";

	person * someone = &Bel;
	//erase the address of someone
	erasePerson(&someone);

	if(someone == nullptr)
	{
		std::cout << "someone got erased!\n";
	}
	else
	{
		std::cout << "someone is there.\n";
	}
	
	
	while (true)
	{

	}

	return 0;
}