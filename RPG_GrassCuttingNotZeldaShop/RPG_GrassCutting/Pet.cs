using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{

    enum PetType { Wolf, Fox };

    class Pet
    {

        public PetType PType;
        public void HeadPat()
        {
            Console.WriteLine($"You pet your {PType}");
        }
    }
}
