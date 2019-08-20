using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerStuff
{
    class Program
    {

        static void Main(string[] args)
        {
            ServerBrowserService sbs = new ServerBrowserService();
            ServerInfo s1;
            s1.regionID = 1;
            s1.ping = 2;
            s1.maxPlayers = 10;
            s1.currentPlayerCount = 5;
            sbs.registerServer(s1);

            s1.regionID = 8;
            s1.ping = 6;
            s1.maxPlayers = 15;
            s1.currentPlayerCount = 10;
            sbs.registerServer(s1);

            s1.regionID = 8;
            s1.ping = 16;
            s1.maxPlayers = 15;
            s1.currentPlayerCount = 10;
            sbs.registerServer(s1);

            ServerInfo[] tmpOp = new ServerInfo[0];
            int NumberSvrs = sbs.getServers(ref tmpOp);
            int NumberSvrs2 = sbs.getServers(ref tmpOp, 10);

        }
    }
}
