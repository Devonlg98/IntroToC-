#include <iostream>
#include <string>
#include <fstream>
#include "tList.h"
using std::cout;
using std::endl;
int main()
{
	tList<int> newList;

	newList.push_back(1);
	newList.push_back(2);
	newList.push_front(3);
	newList.push_front(4);
	newList.push_back(5);
	newList.push_front(6);
	
	tList<int> newListCopy;
	newListCopy = newList;
	newListCopy.remove(3);
	newList.pop_back();
	newList.pop_back(); 
	tList<int> newListActualCopy(newListCopy);

	newListActualCopy.remove(5);
	newListActualCopy.resize(8);

	if (newListCopy.empty() == true)
	{
		std::cout << "this list is empty" << std::endl;
	}
	else
	{
		std::cout << "this list is not empty" << std::endl;
	}
	newListCopy.clear();
	if (newListCopy.empty() == true)
	{
		std::cout << "this list is empty" << std::endl;
	}
	else
	{
		std::cout << "this list is not empty" << std::endl;
	}
	std::cout << newList.front() << std::endl;
	std::cout << newList.back() << std::endl;
	while (true)
	{

	}
	return 0;
}