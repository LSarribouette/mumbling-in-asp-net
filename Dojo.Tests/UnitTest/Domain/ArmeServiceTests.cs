using Dojo.Domain.Entities;
using Dojo.Domain.Interfaces.Repositories;
using Dojo.Domain.Services;
using Dojo.Infrastructure.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Tests.Services
{
    [TestClass]
    public class ArmeServiceTests
    {
        private Mock<IArmeRepository> _mockRepository;
        private ArmeService _service;
        //Mock<IUnitOfWork> _mockUnitWork;
        List<Arme> listArmes;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IArmeRepository>();
            //_mockUnitWork = new Mock<IUnitOfWork>();
            _service = new ArmeService(_mockRepository.Object);
            listArmes = new List<Arme>() 
            {
                new Arme { Id = 1, Name = "Katana", Damage = 500 },
                new Arme { Id = 2, Name = "Yumi", Damage = 350 },
                new Arme { Id = 3, Name = "Wakisashi", Damage = 463},
            };
        }

        [TestMethod]
        public void Arme_Fetch_All_Test()
        {
            //Arrange
            _mockRepository.Setup(x => x.GetAll()).Returns(listArmes);

            //Act
            List<Arme> result = _service.FetchAll() as List<Arme>;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }
    }
}
