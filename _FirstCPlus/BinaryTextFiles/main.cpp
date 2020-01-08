#include <iostream>
#include <string>
#include "utils.h"
#include <fstream>
using std::cout;
using std::endl;
using std::string;

int main()
{
	int amountOfBooks = 1;
	Library books[3];
	Library library;
	string readIn;
	int count = sizeof(books) / sizeof(Library);
	
	std::fstream bin;
	//read
	bin.open("library.dat", std::ios::in | std::ios::binary);
	bin.read((char*)&books, sizeof(Library));
	if (bin.is_open())
	{
		cout << "bin is open, now closing" << endl;
		bin.close();
	}
	else
	{

		std::fstream txtFile;
		txtFile.open("library.txt", std::ios::in);
		cout << "opening library text file" << endl;
		if (txtFile.bad())
		{
			cout << "Error, failed to open" << endl;

		}
		else
		{
			bin.close();
			cout << "text file opening" << endl;
			for (int i = 0; i < 3; i++)
			{
				cout << "loop" << i << endl;
				std::getline(txtFile, readIn);
				strcpy_s(books[i].callNumber, readIn.c_str());
				std::getline(txtFile, readIn);
				strcpy_s(books[i].title, readIn.c_str());
				std::getline(txtFile, readIn);
				strcpy_s(books[i].author, readIn.c_str());
				std::getline(txtFile, readIn);
				strcpy_s(books[i].bookStatus, readIn.c_str());
				std::getline(txtFile, readIn);
				strcpy_s(books[i].dueDate, readIn.c_str());
				std::getline(txtFile, readIn);
				strcpy_s(books[i].borrowersName, readIn.c_str());
				cout << "loop" << i << endl;
			}
			txtFile.close();
			cout << "closing txt" << endl;
			//creats new bat
			cout << "creating bat" << endl;
			bin.open("library.dat", std::ios::out | std::ios::binary);

			bin.write((char*)&books, sizeof(Library) * 3);
			bin.close();

		}



	}


	//testWrite("test.bin", "yo");    // write "yo" to the file
	//std::cout << testRead("test.bin");  // read "yo" from the file
	//write
	//file.open("library.dat", std::ios::out | std::ios::binary);
	//file.write((char*)&library, sizeof(Library));
	//file.close();

	while (true)
	{

	}

	return 0;
}
