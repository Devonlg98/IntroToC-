#include <iostream>
#include "utils.h"
#include <cmath>
#include <algorithm> 

float calcPiggyBankNotes(piggyBank piggy)
{
	return (float)(piggy.oneDollarBills + (piggy.twoDollarBills * 2) + (piggy.fiveDollarBills * 5));
}

float calcPiggyBankCoins(piggyBank piggy)
{
	return (float)(piggy.pennies + (piggy.nickles * 5) + (piggy.dimes * 10) + (piggy.quarters * 25))/100;
}

float calcPiggyBankTotal(piggyBank piggy)
{
	return (float)(calcPiggyBankNotes(piggy) + calcPiggyBankCoins(piggy));
}

void studentPrint(student student)
{
	std::cout << "Here is information for the following student " << student.name << "\n" << 
		"Student ID: " << student.id << "\n"
		"Enrolled Course: " << student.course << "\n"
		"last Exam Score: " << student.lastExam << "\n";
}

float studentAverageTest(student school[], size_t size)
{
	float total = 0;
	for (size_t i = 0; i < size; i++)
	{
		total += school[i].lastExam;
	}
	return total/size;
}

float studentMedianTest(student school[], size_t size)
{
	

	int * medianArray = new int[size];
	int n = sizeof(medianArray) / sizeof(medianArray[0]);
	for (size_t i = 0; i < size; i++)
	{
		medianArray[i] = school[i].lastExam;
	}
	std::sort(medianArray, medianArray + n);
	//median should bed 36 for the 4
	if ((size % 2) == 0)
	{
		float median = (((float)medianArray[(size / 2)] + (float)medianArray[(size / 2) + 1]) / 2);
		return median;
	}
	else
	{
		return (float)medianArray[(int)((size / 2)+1)];
	}
}

float studentTotalEnroll(student school[], size_t size, int course)
{
	float total = 0;
	for (size_t i = 0; i < size; i++)
	{
		if (course == school[i].course)
		{
			total += 1;
		}
	}
	return total;
}

vector2 vector2Sum(vector2 vec1,vector2 vec2)
{
	return { (vec1.x + vec2.x), (vec1.y + vec2.y) };
}

vector2 vector2Difference(vector2 vec1, vector2 vec2)
{
	return { (vec1.x - vec2.x), (vec1.y - vec2.y) };
}

float vector2Distance(vector2 vec1, vector2 vec2)
{
	return sqrt(pow(vec2.x - vec1.x, 2) + pow(vec2.y - vec1.y, 2));
}