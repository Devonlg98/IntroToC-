using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionTeach2
{
        class Television
     {
            private int currentChannel;
            private int currentVolume;

            // increases the volume by one
            public void increaseVolume()
            {
                currentVolume++;
            }

            // decreases the volume by one
            public void decreaseVolume()
            {
                currentVolume--;
            }

            // // returns the current volume
            public int volume()
            {
                return currentVolume;
            }

            // increases the channel num by one
            public void increaseChannel()
            {
                currentVolume++;
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
     };
}
