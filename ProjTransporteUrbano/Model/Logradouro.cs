using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Logradouro
    {
        public string NomeLogradouro { get; set; }
        public int id_Logradouro { get; set; }
        public int id_Cidade { get; set; }

        public const string INSERT = "INSERT INTO Logradouro (NomeLogradouro, id_Cidade) VALUES ('{0}', {1})";
        public const string GETALL = "SELECT * FROM Logradouro";
    }
}
