using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Billar
{
    class Product
    {
        class Cliente
        {
            public DataTable GetProductByName(String name)
            {
                string query = "Select * from product where Name='" + name + "' ";
                Console.WriteLine(query);
                Conexion.query(query);
                return Conexion.query(query); ;
            }

            public DataTable GetProductById(string id)
            {
                string query = "Select * from product where Code='" + id + "'";
                Console.WriteLine(query);
                Conexion.query(query);
                return Conexion.query(query);
            }
            public void insertProduct(string name, float price, int stock, string description)
            {
                string query = "INSERT INTO product(Name,Price,Stock,Description) VALUES('" + name + "'," + price + ","+ stock +",'"+description+"');";
                Console.WriteLine(query);
                Conexion.query(query); ;
            }
            public void deleteProduct(int codigo)
            {
                string query = "DELETE FROM product WHERE Code=" + codigo + ";";
                Console.WriteLine(query);
                Conexion.query(query); ;
            }
            public void updateProduct(int codigo, string name, float price, int stock, string description)
            {
                string query = "UPDATE product SET Name='" + name + "' , Price= " + price + ", Stock="+ stock + ", Description= '"+ description + "' WHERE code=" + codigo + ";";
                Console.WriteLine(query);
                Conexion.query(query); ;
            }

        }
    }
}
