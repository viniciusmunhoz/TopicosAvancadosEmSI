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
    public class CidadeCadastroDB : ICidadeCadastroDB
    {
        
        public List<Cidade> GetAll()
        {
            string sql = Cidade.GETALL;
            List<Cidade> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Cidade> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Cidade>();

            while (returnData.Read())
            {
                var item = new Cidade()
                {
                    NomeCidade = returnData["NomeCidade"].ToString(),
                    id_Cidade =  int.Parse(returnData["id_Cidade"].ToString()),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Cidade cidade)
        {
            bool status =  false;
            string sql = string.Format(Cidade.INSERT, cidade.id_Cidade, cidade.NomeCidade);

            using (var connection = new DB())
            {
                status =  connection.ExecQuery(sql);
            }
            return status;
        }

        //Segundo momento:

        public Cidade SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cidade cidade)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
