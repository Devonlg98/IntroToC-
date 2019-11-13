#include <iostream>

int sum(int * numbers, size_t length)
{
	int total = 0;

	for (size_t i = 0; i < length; i++)
	{
		total += numbers[i];
	}
	return total;
}


//how to return an array
int * zeroArray(size_t length)
{
	int * arr = new int[length];
	for (size_t i = 0; i < length; i++)
	{
		arr[i] = 0;
	}
	return arr;
}

int main()
{
	
	
	//section in memory reserved for a pointer meeples
	int walletCount = 10;
	//int * meeples = new int;
	//Costly to do, but allows for a dynamic array
	int * wallets = new int[walletCount];
	//int wallets[10]; with a static array, it's defined and cannot be changed

	wallets[0] = 5;
	wallets[1] = 3;
	wallets[2] = 5;
	wallets[3] = 69;
	wallets[4] = 30;
	wallets[5] = 15;
	wallets[6] = 13;
	wallets[7] = 15;
	wallets[8] = 169;
	wallets[9] = 130;


	
	//*meeples = 5;
	//std::cout << meeples << std::endl;
	//for (size_t i = 0; i < walletCount; i++)
	//{
	//	wallets[i] = i;
	//}


	//for (size_t i = 0; i < walletCount; i++)
	//{
	//	std::cout << wallets[i] << std::endl;
	//}


	//need to make sure to delete manually
	//delete meeples;

	//Only delete stack allocated arrays
	
	int * noWallets = zeroArray(1000);
	
	int total = sum(noWallets, walletCount);
	std::cout << total;
	//int total = sum(wallets, walletCount);
	//std::cout << total;
	delete[] wallets;
	delete[] noWallets;

	//evaluates pointer at location of zero
	int * something = nullptr;
	*something = 55;
	delete something;
	//if something has access to pointer, you need to set them to null

	if (something != nullptr)
	{
		std::cout << *something << std::endl;
	}
	else
	{
		std::cout << "Something was null! BibleThump" << std::endl;
	}


	while (true)
	{

	}
	return 0;
}