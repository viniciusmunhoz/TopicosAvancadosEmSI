using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dal
{
    public class LogradouroCadastroDB : ILogradouroCadastroDB
    {
        
        public List<Logradouro> GetAll()
        {
            string sql = Logradouro.GETALL;
            List<Logradouro> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Logradouro> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Logradouro>();

            while (returnData.Read()) 
            {
                var item = new Logradouro()
                {
                    id_Logradouro = int.Parse(returnData["id_Logradouro"].ToString()),
                    NomeLogradouro = returnData["NomeLogradouro"].ToString(),
                    id_Cidade = int.Parse(returnData["id_cidade"].ToString())
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Logradouro logradouro)
        {
            bool status =  false;
            string sql = string.Format(Logradouro.INSERT, logradouro.NomeLogradouro, logradouro.id_Cidade);

            using (var connection = new DB())
            {
                status =  connection.ExecQuery(sql);
            }
            return status;
        }

        //Segundo momento:

        public Logradouro SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Logradouro logradouro)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
