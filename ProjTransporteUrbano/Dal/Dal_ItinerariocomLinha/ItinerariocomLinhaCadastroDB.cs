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
    public class ItinerariocomLinhaCadastroDB : IItinerariocomLinhaCadastroDB
    {
        
        public List<ItinerariocomLinha> GETALL(string texto)
        {
            ItinerariocomLinha itinerariocomLinha = new ItinerariocomLinha();
            string sql = string.Format(ItinerariocomLinha.GETALL, texto);
            List<ItinerariocomLinha> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<ItinerariocomLinha> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<ItinerariocomLinha>();

            while (returnData.Read())
            {
                var item = new ItinerariocomLinha()
                {
                    id_Linha = int.Parse(returnData["id_Linha"].ToString()),
                    NomeLinha = returnData["NomeLinha"].ToString(),
                    id_Itinerario = int.Parse(returnData["id_Itinerario"].ToString()),
                    itinerario = returnData["itinerario"].ToString(),
                    Sentido = returnData["Sentido"].ToString(),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(ItinerariocomLinha itinerariocomLinha)
        {
            bool status =  false;
            string sql = string.Format(Itinerario.INSERT, itinerariocomLinha.itinerario, itinerariocomLinha.Sentido);

            using (var connection = new DB())
            {
                status =  connection.ExecQuery(sql);
            }
            return status;
        }

        //Segundo momento:

        public ItinerariocomLinha SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ItinerariocomLinha itinerariocomLinha)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ItinerariocomLinha> GetAll()
        {
            throw new NotImplementedException();
        }



        public List<ItinerariocomLinha> GETALLGETALLLOGRADOURO(string texto)
        {
            ItinerariocomLinha itinerariocomLinha = new ItinerariocomLinha();
            string sql = string.Format(ItinerariocomLinha.GETALLLOGRADOURO, texto);
            List<ItinerariocomLinha> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToListlOGRADOURO(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<ItinerariocomLinha> TransformSQLReaderToListlOGRADOURO(SqlDataReader returnData)
        {
            var lst = new List<ItinerariocomLinha>();

            while (returnData.Read())
            {
                var item = new ItinerariocomLinha()
                {
                    id_Linha = int.Parse(returnData["id_Linha"].ToString()),
                    NomeLinha = returnData["NomeLinha"].ToString(),
                    id_Itinerario = int.Parse(returnData["id_Itinerario"].ToString()),
                    itinerario = returnData["itinerario"].ToString(),
                    Sentido = returnData["Sentido"].ToString(),
                };
                lst.Add(item);
            }
            return lst;
        }
    }
}
