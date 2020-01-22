#include <iostream>
#include <string>
#include <fstream>
#include "tLinkedList.h"
using std::cout;
using std::endl;
using std::string;

int main()
{
	tForwardList<int>list;

	list.push_front(3);
	list.push_front(6);
	list.push_front(6);
	list.push_front(9);
	list.remove(9);
	
	while (true)
	{

	}
	return 0;
}