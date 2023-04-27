using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using Dojo.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

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

            Mock<IRepository<ArtMartial>> mockRepository = new Mock<IRepository<ArtMartial>>();
            mockRepository.Setup(r => r.GetAll()).Returns(() => artsmartiaux);

            var baseService = new BaseService<ArtMartial>(mockRepository.Object);

            //act 
            var result = baseService.FetchAll();

            //Assert
            CollectionAssert.AreEqual(artsmartiaux, result);
            //Assert.IsNotNull(result);
            //Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void FetchAllPagedTest()
        {
            //arrange
            int pageNumber = 1;
            int pageSize = 2;
            var artsmartiaux = GetSomeArtMartial().Take(pageSize);

            Mock<IRepository<ArtMartial>> mockRepository = new Mock<IRepository<ArtMartial>>();
            mockRepository.Setup(r => r.GetAllPaged(pageNumber, pageSize)).Returns(() => artsmartiaux.ToPagedList());

            var baseService = new BaseService<ArtMartial>(mockRepository.Object);

            //act 
            var result = baseService.FetchAllPaged(pageNumber, pageSize);

            //Assert
            CollectionAssert.AreEqual(artsmartiaux.ToList(), result.ToList());
        }

        [TestMethod]
        public void FindByIdTest()
        {
            //arrange
            int id = 1;
            ArtMartial artmartial = GetSomeArtMartial().Single(a => a.Id == id);
            Mock<IRepository<ArtMartial>> mockRepository = new Mock<IRepository<ArtMartial>>();
            mockRepository.Setup(r => r.GetById(id)).Returns(() => artmartial);

            var baseService = new BaseService<ArtMartial>(mockRepository.Object);

            //act
            var result = baseService.FindById(id);

            //assert
            Assert.AreEqual(result, artmartial);
        }

        [TestMethod]
        public void CreateTest()
        {
            ArtMartial resultOutput = null;
            ArtMartial artMartial = new ArtMartial { Id = 4, Name = "Boxe" };
            Mock<IRepository<ArtMartial>> mockRepository = new Mock<IRepository<ArtMartial>>();
            mockRepository.Setup(r => r.Add(It.IsNotNull<ArtMartial>())).Callback((ArtMartial a) => resultOutput = a);
            //setup moi lorsqu'on m'envoie un ArtM non null

            var baseService = new BaseService<ArtMartial>(mockRepository.Object);

            baseService.Create(artMartial);

            mockRepository.Verify(x => x.Add(It.IsNotNull<ArtMartial>()), Times.Once);
            Assert.IsNotNull(resultOutput);
            Assert.AreEqual(resultOutput, artMartial);
        }

        [TestMethod]
        public void EditTest()
        {
            ArtMartial resultOutput = new ArtMartial { Id = 4, Name = "Boxe" };
            ArtMartial expected = new ArtMartial { Id = 4, Name = "Boxe française" };
            Mock<IRepository<ArtMartial>> mockRepository = new Mock<IRepository<ArtMartial>>();
            mockRepository.Setup(r => r.Update(It.IsNotNull<ArtMartial>())).Callback((ArtMartial a) => resultOutput = expected);

            var baseService = new BaseService<ArtMartial>(mockRepository.Object);
            baseService.Edit(resultOutput);

            mockRepository.Verify(x => x.Update(It.IsNotNull<ArtMartial>()), Times.Once);
            Assert.IsNotNull(resultOutput);
            Assert.AreEqual(resultOutput, expected);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int id = 1;
            var artsmartiaux = GetSomeArtMartial();
            var toBeDeleted = artsmartiaux.Single(a => a.Id == id);
            var expected = artsmartiaux.Where(a => a.Id != id);


            Mock<IRepository<ArtMartial>> mockRepository = new Mock<IRepository<ArtMartial>>();
            mockRepository.Setup(r => r.Remove(It.IsNotNull<ArtMartial>())).Callback((ArtMartial a) => artsmartiaux.Remove(a));

            var baseService = new BaseService<ArtMartial>(mockRepository.Object);
            baseService.Delete(toBeDeleted);

            Assert.IsFalse(artsmartiaux.Any(a => a.Id == id));
            Assert.AreEqual(expected.Count(), artsmartiaux.Count());
            CollectionAssert.AreEqual(expected.ToList(), artsmartiaux.ToList());
        }
    }
}
