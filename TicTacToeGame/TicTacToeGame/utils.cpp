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
				if (boardPos < 10)
				{
					std::cout << " " << "X ";
					break;
				}
				else
				{
					std::cout << "X ";
					break;
				}

			case 2:
				if (boardPos < 10)
				{
					std::cout << " " << "O ";
					break;
				}
				else
				{
				std::cout << "O ";
				break;
				}

			default :
				if (boardPos < 10)
				{
					std::cout <<" " <<boardPos << " ";
					break;
				}
				else 
				{
				std::cout << boardPos << " ";
				break;

				}
			}

		}
 		std::cout << std::endl;
	}
	return *board;
}

int * placeBoard(int * board[], size_t size, player * player)
{

	
	//need to make this not a for loop
	int boardPos = 0;
	for (int i = 0; i < size; i++)
	{
		for (int idx = 0; idx < size; idx++)
		{
			boardPos++;
			if (boardPos == *player->playerInput)
			{
				if (board[i][idx] != 0)
				{
					player.playerInput = -1;
					printBoard(board, size);
					system("CLS");
					std::cout << "Spot already filled" << std::endl;
					return NULL;
				}
				else
				{
				board[i][idx] = player.xoro;
					return *board;

				}
			}

		}
	}
	return *board;
}
//
//int * placeBoard2(int * board[], size_t size, int input)
//{
//	int boardPos = 0;
//	for (int i = 0; i < size; i++)
//	{
//		for (int idx = 0; idx < size; idx++)
//		{
//			boardPos++;
//			if (board[i][idx] == 1)
//			{
//				input = -1;
//				printBoard(board, size);
//				system("CLS");
//				std::cout << "Spot already filled" << std::endl;
//				return *board;
//			}
//			if (boardPos == input)
//			{
//				board[i][idx] = 2;
//				return *board;
//			}
//		}
//	}
//	return *board;
//}
//
//int * zeroArray(size_t length)
//{
//	int * arr = new int[length];
//	for (size_t i = 0; i < length; i++)
//	{
//		arr[i] = 0;
//	}
//	return arr;
//}

bool boardCheckWin(int * board[], size_t size, player player)
{
	//Check for X
	int winCheck = 0;
	//Horizontal Check i ^v idx <>
	for (int i = 0; i < size; i++)
	{
		for (int idx = 0; idx < size; idx++)
		{
			if (board[i][idx] == player.xoro)
			{
				winCheck++;
			}
		}
		//wincheck and reset
		if (winCheck == size)
		{
			player.score++;
			std::cout << std::endl << player.name << " has won!" << std::endl;
			return true;
		}
		else
		{
			winCheck = 0;
		}
		//Vertical check
		for (int idx = 0; idx < size; idx++)
		{
			if (board[idx][i] == player.xoro)
			{
				winCheck++;
			}
		}
		//wincheck and reset
		if (winCheck == size)
		{
			player.score++;
			std::cout << std::endl << player.name << " has won!" << std::endl;
			return true;
		}
		else
		{
			winCheck = 0;
		}
	}

	//Diagonal check top to bottom
	for (int i = 0; i < size; i++)
	{
		if (board[i][i] == player.xoro)
		{
			winCheck++;
		}
	}
	if (winCheck == size)
	{
		player.score++;
		std::cout << std::endl << player.name << " has won!" << std::endl;
		return true;
	}
	else
	{
		winCheck = 0;
	}

	//Diagonal check bottom to top
	for (int i = 0; i < size; i++)
	{
		if (board[size-i-1][size-i-1] == player.xoro)
		{
			winCheck++;
		}
	}
	if (winCheck == size)
	{
		player.score++;
		std::cout << std::endl << player.name << " has won!" << std::endl;
		return true;
	}
	else
	{
		winCheck = 0;
	}

	return false;
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