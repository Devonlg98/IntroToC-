#pragma once
#include <iostream>
#include <cmath>
#ifndef  _UTILS_H_
#define _UTILS_H_

//Television
class Television
{
private:
	int currentChannel;
	int currentVolume;

public:
	void increaseVolume();    // increases the volume by one
	void decreaseVolume();    // decreases the volume by one

	int volume();             // returns the current volume

	void increaseChannel();   // increases the channel num by one
	void decreaseChannel();   // decreases the channel num by one

	int channel();			  // returns the current channel
};


//Piggy
class DigitalPiggyBank
{
private:
	// Maintains the current balance of the piggy bank.
	float currentBalance;
public:
	// Add funds to the value of the current balance.
	void deposit(float net);

	// Returns and clears the total current balance.
	float withdraw();

	// Returns the current balance of the function.
	float balance();
};


//Server
struct ServerInfo
{
	int regionID;             // region
	int currentPlayerCount;   // current player count
	int maxPlayers;           // max player count
	int ping;                 // ping
};

struct ServerFilter
{
	int maxResults = INT_MAX;
	int ping = INT_MAX;                
	int regionID = NULL;
	bool allowEmpty = true;
	bool allowFull = true;
};


class ServerBrowserService
{
private:
	// An array of all servers registered with the system.
	ServerInfo servers[50]; // note: this is hard-coded for 50 servers

	// A count of all servers currently registered.
	int serverCount;
public:
	// Registers a server with the service
	bool registerServer(ServerInfo);

	// Copies server entries into the given array.
	// Returns the total number of servers provided to the array.
	int getServers(ServerInfo * , size_t);
	int getServers(ServerInfo *, size_t, ServerFilter);

};
#endif // ! _UTILS_H_