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
    public class ItinerarioCadastroDB : IItinerarioCadastroDB
    {
        
        public List<Itinerario> GetAll()
        {
            string sql = Itinerario.GETALL;
            List<Itinerario> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Itinerario> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Itinerario>();

            while (returnData.Read())
            {
                var item = new Itinerario()
                {
                    id_Itinerario = int.Parse(returnData["id_Itinerario"].ToString()),
                    itinerario = returnData["itinerario"].ToString(),
                    Sentido = int.Parse(returnData["Sentido"].ToString())
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Itinerario itinerario)
        {
            bool status =  false;
            string sql = string.Format(Itinerario.INSERT, itinerario.itinerario, itinerario.Sentido);

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

        public bool Update(Linha itinerario)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
