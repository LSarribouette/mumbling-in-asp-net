using Dojo.Domain.Entities;
using Dojo.Domain.Services;
using Dojo.Infrastructure.Repositories;
using Dojo.Web.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Dojo.Web.Mappings
{
    public class SamouraiMapping
    {
        //public static List<SamouraiVM> ToVM(List<SamouraiVM> samouraisToConvert, List<Arme> availableArmes)
        //{
        //    // old school : auto mapper (NuGet)
        //    List<SamouraiVM> samouraiVMs = new List<SamouraiVM>();
        //    foreach (var samourai in samouraisToConvert)
        //    {
        //        samouraiVMs.Add(ToVM(samourai));
        //    }
        //    return samouraiVMs;
        //}

        public static SamouraiVM ToVM(Samourai samourai, List<Arme> availableArmes, List<ArtMartial> availableArts)
        {
            SamouraiVM samouraiVM = new SamouraiVM();
            samouraiVM.Samourai = new Samourai();
            samouraiVM.Samourai.Id = samourai.Id;
            samouraiVM.Samourai.Name = samourai.Name;
            samouraiVM.Samourai.Strength = samourai.Strength;
            samouraiVM.IdArme = samourai.Arme?.Id;
            samouraiVM.IdsArts = samourai.ArtsMartiaux?.Select(i => i.Id).ToList();
            samouraiVM.OptionArmes = new SelectList(availableArmes, "Id", "Name", "Damage");
            samouraiVM.OptionArtsMartiaux = new SelectList(availableArts, "Id", "Name");
            return samouraiVM;
        }

        public static Samourai ToModel(SamouraiVM samouraiVM, List<Arme> availableArmes, List<ArtMartial> availableArts)
        {
            Samourai samourai = new Samourai();
            samourai.Id = samouraiVM.Samourai.Id;
            samourai.Name = samouraiVM.Samourai.Name;
            samourai.Strength = samouraiVM.Samourai.Strength;
            samourai.Arme = availableArmes.Single(a => a.Id == samouraiVM.IdArme);
            samourai.ArtsMartiaux = availableArts.Where(a => samouraiVM.IdsArts.Contains(a.Id)).ToList();
            return samourai;

        }
    }
}
