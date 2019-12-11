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
};
int * printBoard(int * board[], size_t size);
int * resetBoard(int * board[], size_t size);
int * placeBoardX(int * board[], size_t size, int input);
int * placeBoardY(int * board[], size_t size, int input);

#endif // ! _UTILS_H_