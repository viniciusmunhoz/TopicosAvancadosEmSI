using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Linha //: Empresa
    {
        public string NomeLinha { get; set; }
        public int id_Itinerario { get; set; }

        public const string INSERT = "INSERT INTO Linha (NomeLinha, id_Itinerario) VALUES ('{0}', {1})";
        public const string GETALL = "SELECT * FROM Linha";
        public const string GETALLNOME = "SELECT * FROM Linha L inner join QuadroHorario Q on L.id_Linha = Q.id_Linha WHERE L.NomeLinha like '%{0}%'";

        public string DiasUteis { get; set; }
        public string Sabados { get; set; }
        public string Domingos { get; set; }
        public string Feriados { get; set; }
        public int id_Linha { get; set; }


    }
}
