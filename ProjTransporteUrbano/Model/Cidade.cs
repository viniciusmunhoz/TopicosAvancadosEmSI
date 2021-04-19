using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class Cidade
    {
            public string NomeCidade { get; set; }
            public int id_Cidade { get; set; }

            public const string INSERT = "INSERT INTO Cidade (id_Cidade ,NomeCidade) VALUES ({0}, '{1}')";
            public const string GETALL = "SELECT * FROM Cidade";
        
    }
}
