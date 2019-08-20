using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    class Television
    {
        private int currentChannel = 0;
        private int currentVolume = 0;

        // increases the volume by one
        public void increaseVolume()
        {
            Console.WriteLine(currentVolume + 1);
        }

        // decreases the volume by one
        public void decreaseVolume()
        {
            Console.WriteLine(currentVolume - 1);
        }

        // // returns the current volume
        public int volume()
        {
            return currentVolume;
        }

        // increases the channel num by one
        public void increaseChannel()
        {
            Console.WriteLine(currentChannel + 1);
        }

        // decreases the channel num by one
        public void decreaseChannel()
        {
            Console.WriteLine(currentChannel - 1);
        }

        // returns the current channel
        public int channel()
        {
            return currentChannel;
        }

    };
}
