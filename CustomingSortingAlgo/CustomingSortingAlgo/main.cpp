#include <iostream>
#include <string>
#include "utils.h"
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
	original.printList();
	original.bubbleSort();
	original.printList();
	original.bubbleSortReverse();
	original.printList();


	while (true)
	{

	}
	return 0;
}