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
    public class QuadroHorarioCadastroDB : IQuadroHorarioCadastroDB
    {
        
        public List<QuadroHorario> GetAll()
        {
            string sql = QuadroHorario.GETALL;
            List<QuadroHorario> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<QuadroHorario> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<QuadroHorario>();

            while (returnData.Read()) 
            {
                var item = new QuadroHorario()
                {

                    DiasUteis = returnData["DiasUteis"].ToString(),
                    Sabados =   returnData["Sabado"].ToString(),
                    Domingos = returnData["Domingo"].ToString(),
                    Feriados = returnData["Feriado"].ToString(),
                    id_Linha = int.Parse(returnData["id_Linha"].ToString())
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(QuadroHorario quadroHorario)
        {
            bool status =  false;
            string sql = string.Format(QuadroHorario.INSERT, quadroHorario.DiasUteis, quadroHorario.Sabados, quadroHorario.Domingos, quadroHorario.Feriados, quadroHorario.id_Linha);

            using (var connection = new DB())
            {
                status =  connection.ExecQuery(sql);
            }
            return status;
        }

        //Segundo momento:

        public QuadroHorario SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(QuadroHorario quadroHorario)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
