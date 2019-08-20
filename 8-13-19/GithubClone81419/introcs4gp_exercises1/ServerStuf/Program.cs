using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespaces silo your code so you can be sure
//than things like Class names don't clash with
//other peoples code in larger proejcts.
namespace ServerStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we'll create an instance of our
            //Server browser service object so we can interact with it.
            ServerBrowserService sbs = new ServerBrowserService();
            //Here we will create a utility instance of the ServerInfo struct
            ServerInfo s1;
            //And then populate it
            s1.regionID = 1;
            s1.ping = 2;
            s1.maxPlayers = 10;
            s1.currentPlayerCount = 5;

            //Now we will register this ServerInfo instance with our browser service.
            sbs.registerServer(s1);
            //Because the SBS has an array of ServerInfo objects into which
            //it places a COPY of the data sent in the parameter,
            //what we do with s1 out here, will have ZERO impact on the data inside Sbs.
            //So we can repurpose s1 for the next server to add and so on...
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

            s1.regionID = 8;
            s1.ping = 5;
            s1.maxPlayers = 15;
            s1.currentPlayerCount = 10;
            sbs.registerServer(s1);

            //Now we call the 2 versions of the getServers Method
            //on our SBS to obtain a copy of the data from within the sbs
            ServerInfo[] tmpOp = new ServerInfo[0];
            //we need to tell the getServers method(s) where to place the
            //filtered / retrieved data by declaring and initializing the
            //tmpOp object (an initial array of ServerInfo objects
            //This 0 length array will be discarded within getServers.
            //
            //The ref keyword in the method call lets the compiler know
            //that this variable will be updatable from within the method
            //and those changes will persist when the method returns.
            //This works well in this scenario because we want to also know
            //howmany servers are returned in the array by returning an int
            //into the NumberSvrs and NumberSvrs2 variables.
            int NumberSvrs = sbs.getServers(ref tmpOp);

            int NumberSvrs2 = sbs.getServers(ref tmpOp,10);


        }
    }
}
