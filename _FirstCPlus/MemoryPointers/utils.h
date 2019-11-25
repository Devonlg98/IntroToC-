#pragma once
#include <iostream>
#include <cmath>
#ifndef  _UTILS_H_
#define _UTILS_H_
int sum(int * , size_t);
int * zeroArray(size_t);
void printFloats(float *, size_t);
int arraySum(int *, size_t);
void initBools(bool *, size_t, bool);
void iLoveNumbers();
int * duplicateArray(int *, size_t);
void printInts(int *, size_t);
int * duplicateSubArray(int *, size_t, int, int);
void printChars(char *, size_t);
int  pointerToElement(char *, size_t, char, bool);
void swappingPointers(int, int, int*, int*);


#endif // ! _UTILS_H_