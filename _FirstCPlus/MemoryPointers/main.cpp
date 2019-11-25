#include <iostream>
#include "utils.h"
int main()
{
	//Print an Array of Floats
	int arrayCount = 5;
	float * arrayOfFloats = new float[arrayCount];
	arrayOfFloats[0] = 1;
	arrayOfFloats[1] = 2;
	arrayOfFloats[2] = 3;
	arrayOfFloats[3] = 4;
	arrayOfFloats[4] = 5.5f;
	printFloats(arrayOfFloats, arrayCount);
	delete arrayOfFloats;
	
	//Sum of an Integer Array
	arrayCount = 3;
	int * sumIntArray = new int[arrayCount];
	sumIntArray[0] = 420;
	sumIntArray[1] = 117;
	sumIntArray[2] = 69;
	int total = sum(sumIntArray, arrayCount);
	std::cout << "\r\nThe sum of\r\n" << sumIntArray[0] << std::endl << sumIntArray[1] << std::endl << sumIntArray[2] << std::endl << "Is " << total;
	delete sumIntArray;

	//Initalizing an Array of Booleans
	arrayCount = 4;
	bool * boolArray = new bool[arrayCount];
	boolArray[0] = true;
	boolArray[1] = false;
	boolArray[2] = true;
	boolArray[3] = false;
	for (size_t i = 0; i < arrayCount; i++)
	{
		if (boolArray[i] == true)
		{
			std::cout << "\r\nBool array " << i << " is true\r\n";
		}
		else
		{
			std::cout << "\r\nBool array " << i << " is false\r\n";
		}
	}
	std::cout << "The values of boolArray 1, 2, 3, and 4 will be forced true";
	initBools(boolArray, arrayCount, true);
	for (size_t i = 0; i < arrayCount; i++)
	{
		if (boolArray[i] == true)
		{
			std::cout << "\r\nBool array " << i << " is true\r\n";
		}
		else
		{
			std::cout << "\r\nBool array " << i << " is false\r\n";
		}
	}
	delete boolArray;

	//Return Zero Array
	arrayCount = 10;
	int * newZeroArray = zeroArray(arrayCount);
	for (size_t i = 0; i < arrayCount; i++)
	{
		std::cout << newZeroArray[i] << std::endl;
	}

	total = arraySum(newZeroArray, arrayCount);
	std::cout << total;

	//I love Numbers
	iLoveNumbers();

	//Duplicate That Array
	arrayCount = 5;
	int * soonToBeDupedArray = new int[arrayCount];
	std::cout << "\r\nWatch as I duplicate the array below\r\n";
	soonToBeDupedArray[0] = 69;
	soonToBeDupedArray[1] = 52;
	soonToBeDupedArray[2] = 42;
	soonToBeDupedArray[3] = 17;
	soonToBeDupedArray[4] = 88;
	printInts(soonToBeDupedArray, arrayCount);
	int * dupedArray = duplicateArray(soonToBeDupedArray, arrayCount);
	printInts(dupedArray, arrayCount);
	delete soonToBeDupedArray;
	delete dupedArray;


	//Get Integer Subarray
	arrayCount = 8;
	int * soonToBeSubDupedArray = new int[arrayCount];
	int subArrayStart;
	int subArrayStop;
	soonToBeSubDupedArray[0] = 69;
	soonToBeSubDupedArray[1] = 52;
	soonToBeSubDupedArray[2] = 42;
	soonToBeSubDupedArray[3] = 17;
	soonToBeSubDupedArray[4] = 619;
	soonToBeSubDupedArray[5] = 512;
	soonToBeSubDupedArray[6] = 142;
	soonToBeSubDupedArray[7] = 171;
	std::cout << "\r\nLooking at the following array, what would you like to copy into a new array?\r\n";
	printInts(soonToBeSubDupedArray, arrayCount);
	std::cout << "\r\nWhat Index would you like to start at?";
	std::cin >> subArrayStart;
	std::cout << "\r\nWhat Index would you like to stop at?";
	std::cin >> subArrayStop;

	int * dupedSubArray = duplicateSubArray(soonToBeSubDupedArray, arrayCount, subArrayStart, subArrayStop);
	printInts(dupedSubArray, arrayCount);

	//Get Pointer to Element
	arrayCount = 11;
	bool caseSenitive;
	char caseCheck;
	char searchedChar;
	char * elementCharArray = new char[arrayCount];
	elementCharArray[0] = 'a';
	elementCharArray[1] = 'b';
	elementCharArray[2] = 'c';
	elementCharArray[3] = 'd';
	elementCharArray[4] = 'e';
	elementCharArray[5] = 'F';
	elementCharArray[6] = 'g';
	elementCharArray[7] = 'H';
	elementCharArray[8] = 'I';
	elementCharArray[9] = 'J';
	elementCharArray[10] = 'j';
	std::cout << "\r\nWhat character would you like to search for in my array?\r\n";
	std::cin >> searchedChar;

	printChars(elementCharArray, arrayCount);
	std::cout << "\r\nWould you like your search to be case Sensitive [y]es or [n]o?\r\n";
	std::cin >> caseCheck;
	caseCheck = tolower(caseCheck);
	if (caseCheck == 'y')
	{
		caseSenitive = true;
	}
	else if (caseCheck == 'n')
	{
		caseSenitive = false;
	}
	else
	{
		std::cout << "Incorrect input idiot";
		
		//Break here if in a loop
	}
	
	int positionInArray = pointerToElement(elementCharArray, arrayCount, searchedChar, caseSenitive);
	
	if (positionInArray > 0)
	{
		
		std::cout << "\r\nThis is the memory address of that character is " << &elementCharArray + positionInArray * sizeof(char) << " \r\n";
		char * memoryAddress = &elementCharArray[positionInArray];
		//memoryAddress += positionInArray * sizeof(char);
		void * ptr = memoryAddress;
		std::cout << "\r\nThis is the memory address of that character is " << ptr<< " \r\n";
		
		
		//int memoryAddress = (int) &elementCharArray + *positionInArray * sizeof(char);
		//char * addMemory = new char[8];
		//sprintf(addMemory, "%x", memoryAddress);
		//std::cout << "address: " << addMemory;
	}
	else
	{
		std::cout << "\r\nWe couldn't find any of those characters in the array.\r\n";
	}


	//Swapping Pointers

	int val = 2;
	int otherVal = 4;

	int * a = &val;
	int * b = &otherVal;

	// call the swap function here

	std::cout << val << std::endl;      // this should read 2 because val is unchanged
	std::cout << otherVal << std::endl; // this should read 4 because otherVal is unchanged
	swappingPointers(*a, *b, &val, &otherVal); 

	std::cout << *a << std::endl;       // this should read 4 because a is now pointing to the value of otherVal
	std::cout << *b << std::endl;






	////section in memory reserved for a pointer meeples
	//int walletCount = 10;
	////int * meeples = new int;
	////Costly to do, but allows for a dynamic array
	//int * wallets = new int[walletCount];
	////int wallets[10]; with a static array, it's defined and cannot be changed

	//wallets[0] = 5;
	//wallets[1] = 3;
	//wallets[2] = 5;
	//wallets[3] = 69;
	//wallets[4] = 30;
	//wallets[5] = 15;
	//wallets[6] = 13;
	//wallets[7] = 15;
	//wallets[8] = 169;
	//wallets[9] = 130;



	////*meeples = 5;
	////std::cout << meeples << std::endl;
	////for (size_t i = 0; i < walletCount; i++)
	////{
	////	wallets[i] = i;
	////}


	////for (size_t i = 0; i < walletCount; i++)
	////{
	////	std::cout << wallets[i] << std::endl;
	////}


	////need to make sure to delete manually
	////delete meeples;

	////Only delete stack allocated arrays

	//int * noWallets = zeroArray(1000);

	//int total = sum(noWallets, walletCount);
	//std::cout << total;
	////int total = sum(wallets, walletCount);
	////std::cout << total;
	//delete[] wallets;
	//delete[] noWallets;

	////evaluates pointer at location of zero
	//int * something = nullptr;
	//
	//delete something;
	////if something has access to pointer, you need to set them to null

	//if (something != nullptr)
	//{
	//	std::cout << *something << std::endl;
	//}
	//else
	//{
	//	std::cout << "Something was null! BibleThump" << std::endl;
	//}





	while (true)
	{

	}
	return 0;
}