#pragma once
#include "person.h"
struct person
{
	char name[20];
	int age;
	float cash;
	int killCount;
	
};
float getMoney(person * target, float withdraw);
void erasePerson(person ** target);
