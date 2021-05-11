using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orcamento
    {
        #region Propriedades
        public int id_Orcamento { get; set; }
        public string DtInicio { get; set; }
        public string DtFim { get; set; }
        public int QtdDias { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public int Modulo { get; set; }

        public const string INSERT = "INSERT INTO Squad (DtInicio, DtFim, QtdDias, Descricao, Titulo, id_Modulo) VALUES ('{0}', '{1}', {2}, '{3}', '{4}', {5})";
        public const string GETALL = "SELECT * FROM Squad";
        public const string UPDATE = "UPDATE Squad SET dtinicio = '{0}', dtfim = '{1}', qtddias = {2}, descricao = '{3}', titulo = '{4}', id_Modulo = {5} WHERE id_Squad = {6}";
        public const string DELETE = "DELETE FROM Squad WHERE id_Squad = {0}";
        public const string GETBYID = "SELECT * FROM Squad WHERE id_Squad = {0}";

        #endregion
    }
}
