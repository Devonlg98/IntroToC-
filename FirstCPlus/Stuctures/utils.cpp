#include "person.h"
#include <iostream>

float getMoney(person * target, float withdraw)
{
	float loss = target->cash < withdraw ? target->cash : withdraw;

	(*target).cash -= loss;

	return loss;
}

// erase the pointer using a pointer to a pointer, by setting it null
void erasePerson(person ** target)
{
	(*target) = nullptr;

}

//float getMoney(person target, float withdraw)
//{
//	float loss = target.cash < withdraw ? target.cash : withdraw;
//
//	target.cash -= loss;
//
//	return loss;
//}