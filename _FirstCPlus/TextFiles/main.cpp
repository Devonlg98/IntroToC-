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
	string userInput;

	bool exitLoop = false;
	std::string filename = "test.txt";

	std::ifstream inputFile;
	std::ofstream outputFile;




	while (exitLoop == false)
	{

		//Safe to write to file
		cout << "Would you like to [display]? [write]? [clear]? or [exit] the program?" << endl;
		cin >> userInput;
		for (string::size_type i = 0; i < userInput.length(); i++)
		{
			userInput[i] = tolower(userInput[i]);
		}

		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		if (userInput == "display")
		{
			
			inputFile.open("output.txt", std::ios::in);

			if (inputFile.is_open())
			{
				std::string buffer;
				while (std::getline(inputFile, buffer)) // iterates until error or EOF
				{
					// print the line after it is buffered
					std::cout << buffer << std::endl;
				}

				inputFile.close();
			}
			else
			{
				std::cerr << "Input file not found." << std::endl;
			}

		}
		else if (userInput == "write")
		{
			outputFile.open("output.txt", std::ios::app);
			string userWrite;

			cout << "What would you like to write?" << endl;
			std::getline(cin, userWrite);
			outputFile.seekp(0, std::ios_base::end);

			outputFile << userWrite << endl;
			outputFile.flush();
			outputFile.close();

		}
		else if (userInput == "clear")
		{
			outputFile.open("output.txt", std::ios::out);
			outputFile.clear();
			outputFile.close();

		}
		else if (userInput == "exit")
		{
			exitLoop = true;
			break;
		}
		else
		{
			cout << "incorrect Input" << endl;
		}

	}




	return 0;
}
