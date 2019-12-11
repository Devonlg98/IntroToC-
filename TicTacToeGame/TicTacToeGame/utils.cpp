#include <iostream>
#include "utils.h"
#include <cmath>
#include <string>
#include <algorithm> 

void resetGame(player &targetPlayer)
{
	targetPlayer.score = 0;
	targetPlayer.name = nullptr;
}

//int checkAndReplace(int numbers[3][3], size_t size, int value)
//{
//	int valuePosition = 0 - 1;
//	for (size_t i = 0; i < size; i++)
//	{
//		valuePosition++;
//		if (numbers[i] == value)
//		{
//			value = valuePosition;
//			return value;
//		}
//
//	}
//	return -1;
//}

int * printBoard(int * board[], size_t size)
{
	int boardPos = 0;
	for (int i = 0; i < size; i++)
	{
		for (int idx = 0; idx < size; idx++)
		{

			boardPos++;
			switch (board[i][idx])
			{
			case 1:
				std::cout << "X ";
				break;

			case 2:
				std::cout << "O ";
				break;

			default :
				std::cout << boardPos << " ";
				break;
			}

		}
 		std::cout << std::endl;
	}
	return *board;
}

int * placeBoardX(int * board[], size_t size, int input)
{
	int boardPos = 0;
	for (int i = 0; i < size; i++)
	{
		for (int idx = 0; idx < size; idx++)
		{
			boardPos++;
			if (board[i][idx] = 2)
			{
				input = -1;
				printBoard(board, size);
				system("CLS");
				std::cout << "Spot already filled" << std::endl;
				return *board;
			}
			if (boardPos == input)
			{
				board[i][idx] = 1;
					return *board;
			}
		}
	}
	return *board;
}

int * placeBoardY(int * board[], size_t size, int input)
{
	int boardPos = 0;
	for (int i = 0; i < size; i++)
	{
		for (int idx = 0; idx < size; idx++)
		{
			boardPos++;
			if (board[i][idx] = 1)
			{
				input = -1;
				printBoard(board, size);
				system("CLS");
				std::cout << "Spot already filled" << std::endl;
				return *board;
			}
			if (boardPos == input)
			{
				board[i][idx] = 2;
				return *board;
			}
		}
	}
	return *board;
}

int * zeroArray(size_t length)
{
	int * arr = new int[length];
	for (size_t i = 0; i < length; i++)
	{
		arr[i] = 0;
	}
	return arr;
}



int * resetBoard(int * board[], size_t size)
{
	for (int i = 0; i < size; i++)
	{
		for (int idx = 0; idx < (size); idx++)
		{
			board[i][idx] = 0;
		}
		std::cout << std::endl;
	}
	return *board;
}