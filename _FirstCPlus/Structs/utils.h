#pragma once
#include <iostream>
#include <cmath>
#ifndef  _UTILS_H_
#define _UTILS_H_
struct piggyBank
{
	int oneDollarBills;
	int twoDollarBills;
	int fiveDollarBills;
	int pennies;
	int nickles;
	int dimes;
	int quarters;
};

struct student
{
	char name[35];
	int id;
	int course;
	int lastExam;
};

struct vector2
{
	float x;
	float y;
};

float calcPiggyBankNotes(piggyBank);
float calcPiggyBankCoins(piggyBank);
float calcPiggyBankTotal(piggyBank);
void studentPrint(student);
float studentAverageTest(student[], size_t);
float studentMedianTest(student[], size_t);
float studentTotalEnroll(student[], size_t, int);
vector2 vector2Sum(vector2 vec1, vector2 vec2);
vector2 vector2Difference(vector2, vector2);
float vector2Distance(vector2, vector2);



#endif // ! _UTILS_H_