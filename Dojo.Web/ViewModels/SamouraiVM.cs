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

        public SelectList? OptionArmes { get; set; }
    }
}
