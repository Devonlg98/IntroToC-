using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{
    class Wolf : Pet
    {

        int wolfUpgrade = 0;
        int wolfHunger = 0;
        string wolfName;
        public Wolf(int v1, int v2, string v3)
        {
            PType = PetType.Wolf;
            this.wolfUpgrade = v1;
            this.wolfHunger = v2;
            this.wolfName = v3;
        }
    }
}
