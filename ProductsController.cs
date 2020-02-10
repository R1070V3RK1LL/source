using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
namespace ProductsCore.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private static string _str = " Data Source = PCISABELLE; Initial Catalog = Products; Integrated Security = True";
        

        private List<Product> ReadAllData()
        {
            var lp = new List<Product>();
            string queryString =
                "SELECT workbench, utilitary FROM dbo.Table_1";

            using (SqlConnection connection =
                       new SqlConnection(_str))
            {
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    var p = ReadSingleRow((IDataRecord)reader);
                    lp.Add(p);
                }
                // Call Close when done reading.
                reader.Close();
            }
            return lp;
        }
        private void InsertOrderData(Product product)
        {

            using (SqlConnection connection =
                       new SqlConnection(_str))
            {
                SqlCommand command =
                    new SqlCommand(_str, connection);
                connection.Open();
                command.CommandText = $"INSERT INTO dbo.Table_1(workbench,utilitary) VALUES ('{product.Workbench}','{product.Utilitary}')";
                command.ExecuteNonQuery();
            }
        }
        private void UpdateOrderData(Product product)
        {
            string queryString ="SELECT workbench, utilitary FROM dbo.Table_1";

            using (SqlConnection connection =
                       new SqlConnection(_str))
            {
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();
                command.CommandText =$"UPDATE dbo.Table_1 SET workbench='{product.Workbench}', utilitary='{product.Utilitary}'";
                command.ExecuteNonQuery();
            }
        }
        private void DeleteOrderData(Product product)
        {
            string queryString ="SELECT workbench, utilitary FROM dbo.Table_1";

            using (SqlConnection connection = new SqlConnection(_str))
            {
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();
                command.CommandText = $"DELETE FROM dbo.Table_1 WHERE workbench = '{product.Workbench}'" ;
                command.ExecuteNonQuery();
            }
        }

        private Product ReadSingleRow(IDataRecord record)
        {
            Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
            var p = new Product()
            {
                Workbench = record[0].ToString(),
                Utilitary = record[1].ToString()
            };
            return p;
        }
        [HttpGet("{id}")]
        private IActionResult GetProduct(int id)
        {
            var product = ReadAllData().FirstOrDefault((p) =>  p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProduct(Product product)
        {
            InsertOrderData(product);
            //DeleteOrderData(product);
            //UpdateOrderData(product);
            product.Id = product.Id+1;
            return CreatedAtAction(nameof(product), new { id = product.Id }, product);

        }

        public IActionResult GetAllProducts()
        {
            var lp = ReadAllData();
            return Ok(lp);
        }
    }
}
