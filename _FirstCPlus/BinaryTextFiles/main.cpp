#include <iostream>
#include <string>
#include "utils.h"
#include <fstream>
using std::cout;
using std::endl;
using std::cin;
using std::string;

int main()
{
	struct Library
	{
		int callNumber;
		string title;
		string author;
		int bookStatus;
		int dueDate;
		string borrowersName;

	};
	//int amountOfBooks = 10;
	//Library * books = new Library[amountOfBooks];
	//Library library;
	//
	//Library book1 = { 0016452, "ahh", "AhhRowling", 2, 10272021, "Devon" };

	//
	testWrite("test.bin", "yo");    // write "yo" to the file
	std::cout << testRead("test.bin");  // read "yo" from the file

	





	

	//std::fstream file;
	////read
	//if (file.is_open())
	//	file.close();
	//file.open("library.dat", std::ios::out | std::ios::binary);
	//file.write((char*)&library, sizeof(Library));
	//file.close();











	while (true)
	{

	}

	return 0;
}