using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{
    class JobUpgrade
    {
        public int price = 0;
        public int jobUpgrade = 0;
        public string jobUpgradeName;
        public string upgradeDescription;
        public bool finalWeapon = false;

        public JobUpgrade(int v1, int v2, string v3, string v4, bool v5)
        {
            this.price = v1;
            this.jobUpgrade = v2;
            this.jobUpgradeName = v3;
            this.upgradeDescription = v4;
            this.finalWeapon = v5;
        }
        //Note to self add MasterSword and HylianLawnMower
    }
}
