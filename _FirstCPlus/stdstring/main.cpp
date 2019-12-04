#include <iostream>
#include <string>
#include "utils.h"
using std::cout;
using std::endl;
using std::cin;
using std::string;

int main()
{

	string my_string1 = "a string";
	string my_string2 = " is this";
	string my_string3 = my_string1 + my_string2;
	cout << my_string3 << std::endl; // Will output "a string is this"

	string passwd;
	getline(cin, passwd, '\n');
	if (passwd == "xyzzy") 
	{
		cout << "Access allowed";	}
	else
	{
		cout << "syskey" << endl;
	}

	my_string1 = "ten chars.";
	int len = my_string1.length(); // or .size();
	cout << len << endl;
	//Every Other
	string my_string = "meow";
	for (int i = 0; i < my_string.length(); i++) 
	{
		if (i % 2 != 0)
		{
		std::cout << my_string[i];
		}
	}	//Bestowing Title	string userInput;	cout << endl<< "What's your name?" << endl;	getline(cin, userInput, '\n');	cout << userInput << ", the loser."<< endl;	//Instance Counting
	//string instanceCountingstring = "I want to die sometime very soon, release me from this deep pocket in hell";
	//string test = " ";
	//int pleaseWork = instanceCounting(instanceCountingstring, test);
	//cout << pleaseWork;
		

	//character frequency
	string checkedString = "uhbntrf cd5gvxswz vcfhrs degb nmgjt scbwghyesd ";
	char characterCheck = 'u';
	characterFrequency(checkedString,characterCheck);

	while (true)
	{

	}
	return 0;
}