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
    public class LinhacomEmpresaCadastroDB : ILinhacomEmpresaCadastroDB
    {
        public List<LinhacomEmpresa> GetNomeLinha(string nomelinha)
        {
            LinhacomEmpresa linhacomEmpresa = new LinhacomEmpresa();
            string sql = string.Format(LinhacomEmpresa.GETALLNOME, nomelinha);
            List<LinhacomEmpresa> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToListQuadro(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<LinhacomEmpresa> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<LinhacomEmpresa>();

            while (returnData.Read())
            {
                var item = new LinhacomEmpresa()
                {
                    NomeLinha = returnData["NomeLinha"].ToString(),
                    id_Itinerario = int.Parse(returnData["id_Itinerario"].ToString())
                };
                lst.Add(item);
            }
            return lst;
        }


        //Segundo momento:

        public LinhacomEmpresa SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(LinhacomEmpresa linhacomEmpresa)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }


        private List<LinhacomEmpresa> TransformSQLReaderToListQuadro(SqlDataReader returnData)
        {
            var lst = new List<LinhacomEmpresa>();

            while (returnData.Read())
            {
                var item = new LinhacomEmpresa()
                {

                   
                    id_Empresa = int.Parse(returnData["id_Empresa"].ToString()),
                    NomeEmpresa = returnData["NomeEmpresa"].ToString(),
                    Endereco = returnData["Endereco"].ToString(),
                    Telefone = returnData["Telefone"].ToString(),
                    Site = returnData["Site"].ToString(),
                    id_Cidade = int.Parse(returnData["id_Cidade"].ToString()),
                    id_Linha = int.Parse(returnData["id_Linha"].ToString()),
                    NomeLinha = returnData["NomeLinha"].ToString(),
                    id_Itinerario = int.Parse(returnData["id_Itinerario"].ToString())

                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(LinhacomEmpresa linhacomEmpresa)
        {
            throw new NotImplementedException();
        }

        public List<LinhacomEmpresa> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
