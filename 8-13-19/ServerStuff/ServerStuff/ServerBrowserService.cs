using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerStuff
{
    struct ServerInfo
    {
       public int regionID;             // region
       public int currentPlayerCount;   // current player count
       public int maxPlayers;           // max player count
       public int ping;                 // ping
    };
    class ServerBrowserService
    {
        // An array of all servers registered with the system.
        private ServerInfo[] servers = new ServerInfo[50]; // note: this is hard-coded for 50 servers
    
        // A count of all servers currently registered.
        private int serverCount;

        // Registers a server with the service
        //returns success if server has been added.
        // no more than 50 servers can be added.
        public bool registerServer(ServerInfo newServer)
        {
            if (serverCount > 49)
                return false;

            servers[serverCount] = newServer;
            serverCount++;
            
            return true;
        }
  
  
        // Copies server entries into the given array.
        // Returns the total 1 of servers provided to the array.
        //Assumes dstArray has 50 elements available
        public int getServers(ref ServerInfo[] dstArray)
        {
            dstArray = new ServerInfo[50];
            int svrsCopied2;
            for (svrsCopied2 = 0; svrsCopied2 < serverCount; svrsCopied2++)
            {
                dstArray[svrsCopied2] = servers[svrsCopied2];
            }
            

            return svrsCopied2;
        }
        public int getServers(ref ServerInfo[] dstArray, int pingLimit)
        {
            dstArray = new ServerInfo[50];
            int svrsCopied2;
            int dstIndex=0;

            for (svrsCopied2 = 0; svrsCopied2 < serverCount; svrsCopied2++)
            {
                dstArray[svrsCopied2] = servers[svrsCopied2];
                dstIndex++;
            }


            return dstIndex;
        }
    };
}
