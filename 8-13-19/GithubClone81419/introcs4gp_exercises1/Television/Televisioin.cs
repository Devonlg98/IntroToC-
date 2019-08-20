using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    /// <summary>
    /// The Television class demonstrates a basic class implementation.
    /// </summary>
    class Television
    {
        private int currentChannel;
        private int currentVolume;

        /// <summary>
        /// Increases the current volume of the TV by 1
        /// </summary>
        public void increaseVolume()
        {
            currentVolume++;
        }

        /// <summary>
        /// Decreases the current volume of the TV by 1
        /// </summary>
        public void decreaseVolume()
        {
            currentVolume--;
        }

        /// <summary>
        /// Returns the current volume to the calling code.
        /// </summary>
        public int volume()
        {
            return currentVolume;
        }

        /// <summary>
        /// Increases the channel by 1 step
        /// </summary>
        public void increaseChannel()
        {
            currentChannel++;
        }


        /// <summary>
        /// Decreases the channel by 1 step
        /// </summary>
        public void decreaseChannel()
        {
            currentChannel--;
        }

        // returns the current channel

        /// <summary>
        /// This returns the currently selected channel.
        /// </summary>
        public int channel()
        {
            return currentChannel;
        }
    };
}
