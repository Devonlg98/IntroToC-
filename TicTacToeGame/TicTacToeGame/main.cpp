#include <iostream>
#include <string>
#include "utils.h"
using std::cout;
using std::endl;
using std::cin;
using std::string;

int main()
{
	int ticTacToeArray[3][3] = { {1,2,3}, {4,5,6}, {7,8,9} };
	int userInputInt;
	string userInputString;
	bool gameOn = true;
	player player1;
	player player2;
	cout << "how big would you like the tictactoe to be? x by x?" << endl;
	//cout << " " << ticTacToeArray[0][0] << " | " << ticTacToeArray[0][1] << " | " << ticTacToeArray[0][2] << endl
	//	<< "-----------" << endl
	//	<< " " << ticTacToeArray[1][0] << " | " << ticTacToeArray[1][1] << " | " << ticTacToeArray[1][2] << endl
	//	<< "-----------" << endl << " " << ticTacToeArray[2][0] << " | " << ticTacToeArray[2][1] << " | " << ticTacToeArray[2][2] << endl;
	cin >> userInputInt;
	int sizeY = userInputInt;
	int sizeX = userInputInt;
	int **board = new int*[sizeY];
	for (int i = 0; i < sizeY; ++i) 
	{
		board[i] = new int[sizeX];
	}
	system("CLS");
	int boardSize = userInputInt;
	resetBoard(board, boardSize);
	printBoard(board, boardSize);

	std::cin.clear();
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	cout << "Player 1, what is your name?" << endl;
	cin >> userInputString;
	system("CLS");
	player1.name = userInputString;

	std::cin.clear();
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	cout << "Player 2, what is your name?" << endl;
	cin >> userInputString;
	system("CLS");
	player2.name = userInputString;

	while (gameOn)
	{
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cout << player1.name << ", do you want X's or O's? type 1 for X, 2 for O" << endl;
		cin >> userInputInt;
		switch (userInputInt)
		{
		case 1:
			player1.xoro = 1;
			player2.xoro = 2;
			gameOn = false;
			break;

		case 2:
			player1.xoro = 2;
			player2.xoro = 1;
			gameOn = false;
			break;

		default:
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			cout << "Incorrect Input" << endl << player1.name << " do you want X's or O's? type 1 for X, 2 for O" << endl;
			cin >> userInputInt;
			continue;
		}
	}
	gameOn = true;
	while (gameOn)
	{
		system("CLS");
		printBoard(board, boardSize);
		//player 1
		player1.playerInput = -1;

		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cout << "Pick a space, 1 through 9 " << player1.name << endl;
		cin >> player1.playerInput;
		placeBoard(board, boardSize, player1);
		while (player1.playerInput < 1 || player1.playerInput > boardSize*boardSize)
		{
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			cout << "Incorrect Input, try again!" << endl << "Pick a space, 1 through 9 " << player1.name << endl;
			cin >> player1.playerInput;
			placeBoard(board, boardSize, player1);



			if(placeBoard(board, boardSize, player1)== NULL)
			{
				player1.playerInput = -1;
			}
		}

		system("CLS");
		printBoard(board, boardSize);
		//check win for p1
		if (boardCheckWin(board, boardSize, player1) == true)
		{
			break;
		}

		//player 2
		player2.playerInput = -1;

		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cout << "Pick a space, 1 through 9 " << player2.name << endl;
		cin >> player2.playerInput;
		placeBoard(board, boardSize, player2);
		while (player2.playerInput < 1 || player2.playerInput > boardSize*boardSize)
		{
			std::cin.clear();
			std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			cout << "Incorrect Input, try again!" << endl << "Pick a space, 1 through 9 " << player2.name << endl;
			cin >> player2.playerInput;
			placeBoard(board, boardSize, player2);
			if (placeBoard(board, boardSize, player2) == NULL)
			{
				player2.playerInput = -1;
			}
		}
		system("CLS");
		printBoard(board, boardSize);
		//check win for p2
		if (boardCheckWin(board, boardSize, player2) == true)
		{
			break;
		}
	}






	//std::cin.clear();
	//std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	//cout << "Pick a space, 1 through 9" << endl;
	//cin >> userInput;
	//system("CLS");
	//placeBoardX(board, boardSize, userInput);

	//printBoard(board, boardSize);
	//std::cin.clear();
	//std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	//cout << "Pick a space, 1 through 9" << endl;
	//cin >> userInput;
	//system("CLS");
	//placeBoardX(board, boardSize, userInput);
	//printBoard(board, boardSize);
	//std::cin.clear();
	//std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	//cout << "Pick a space, 1 through 9" << endl;
	//cin >> userInput;
	//placeBoardX(board, boardSize, userInput);


	for (int i = 0; i < sizeY; ++i) {
		delete[] board[i];
	}
	delete[] board;


	while (true)
	{

	}
	return 0;
}