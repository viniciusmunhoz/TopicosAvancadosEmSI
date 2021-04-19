using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Itinerario
    {
        public int id_Itinerario { get; set; }
        public string itinerario { get; set; }
        public int Sentido { get; set; }

        public const string INSERT = "INSERT INTO Itinerario (itinerario, Sentido) VALUES ('{0}', {1})";
        public const string GETALL = "SELECT * FROM Itinerario";
    }
}
