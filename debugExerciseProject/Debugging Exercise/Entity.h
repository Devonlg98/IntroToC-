#pragma once
class Entity
{
public:
	Entity();
	~Entity();

	int attack();
	void takeDamage(int damage);
	bool isAlive();

private:
	int health;
	int maxHealth;
};

