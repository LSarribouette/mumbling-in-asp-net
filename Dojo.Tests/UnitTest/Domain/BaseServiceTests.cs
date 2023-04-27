using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using Dojo.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Tests.UnitTest.Domain
{
    [TestClass]
    public class BaseServiceTests
    {
        private List<ArtMartial> GetSomeArtMartial() => new List<ArtMartial>()
        {
            new ArtMartial { Id = 1, Name = "Jujitsu-brésilien" },
            new ArtMartial { Id = 2, Name = "Karaté" },
            new ArtMartial { Id = 3, Name = "Judo" }
        };

        [TestMethod]
        public void FetchAllTest()
        {
            //arrange
            var artsmartiaux = GetSomeArtMartial();

            Mock<IRepository<ArtMartial>> repository = new Mock<IRepository<ArtMartial>>();
            repository.Setup(r => r.GetAll()).Returns(() => artsmartiaux);

            var baseService = new BaseService<ArtMartial>(repository.Object);

            //act 
            var result = baseService.FetchAll();

            //Assert
            CollectionAssert.AreEqual(artsmartiaux, result);
            //Assert.IsNotNull(result);
            //Assert.AreEqual(3, result.Count);
        }
    }
}
