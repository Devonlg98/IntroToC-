#include <iostream>
#include "utils.h"
using std::cout;
using std::endl;

	Television tv;
	DigitalPiggyBank piggy;
	ServerBrowserService server;

int main()
{

	//Television
	std::cout << tv.channel();
	std::cout << tv.volume();
	tv.increaseChannel();
	tv.increaseChannel();
	tv.increaseChannel();
	tv.increaseVolume();
	tv.increaseVolume();
	std::cout << tv.channel();
	std::cout << tv.volume();


	//PiggyBank
	cout << piggy.balance() << endl;
	piggy.deposit(300);
	cout << piggy.balance() << endl;
	piggy.withdraw();
	cout << piggy.balance() << endl;


	//Servers
	ServerInfo haloReachPC1 = {1, 16, 16, 36};
	ServerInfo haloReachPC2 = { 2, 16, 16, 182 };
	ServerInfo haloReachPC3 = { 3, 9, 16, 42 };
	ServerInfo haloReachPC4 = { 1, 15, 16, 52 };
	ServerInfo haloReachPC5 = { 2, 15, 16, 32 };
	ServerInfo haloReachPC6 = { 1, 14, 16, 48 };
	server.registerServer(haloReachPC1);
	server.registerServer(haloReachPC2);
	server.registerServer(haloReachPC3);
	server.registerServer(haloReachPC4);
	server.registerServer(haloReachPC5);
	server.registerServer(haloReachPC6);
	ServerInfo haloServers[6] = { haloReachPC1,haloReachPC2,haloReachPC3,haloReachPC4,haloReachPC5,haloReachPC6 };
	cout<< "The current active servers for halo Reach on PC are "<< server.getServers(haloServers, 6)<< endl;
	ServerFilter filterPreferred = { 5, 50, 1, true, false };
	cout << "The current active servers for halo Reach on PC are " << server.getServers(haloServers, 6, filterPreferred) << endl;


	while (true)
	{

	}
	return 0;
}