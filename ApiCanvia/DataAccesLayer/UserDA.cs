using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class UserDA
    {
        public static Users GetUser(int IdUsers)
        {
            using (SqlConnection con = new SqlConnection(Conexion.GetConexionString()))
            {
                SqlDataReader rdr = null;
                var objuser = new Users();
                using (SqlCommand cmd = new SqlCommand("sp_Get_Users", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        objuser.IdUser = (int)rdr["IdUser"];
                        objuser.LastName = (string)rdr["LastName"];
                        objuser.Name = (string)rdr["Name"];
                        objuser.UserCode = (string)rdr["UserCode"];
                        objuser.Password = (string)rdr["Password"];
                        objuser.Email = (string)rdr["Email"];
                    }
                }
                return objuser;
            }
        }
        public static List<Users> ListAllUser()
        {
            using (SqlConnection con = new SqlConnection(Conexion.GetConexionString()))
            {
                SqlDataReader rdr = null;
        
                var listuser = new List<Users>();
                using (SqlCommand cmd = new SqlCommand("sp_ListAll_Users", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        var objuser = new Users();
                        objuser.IdUser = (int)rdr["IdUser"];
                        objuser.LastName = (string)rdr["LastName"];
                        objuser.Name = (string)rdr["Name"];
                        objuser.UserCode = (string)rdr["UserCode"];
                        objuser.Password = (string)rdr["Password"];
                        objuser.Email = (string)rdr["Email"];
                        listuser.Add(objuser);
                    }
                }
                return listuser;
            }
        }
        public static Boolean  InsertUsers(Users users)
        {
            Boolean valida = false;
            try
            {
            using (SqlConnection con = new SqlConnection(Conexion.GetConexionString()))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_insert_users", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LastName", users.LastName);
                    cmd.Parameters.AddWithValue("@Name", users.Name);
                    cmd.Parameters.AddWithValue("@UserCode",  users.UserCode);
                    cmd.Parameters.AddWithValue("@Password", users.Password);
                        cmd.Parameters.AddWithValue("@Email", users.Email);
                        con.Open();
                    cmd.ExecuteNonQuery();
                    valida= true;
                } 
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valida;
        }
    }
}



