#include <iostream>
#include "utils.h"
using std::cout;
using std::endl;


int main()
{

	//Piggy Bank defining and helper functions
	piggyBank money = { 1, 2, 3, 4, 5, 6, 7 };
	cout <<
		"you have " << money.oneDollarBills << " one dollar bills. \n"
		"you have " << money.twoDollarBills << " two dollar bills. \n"
		"you have " << money.fiveDollarBills << " five dollar bills. \n"
		"you have " << money.pennies << " pennies. \n"
		"you have " << money.nickles << " nickles. \n"
		"you have " << money.dimes << " dimes. \n"
		"you have " << money.quarters << " quarters. \n"
		"your total bills add up to $" << calcPiggyBankNotes(money) << "\n"
		"your total coins add up to $" << calcPiggyBankCoins(money) << "\n"
		"your total money is $" << calcPiggyBankTotal(money) << "\n";

	//Student print and analytics
	student Joseph = { "Joseph",12007, 2, 29 };
	student Sam = { "Sam",12008, 2, 32 };
	student Devon = { "Devon", 12009, 1, 41 };
	student Bel = { "Bel",12006, 1, 45 };
	student Colin = { "Colin", 12010, 1, 47 };
	studentPrint(Bel);
	studentPrint(Joseph);
	studentPrint(Sam);
	studentPrint(Devon);
	studentPrint(Colin);
	student school[5] = { Bel, Joseph, Sam, Devon, Colin};
	cout << "The school average test score is " << studentAverageTest(school, 5) << endl;
	cout << "The school median test score is " << studentMedianTest(school, 5) << endl;
	cout << "The total people enrolled in 2 is " << studentTotalEnroll(school, 5, 2) << endl;

	//Vector2D
	vector2 test = { 5, 10 };
	vector2 test2 = { 4, -3 };
	
	vector2 sum = vector2Sum(test, test2);
	vector2 difference = vector2Difference(test, test2);
	float distance = vector2Distance(test, test2);
	cout << "The Vector sum is (" << sum.x << ", " << sum.y << ")" << endl;
	cout << "The Vector difference is (" << difference.x << ", " << difference.y << ")" << endl;
	cout << "The Vector distance is " << distance << endl;


	//Player vs Zombie
	player ValveIndex = { 10,3,5 };
	zombie Bills = { 10,4,1 };


	playerVsZombie(ValveIndex, Bills);


	//HighScore Data
	highScoreData DOX = { 10, 60 };
	highScoreData DLG = { 100, 35 };
	highScoreData CLR = { 55, 45 };
	highScoreData BEL = { 120, 20 };
	highScoreData CHF = { 35, 120 };
	highScoreData PAN = { 15, 84 };
	highScoreData pennyArcade[6] = { DOX, DLG, CLR, BEL, CHF, PAN };
	highScoreData pennyArcadeFake[3];

	std::cout << "The position of the highest score is at "<< highScoreIndex(pennyArcade, 6)<< " index." << std::endl;
	std::cout << "The average time completion is " << highScoreAvgCompletion(pennyArcade, 6) << "." << std::endl;

	highSchoreArrayTopScores(pennyArcade, pennyArcadeFake, 6, 3);
	for (int i = 0; i < 3; i++)
	{
		std::cout << pennyArcadeFake[i].highScore << std::endl;
	}
	std::cout << "The difference between the highest score and the nth score is " << highSchoreDifference(pennyArcade, 1, 6) << "."<<std::endl;



	//Player Randomizer Generator
	//playerPrint(playerRandomizerGenerator(10), 10);
	//playerRNG * dndGroup[10];
	//dndGroup[10] = playerRandomizerGenerator(10);
	////dndGroup[1]->attack;
	//
	//items pie = { 1234, 100 };
	//addItem(dndGroup[0], pie);
	//std::cout << dndGroup[0]->items;

	playerRNG coolerNPC = { 100,100,100 };
	playerRNG * coolNPC = &coolerNPC;
	
	items pie = { 1234, 100 };
	items pork = { 1235, 120 };
	items apple = { 1236, 40 };
	addItem(coolNPC, pie);
	addItem(coolNPC, pork);
	addItem(coolNPC, apple);
	hasItem(coolNPC, apple);
	std::cout << "The total value of their items is "<< totalValue(coolNPC)<< std::endl;
	while (true)
	{

	}
}