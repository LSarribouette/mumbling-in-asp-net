using Dojo.Domain.Interfaces.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dojo.Infrastructure.Repositories;
using Dojo.Domain.Interfaces;
using Dojo.Domain.Entities;
using Dojo.Domain.Services;
using Newtonsoft.Json;

namespace Dojo.Tests.Services
{
    [TestClass]
    public class SamouraiServiceTests
    {
        private List<Samourai> GetSomeSamourais() => new List<Samourai>()
        {
            new Samourai { Id = 1, Name = "Abe Masakatsu", Strength = 500 },
            new Samourai { Id = 2, Name = "Adachi Yasumori", Strength = 800 },
            new Samourai { Id = 3, Name = "Adachi Kagemori", Strength = 1900 }
        };

        [TestMethod]
        public void FetchAllTest()
        {
            //arrange
            var samourais = GetSomeSamourais();

            Mock<ISamouraiRepository> repository = new Mock<ISamouraiRepository>();
            repository.Setup(r => r.GetAll()).Returns(() => samourais); // c'est mieux lambda !! pour lui dire c'est une méthode

            var samouraiService = new SamouraiService(repository.Object);

            //act 
            var result = samouraiService.FetchAll();

            //Assert
            CollectionAssert.AreEqual(samourais, result);
            //Assert.IsNotNull(result);
            //Assert.AreEqual(3, result.Count);
        }
    }
}
