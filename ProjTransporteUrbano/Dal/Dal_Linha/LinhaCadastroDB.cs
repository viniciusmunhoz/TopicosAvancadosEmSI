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
    public class LinhaCadastroDB : ILinhaCadastroDB
    {
        public List<Linha> GetNomeLinha(string nomelinha)
        {
            Linha linha = new Linha();
            string sql = string.Format(Linha.GETALLNOME, nomelinha);
            List<Linha> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToListQuadro(connection.ExecQueryReturn(sql));
            }
            return lst;
        }


        public List<Linha> GetAll()
        {
            string sql = Linha.GETALL;
            List<Linha> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Linha> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Linha>();

            while (returnData.Read())
            {
                var item = new Linha()
                {
                    NomeLinha = returnData["NomeLinha"].ToString(),
                    id_Itinerario = int.Parse(returnData["id_Itinerario"].ToString())
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Linha linha)
        {
            bool status =  false;
            string sql = string.Format(Linha.INSERT, linha.NomeLinha, linha.id_Itinerario);

            using (var connection = new DB())
            {
                status =  connection.ExecQuery(sql);
            }
            return status;
        }

        //Segundo momento:

        public Linha SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Linha linha)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }


        private List<Linha> TransformSQLReaderToListQuadro(SqlDataReader returnData)
        {
            var lst = new List<Linha>();

            while (returnData.Read())
            {
                var item = new Linha()
                {
                    NomeLinha = returnData["NomeLinha"].ToString(),
                    id_Itinerario = int.Parse(returnData["id_Itinerario"].ToString()),

                    DiasUteis = returnData["DiasUteis"].ToString(),
                    Sabados = returnData["Sabados"].ToString(),
                    Domingos = returnData["Domingos"].ToString(),
                    Feriados = returnData["Feriados"].ToString(),
                    id_Linha = int.Parse(returnData["id_Linha"].ToString())

                };
                lst.Add(item);
            }
            return lst;
        }
    }
}
