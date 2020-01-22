#include <iostream>
#include <string>
#include "tVector.h"
#include <fstream>
using std::cout;
using std::endl;
using std::string;

int main()
{
	tVector<int> original;
	original.push_back(4);
	original.push_back(5);
	original.push_back(6);

	tVector<int> copy = original;
	copy.pop_back(); // removes from the copy array, but not the original
	copy.pop_back();
	copy.pop_back();


	for (size_t i = 0; i < original.size(); i++)
	{
		cout << original.at(i) << endl;
	}

	for (size_t i = 0; i < copy.size(); i++)
	{
		cout << copy[i] << endl;
	}

	





	while (true)
	{

	}
	return 0;
}