using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ambiente
    {
        #region Propriedades
        public int id_Ambiente { get; set; }
        public string Descricao { get; set; }
        
        public const string INSERT = "INSERT INTO Ambiente (Descricao) VALUES ('{0}')";
        public const string GETALL = "SELECT * FROM Ambiente";
        public const string UPDATE = "UPDATE Ambiente SET Descricao = '{0}' WHERE id_Ambiente = {1}";
        public const string DELETE = "DELETE FROM Ambiente WHERE id = {0}";
        public const string GETBYID = "SELECT * FROM Ambiente WHERE id_Ambiente = {0}";

        #endregion
    }
}
