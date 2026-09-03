using MCP.BuisnessLayer;
using MCP_DataAccess;

namespace MCP.tests
{
    public class Tests
    {
        IScooterDAO dao;
        ScooterBL bl;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            dao = new ScooterDAO();
            bl = new(dao);
            dao.RebuildDatabase();

        }
        [SetUp]
        public void Setup()
        {
        }

        [TestCase ("konrad", 1)]
        [TestCase("Ida", 2)]
        [TestCase("Pål", 3)]
        public void CreateUsers(string name, int expectedId)
        {
            int result = bl.CreateUser(name);
            Assert.That(result, Is.EqualTo(expectedId));
        }
    }
}
