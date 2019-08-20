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
            currentVolume ++;
        }

        // decreases the volume by one
        public void decreaseVolume()
        {
            currentVolume --;
        }

        // // returns the current volume
        public int volume()
        {
            return currentVolume;
        }

        // increases the channel num by one
        public void increaseChannel()
        {
            currentChannel ++;
        }

        // decreases the channel num by one
        public void decreaseChannel()
        {
            currentChannel--;
        }

        // returns the current channel
        public int channel()
        {
            return currentChannel;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Television volume = new Television(); 
                Console.WriteLine(volume.currentVolume);
                volume.increaseVolume();
                Console.WriteLine(volume.currentVolume);
                Television channel = new Television();
                Console.WriteLine(volume.currentChannel);
                channel.increaseChannel();
                Console.WriteLine(volume.currentChannel);
                Console.ReadKey();
            }
        }
    };
}
