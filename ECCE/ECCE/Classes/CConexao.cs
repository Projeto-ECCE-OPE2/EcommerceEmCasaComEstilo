using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Classes
{
    public class CConexao
    {
        public static string Get_StringConexao()
        {
            string Host = "mysqlsrv.cy1mxgpswikk.us-east-2.rds.amazonaws.com";
            string Banco = "ecce";
            string Usuario = "admin";
            string Senha = "Jc080912";
            return "Data Source = " + Host + "; Initial Catalog = " + Banco + "; User Id = " + Usuario + "; Password = " + Senha + "; ";
        }
    }
}
