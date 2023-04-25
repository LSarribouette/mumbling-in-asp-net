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

        public virtual Arme? Arme { get; set; }
    }
}
