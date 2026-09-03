using MCP.BuisnessLayer;
using MCP_DataAccess;
using MCP_Domain.Models;

namespace MCP.tests
{
    public class Tests
    {
        IScooterDAO dao;
        ScooterBL bl;
        public App_User user1 = new App_User("Elsa");
        public Scooter scooter1 = new("Vespa");

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            dao = new ScooterDAO();
            bl = new(dao);
            dao.RebuildDatabase();
            dao.CreateUser(user1);
            dao.CreateScooter(scooter1);


        }
        [SetUp]
        public void Setup()
        {
        }

        [TestCase ("konrad", 2)]
        [TestCase("Ida", 3)]
        [TestCase("Pål", 4)]
        public void CreateUsers(string name, int expectedId)
        {
            int result = bl.CreateUser(name);
            Assert.That(result, Is.EqualTo(expectedId));
        }
        [TestCase("Vespa", 2)]
        [TestCase("Voi", 3)]
        [TestCase("Oola", 4)]
        public void CreateScooters_ThreeScooters_CorrectIdOnScoot(string brand, int expectedId)
        {
            int result = bl.CreatesScooter(brand);
            Assert.That(result, Is.EqualTo(expectedId));
        }
        [Test]
        public void CreateTrips_OneTrip_CorrectId()
        {
            int expectedId = 1;
            int result = bl.CreateTrip(user1, scooter1);

            Assert.That (result, Is.EqualTo(expectedId));
        }
        //[Test]
        //public void AllScootersWithBatter_TwoScooters_correctList()
        //{
        //    Scooter scoot1 = new("vespa");
        //    scoot1.Battery_Capacity = 0.4;
        //    dao.CreateScooter(scoot1);

        //    Scooter scoot2 = new("Voi");
        //    scoot2.Battery_Capacity = 0.8;
        //    dao.CreateScooter(scoot2);

        //    Scooter scoot3 = new("Voi");
        //    scoot2.Battery_Capacity = 0.1;
        //    dao.CreateScooter(scoot3);

        //    List<Scooter> expectedList = new();
        //    expectedList.Add(scoot1);
        //    expectedList.Add(scoot2);

        //    List<Scooter> result = dao.ScootersWithBatter();

        //    Assert.That(result, Is.EqualTo(expectedList));
        //}
    }
}
