using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Domain.Entities
{
    public class ArtMartial
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Samourai>? Samourais { get; set; }
    }
}
