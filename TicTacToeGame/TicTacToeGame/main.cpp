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
	int userInput;
	bool gameOn = true;
	cout << "how big would you like the tictactoe to be? x by x?" << endl;
	//cout << " " << ticTacToeArray[0][0] << " | " << ticTacToeArray[0][1] << " | " << ticTacToeArray[0][2] << endl
	//	<< "-----------" << endl
	//	<< " " << ticTacToeArray[1][0] << " | " << ticTacToeArray[1][1] << " | " << ticTacToeArray[1][2] << endl
	//	<< "-----------" << endl << " " << ticTacToeArray[2][0] << " | " << ticTacToeArray[2][1] << " | " << ticTacToeArray[2][2] << endl;
	cin >> userInput;
	int sizeY = userInput;
	int sizeX = userInput;
	int **board = new int*[sizeY];
	for (int i = 0; i < sizeY; ++i) 
	{
		board[i] = new int[sizeX];
	}
	system("CLS");
	int boardSize = userInput;
	resetBoard(board, boardSize);
	printBoard(board, boardSize);

	while (gameOn)
	{
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cout << "Pick a space, 1 through 9 Player 1" << endl;
		cin >> userInput;
		system("CLS");
		placeBoardX(board, boardSize, userInput);
		while (userInput == -1)
		{
				std::cin.clear();
				std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
				cout << "Pick a space, 1 through 9 Player 1" << endl;
				cin >> userInput;
				placeBoardX(board, boardSize, userInput);

		}

		printBoard(board, boardSize);
		std::cin.clear();
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cout << "Pick a space, 1 through 9 Player 2" << endl;
		cin >> userInput;
		system("CLS");
		placeBoardY(board, boardSize, userInput);
		printBoard(board, boardSize);

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