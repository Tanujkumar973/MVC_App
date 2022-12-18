using Dapper;
using MVC_App.Models;
using System.Data.SqlClient;

namespace MVC_App.Repositories
{
    public class ProductsRepo
    {
         
        public List<Product> GetProducts()
        {
            try
            {
                using (
                    var connection = new SqlConnection("data source=tanujsqldatabase.database.windows.net; database= appdb; user id =admin123; password = intelCOREi78thGen"))
                {
                    var productsLst = connection.Query<Product>("select * from tblproducts").ToList();
                    return productsLst;
                }
            }



            catch (Exception)
            {

                throw;
                
            }
        }
    }
}
