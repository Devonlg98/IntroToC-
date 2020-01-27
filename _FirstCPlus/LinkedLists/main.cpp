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
	//list.remove(9);
	tForwardList<int>list2(list);
	tForwardList<int>list3;
	list3=(list2);
	tForwardList<int>emptyList;
	if (emptyList.empty() == false)
	{
		cout << "this is not empty" << endl;
	}
	else
	{
		cout << "this is empty" << endl;
	}
	if (list.empty() == false)
	{
		cout << "this is not empty" << endl;
	}
	else
	{
		cout << "this is empty" << endl;
	}
	emptyList.empty();
	list.push_front(3);
	list.resize(10);
	while (true)
	{

	}
	return 0;
}