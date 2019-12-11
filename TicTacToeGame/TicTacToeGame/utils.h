#pragma once
#include <iostream>
#include <cmath>
#include <string>
#ifndef  _UTILS_H_
#define _UTILS_H_

struct player
{
	int score;
	std::string name;
	int xoro;
	int playerInput;
};
int * printBoard(int * board[], size_t size);
int * resetBoard(int * board[], size_t size);
int * placeBoard(int * board[], size_t size, player player);

bool boardCheckWin(int * board[], size_t size, player player);


#endif // ! _UTILS_H_