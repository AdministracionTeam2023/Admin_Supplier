using System.Configuration;

namespace AdminSuppliers.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string serverName = ConfigurationManager.AppSettings["serverName"];
            string dataBase = ConfigurationManager.AppSettings["dataBase"];
        }
    }
}