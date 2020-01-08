#pragma once
#pragma once
#include <iostream>
#include <cmath>
#include <fstream>
#ifndef  _UTILS_H_
#define _UTILS_H_
bool testWrite(std::string filePath, std::string message);
std::string testRead(std::string filePath);
struct Library
{
	char callNumber[32];
	char title[32];
	char author[32];
	char bookStatus[32];
	char dueDate[32];
	char borrowersName[32];

};

#endif // ! _UTILS_H_
