using Dojo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Dojo.Tests.Integration
{
    [TestClass]
    public class InfrastructureTests
    {
        public IConfigurationRoot Configuration { get; set; }

        [TestInitialize]
        public void Init()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }

        [TestMethod]
        public void IntegrationContextTest()
        {

            var builder = new DbContextOptionsBuilder<DojoContext>();
            builder.UseSqlServer(Configuration.GetConnectionString("DojoContextTest"));

            var db = new DojoContext(builder.Options);

            db.Database.EnsureCreated();

            var count = db.Samourai.Count();
        }
    }
}