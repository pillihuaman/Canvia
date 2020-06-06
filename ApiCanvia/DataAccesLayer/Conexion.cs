using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Conexion
    {
        public static string  GetConexionString()
        {
            return   ConfigurationManager.AppSettings["ConexionCanvia"];
        }
    }
}
