using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Modulo
    {
        #region Propriedades
        public int id_Modulo { get; set; }
        public int Ambiente { get; set; }  //DUVIDA
        public int Squad { get; set; }
        
        public const string INSERT = "INSERT INTO Modulo (ambiente, squad) VALUES ('{0}', '{1}')";
        public const string GETALL = "SELECT * FROM Modulo";
        public const string UPDATE = "UPDATE Modulo SET id_Ambiente = '{0}', id_Squad = '{1}' WHERE id_Modulo = {2}";
        public const string DELETE = "DELETE FROM Modulo WHERE id_Modulo = {0}";
        public const string GETBYID = "SELECT * FROM Modulo WHERE id_Modulo = {0}";

        #endregion
    }
}
