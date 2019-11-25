#include <iostream>
#include "utils.h"


int main()
{
	int anything;
	int choice = 0;
	bool gameOn = true;
	char sentence[50] = {};
	char trimmedSentence[] = { "       destroy all boomers      " };
	char reverseSentence[] = { "Please reverse this string" };
	char racecar[] = { "racecar" };
	char guiltyGear[] = { "guiltygear" };
	char fortniteBad[] = { "Fortnite bad" };

	while (gameOn == true)
	{
		system("cls");
		std::cout << "Welcome to character arrays, type the number of the exercise you'd like to view!\r\nGreeting[1]\r\nFavorite Color[2]\r\nUppercase your sentence[3]\r\nRemove Empty Spaces[4]\r\nStart and stop string[5]\r\nTrimmed string[6]\r\nString Reversal[7]\r\nPalindrome Test[8]\r\nString Length[9]\r\n";
		std::cin >> choice;
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		switch (choice)
		{
		case 1:
			char name[50];
			std::cout << "\r\nWhat is your name?\r\n";
			std::cin >> name;
			std::cout << "\r\nHello " << name << ". Nice to meet you!\r\n";
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 2:
			char favoriteColor[15];
			std::cout << "\r\nWhat is your favorite color?\r\n";
			std::cin >> favoriteColor;
			favoriteColorCheck(favoriteColor);

			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;
			

		case 3:
			std::cout << "\r\nType a sentence\n";
			std::cin.getline(sentence,49);
			toUpperFunc(sentence);
			std::cout << sentence << "\n";
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;


		case 4:
			std::cout << "\r\nType a sentence\n";
			std::cin.getline(sentence, 49);
			removeEmptySpaces(sentence);
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;


		case 5:
			int start;
			int stop;
			std::cout << "\r\nType a sentence\n";
			std::cin.getline(sentence, 49);
			std::cout << "\r\nWhat position in the string would you like to start reading?\r\n";
			std::cin >> start;
			std::cout << "\r\nWhat position in the string would you like to stop reading?\r\n";
			std::cin >> stop;
			substringStartStop(sentence, start, stop);
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;


		case 6:
			std::cout << "\r\nThis will trim the string : \r\n" << trimmedSentence << std::endl;
			stringTrimming(trimmedSentence, 32);
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 7:
			std::cout << "\r\nI'm going to reverse this string: \n"<< reverseSentence << std::endl;
			
			stringReversal(reverseSentence, 26);

			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 8:
			std::cout << "\r\nIs 'racecar' a palindrome?\r\n";
			if (palindromeTest(racecar, 7) == true)
			{
				std::cout << "\r\nyes\r\n";
			}
			else
			{
				std::cout << "\r\nno\r\n";
			}
			std::cout << "\r\nIs 'guiltygear' a palindrome?\r\n";
			if (palindromeTest(guiltyGear, 10) == true)
			{
				std::cout << "\r\nyes\r\n";
			}
			else
			{
				std::cout << "\r\nno\r\n";
			}
			
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		case 9:
			std::cout << "\r\nType a string and the length of your string will come out after.\r\n";
			std::cin.getline(sentence, 49);
			std::cout << stringLength(sentence);
			std::cout << "\r\nType anthing and hit Enter to continue . . .\r\n";
			std::cin >> anything;
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			continue;

		default:
			system("cls");
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			std::cout << "\r\nIncorrect Input, try again!\r\n";
			continue;


		}
	}
	


	// storing a string literal in an array
	//char name[50] = "Hello C-Strings!";

	//// printing letter by letter by hand
	//for (int i = 0; i < 50; ++i)
	//{
	//	std::cout << name[i];

	//	if (name[i] == '\0')
	//	{
	//		break;
	//	}
	//}

	//// printing the whole string
	//std::cout << name << std::endl;

	//// input buffer
	//char input[50] = {};

	//// prompting for a string (up to the size of the array)
	//// note that you can store 49 characters + 1 for null-terminator
	//// note that this also stops at the first whitespace character (e.g. space, newline)
	//std::cin >> input;

	//std::cin.getline(input, 50);

	//std::cout << "You said: " << input << std::endl;

	//char personA[50] = "John";
	//char personB[50] = "John";

	//// strcmp
	//if (strcmp(personA, personB) == 0)
	//{
	//	std::cout << "Names match!" << std::endl;
	//}
	//else
	//{
	//	std::cout << "Names don't match!" << std::endl;
	//}

	//// strlen
	//char yourName[255] = {};

	//std::cin.getline(yourName, 255);

	//std::cout << "Your name is " << std::strlen(yourName) << " characters long, and is " << yourName << "." << std::endl;







	while (true)
	{

	}
	return 0;
}