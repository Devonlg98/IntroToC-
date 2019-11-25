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

	while (true)
	{

	}
}