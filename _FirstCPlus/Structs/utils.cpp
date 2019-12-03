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

void playerVsZombie(player player, zombie zombie)
{

	for (int i = 0; player.healthPoints > 0; i++)
	{

		int playerDamage = (rand() % 3)+player.attackPoints;
		if (playerDamage > zombie.defensePoints)
		{
		zombie.healthPoints -= playerDamage;
		std::cout << "The player swings at the zombie doing " << playerDamage << " damage to the zombie.The zombie has "<< zombie.healthPoints<< " health points." << std::endl;
		}
		if (zombie.healthPoints < 1)
		{
			std::cout << "The player slayed the zombie" << std::endl;
			break;
		}
		int zombieDamage = (rand() % 3) + zombie.attackPoints;
		if (zombieDamage > player.defensePoints)
		{
		player.healthPoints -= zombieDamage;
		std::cout << "The zombie swings back doing " << zombieDamage << " damage to the player. The player has " << player.healthPoints <<" health points." << std::endl;

		}
		if (player.healthPoints < 1)
		{
			std::cout << "The zombie slayed the player" << std::endl;
			break;
		}
	}
}

int highScoreIndex(highScoreData arrayScore[], size_t size)
{
	int highestScorePosition = 0;
	int highestScore = 0;
	for (size_t i = 0; i < size; i++)
	{
		if (arrayScore[i].highScore > highestScore)
		{
		highestScore = arrayScore[i].highScore;
		highestScorePosition = i;
		}
	}
	return highestScorePosition;
}

int highScoreAvgCompletion(highScoreData arrayScore[], size_t size)
{
	int averageTime = 0;
	for (size_t i = 0; i < size; i++)
	{
		averageTime += arrayScore[i].timeToComplete;
	}
	return averageTime / size;
}

void highSchoreArrayTopScores(highScoreData arrayScore[], highScoreData emptyArray[], size_t size, size_t newArrayLength)
{
	int highestscore = 0;
	//loop for whole highscoredata array
	for (int i = 0; i < size; i++)
	{
		//array for length of new array
		for (int idx = 0; idx < newArrayLength; idx++)
		{
			//if highscore is higher than emptyArrays highscore, move all scores down one and replace the current score.
			if (arrayScore[i].highScore >= emptyArray[idx].highScore)
			{
				for (int idxx = newArrayLength; idxx >idx; idxx--)
				{
					emptyArray[idxx].highScore = emptyArray[idxx - 1].highScore;
				}
				emptyArray[idx].highScore = arrayScore[i].highScore;
				idx = newArrayLength;
			}
		}
	}
}

int highSchoreDifference(highScoreData arrayScore[],int nScore, size_t size)
{
	int difference = 0;
	//loop for whole highscoredata array
	int highScorePos = highScoreIndex(arrayScore, size);
	difference = arrayScore[nScore].highScore - arrayScore[highScorePos].highScore;
	return abs(difference);
}

playerRNG * playerRandomizerGenerator(size_t size)
{

	playerRNG * rngArray = new playerRNG[size];
	for (size_t i = 0; i < size; i++)
	{
		rngArray[i].attack = rand() % 100;
		rngArray[i].defense = rand() % 100;
		rngArray[i].experience = rand() % 100;
	}
	return rngArray;
}

void playerPrint(playerRNG rngArray[], size_t size)
{
	for (int i = 0; i < size; i++)
	{
		std::cout << "Player " << i + 1 << " has: " << std::endl;
		std::cout << "Attack: " << rngArray[i].attack << std::endl;
		std::cout << "Defense: " << rngArray[i].defense << std::endl;
		std::cout << "Experience: " << rngArray[i].experience << std::endl;
	}
}

bool addItem(playerRNG * recepient, items gift)
{
	for (int i = 0; i < 9; i++)
	{
		if (recepient->pop[i].id == gift.id)
		{
			std::cout << "You already have this item!" << std::endl;
			return false;
		}
		else if (recepient->pop[i].id == NULL)
		{
			recepient->pop[i].id = gift.id;
			recepient->pop[i].gold = gift.gold;
			return true;
		}
	}
}

bool hasItem(playerRNG * holder, items gift)
{
	for (int i = 0; i < 9; i++)
	{
		if (holder->pop[i].id == gift.id)
		{
			std::cout << "They do have this item" << std::endl;
			return true;
		}
	}
	std::cout << "They do not have this item" << std::endl;
	return false;
}

float totalValue(playerRNG * holder)
{
	int	total = 0;
	for (int i = 0; i < 9; i++)
	{
		if (holder->pop[i].id != NULL)
		{
			total += holder->pop[i].gold;
		}
	}
	return total;
}