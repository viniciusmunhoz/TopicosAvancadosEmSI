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
    public class EmpresaCadastroDB : IEmpresaCadastroDB
    {
        public List<Empresa> GetNomeEmpresas(string nomeempresa)
        {
            Empresa empresa = new Empresa();
            string sql = string.Format(Empresa.GETALLNOME, nomeempresa);
            List<Empresa> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        public List<Empresa> GetAll()
        {
            string sql = Empresa.GETALL;
            List<Empresa> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Empresa> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Empresa>();

            while (returnData.Read())
            {
                var item = new Empresa()
                {
                    NomeEmpresa = returnData["NomeEmpresa"].ToString(),
                    Endereco = returnData["Endereco"].ToString(),
                    Telefone = returnData["Telefone"].ToString(),
                    Site = returnData["Site"].ToString(),
                    id_Cidade = int.Parse(returnData["id_Cidade"].ToString())
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Empresa empresa)
        {
            bool status =  false;
            string sql = string.Format(Empresa.INSERT, empresa.NomeEmpresa, empresa.Endereco, empresa.Telefone, empresa.Site, empresa.id_Cidade);

            using (var connection = new DB())
            {
                status =  connection.ExecQuery(sql);
            }
            return status;
        }

        //Segundo momento:

        public Empresa SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Empresa Empresa)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
