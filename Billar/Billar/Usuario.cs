using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Billar
{
    class Usuario
    { 
      
        public DataTable GetUsuario(String username, string password)
        {
            string query = "Select * from user where Username='" + username + "' and Password ='" + password + "'";
            Console.WriteLine(query);
            Conexion.query(query);
            return Conexion.query(query); ;
        }
       
        public DataTable GetUsuarioById(string id)
        {
            string query = "Select * from user where code='" + id + "'";
            Console.WriteLine(query);
            Conexion.query(query);
            return Conexion.query(query);
        }
        public void insertUsuario(string username, string password, string name, string type)
        {
            string query = "INSERT INTO user(Username,Password,Name,Type) VALUES('" + username + "','" + password + "','" + name + "','" + type +"');";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void deleteUsuario(string codigo)
        {
            string query = "DELETE FROM user WHERE code='" + codigo + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void updateUsuario(int codigo, string Username, string password, string name)
        {
            string query = "UPDATE user SET Username='" + Username + "' , Password= '" + password + "', Name= '"+ name + "' WHERE code=" + codigo + ";";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }

    }
}
