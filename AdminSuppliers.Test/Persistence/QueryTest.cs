using AdminSupplier.Persistence;
using AdminSuppliers.Core;
using Newtonsoft.Json.Linq;
using System.Configuration;

namespace AdminSuppliers.Test
{
    [TestClass]
    public class QueryTest
    {
        [TestMethod]
        public void GetSuppliers() 
        {

            var dBContext = new DBContext("DESKTOP-Q138CQJ", "AdministrationResources");

            dBContext.GetReportResults<ProductReport>(DateTime.Now, DateTime.Now);
                //dBContext.GetReportResults<>


        }

    }
}
