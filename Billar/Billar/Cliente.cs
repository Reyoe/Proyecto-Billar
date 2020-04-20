using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Billar
{
    class Cliente
    {
        public DataTable GetClienteByName(String name)
        {
            string query = "Select * from client where name='" + name + "' ";
            Console.WriteLine(query);
            Conexion.query(query);
            return Conexion.query(query); ;
        }

        public DataTable GetClienteById(string id)
        {
            string query = "Select * from client where code='" + id + "'";
            Console.WriteLine(query);
            Conexion.query(query);
            return Conexion.query(query);
        }
        public void insertCliente(string name, int hours)
        {
            string query = "INSERT INTO client(name,hours) VALUES('" + name + "'," + hours + ");";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void deleteCliente(int codigo)
        {
            string query = "DELETE FROM user WHERE code=" + codigo + ";";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void updateCliente(int codigo, string name, int hours)
        {
            string query = "UPDATE client SET name='" + name + "' , hours= " + hours + " WHERE code=" + codigo + ";";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }

    }
}

