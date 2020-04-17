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
        public DataTable GetAllUsers(string id)
        {
            string query = "Select (Code,Username,Name) from user";
            Console.WriteLine(query);
            Conexion.query(query);
            return Conexion.query(query);
        }
        public DataTable GetUsuarioById(string id)
        {
            string query = "Select * from user where code='" + id + "'";
            Console.WriteLine(query);
            Conexion.query(query);
            return Conexion.query(query);
        }
        public void insertUsuario(string codigo, string nombre, string contrasenia)
        {
            string query = "INSERT INTO user(code,Username,Password) VALUES('" + codigo + "','" + nombre + "','" + contrasenia + "');";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void deleteUsuario(string codigo)
        {
            string query = "DELETE FROM user WHERE code='" + codigo + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void updateUsuario(string codigo, string nombre, string contrasenia)
        {
            string query = "UPDATE user SET Username='" + nombre + "' , Password= '" + contrasenia + "' WHERE code='" + codigo + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }

    }
}
