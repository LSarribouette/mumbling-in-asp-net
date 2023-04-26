using Dojo.Domain.Entities;
using Dojo.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Dojo.Web.ViewModels
{
    public class SamouraiVM
    {
        public Samourai Samourai { get; set; }

        [DisplayName("Arme")]
        public int? IdArme { get; set; }

        [DisplayName("Arts martiaux maîtrisés")]
        public List<int> IdsArts { get; set; } = new List<int>();

        public SelectList? OptionArmes { get; set; }

        public SelectList? OptionArtsMartiaux { get; set; }
    }
}
