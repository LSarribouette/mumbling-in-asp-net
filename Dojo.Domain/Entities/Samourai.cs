using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Domain.Entities
{
    public class Samourai
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Strength { get; set; }

        // relation one to one
        public virtual Arme? Arme { get; set; }

        // relation manitoumani
        public virtual ICollection<ArtMartial>? ArtsMartiaux { get; set; }

        public int Potential
        {
            get
            {
                int potential = Strength;
                if (Arme != null)
                    potential += Arme.Damage;
                if (ArtsMartiaux != null)
                    potential *= ArtsMartiaux.Count + 1;
                return potential;
            }
        }
    }
}
