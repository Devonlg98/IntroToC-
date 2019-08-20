using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerStuff
{
    /// <summary>
    /// This is a basic structure which is used to hold 4 integers.
    /// </summary>
    struct ServerInfo
    {
        public int regionID;             // region
        public int currentPlayerCount;   // current player count
        public int maxPlayers;           // max player count
        public int ping;                 // ping
    };

    /// <summary>
    /// The Server Browser Service is a basic class we're using
    /// to maintain a list of servers, and to provide various filetered
    /// lists of thos servers.
    /// </summary>
    class ServerBrowserService
    {
        // An array of all servers registered with the system.
        // Because this is marked as PRIVATE we can be confident that
        // other code won't be able to directly access this data.
        // unless methods within the SBS provide that access.
        private ServerInfo[] servers = new ServerInfo[50];
        // note: this is hard-coded for 50 servers
        // A C# array is unmutable ie unchangable (except for throwing it away
        // and restarting it.
        // So this 'servers' variable won't be able to contain more than 50 elements
        // NB: An element in an array is an individual INSTANCE of the type
        // that the array is initialized as. So in this example
        // our 'servers' array contains space for 50 instances of ServerInfo.

        /// <summary>
        /// Servercount.A count of all servers currently registered.
        /// This provides a way for us to
        ///          1) Provide a bookmark to where we're going to insert the next serverinfo
        ///          2) A total of how many servers have been added to the servers array.
        /// </summary>
        private int serverCount;

        /// <summary>
        /// 
        /// Registers a server with the service
        /// Returns true if server has been added.
        /// No more than 50 servers can be added.
        /// </summary>
        /// <param name="newServer"></param>
        /// <returns></returns>
        public bool registerServer(ServerInfo newServer)
        {
            if (serverCount > 49)
                return false;
            servers[serverCount] = newServer;
            serverCount++;
            return true;
        }

        /// <summary>
        /// Copies server entries into the given array.
        /// Returns the total number of servers provided to the array.
        /// </summary>
        /// <param name="dstArray"></param>
        /// <returns></returns>        
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










        /// <summary>
        /// Copies server entries into the given array.
        /// Filtered by the pingLimit parameter.
        /// Returns the total number of servers provided to the array.
        /// </summary>
        /// <param name="dstArray"></param>
        /// <returns></returns>  
        public int getServers(ref ServerInfo[] dstArray, int pingLimit)
        {
            dstArray = new ServerInfo[50];
            int svrsCopied;
            int dstIndex = 0;
            for (svrsCopied = 0; svrsCopied < serverCount; svrsCopied++)
            {
                if (servers[svrsCopied].ping < pingLimit)
                {
                    dstArray[dstIndex] = servers[svrsCopied];
                    dstIndex++;
                }
            }

            return dstIndex;
        }

    };
}
