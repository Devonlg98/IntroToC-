#pragma once

class Marine
{
public:
	Marine();
	~Marine();

	int health;
	int attack();
	void takeDamage(int damage);

};

