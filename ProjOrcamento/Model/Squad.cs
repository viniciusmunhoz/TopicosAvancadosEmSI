using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Squad
    {
        #region Propriedades
        public int id_Squad { get; set; }
        public string Nome { get; set; }
        public int QtdPessoas { get; set; }
        
        public const string INSERT = "INSERT INTO Squad (Nome, QtdPessoas) VALUES ('{0}', {1})";
        public const string GETALL = "SELECT * FROM Squad";
        public const string UPDATE = "UPDATE Squad SET nome = '{0}', QtdPessoas = {1} WHERE id = {2}";
        public const string DELETE = "DELETE FROM Squad WHERE id_Squad = {0}";
        public const string GETBYID = "SELECT * FROM Squad WHERE id_Squad = {0}";

        #endregion
    }
}
