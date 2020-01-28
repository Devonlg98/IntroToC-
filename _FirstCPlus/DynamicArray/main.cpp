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
	original.push_back(42);
	original.push_back(19);
	original.push_back(32);
	original.push_back(3);
	original.push_back(54);
	original.push_back(45);
	original.push_back(1);
	original.push_back(23);
	original.push_back(11);
	//original.bubbleSort();
	original.insertionSort();
	tVector<int> copy = original;
	copy.pop_back(); // removes from the copy array, but not the original
	copy.pop_back();
	copy.pop_back();


	for (size_t i = 0; i < original.size(); i++)
	{
		cout << original.at(i) << endl;
	}

	//for (size_t i = 0; i < copy.size(); i++)
	//{
	//	cout << copy[i] << endl;
	//}

	





	while (true)
	{

	}
	return 0;
}