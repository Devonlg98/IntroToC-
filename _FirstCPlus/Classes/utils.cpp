#include <iostream>
#include "utils.h"
#include <cmath>
#include <algorithm> 


static int currentVolume = 0;

static int currentChannel = 0;


int Television::volume()
{
	return currentVolume;
}

int Television::channel()
{
	return currentChannel;
}

void Television::increaseVolume()
{
	currentVolume++;
}

void Television::decreaseVolume()
{
	currentVolume--;
}


void Television::increaseChannel()
{
	currentChannel++;
}

void Television::decreaseChannel()
{
	currentChannel--;
}



//PIGGYBANK
static float currentBalance = 0;


	//// Add funds to the value of the current balance.
void DigitalPiggyBank::deposit(float net)
{
	currentBalance += net;
}


	//// Returns and clears the total current balance.
float DigitalPiggyBank::withdraw()
{
	float tempCurrentBalance = currentBalance;
	currentBalance = 0;
	return tempCurrentBalance;
}

	//// Returns the current balance of the function.
float DigitalPiggyBank::balance()
{
	return currentBalance;
}


//SERVER
static ServerInfo servers[50];
static int serverCount = 50;

bool ServerBrowserService::registerServer(ServerInfo newServer)
{
	for (int i = 0; i < 50; i++)
	{
		if (servers[i].regionID == NULL)
		{
			servers[i] = newServer;
			break;
		}
	}
	return true;
}

int ServerBrowserService::getServers(ServerInfo * dstArray, size_t dstSize)
{
	int idx = 0;
	for (int i = 0; i < dstSize; i++)
	{
		if (servers[i].regionID != NULL)
		{
			dstArray[idx] = servers[i];
			idx++;
		}
	}
	return idx;
}





int ServerBrowserService::getServers(ServerInfo * dstArray, size_t dstSize, ServerFilter filter)
{
	int idx = 0;
	int filtersOn = 0;
	for (int i = 0; i < dstSize; i++)
	{
		if (filter.maxResults < INT_MAX)
		{
			if (servers[i].regionID != NULL && idx != filter.maxResults)
			{
				dstArray[idx] = servers[i];
			}
			else
			{
				continue;
			}
		}

		if (filter.ping != NULL)
		{
			if (servers[i].regionID != NULL && servers[i].ping < filter.ping)
			{
				dstArray[idx] = servers[i];
			}
			else
			{
				continue;
			}

		}
		if (filter.regionID != NULL)
		{
			if (servers[i].regionID != NULL && servers[i].regionID == filter.regionID)
			{
				dstArray[idx] = servers[i];
			}
			else
			{
				continue;
			}
		}
		//If they don't want empty lobbies, only add servers with a player count above max
		if (filter.allowEmpty == false)
		{
			if (servers[i].regionID != NULL && servers[i].currentPlayerCount > servers[i].maxPlayers)
			{
				dstArray[idx] = servers[i];
			}
			else
			{
				continue;
			}
		}
		//If they don't want full lobbies, only add servers with a player count less than max
		if (filter.allowFull == false)
		{
			if (servers[i].regionID != NULL && servers[i].currentPlayerCount < servers[i].maxPlayers)
			{
				dstArray[idx] = servers[i];
			}
			else
			{

				continue;
			}
		}
		idx++;
	}
	return idx;
}

//int ServerBrowserService::getServersServerInfo * dstArray, size_t dstSize, size_t serverCap)
//{
//	int idx = 0;
//	for (int i = 0; i < dstSize; i++)
//	{
//		if (servers[i].regionID != NULL)
//		{
//			dstArray[idx] = servers[i];
//			idx++;
//		}
//	}
//	return idx;
//}
//
////ping check
//int ServerBrowserService::getServers(ServerInfo * dstArray, size_t dstSize, size_t pingLimit)
//{
//	int idx = 0;
//	for (int i = 0; i < dstSize; i++)
//	{
//		if (servers[i].regionID != NULL)
//		{
//			if (servers[i].ping < pingLimit)
//			{
//			dstArray[idx] = servers[i];
//			idx++;
//			}
//		}
//	}
//	return idx;
//}


