using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Domain.Entities
{
    public class Arme
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public virtual Samourai? Proprietaire { get; set; }
    }
}
