using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{
    class Fox : Pet
    {
        int foxUpgrade = 0;
        int foxHealth = 0;
        string foxName;
        public Fox(int v1, int v2, string v3)
        {
            PType = PetType.Fox;
            this.foxUpgrade = v1;
            this.foxHealth = v2;
            this.foxName = v3;
        }
    }
}
